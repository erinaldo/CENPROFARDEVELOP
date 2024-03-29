Imports Microsoft.ApplicationBlocks.Data
Imports Utiles
Imports System.Data.SqlClient
Imports ReportesNet

Public Class frmEmpleados

    Dim bolpoliticas As Boolean
    Dim llenandoCombo As Boolean = False
    Dim tranWEB As New WS_Porkys.WS_PorkysSoapClient

#Region "Componentes Formulario"

    Private Sub frmEmpleados_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3 'nuevo
                If bolModo = True Then
                    If MessageBox.Show("No ha guardado el Empleado que est� realizando. �Est� seguro que desea continuar sin Grabar y hacer un Nuevo Empleado?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        btnNuevo_Click(sender, e)
                    End If
                Else
                    btnNuevo_Click(sender, e)
                End If
            Case Keys.F4 'grabar
                btnGuardar_Click(sender, e)
        End Select
    End Sub

    Private Sub frmEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'AsignarPermisos(UserID, Me.Name, ALTA, MODIFICA, BAJA, BAJA_FISICA)
        configurarform()
        asignarTags()

       LlenarcmbJornadas

        SQL = "exec spEmpleados_Select_All @Eliminado = 0"

        LlenarGrilla()
        Permitir = True
        CargarCajas()
        PrepararBotones()

        If grd.RowCount = 0 Then
            dtpFechaIngreso.Value = Today.Date
        End If

        txtusuario.Enabled = Not bolModo

        grd.Columns(6).Visible = False
        grd.Columns(7).Visible = False
        grd.Columns(12).Visible = False
        grd.Columns(13).Visible = False
        grd.Columns(14).Visible = False
        grd.Columns(15).Visible = False
        grd.Columns(16).Visible = False
        grd.Columns(17).Visible = False
        grd.Columns(18).Visible = False
        grd.Columns(19).Visible = False
        grd.Columns(20).Visible = False

        cmbJornadas.Enabled = bolModo

        'solo un usuario autorizado podra a poner como autorizado a otro 
        chkAutoriza.Enabled = MDIPrincipal.ControlUsuarioAutorizado(MDIPrincipal.EmpleadoLogueado)

        txtApellido.Focus()

    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkEliminados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEliminados.CheckedChanged
        btnNuevo.Enabled = Not chkEliminados.Checked
        btnGuardar.Enabled = Not chkEliminados.Checked
        btnCancelar.Enabled = Not chkEliminados.Checked
        btnEliminar.Enabled = Not chkEliminados.Checked

        If chkEliminados.Checked = True Then
            SQL = "exec spEmpleados_Select_All @Eliminado = 1"
        Else
            SQL = "exec spEmpleados_Select_All @Eliminado = 0"
        End If

        LlenarGrilla()

        If grd.RowCount = 0 Then
            btnActivar.Enabled = False
        Else
            btnActivar.Enabled = chkEliminados.Checked
        End If
    End Sub

    Private Sub txtNOMBRE_LostFocus(sender As Object, e As EventArgs) Handles txtNOMBRE.LostFocus
        If bolModo = True Then
            Try
                txtusuario.Text = txtNOMBRE.Text.Substring(0, 1).ToLower + txtApellido.Text.ToLower
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub cmbJornadas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJornadas.SelectedIndexChanged
        If llenandoCombo = False Then
            If cmbJornadas.Text.ToString <> "" Then
                txtIdJornada.Text = cmbJornadas.SelectedValue
            End If
        End If
    End Sub

#End Region

#Region "Botones"

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'If ALTA Then
        bolModo = True
        Util.MsgStatus(Status1, "Haga click en [Guardar] despues de completar los datos.")
        PrepararBotones()
        Util.LimpiarTextBox(Me.Controls)

        dtpFechaIngreso.Value = Today.Date
        dtpVencPoliza.Value = Today.Date
        dtpFechaNac.Value = Today.Date
        'hkAutorizante.Checked = False
        chkUsuarioSistema.Checked = False

        cmbJornadas.Enabled = bolModo

        txtApellido.Focus()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim res As Integer

        If chkUsuarioSistema.Checked = True And txtusuario.Text = "" Then
            MsgBox("Debe ingresar el nombre del usuario para el sistema.", MsgBoxStyle.Critical, "Atenci�n")
            Exit Sub
        End If

        Dim ModoActual As Boolean
        ModoActual = bolModo

        If bolModo = False Then
            If MessageBox.Show("Est� seguro que desea modificar el Empleado seleccionado?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Util.MsgStatus(Status1, "Guardando el registro...", My.Resources.Resources.indicator_white)

        If ReglasNegocio() Then
            Verificar_Datos()
            If bolpoliticas Then

                res = AgregarActualizar_Registro()
                Select Case res
                    Case -2
                        Util.MsgStatus(Status1, "El registro ya existe.", My.Resources.Resources.stop_error.ToBitmap)
                        Exit Sub
                    Case -1
                        Util.MsgStatus(Status1, "No se pudo actualizar el registro.", My.Resources.Resources.stop_error.ToBitmap)
                        Exit Sub
                    Case 0
                        Util.MsgStatus(Status1, "No se pudo agregar el registro.", My.Resources.Resources.stop_error.ToBitmap)
                        Exit Sub
                    Case Else
                        Util.MsgStatus(Status1, "Se insert� correctamente el Empleado.", My.Resources.Resources.ok.ToBitmap)


                        'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then
                        'Try
                        '    Dim sqlstring As String

                        '    If ModoActual = True Then

                        '        sqlstring = "INSERT INTO [dbo].[" & NameTable_Empleados & "] ( Id,[Codigo],[Apellido],[Nombre],[Domicilio],[Telefono],[Celular],[Cuit]," & _
                        '                    "[Email],[UsuarioSistema],[Usuario],[Pass],[Revendedor],[Eliminado],[DateAdd], [Repartidor],[Vendedor]) Values(" & _
                        '                    txtID.Text & ",'" & txtCODIGO.Text & "','" & txtApellido.Text & "','" & txtNOMBRE.Text & "','" & txtDIRECCION.Text & "','" & _
                        '                    txtTELEFONO.Text & "','" & txtCelular.Text & "'," & txtCuit.Text & ",'" & txtEMAIL.Text & "'," & IIf(chkUsuarioSistema.Checked = True, 1, 0) & ",'" & _
                        '                    txtusuario.Text & "','123456'," & IIf(chkRevendedor.Checked = True, 1, 0) & ",0,'" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "'," & _
                        '                    IIf(chkRepartidor.Checked = True, 1, 0) & "," & IIf(chkAutoriza.Checked = True, 1, 0) & "," & IIf(chkVendedor.Checked = True, 1, 0) & ")"
                        '    Else

                        '        sqlstring = "UPDATE [dbo].[" & NameTable_Empleados & "] SET " & _
                        '                    "[Apellido] = '" & txtApellido.Text & "'," & _
                        '                    "[Nombre] = '" & txtNOMBRE.Text & "'," & _
                        '                    "[Domicilio] = '" & txtDIRECCION.Text & "'," & _
                        '                    "[Telefono] = '" & txtTELEFONO.Text & "'," & _
                        '                    "[Celular] = '" & txtCelular.Text & "'," & _
                        '                    "[Cuit] = " & txtCuit.Text & "," & _
                        '                    "[Email] = '" & txtEMAIL.Text & "'," & _
                        '                    "[UsuarioSistema] = " & IIf(chkUsuarioSistema.Checked = True, 1, 0) & "," & _
                        '                    "[Usuario] = '" & txtusuario.Text & "'," & _
                        '                    "[Revendedor] = " & IIf(chkRevendedor.Checked = True, 1, 0) & "," & _
                        '                    "[DateUpd] = '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "'," & _
                        '                    "[Repartidor] = " & IIf(chkRepartidor.Checked = True, 1, 0) & "," & _
                        '                    "[Autoriza] = " & IIf(chkAutoriza.Checked = True, 1, 0) & "," & _
                        '                    "[Vendedor] = " & IIf(chkVendedor.Checked = True, 1, 0) & " " & _
                        '                    " WHERE Codigo = '" & txtCODIGO.Text & "'"
                        '    End If

                        '    tranWEB.Sql_Set(sqlstring)

                        'Catch ex As Exception

                        '    MsgBox("No se puede sincronizar en la Web el empleado actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB. " + ex.Message)

                        'End Try
                        'End If


                        bolModo = False
                        PrepararBotones()
                        MDIPrincipal.NoActualizarBase = False
                        btnActualizar_Click(sender, e)

                        cmbJornadas.Enabled = bolModo

                End Select
                'Else
                '    Util.MsgStatus(Status1, "No tiene permiso para Agregar registros.", My.Resources.stop_error.ToBitmap)
                'End If

            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim res As Integer

        If MessageBox.Show("Est� seguro que desea eliminar el Empleado seleccionado?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        'If BAJA_FISICA Then
        Util.MsgStatus(Status1, "Eliminando el registro...", My.Resources.Resources.indicator_white)
        res = EliminarRegistro()
        Select Case res
            Case -2
                Util.MsgStatus(Status1, "El registro no existe.", My.Resources.stop_error.ToBitmap)
            Case -1
                Util.MsgStatus(Status1, "No se pudo borrar el registro.", My.Resources.stop_error.ToBitmap)
            Case 0
                Util.MsgStatus(Status1, "No se pudo borrar el registro.", My.Resources.stop_error.ToBitmap)
            Case Else
                Util.MsgStatus(Status1, "Se ha borrado el registro.", My.Resources.ok.ToBitmap)
                If Me.grd.RowCount = 0 Then
                    bolModo = True
                    PrepararBotones()
                    Util.LimpiarTextBox(Me.Controls)

                    cmbJornadas.Enabled = bolModo

                End If
        End Select
        'Else
        'Util.MsgStatus(Status1, "No tiene permiso para eliminar registros.", My.Resources.stop_error.ToBitmap)
        'End If
    End Sub

    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        Dim connection As SqlClient.SqlConnection = Nothing
        Dim ds_Update As Data.DataSet

        If MessageBox.Show("Est� por activar nuevamente el Empleado: " & grd.CurrentRow.Cells(2).Value.ToString & ", " & grd.CurrentRow.Cells(3).Value.ToString & ". Desea continuar?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            'llenandoCombo = False
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try

            ds_Update = SqlHelper.ExecuteDataset(connection, CommandType.Text, "UPDATE Empleados SET Eliminado = 0 WHERE id = " & grd.CurrentRow.Cells(0).Value)
            ds_Update.Dispose()

            'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then
            'Try
            '    Dim sqlstring As String

            '    sqlstring = "UPDATE [dbo].[" & NameTable_Empleados & "] SET [Eliminado] = 0, [DateUpd] = '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "' WHERE Codigo = '" & txtCODIGO.Text & "'"
            '    tranWEB.Sql_Set(sqlstring)

            'Catch ex As Exception
            '    'MsgBox(ex.Message)
            '    MsgBox("No se puede sincronizar en la Web el Empleado actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
            'End Try
            'End If

            SQL = "exec spEmpleados_Select_All @Eliminado = 1"

            LlenarGrilla()

            If grd.RowCount = 0 Then
                btnActivar.Enabled = False
            End If

            Util.MsgStatus(Status1, "El Empleado se activ� correctamente.", My.Resources.ok.ToBitmap)

        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim param As New frmParametros
        Dim Cnn As New SqlConnection(ConnStringSEI)
        Dim codigo As String
        Dim rpt As New frmReportes

        nbreformreportes = "Empleados"

        param.AgregarParametros("Nro Legajo :", "STRING", "", False, txtCODIGO.Text.ToString, "", Cnn)
        param.ShowDialog()

        If cerroparametrosconaceptar = True Then
            codigo = param.ObtenerParametros(0)

            rpt.Empleados_Maestro_App(codigo, rpt, My.Application.Info.AssemblyName.ToString)
            cerroparametrosconaceptar = False

            param = Nothing
            Cnn = Nothing

        End If

    End Sub

    Private Sub btnRestablecerContrase�a_Click(sender As Object, e As EventArgs) Handles btnRestablecerContrase�a.Click
        Dim connection As SqlClient.SqlConnection = Nothing
        Dim ds_Update As Data.DataSet

        If MessageBox.Show("Desea restablecer la contrase�a del usuario: " & grd.CurrentRow.Cells(2).Value.ToString & ", " & grd.CurrentRow.Cells(3).Value.ToString & "?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            'llenandoCombo = False
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try

            ds_Update = SqlHelper.ExecuteDataset(connection, CommandType.Text, "UPDATE Empleados SET pass = '7C4A8D09CA3762AF61E59520943DC26494F8941B', PrimerIngreso = 1, dateupd = NULL WHERE id = " & grd.CurrentRow.Cells(0).Value)
            ds_Update.Dispose()

            Util.MsgStatus(Status1, "La contrase�a del Empleado se cambi� correctamente. La nueva contrase�a es 123456", My.Resources.ok.ToBitmap)

        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try
    End Sub

    Public Overloads Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        cmbJornadas.Enabled = bolModo
    End Sub

#End Region

#Region "Funciones"

    Private Function AgregarActualizar_Registro() As Integer
        Dim connection As SqlClient.SqlConnection = Nothing

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la Base de Datos. Consulte con su Administrador.", "Error de Conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try

        Try
            Dim param_id As New SqlClient.SqlParameter
            param_id.ParameterName = "@id"
            param_id.SqlDbType = SqlDbType.BigInt
            If bolModo = True Then
                param_id.Value = DBNull.Value
            Else
                param_id.Value = txtID.Text
            End If
            param_id.Direction = ParameterDirection.InputOutput

            Dim param_codigo As New SqlClient.SqlParameter
            param_codigo.ParameterName = "@Codigo"
            param_codigo.SqlDbType = SqlDbType.VarChar
            param_codigo.Size = 10
            param_codigo.Value = DBNull.Value
            param_codigo.Direction = ParameterDirection.InputOutput

            'Dim param_nrolegajo As New SqlClient.SqlParameter
            'param_nrolegajo.ParameterName = "@nrolegajo"
            'param_nrolegajo.SqlDbType = SqlDbType.VarChar
            'param_nrolegajo.Size = 50
            'param_nrolegajo.Value = txtNroLegajo.Text
            'param_nrolegajo.Direction = ParameterDirection.Input

            Dim param_apellido As New SqlClient.SqlParameter
            param_apellido.ParameterName = "@apellido"
            param_apellido.SqlDbType = SqlDbType.VarChar
            param_apellido.Size = 50
            param_apellido.Value = txtApellido.Text.ToUpper
            param_apellido.Direction = ParameterDirection.Input

            Dim param_nombre As New SqlClient.SqlParameter
            param_nombre.ParameterName = "@nombre"
            param_nombre.SqlDbType = SqlDbType.VarChar
            param_nombre.Size = 50
            param_nombre.Value = txtNOMBRE.Text.ToUpper
            param_nombre.Direction = ParameterDirection.Input

            Dim param_direccion As New SqlClient.SqlParameter
            param_direccion.ParameterName = "@domicilio"
            param_direccion.SqlDbType = SqlDbType.VarChar
            param_direccion.Size = 50
            param_direccion.Value = txtDIRECCION.Text
            param_direccion.Direction = ParameterDirection.Input

            Dim param_telefono As New SqlClient.SqlParameter
            param_telefono.ParameterName = "@telefono"
            param_telefono.SqlDbType = SqlDbType.VarChar
            param_telefono.Size = 50
            param_telefono.Value = txtTELEFONO.Text
            param_telefono.Direction = ParameterDirection.Input

            Dim param_celular As New SqlClient.SqlParameter
            param_celular.ParameterName = "@celular"
            param_celular.SqlDbType = SqlDbType.VarChar
            param_celular.Size = 50
            param_celular.Value = txtCelular.Text
            param_celular.Direction = ParameterDirection.Input

            Dim param_cuit As New SqlClient.SqlParameter
            param_cuit.ParameterName = "@cuit"
            param_cuit.SqlDbType = SqlDbType.BigInt
            param_cuit.Value = IIf(txtCuit.Text = "", 0, txtCuit.Text)
            param_cuit.Direction = ParameterDirection.Input

            Dim param_fechaNAC As New SqlClient.SqlParameter
            param_fechaNAC.ParameterName = "@fechaNAC"
            param_fechaNAC.SqlDbType = SqlDbType.DateTime
            param_fechaNAC.Value = dtpFechaNac.Value
            param_fechaNAC.Direction = ParameterDirection.Input

            Dim param_fechaIng As New SqlClient.SqlParameter
            param_fechaIng.ParameterName = "@fechaingreso"
            param_fechaIng.SqlDbType = SqlDbType.DateTime
            param_fechaIng.Value = dtpFechaIngreso.Value
            param_fechaIng.Direction = ParameterDirection.Input

            Dim param_mail As New SqlClient.SqlParameter
            param_mail.ParameterName = "@email"
            param_mail.SqlDbType = SqlDbType.VarChar
            param_mail.Size = 150
            param_mail.Value = txtEMAIL.Text
            param_mail.Direction = ParameterDirection.Input

            'Dim param_preciohora As New SqlClient.SqlParameter
            'param_preciohora.ParameterName = "@preciohora"
            'param_preciohora.SqlDbType = SqlDbType.Decimal
            'param_preciohora.Precision = 18
            'param_preciohora.Scale = 2
            'param_preciohora.Value = IIf(txtPrecioHora.Text = "", 0, txtPrecioHora.Text)
            'param_preciohora.Direction = ParameterDirection.Input

            Dim param_art As New SqlClient.SqlParameter
            param_art.ParameterName = "@art"
            param_art.SqlDbType = SqlDbType.VarChar
            param_art.Size = 50
            param_art.Value = txtART.Text
            param_art.Direction = ParameterDirection.Input

            Dim param_VencPoliza As New SqlClient.SqlParameter
            param_VencPoliza.ParameterName = "@vencpoliza"
            param_VencPoliza.SqlDbType = SqlDbType.DateTime
            param_VencPoliza.Value = dtpVencPoliza.Value
            param_VencPoliza.Direction = ParameterDirection.Input

            Dim param_usuariosistema As New SqlClient.SqlParameter
            param_usuariosistema.ParameterName = "@usuariosistema"
            param_usuariosistema.SqlDbType = SqlDbType.Bit
            param_usuariosistema.Value = chkUsuarioSistema.Checked
            param_usuariosistema.Direction = ParameterDirection.Input

            Dim param_usuario As New SqlClient.SqlParameter
            param_usuario.ParameterName = "@usuario"
            param_usuario.SqlDbType = SqlDbType.VarChar
            param_usuario.Size = 50
            param_usuario.Value = txtusuario.Text
            param_usuario.Direction = ParameterDirection.Input

            'Dim param_autorizante As New SqlClient.SqlParameter
            'param_autorizante.ParameterName = "@autorizante"
            'param_autorizante.SqlDbType = SqlDbType.Bit
            'param_autorizante.Value = chkAutorizante.Checked
            'param_autorizante.Direction = ParameterDirection.Input

            Dim param_jornada As New SqlClient.SqlParameter
            param_jornada.ParameterName = "@idjornada"
            param_jornada.SqlDbType = SqlDbType.BigInt
            param_jornada.Value = IIf(txtIdJornada.Text = "", 0, txtIdJornada.Text)
            param_jornada.Direction = ParameterDirection.Input

            Dim param_revendedor As New SqlClient.SqlParameter
            param_revendedor.ParameterName = "@revendedor"
            param_revendedor.SqlDbType = SqlDbType.Bit
            param_revendedor.Value = chkRevendedor.Checked
            param_revendedor.Direction = ParameterDirection.Input


            Dim param_repartidor As New SqlClient.SqlParameter
            param_repartidor.ParameterName = "@repartidor"
            param_repartidor.SqlDbType = SqlDbType.Bit
            param_repartidor.Value = chkRepartidor.Checked
            param_repartidor.Direction = ParameterDirection.Input

            Dim param_autoriza As New SqlClient.SqlParameter
            param_autoriza.ParameterName = "@Autoriza"
            param_autoriza.SqlDbType = SqlDbType.Bit
            param_autoriza.Value = chkAutoriza.Checked
            param_autoriza.Direction = ParameterDirection.Input

            Dim param_vendedor As New SqlClient.SqlParameter
            param_vendedor.ParameterName = "@Vendedor"
            param_vendedor.SqlDbType = SqlDbType.Bit
            param_vendedor.Value = chkVendedor.Checked
            param_vendedor.Direction = ParameterDirection.Input

            Dim param_useradd As New SqlClient.SqlParameter
            If bolModo = True Then
                param_useradd.ParameterName = "@useradd"
            Else
                param_useradd.ParameterName = "@userupd"
            End If
            param_useradd.SqlDbType = SqlDbType.Int
            param_useradd.Value = 99
            param_useradd.Direction = ParameterDirection.Input

            Dim param_res As New SqlClient.SqlParameter
            param_res.ParameterName = "@res"
            param_res.SqlDbType = SqlDbType.Int
            param_res.Value = DBNull.Value
            param_res.Direction = ParameterDirection.InputOutput

            Try
                If bolModo = True Then

                    SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "spEmpleados_Insert", param_id, _
                                           param_apellido, param_nombre, param_direccion, param_telefono, param_celular, _
                                           param_cuit, param_fechaNAC, param_fechaIng, param_mail, param_codigo, param_autoriza, _
                                           param_art, param_VencPoliza, param_usuariosistema, param_usuario, param_vendedor, _
                                           param_jornada, param_revendedor, param_repartidor, param_useradd, param_res)

                    txtID.Text = param_id.Value
                    txtCODIGO.Text = param_codigo.Value

                Else
                    SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "spEmpleados_Update", param_id, _
                                        param_apellido, param_nombre, param_direccion, param_telefono, param_celular, _
                                        param_cuit, param_fechaNAC, param_fechaIng, param_mail, param_autoriza, _
                                        param_art, param_VencPoliza, param_usuariosistema, param_usuario, param_vendedor, _
                                        param_jornada, param_revendedor, param_repartidor, param_useradd, param_res)

                End If

                AgregarActualizar_Registro = param_res.Value

            Catch ex As Exception
                Throw ex
            End Try

        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor valide el siguiente mensaje de error: {0}" _
                + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
                "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try

    End Function

    Private Function EliminarRegistro() As Integer
        Dim res As Integer = 0
        Dim connection As SqlClient.SqlConnection = Nothing


        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la Base de Datos. Consulte con su Administrador.", "Error de Conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try

        Try

            Dim param_id As New SqlClient.SqlParameter("@id", SqlDbType.BigInt, ParameterDirection.Input)
            param_id.Value = CType(txtID.Text, Long)
            param_id.Direction = ParameterDirection.Input

            Dim param_userdel As New SqlClient.SqlParameter
            param_userdel.ParameterName = "@userdel"
            param_userdel.SqlDbType = SqlDbType.Int
            param_userdel.Value = 99
            param_userdel.Direction = ParameterDirection.Input

            Dim param_res As New SqlClient.SqlParameter
            param_res.ParameterName = "@res"
            param_res.SqlDbType = SqlDbType.Int
            param_res.Value = DBNull.Value
            param_res.Direction = ParameterDirection.Output

            Try

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "spEmpleados_Delete", param_id, param_userdel, param_res)
                res = param_res.Value

                If res > 0 Then
                    'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then
                    'Try
                    '    Dim sqlstring As String

                    '    sqlstring = "UPDATE [dbo].[" & NameTable_Empleados & "] SET [Eliminado] = 1, [DateDel] = '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "' WHERE Codigo = '" & txtCODIGO.Text & "'"
                    '    tranWEB.Sql_Set(sqlstring)

                    'Catch ex As Exception
                    '    'MsgBox(ex.Message)
                    '    MsgBox("No se puede sincronizar en la Web el Empleado actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                    'End Try
                    'End If

                    Util.BorrarGrilla(grd)

                End If

                EliminarRegistro = res

            Catch ex As Exception
                '' 


                Throw ex
            End Try

        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try

    End Function

#End Region

#Region "Procedimientos"

    Private Sub configurarform()
        'Me.Text = "Empleados"

        'Me.grd.Location = New Size(GroupBox1.Location.X, GroupBox1.Location.Y + GroupBox1.Size.Height + 7)

        ''Me.Size = New Size(IIf(Me.Size.Width <= AnchoMinimoForm, AnchoMinimoForm, Me.Size.Width), Me.grd.Location.Y + Me.grd.Size.Height + 65)
        'Me.Size = New Size(Me.Size.Width, (Screen.PrimaryScreen.WorkingArea.Height - 75))

        'Dim p As New Size(GroupBox1.Size.Width, Me.Size.Height - 7 - GroupBox1.Size.Height - GroupBox1.Location.Y - 65)
        'Me.grd.Size = New Size(p)

        'If LLAMADO_POR_FORMULARIO Then
        '    LLAMADO_POR_FORMULARIO = False
        '    'Me.Top = ARRIBA
        '    'Me.Left = IZQUIERDA
        '    'Else
        '    '    Me.Top = 0
        '    '    Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        'End If

        ''Me.Top = 0
        ''Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2

        'Me.WindowState = FormWindowState.Maximized

        'Me.grd.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 27, Me.Size.Height - 3 - GroupBox1.Size.Height - GroupBox1.Location.Y - 62) '65)

        Me.Text = "Empleados"

        Me.grd.Location = New Size(GroupBox1.Location.X, GroupBox1.Location.Y + GroupBox1.Size.Height + 7)

        'Me.Size = New Size(IIf(Me.Size.Width <= AnchoMinimoForm, AnchoMinimoForm, Me.Size.Width), Me.grd.Location.Y + Me.grd.Size.Height + 65)
        Me.Size = New Size(Me.Size.Width, (Screen.PrimaryScreen.WorkingArea.Height - 40))

        Dim p As New Size(GroupBox1.Size.Width, Me.Size.Height - 25 - GroupBox1.Size.Height - GroupBox1.Location.Y - 40)
        Me.grd.Size = New Size(p)

        If LLAMADO_POR_FORMULARIO Then
            LLAMADO_POR_FORMULARIO = False
            'Me.Top = ARRIBA
            'Me.Left = IZQUIERDA
            'Else
            '    Me.Top = 0
            '    Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2
        End If

        Me.Top = 0
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub asignarTags()
        txtID.Tag = "0"
        'txtCODIGO.Tag = "1"
        'txtNroLegajo.Tag = "1"
        txtApellido.Tag = "1"
        txtNOMBRE.Tag = "2"
        txtCuit.Tag = "3"
        dtpFechaNac.Tag = "4"
        dtpFechaIngreso.Tag = "5"
        'txtPrecioHora.Tag = "7"
        txtART.Tag = "6"
        dtpVencPoliza.Tag = "7"
        txtDIRECCION.Tag = "8"
        txtTELEFONO.Tag = "9"
        txtCelular.Tag = "10"
        txtEMAIL.Tag = "11"
        txtusuario.Tag = "12"
        chkUsuarioSistema.Tag = "13"

        txtIdJornada.Text = "14"
        cmbJornadas.Tag = "15"

        chkRevendedor.Tag = "16"
        txtCODIGO.Tag = "17"
        chkRepartidor.Tag = "18"
        chkAutoriza.Tag = "19"
        chkVendedor.Tag = "20"

    End Sub

    Private Sub Verificar_Datos()

        bolpoliticas = False

        bolpoliticas = True

    End Sub

    Private Sub LlenarcmbJornadas()
        Dim connection As SqlClient.SqlConnection = Nothing
        Dim ds As Data.DataSet

        llenandoCombo = True

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            llenandoCombo = False
            Exit Sub
        End Try

        Try

            ds = SqlHelper.ExecuteDataset(connection, CommandType.Text, "SELECT id, (Nombre + ' - Toler.: ' + CAST(tolerancia AS VARCHAR(2))) AS Nombre FROM Jornadas ORDER BY Nombre")
            ds.Dispose()

            With cmbJornadas
                .DataSource = ds.Tables(0).DefaultView
                .DisplayMember = "nombre"
                .ValueMember = "Id"
            End With

        Catch ex As Exception
            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            llenandoCombo = False

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not connection Is Nothing Then
                CType(connection, IDisposable).Dispose()
            End If
        End Try

        llenandoCombo = False

    End Sub

#End Region

   

   
End Class