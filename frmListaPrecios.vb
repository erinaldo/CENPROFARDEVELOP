Imports Microsoft.ApplicationBlocks.Data
Imports Utiles
Imports Utiles.Util
Imports Utiles.compartida
Imports System.Data.SqlClient
Imports ReportesNet
Imports System.Threading

Public Class frmListaPrecios

    Dim bolpoliticas As Boolean
    Private ds_2 As DataSet
    Dim permitir_evento_CellChanged As Boolean
    Dim tran As SqlClient.SqlTransaction
    Dim Cell_X As Integer, Cell_Y As Integer
    Public Origen As Integer
    Dim CambioValor As Boolean = False

    Dim tranWEB As New WS_Porkys.WS_PorkysSoapClient


#Region "Componentes Formulario"

    Private Sub frmListaPrecios_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3 'nuevo
                If bolModo = True Then
                    If MessageBox.Show("No ha guardado la Lista de Precios Nuevo que est� realizando. �Est� seguro que desea continuar sin Grabar y hacer un Nuevo Cliente?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        btnNuevo_Click(sender, e)
                    End If
                Else
                    btnNuevo_Click(sender, e)
                End If
            Case Keys.F4 'grabar
                btnGuardar_Click(sender, e)
        End Select
    End Sub

    Private Sub frmAjustes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        btnSalir_Click(sender, e)
    End Sub

    Private Sub frmClientes_ev_CellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ev_CellChanged
        'If permitir_evento_CellChanged Then
        '    If txtID.Text <> "" Then
        '        LlenarGridItems()
        '    End If
        'End If
    End Sub

    Private Sub frmListaPrecios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        configurarform()
        asignarTags()

        'Try
        '    If MDIPrincipal.EmpleadoLogueado = "12" Or MDIPrincipal.EmpleadoLogueado = "13" Or MDIPrincipal.EmpleadoLogueado = "2" Then
        '        Dim sqlstring As String = "update [" & NameTable_NotificacionesWEB & "] set BloqueoL = 1"
        '        tranWEB.Sql_Set(sqlstring)
        '    End If

        'Catch ex As Exception

        'End Try

        'LlenarLocalidad()
        'LlenarProvincia()
        'LlenarcmbTipoDocumento_App(Me.cmbDocTipo, ConnStringSEI)

        'momentaneamente no dejo que puedan elimianr una lista de precios
        btnEliminar.Visible = False
        chkEliminados.Visible = False
        btnActivar.Visible = False

        SQL = "exec spLista_Precios_Select_All @Eliminado = 0"

        LlenarGrilla()
        Permitir = True

        CargarCajas()

        PrepararBotones()

        If bolModo = True Then
            btnNuevo_Click(sender, e)
        End If

        If grd.RowCount > 0 Then
            grd.Rows(0).Selected = True
            grd.CurrentCell = grd.Rows(0).Cells(1)
        End If

        permitir_evento_CellChanged = True

    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
     Handles txtID.KeyPress, txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub chkEliminados_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkEliminados.CheckedChanged

        btnNuevo.Enabled = Not chkEliminados.Checked
        btnGuardar.Enabled = Not chkEliminados.Checked
        btnCancelar.Enabled = Not chkEliminados.Checked
        btnEliminar.Enabled = Not chkEliminados.Checked

        If chkEliminados.Checked = True Then
            SQL = "exec spLista_Precios_Select_All @Eliminado = 1"
        Else
            SQL = "exec spLista_Precios_Select_All @Eliminado = 0"
        End If

        LlenarGrilla()

        'LlenarGridItems()

        If grd.RowCount = 0 Then
            btnActivar.Enabled = False
        Else
            btnActivar.Enabled = chkEliminados.Checked
        End If

    End Sub

    Private Sub txtPorcentaje_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentaje.TextChanged
        'aviso que esta cambiando el valor de porcentaje
        CambioValor = True
    End Sub

#End Region

#Region "Botones"

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        bolModo = True
        Util.MsgStatus(Status1, "Haga click en [Guardar] despues de completar los datos.")
        PrepararBotones()
        Util.LimpiarTextBox(Me.Controls)
        txtDescripcion.Focus()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim res As Integer

        If bolModo = False Then
            If MessageBox.Show("�Est� seguro que desea modificar esta lista de precio?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Util.MsgStatus(Status1, "Guardando el registro...", My.Resources.Resources.indicator_white)

        If ReglasNegocio() Then
            Verificar_Datos()
            If bolpoliticas Then
                res = AgregarActualizar_Registro()
                Select Case res
                    Case -10
                        Util.MsgStatus(Status1, "Est� intentando ingresar un PORCENTAJE que ya existe en el sistema. Por favor, verifique esta informaci�n.", My.Resources.Resources.stop_error.ToBitmap)
                        Util.MsgStatus(Status1, "Est� intentando ingresar un PORCENTAJE que ya existe en el sistema. Por favor, verifique esta informaci�n.", My.Resources.Resources.stop_error.ToBitmap, True)
                        Cancelar_Tran()
                        txtPorcentaje.Focus()
                        Exit Sub
                    Case -1
                        Util.MsgStatus(Status1, "No se pudo insertar la lista de precio.", My.Resources.Resources.stop_error.ToBitmap)
                        Cancelar_Tran()
                        Exit Sub
                    Case -2
                        Util.MsgStatus(Status1, "No se pudo actualizar la lista de precio.", My.Resources.Resources.stop_error.ToBitmap)
                        Cancelar_Tran()
                        Exit Sub
                    Case 0
                        Util.MsgStatus(Status1, "No se pudo insertar/actualizar la lista de precio.", My.Resources.Resources.stop_error.ToBitmap)
                        Cancelar_Tran()
                        Exit Sub
                    Case Else
                        Util.MsgStatus(Status1, "Se agreg� la Lista de Precios.", My.Resources.Resources.ok.ToBitmap)

                        'me fijo en que modo est�
                        If bolModo = False Then
                            res = ActualizarPreciosPorLista()
                        Else
                            'Try
                            '    Dim sqlstring As String
                            '    Dim valorcambio As Decimal

                            '    valorcambio = (1 + CDbl(txtPorcentaje.Text) / 100)

                            '    sqlstring = "insert into [" & NameTable_ListaPrecios & "] (ID, Codigo, Descripcion, Porcentaje, Valor_Cambio, Eliminado, DateUpd) " & _
                            '      "values ( " & txtID.Text & ", " & txtCODIGO.Text & ",'" & txtDescripcion.Text.ToUpper & "', " & txtPorcentaje.Text & ", " & _
                            '                  valorcambio & ", 0 , '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "')"

                            '    tranWEB.Sql_Set(sqlstring)

                            'Catch ex As Exception
                            '    MsgBox("No se pudo agregar en la Web la nueva lista de precios. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                            'End Try
                            res = 1
                        End If
                        Select Case res
                            Case Is <= 0
                                Util.MsgStatus(Status1, "No se pudo actualizar los precios de los productos asociados a esta Lista.", My.Resources.Resources.stop_error.ToBitmap)
                                Util.MsgStatus(Status1, "No se pudo actualizar los precios de los productos asociados a esta Lista.", My.Resources.Resources.stop_error.ToBitmap, True)
                                Cancelar_Tran()
                            Case Else
                                Cerrar_Tran()
                                bolModo = False
                                chkPrincipal.Checked = False
                                chkPeron.Checked = False
                                MDIPrincipal.NoActualizarBase = False
                                btnActualizar_Click(sender, e)
                        End Select
                End Select
            End If
        End If

        If Origen = 1 Then
            Me.Close()
        End If

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim connection As SqlClient.SqlConnection = Nothing
        Dim ds As Data.DataSet
        Dim res As Integer

        If MessageBox.Show("Est� seguro que desea eliminar la lista de precio seleccionada?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            ds = SqlHelper.ExecuteDataset(ConnStringSEI, CommandType.Text, "SELECT  c.id FROM Clientes C Join lista_precios L on l.codigo = C.IDPrecioLista where L.codigo = '" & txtCODIGO.Text & "'")
            ds.Dispose()

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("No se puede eliminar una lista de precio que este asociada a un cliente. Por favor verifique.", MsgBoxStyle.Information, "Atenci�n")
                Exit Sub
            End If
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
     

		Util.MsgStatus(Status1, "Eliminando el registro...", My.Resources.Resources.indicator_white)        
		
        Dim id As Long
        Dim codigo As String

        id = txtID.Text
        codigo = txtCODIGO.Text

        res = EliminarRegistro()
        Select Case res
            Case -1
                Util.MsgStatus(Status1, "No se pudo borrar el registro.", My.Resources.stop_error.ToBitmap)
                Exit Sub
            Case 0
                Util.MsgStatus(Status1, "No se pudo borrar el registro.", My.Resources.stop_error.ToBitmap)
                Exit Sub
            Case Else
                Util.MsgStatus(Status1, "Se ha borrado el registro.", My.Resources.ok.ToBitmap)

                'Try
                '    tranWEB.Sql_Set("delete from Lista_Precios where id = " & id)
                'Catch ex As Exception
                '    MsgBox("No se puede eliminar en la Web la Lista de Precios actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                'End Try

                'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then
                'Try
                '    Dim sqlstring As String

                '    sqlstring = "UPDATE [dbo].[" & NameTable_ListaPrecios & "] SET [Eliminado] = 1 WHERE Codigo = " & codigo
                '    tranWEB.Sql_Set(sqlstring)

                'Catch ex As Exception
                '    'MsgBox(ex.Message)
                '    MsgBox("No se puede actualizar en la Web la lista de Precios. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                'End Try
                'End If

                If Me.grd.RowCount = 0 Then
                    bolModo = True
                    PrepararBotones()
                    Util.LimpiarTextBox(Me.Controls)
                End If

        End Select
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim param As New frmParametros
        Dim cnn As New SqlConnection(ConnStringSEI)
        Dim codigo As String
        Dim rpt As New frmReportes

        nbreformreportes = "Listado Precios por Descripci�n"

        param.AgregarParametros("Descripci�n :", "STRING", "", False, txtDescripcion.Text.ToString, "", cnn)
        param.ShowDialog()

        If cerroparametrosconaceptar = True Then

            codigo = param.ObtenerParametros(0)

            rpt.Clientes_Maestro_App(codigo, rpt, My.Application.Info.AssemblyName.ToString)

            cerroparametrosconaceptar = False
            param = Nothing
            cnn = Nothing
        End If

    End Sub

    Private Overloads Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'If txtID.Text <> "" Then
        '    LlenarGridItems()
        'End If
        CambioValor = False
        chkPrincipal.Checked = False
        chkPeron.Checked = False
    End Sub

    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        Dim connection As SqlClient.SqlConnection = Nothing
        Dim ds_Update As Data.DataSet

        If MessageBox.Show("Est� por activar nuevamente la lista de precios: " & grd.CurrentRow.Cells(1).Value.ToString & ". Desea continuar?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
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

            ds_Update = SqlHelper.ExecuteDataset(connection, CommandType.Text, "UPDATE Lista_Precios SET Eliminado = 0 WHERE id = " & grd.CurrentRow.Cells(0).Value)
            ds_Update.Dispose()



            'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then
            'Try
            '    Dim sqlstring As String

            '    sqlstring = "UPDATE [dbo].[" & NameTable_ListaPrecios & "] SET [Eliminado] = 0 WHERE Codigo = " & grd.CurrentRow.Cells(1).Value
            '    tranWEB.Sql_Set(sqlstring)

            'Catch ex As Exception
            '    'MsgBox(ex.Message)
            '    MsgBox("No se puede Activa en la Web la lista de Precio seleccionada. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
            'End Try
            'End If

            SQL = "exec spLista_Precios_Select_All @Eliminado = 1"

            LlenarGrilla()

            If grd.RowCount = 0 Then
                btnActivar.Enabled = False
            End If

            Util.MsgStatus(Status1, "La lista de precio se activ� correctamente.", My.Resources.ok.ToBitmap)

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

    Protected Overloads Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        'Try
        '    If MDIPrincipal.sucursal.ToUpper.Contains("PRINCIPAL") And (MDIPrincipal.EmpleadoLogueado = "12" Or MDIPrincipal.EmpleadoLogueado = "13" Or MDIPrincipal.EmpleadoLogueado = "2") Then
        '        Dim sqlstring As String = "update [" & NameTable_NotificacionesWEB & "] set BloqueoL = 0"
        '        tranWEB.Sql_Set(sqlstring)
        '    End If

        'Catch ex As Exception

        'End Try

    End Sub


#End Region

#Region "Procedimientos"

    Private Sub configurarform()
        Me.Text = "Lista de Precios"

        Me.grd.Location = New Size(GroupBox1.Location.X, GroupBox1.Location.Y + GroupBox1.Size.Height + 7)

        'Me.Size = New Size(IIf(Me.Size.Width <= AnchoMinimoForm, AnchoMinimoForm, Me.Size.Width), Me.grd.Location.Y + Me.grd.Size.Height + 65)
        'Me.Size = New Size(Me.Size.Width, (Screen.PrimaryScreen.WorkingArea.Height - 75))
        Me.Size = New Size(Me.Size.Width, 500)

        Dim p As New Size(GroupBox1.Size.Width, Me.Size.Height - 7 - GroupBox1.Size.Height - GroupBox1.Location.Y - 65)
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

    End Sub

    Private Sub asignarTags()
        txtID.Tag = "0"
        txtCODIGO.Tag = "1"
        txtDescripcion.Tag = "2"
        txtPorcentaje.Tag = "3"
    End Sub

    Private Sub Verificar_Datos()

        bolpoliticas = False
        'controlo el porcentaje 
        'If txtPorcentaje.Text <> "" Then
        '    If CDbl(txtPorcentaje.Text) <= 0 Then
        '        MsgBox("El porcentaje ingresado no es v�lido . Por favor, controle el dato.", MsgBoxStyle.Information, "Atenci�n")
        '        txtPorcentaje.Focus()
        '        Exit Sub
        '    End If
        'Else
        '    Exit Sub
        'End If
        'Controlo que al menos seleccione un Almacen
        If CambioValor = True Then
            If chkPeron.Checked = False And chkPrincipal.Checked = False Then
                MsgBox("Por favor seleccione un almacen para realizar los cambios.", MsgBoxStyle.Information, "Atenci�n")
                Exit Sub
            End If
        End If
        bolpoliticas = True

    End Sub

    Private Sub InicializarGridItems(ByVal Grd As DataGridView)

        Dim style As New DataGridViewCellStyle
        Grd.EnableHeadersVisualStyles = False

        'da formato al encabezado...
        With Grd.ColumnHeadersDefaultCellStyle
            .BackColor = Color.CadetBlue
            .ForeColor = Color.Purple
            .Font = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter
        End With

        ' Inicialice propiedades b�sicas.
        With Grd
            '.Dock = DockStyle.Fill ' lo coloca al tope del formulario..
            .BackgroundColor = SystemColors.ActiveBorder 'Color.DarkGray ' color del fondo del grid...
            .BorderStyle = BorderStyle.Fixed3D
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised
            .AllowUserToAddRows = True 'indica si se muestra al usuario la opci�n de agregar filas
            .AllowUserToDeleteRows = True 'indica si el usuario puede eliminar filas de DataGridView.
            .AllowUserToOrderColumns = False 'indica si el usuario puede cambiar manualmente de lugar las columnas..
            .ReadOnly = False
            '.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'indica c�mo se pueden seleccionar las celdas de DataGridView.
            .MultiSelect = False 'indica si el usuario puede seleccionar a la vez varias celdas, filas o columnas del control DataGridView.
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells     'indica c�mo se determina el alto de las filas. 
            .AllowUserToResizeColumns = True 'indica si los usuarios pueden cambiar el tama�o de las columnas.
            .AllowUserToResizeRows = True 'indica si los usuarios pueden cambiar el tama�o de las filas.
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize 'indica si el alto de los encabezados de columna es ajustable y si puede ser ajustado por el usuario o autom�ticamente para adaptarse al contenido de los encabezados. 
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With

        'Setear el color de seleccion de fondo de la celda actual...
        Grd.DefaultCellStyle.SelectionBackColor = Color.White
        Grd.DefaultCellStyle.SelectionForeColor = Color.Blue

        'generamos el formato para las celdas...
        With style
            .BackColor = Color.Lavender   'Color.LightGray
            .Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular)
            .ForeColor = Color.Black
        End With
        Grd.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan

        'Aplicamos el estilo a todas las celdas del control DataGridView
        Grd.RowsDefaultCellStyle = style
    End Sub

 
#End Region

#Region "Funciones"

    Private Function AgregarActualizar_Registro() As Integer
        Dim connection As SqlClient.SqlConnection = Nothing
        'Dim res As Integer = 0

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)

        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try

        'Abrir una transaccion para guardar y asegurar que se guarda todo
        If Abrir_Tran(connection) = False Then
            MessageBox.Show("No se pudo abrir una transaccion", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If

        Try
            Dim param_id As New SqlClient.SqlParameter
            param_id.ParameterName = "@id"
            param_id.SqlDbType = SqlDbType.BigInt

            Dim param_codigo As New SqlClient.SqlParameter
            param_codigo.ParameterName = "@Codigo"
            param_codigo.SqlDbType = SqlDbType.Float
            param_codigo.Size = 10

            If bolModo = True Then
                param_id.Value = DBNull.Value
                param_id.Direction = ParameterDirection.InputOutput

                param_codigo.Value = DBNull.Value
                param_codigo.Direction = ParameterDirection.InputOutput
            Else
                param_id.Value = txtID.Text
                param_id.Direction = ParameterDirection.Input

                param_codigo.Value = txtCODIGO.Text
                param_codigo.Direction = ParameterDirection.Input
            End If

            Dim param_descripcion As New SqlClient.SqlParameter
            param_descripcion.ParameterName = "@Descripcion"
            param_descripcion.SqlDbType = SqlDbType.VarChar
            param_descripcion.Size = 100
            param_descripcion.Value = txtDescripcion.Text.ToUpper
            param_descripcion.Direction = ParameterDirection.Input

            Dim param_porc As New SqlClient.SqlParameter
            param_porc.ParameterName = "@Porcentaje"
            param_porc.SqlDbType = SqlDbType.Decimal
            param_porc.Precision = 18
            param_porc.Scale = 2
            param_porc.Value = txtPorcentaje.Text
            param_porc.Direction = ParameterDirection.Input

            'Dim param_valorcambio As New SqlClient.SqlParameter
            'param_valorcambio.ParameterName = "@valorcambio"
            'param_valorcambio.SqlDbType = SqlDbType.Decimal
            'param_valorcambio.Precision = 18
            'param_valorcambio.Scale = 2
            'param_valorcambio.Value = (1 + CDbl(txtPorcentaje.Text) / 100)
            'param_valorcambio.Direction = ParameterDirection.Input

            Dim param_useradd As New SqlClient.SqlParameter
            If bolModo = True Then
                param_useradd.ParameterName = "@useradd"
            Else
                param_useradd.ParameterName = "@userupd"
            End If
            param_useradd.SqlDbType = SqlDbType.Int
            param_useradd.Value = UserID
            param_useradd.Direction = ParameterDirection.Input

            Dim param_res As New SqlClient.SqlParameter
            param_res.ParameterName = "@res"
            param_res.SqlDbType = SqlDbType.Int
            param_res.Value = DBNull.Value
            param_res.Direction = ParameterDirection.InputOutput

            Try
                If bolModo = True Then
                    SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "spLista_Precios_Insert", param_id, _
                                          param_codigo, param_descripcion, param_porc, _
                                          param_useradd, param_res)

                    txtID.Text = param_id.Value
                    txtCODIGO.Text = param_codigo.Value
                Else

                    SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "spLista_Precios_Update", param_id, _
                                        param_codigo, param_descripcion, param_porc, _
                                        param_useradd, param_res)

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

            If ex.Message.ToString.Contains("UNIQUE KEY") Or ex.Message.ToString.Contains("clave duplicada") Then
                AgregarActualizar_Registro = -10
            Else
                MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
                  + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
                  "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End Try

    End Function

    'Private Function ActualizarRegistro() As Integer
    '    Dim res As Integer = 0
    '    Dim connection As SqlClient.SqlConnection = Nothing

    '    Try
    '        connection = SqlHelper.GetConnection(ConnStringSEI)
    '    Catch ex As Exception
    '        MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Function
    '    End Try

    '    'Abrir una transaccion para guardar y asegurar que se guarda todo
    '    If Abrir_Tran(connection) = False Then
    '        MessageBox.Show("No se pudo abrir una transaccion", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Function
    '    End If

    '    Try

    '        Dim param_id As New SqlClient.SqlParameter
    '        param_id.ParameterName = "@id"
    '        param_id.SqlDbType = SqlDbType.BigInt
    '        param_id.Value = txtID.Text
    '        param_id.Direction = ParameterDirection.InputOutput

    '        Dim param_descripcion As New SqlClient.SqlParameter
    '        param_descripcion.ParameterName = "@Descripcion"
    '        param_descripcion.SqlDbType = SqlDbType.VarChar
    '        param_descripcion.Size = 100
    '        param_descripcion.Value = txtDescripcion.Text
    '        param_descripcion.Direction = ParameterDirection.Input

    '        Dim param_descuento As New SqlClient.SqlParameter
    '        param_descuento.ParameterName = "@Descuento"
    '        param_descuento.SqlDbType = SqlDbType.Bit
    '        param_descuento.Value = rdDescuento.Checked
    '        param_descuento.Direction = ParameterDirection.Input

    '        Dim param_recarga As New SqlClient.SqlParameter
    '        param_recarga.ParameterName = "@Recarga"
    '        param_recarga.SqlDbType = SqlDbType.Bit
    '        param_recarga.Value = rdRecarga.Checked
    '        param_recarga.Direction = ParameterDirection.Input

    '        Dim param_porc As New SqlClient.SqlParameter
    '        param_porc.ParameterName = "@Porcentaje"
    '        param_porc.SqlDbType = SqlDbType.Decimal
    '        param_porc.Precision = 18
    '        param_porc.Scale = 2
    '        param_porc.Value = txtPorcentaje.Text
    '        param_porc.Direction = ParameterDirection.Input

    '        Dim param_valorcambio As New SqlClient.SqlParameter
    '        param_valorcambio.ParameterName = "@valorcambio"
    '        param_valorcambio.SqlDbType = SqlDbType.Decimal
    '        param_valorcambio.Precision = 18
    '        param_valorcambio.Scale = 2
    '        If rdDescuento.Checked = True Then
    '            param_valorcambio.Value = (1 - CDbl(txtPorcentaje.Text) / 100)
    '        Else
    '            param_valorcambio.Value = (1 + CDbl(txtPorcentaje.Text) / 100)
    '        End If
    '        param_valorcambio.Direction = ParameterDirection.Input

    '        Dim param_userupd As New SqlClient.SqlParameter
    '        param_userupd.ParameterName = "@userupd"
    '        param_userupd.SqlDbType = SqlDbType.Int
    '        param_userupd.Value = UserID
    '        param_userupd.Direction = ParameterDirection.Input

    '        Dim param_res As New SqlClient.SqlParameter
    '        param_res.ParameterName = "@res"
    '        param_res.SqlDbType = SqlDbType.Int
    '        param_res.Value = DBNull.Value
    '        param_res.Direction = ParameterDirection.InputOutput

    '        Try


    '            ActualizarRegistro = param_res.Value

    '        Catch ex As Exception
    '            Throw ex
    '        End Try

    '    Catch ex As Exception
    '        Dim errMessage As String = ""
    '        Dim tempException As Exception = ex

    '        While (Not tempException Is Nothing)
    '            errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
    '            tempException = tempException.InnerException
    '        End While

    '        If ex.Message.ToString.Contains("UNIQUE KEY") Or ex.Message.ToString.Contains("clave duplicada") Then
    '            ActualizarRegistro = -10
    '        Else
    '            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
    '              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
    '              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If

    '    End Try

    'End Function

    Private Function EliminarRegistro() As Integer
        Dim res As Integer = 0
        Dim connection As SqlClient.SqlConnection = Nothing

        Try
            connection = SqlHelper.GetConnection(ConnStringSEI)
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar con la base de datos", "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End Try

        Try

            Dim param_id As New SqlClient.SqlParameter("@id", SqlDbType.BigInt, ParameterDirection.Input)
            param_id.Value = CType(txtID.Text, Long)
            param_id.Direction = ParameterDirection.Input

            Dim param_userdel As New SqlClient.SqlParameter
            param_userdel.ParameterName = "@userdel"
            param_userdel.SqlDbType = SqlDbType.Int
            param_userdel.Value = UserID
            param_userdel.Direction = ParameterDirection.Input

            Dim param_res As New SqlClient.SqlParameter
            param_res.ParameterName = "@res"
            param_res.SqlDbType = SqlDbType.Int
            param_res.Value = DBNull.Value
            param_res.Direction = ParameterDirection.Output

            Try

                SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, "spLista_Precios_Delete", param_id, param_userdel, param_res)
                res = param_res.Value

                If res > 0 Then Util.BorrarGrilla(grd)

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

    Private Function ActualizarPreciosPorLista() As Integer

        Dim res As Integer

        Dim param_Codigo As New SqlClient.SqlParameter
        param_Codigo.ParameterName = "@Codigo"
        param_Codigo.SqlDbType = SqlDbType.Float
        param_Codigo.Value = txtCODIGO.Text
        param_Codigo.Direction = ParameterDirection.Input

        Dim param_principal As New SqlClient.SqlParameter
        param_principal.ParameterName = "@Principal"
        param_principal.SqlDbType = SqlDbType.Bit
        param_principal.Value = chkPrincipal.Checked
        param_principal.Direction = ParameterDirection.Input

        Dim param_peron As New SqlClient.SqlParameter
        param_peron.ParameterName = "@Peron"
        param_peron.SqlDbType = SqlDbType.Bit
        param_peron.Value = chkPeron.Checked
        param_peron.Direction = ParameterDirection.Input

        Dim param_res As New SqlClient.SqlParameter
        param_res.ParameterName = "@res"
        param_res.SqlDbType = SqlDbType.Int
        param_res.Value = DBNull.Value
        param_res.Direction = ParameterDirection.InputOutput


        Try
            SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "spActualizar_PrecioPorLista", param_Codigo, param_principal, param_peron, param_res)
            res = param_res.Value

            ActualizarPreciosPorLista = res

            'If MDIPrincipal.NoActualizar = False Then 'Not SystemInformation.ComputerName.ToString.ToUpper = "SAMBA-PC" Then

            If ActualizarPreciosPorLista = 1 Then

                'Try
                '    Dim sqlstring As String
                '    Dim valorcambio As Decimal

                '    valorcambio = (1 + CDbl(txtPorcentaje.Text) / 100)

                '    'If bolModo = True Then
                '    '    sqlstring = "insert into [Lista_Precios] (ID, Codigo, Descripcion, Porcentaje, Valor_Cambio, Eliminado, DateUpd) " & _
                '    '                "values ( " & txtID.Text & ", " & txtCODIGO.Text & ",'" & txtDescripcion.Text.ToUpper & "', " & txtPorcentaje.Text & ", " & _
                '    '                            valorcambio & ", 0 , '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "')"
                '    'Else
                '    sqlstring = "update [" & NameTable_ListaPrecios & "] SET Codigo =  " & txtCODIGO.Text & ", Descripcion = '" & txtDescripcion.Text.ToUpper & "', Porcentaje = " & txtPorcentaje.Text & ", Valor_Cambio = " & valorcambio & ", " & _
                '                "DateUpd = '" & Format(Date.Now, "MM/dd/yyyy").ToString & " " & Format(Date.Now, "hh:mm:ss").ToString & "' where ID = " & txtID.Text
                '    'End If

                '    tranWEB.Sql_Set(sqlstring)

                '    Try
                '        res = 0
                '        sqlstring = "exec " & NameSP_spActualizarPrecioPorLista & " " & txtCODIGO.Text & "," & chkPrincipal.Checked & "," & chkPeron.Checked & ""

                '        res = tranWEB.Sql_Get_Value(sqlstring)

                '        If res = -1 Then
                '            MsgBox("No se puede actualizar en la Web los precios de los productos asociados a la Lista de Precios actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                '        End If

                '    Catch ex As Exception
                '        MsgBox("No se puede actualizar en la Web los precios de los productos asociados a la Lista de Precios actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                '    End Try

                'Catch ex As Exception
                '    'MsgBox(ex.Message)
                '    MsgBox("No se puede actualizar en la Web la Lista de Precios actual. Ejecute el bot�n sincronizar para actualizar el servidor WEB.")
                'End Try

            End If


            'End If




        Catch ex As Exception

            ActualizarPreciosPorLista = -1

            Dim errMessage As String = ""
            Dim tempException As Exception = ex

            While (Not tempException Is Nothing)
                errMessage += tempException.Message + Environment.NewLine + Environment.NewLine
                tempException = tempException.InnerException
            End While

            MessageBox.Show(String.Format("Se produjo un problema al procesar la informaci�n en la Base de Datos, por favor, valide el siguiente mensaje de error: {0}" _
              + Environment.NewLine + "Si el problema persiste cont�ctese con MercedesIt a trav�s del correo soporte@mercedesit.com", errMessage), _
              "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Function

#End Region

#Region "Transacciones"

    Private Function Abrir_Tran(ByRef cnn As SqlClient.SqlConnection) As Boolean
        If tran Is Nothing Then
            Try
                tran = cnn.BeginTransaction
                Abrir_Tran = True
            Catch ex As Exception
                Abrir_Tran = False
                Exit Function
            End Try
        End If
    End Function

    Private Sub Cerrar_Tran()
        'Cierra o finaliza la transaccion
        If Not (tran Is Nothing) Then
            tran.Commit()
            tran.Dispose()
            tran = Nothing
        End If
    End Sub

    Private Sub Cancelar_Tran()
        'Cancela la transaccion
        If Not (tran Is Nothing) Then
            tran.Rollback()
            tran.Dispose()
            tran = Nothing
        End If
    End Sub

#End Region


   
  
End Class