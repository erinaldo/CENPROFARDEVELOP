<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagodeGastos_Recepciones
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarElItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarDescripcionToolStripMenuItem = New System.Windows.Forms.ToolStripComboBox
        Me.txtID = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabChequesPropios = New System.Windows.Forms.TabPage
        Me.txtPropietario = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX
        Me.cmbMoneda = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem5 = New DevComponents.Editors.ComboItem
        Me.ComboItem6 = New DevComponents.Editors.ComboItem
        Me.btnModificarCheque = New DevComponents.DotNetBar.ButtonX
        Me.txtObservacionesCheque = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.btnNuevoCheque = New DevComponents.DotNetBar.ButtonX
        Me.txtMontoCheque = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.txtNroCheque = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX
        Me.btnAgregarCheque = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminarCheque = New DevComponents.DotNetBar.ButtonX
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX
        Me.dtpFechaCheque = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX
        Me.cmbBanco = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem3 = New DevComponents.Editors.ComboItem
        Me.ComboItem4 = New DevComponents.Editors.ComboItem
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX
        Me.grdChequesPropios = New System.Windows.Forms.DataGridView
        Me.NroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaVenc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Propietario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdTipoMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdCheque = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Utilizado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabCheques = New System.Windows.Forms.TabPage
        Me.grdCheques = New System.Windows.Forms.DataGridView
        Me.TabTransferencias = New System.Windows.Forms.TabPage
        Me.btnModificarTransf = New DevComponents.DotNetBar.ButtonX
        Me.txtObservacionesTransf = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX
        Me.btnNuevoTransferencia = New DevComponents.DotNetBar.ButtonX
        Me.cmbCuentaDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem17 = New DevComponents.Editors.ComboItem
        Me.ComboItem18 = New DevComponents.Editors.ComboItem
        Me.cmbCuentaOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem13 = New DevComponents.Editors.ComboItem
        Me.ComboItem14 = New DevComponents.Editors.ComboItem
        Me.txtNroOpCliente = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX
        Me.cmbBancoOrigen = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem11 = New DevComponents.Editors.ComboItem
        Me.ComboItem12 = New DevComponents.Editors.ComboItem
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX
        Me.txtMontoTransf = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX
        Me.cmbMonedaTransf = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem7 = New DevComponents.Editors.ComboItem
        Me.ComboItem8 = New DevComponents.Editors.ComboItem
        Me.btnAgregarTransf = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminarTransf = New DevComponents.DotNetBar.ButtonX
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX
        Me.dtpFechaTransf = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX
        Me.cmbBancoDestino = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem9 = New DevComponents.Editors.ComboItem
        Me.ComboItem10 = New DevComponents.Editors.ComboItem
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX
        Me.grdTransferencias = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BancoDestino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ObservacionesTransf = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabTarjetas = New System.Windows.Forms.TabPage
        Me.btnModificarTarjeta = New DevComponents.DotNetBar.ButtonX
        Me.btnNuevoTarjeta = New DevComponents.DotNetBar.ButtonX
        Me.FormattedTextBoxVB2 = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX
        Me.FormattedTextBoxVB1 = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.btnAgregarTarjeta = New DevComponents.DotNetBar.ButtonX
        Me.btnEliminarTarjeta = New DevComponents.DotNetBar.ButtonX
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX
        Me.ComboBoxEx2 = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem15 = New DevComponents.Editors.ComboItem
        Me.ComboItem16 = New DevComponents.Editors.ComboItem
        Me.grdTarjetas = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabNC = New System.Windows.Forms.TabPage
        Me.FormattedTextBoxVB3 = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX
        Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX
        Me.cmbNC = New DevComponents.DotNetBar.Controls.ComboBoxEx
        Me.ComboItem19 = New DevComponents.Editors.ComboItem
        Me.ComboItem20 = New DevComponents.Editors.ComboItem
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gpPago = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtRedondeo = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.lblResto = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lblEntregaTransferencias = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblEntregaTarjetas = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblEntregaChequesPropios = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMontoIva = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTotalaPagar = New System.Windows.Forms.Label
        Me.lblMontoSinIVA = New System.Windows.Forms.Label
        Me.lblMontoIVA = New System.Windows.Forms.Label
        Me.chkAplicarIvaParcial = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTotalaPagarSinIva = New System.Windows.Forms.Label
        Me.txtEntregaContado = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.lblEntregaCheques = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEntregado = New System.Windows.Forms.Label
        Me.txtIdGasto = New TextBoxConFormatoVB.FormattedTextBoxVB
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabChequesPropios.SuspendLayout()
        CType(Me.dtpFechaCheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdChequesPropios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCheques.SuspendLayout()
        CType(Me.grdCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTransferencias.SuspendLayout()
        CType(Me.dtpFechaTransf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTarjetas.SuspendLayout()
        CType(Me.grdTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabNC.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarElItemToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.BuscarDescripcionToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(361, 73)
        '
        'BorrarElItemToolStripMenuItem
        '
        Me.BorrarElItemToolStripMenuItem.Name = "BorrarElItemToolStripMenuItem"
        Me.BorrarElItemToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.BorrarElItemToolStripMenuItem.Text = "Borrar el Item"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(360, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar..."
        Me.BuscarToolStripMenuItem.Visible = False
        '
        'BuscarDescripcionToolStripMenuItem
        '
        Me.BuscarDescripcionToolStripMenuItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BuscarDescripcionToolStripMenuItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BuscarDescripcionToolStripMenuItem.DropDownWidth = 500
        Me.BuscarDescripcionToolStripMenuItem.Name = "BuscarDescripcionToolStripMenuItem"
        Me.BuscarDescripcionToolStripMenuItem.Size = New System.Drawing.Size(300, 21)
        Me.BuscarDescripcionToolStripMenuItem.Sorted = True
        Me.BuscarDescripcionToolStripMenuItem.Text = "Buscar Descripcion"
        '
        'txtID
        '
        Me.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtID.Decimals = CType(2, Byte)
        Me.txtID.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtID.Enabled = False
        Me.txtID.Format = TextBoxConFormatoVB.tbFormats.UnsignedNumber
        Me.txtID.Location = New System.Drawing.Point(33, 27)
        Me.txtID.MaxLength = 8
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(71, 20)
        Me.txtID.TabIndex = 50
        Me.txtID.Text_1 = Nothing
        Me.txtID.Text_2 = Nothing
        Me.txtID.Text_3 = Nothing
        Me.txtID.Text_4 = Nothing
        Me.txtID.UserValues = Nothing
        Me.txtID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.gpPago)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 376)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Decimals = CType(2, Byte)
        Me.txtCodigo.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Format = TextBoxConFormatoVB.tbFormats.UnsignedNumber
        Me.txtCodigo.Location = New System.Drawing.Point(224, 63)
        Me.txtCodigo.MaxLength = 8
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(23, 20)
        Me.txtCodigo.TabIndex = 188
        Me.txtCodigo.Text_1 = Nothing
        Me.txtCodigo.Text_2 = Nothing
        Me.txtCodigo.Text_3 = Nothing
        Me.txtCodigo.Text_4 = Nothing
        Me.txtCodigo.UserValues = Nothing
        Me.txtCodigo.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabChequesPropios)
        Me.TabControl1.Controls.Add(Me.TabCheques)
        Me.TabControl1.Controls.Add(Me.TabTransferencias)
        Me.TabControl1.Controls.Add(Me.TabTarjetas)
        Me.TabControl1.Controls.Add(Me.TabNC)
        Me.TabControl1.Location = New System.Drawing.Point(243, 18)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(429, 348)
        Me.TabControl1.TabIndex = 0
        '
        'TabChequesPropios
        '
        Me.TabChequesPropios.Controls.Add(Me.txtPropietario)
        Me.TabChequesPropios.Controls.Add(Me.LabelX5)
        Me.TabChequesPropios.Controls.Add(Me.LabelX6)
        Me.TabChequesPropios.Controls.Add(Me.cmbMoneda)
        Me.TabChequesPropios.Controls.Add(Me.btnModificarCheque)
        Me.TabChequesPropios.Controls.Add(Me.txtObservacionesCheque)
        Me.TabChequesPropios.Controls.Add(Me.btnNuevoCheque)
        Me.TabChequesPropios.Controls.Add(Me.txtMontoCheque)
        Me.TabChequesPropios.Controls.Add(Me.txtNroCheque)
        Me.TabChequesPropios.Controls.Add(Me.LabelX7)
        Me.TabChequesPropios.Controls.Add(Me.btnAgregarCheque)
        Me.TabChequesPropios.Controls.Add(Me.btnEliminarCheque)
        Me.TabChequesPropios.Controls.Add(Me.LabelX4)
        Me.TabChequesPropios.Controls.Add(Me.dtpFechaCheque)
        Me.TabChequesPropios.Controls.Add(Me.LabelX3)
        Me.TabChequesPropios.Controls.Add(Me.LabelX2)
        Me.TabChequesPropios.Controls.Add(Me.cmbBanco)
        Me.TabChequesPropios.Controls.Add(Me.LabelX1)
        Me.TabChequesPropios.Controls.Add(Me.grdChequesPropios)
        Me.TabChequesPropios.Location = New System.Drawing.Point(4, 22)
        Me.TabChequesPropios.Name = "TabChequesPropios"
        Me.TabChequesPropios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabChequesPropios.Size = New System.Drawing.Size(421, 322)
        Me.TabChequesPropios.TabIndex = 0
        Me.TabChequesPropios.Text = "Cheques Propios"
        Me.TabChequesPropios.UseVisualStyleBackColor = True
        '
        'txtPropietario
        '
        Me.txtPropietario.Decimals = CType(2, Byte)
        Me.txtPropietario.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.Format = TextBoxConFormatoVB.tbFormats.SpacedAlphaNumeric
        Me.txtPropietario.Location = New System.Drawing.Point(95, 237)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.ReadOnly = True
        Me.txtPropietario.Size = New System.Drawing.Size(168, 20)
        Me.txtPropietario.TabIndex = 170
        Me.txtPropietario.Text_1 = Nothing
        Me.txtPropietario.Text_2 = Nothing
        Me.txtPropietario.Text_3 = Nothing
        Me.txtPropietario.Text_4 = Nothing
        Me.txtPropietario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPropietario.UserValues = Nothing
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.Transparent
        Me.LabelX5.Location = New System.Drawing.Point(95, 220)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX5.Size = New System.Drawing.Size(97, 15)
        Me.LabelX5.TabIndex = 171
        Me.LabelX5.Text = "Propietario Cheque"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.Transparent
        Me.LabelX6.Location = New System.Drawing.Point(248, 94)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX6.Size = New System.Drawing.Size(42, 15)
        Me.LabelX6.TabIndex = 169
        Me.LabelX6.Text = "Moneda"
        Me.LabelX6.Visible = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMoneda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMoneda.DisplayMember = "Text"
        Me.cmbMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.ItemHeight = 14
        Me.cmbMoneda.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6})
        Me.cmbMoneda.Location = New System.Drawing.Point(248, 112)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(73, 20)
        Me.cmbMoneda.TabIndex = 168
        Me.cmbMoneda.Visible = False
        '
        'ComboItem5
        '
        Me.ComboItem5.Text = "Mensual"
        '
        'ComboItem6
        '
        Me.ComboItem6.Text = "Quincenal"
        '
        'btnModificarCheque
        '
        Me.btnModificarCheque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificarCheque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModificarCheque.Location = New System.Drawing.Point(230, 291)
        Me.btnModificarCheque.Name = "btnModificarCheque"
        Me.btnModificarCheque.Size = New System.Drawing.Size(55, 23)
        Me.btnModificarCheque.TabIndex = 159
        Me.btnModificarCheque.Text = "Modificar"
        '
        'txtObservacionesCheque
        '
        Me.txtObservacionesCheque.Decimals = CType(2, Byte)
        Me.txtObservacionesCheque.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtObservacionesCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesCheque.Format = TextBoxConFormatoVB.tbFormats.SpacedAlphaNumeric
        Me.txtObservacionesCheque.Location = New System.Drawing.Point(88, 264)
        Me.txtObservacionesCheque.Name = "txtObservacionesCheque"
        Me.txtObservacionesCheque.Size = New System.Drawing.Size(299, 20)
        Me.txtObservacionesCheque.TabIndex = 156
        Me.txtObservacionesCheque.Text_1 = Nothing
        Me.txtObservacionesCheque.Text_2 = Nothing
        Me.txtObservacionesCheque.Text_3 = Nothing
        Me.txtObservacionesCheque.Text_4 = Nothing
        Me.txtObservacionesCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtObservacionesCheque.UserValues = Nothing
        '
        'btnNuevoCheque
        '
        Me.btnNuevoCheque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoCheque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevoCheque.Location = New System.Drawing.Point(108, 291)
        Me.btnNuevoCheque.Name = "btnNuevoCheque"
        Me.btnNuevoCheque.Size = New System.Drawing.Size(55, 23)
        Me.btnNuevoCheque.TabIndex = 157
        Me.btnNuevoCheque.Text = "Nuevo"
        '
        'txtMontoCheque
        '
        Me.txtMontoCheque.Decimals = CType(2, Byte)
        Me.txtMontoCheque.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtMontoCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCheque.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtMontoCheque.Location = New System.Drawing.Point(275, 237)
        Me.txtMontoCheque.Name = "txtMontoCheque"
        Me.txtMontoCheque.Size = New System.Drawing.Size(71, 20)
        Me.txtMontoCheque.TabIndex = 155
        Me.txtMontoCheque.Text_1 = Nothing
        Me.txtMontoCheque.Text_2 = Nothing
        Me.txtMontoCheque.Text_3 = Nothing
        Me.txtMontoCheque.Text_4 = Nothing
        Me.txtMontoCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoCheque.UserValues = Nothing
        '
        'txtNroCheque
        '
        Me.txtNroCheque.Decimals = CType(2, Byte)
        Me.txtNroCheque.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtNroCheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroCheque.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtNroCheque.Location = New System.Drawing.Point(6, 194)
        Me.txtNroCheque.Name = "txtNroCheque"
        Me.txtNroCheque.Size = New System.Drawing.Size(140, 20)
        Me.txtNroCheque.TabIndex = 151
        Me.txtNroCheque.Text_1 = Nothing
        Me.txtNroCheque.Text_2 = Nothing
        Me.txtNroCheque.Text_3 = Nothing
        Me.txtNroCheque.Text_4 = Nothing
        Me.txtNroCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNroCheque.UserValues = Nothing
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        Me.LabelX7.BackColor = System.Drawing.Color.Transparent
        Me.LabelX7.Location = New System.Drawing.Point(6, 267)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX7.Size = New System.Drawing.Size(76, 15)
        Me.LabelX7.TabIndex = 167
        Me.LabelX7.Text = "Observaciones"
        '
        'btnAgregarCheque
        '
        Me.btnAgregarCheque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarCheque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAgregarCheque.Location = New System.Drawing.Point(169, 291)
        Me.btnAgregarCheque.Name = "btnAgregarCheque"
        Me.btnAgregarCheque.Size = New System.Drawing.Size(55, 23)
        Me.btnAgregarCheque.TabIndex = 158
        Me.btnAgregarCheque.Text = "Guardar"
        '
        'btnEliminarCheque
        '
        Me.btnEliminarCheque.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminarCheque.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminarCheque.Location = New System.Drawing.Point(291, 291)
        Me.btnEliminarCheque.Name = "btnEliminarCheque"
        Me.btnEliminarCheque.Size = New System.Drawing.Size(55, 23)
        Me.btnEliminarCheque.TabIndex = 160
        Me.btnEliminarCheque.Text = "Eliminar"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        Me.LabelX4.Location = New System.Drawing.Point(275, 219)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX4.Size = New System.Drawing.Size(37, 15)
        Me.LabelX4.TabIndex = 165
        Me.LabelX4.Text = "Monto*"
        '
        'dtpFechaCheque
        '
        '
        '
        '
        Me.dtpFechaCheque.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFechaCheque.ButtonDropDown.Visible = True
        Me.dtpFechaCheque.Location = New System.Drawing.Point(6, 237)
        '
        '
        '
        Me.dtpFechaCheque.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaCheque.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaCheque.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFechaCheque.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFechaCheque.MonthCalendar.DisplayMonth = New Date(2011, 8, 1, 0, 0, 0, 0)
        Me.dtpFechaCheque.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFechaCheque.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFechaCheque.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFechaCheque.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFechaCheque.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFechaCheque.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFechaCheque.MonthCalendar.TodayButtonVisible = True
        Me.dtpFechaCheque.Name = "dtpFechaCheque"
        Me.dtpFechaCheque.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaCheque.TabIndex = 153
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        Me.LabelX3.Location = New System.Drawing.Point(6, 220)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX3.Size = New System.Drawing.Size(64, 15)
        Me.LabelX3.TabIndex = 164
        Me.LabelX3.Text = "Fecha Venc."
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        Me.LabelX2.Location = New System.Drawing.Point(152, 176)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(38, 15)
        Me.LabelX2.TabIndex = 163
        Me.LabelX2.Text = "Banco*"
        '
        'cmbBanco
        '
        Me.cmbBanco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBanco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBanco.DisplayMember = "Text"
        Me.cmbBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.ItemHeight = 14
        Me.cmbBanco.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
        Me.cmbBanco.Location = New System.Drawing.Point(152, 194)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(194, 20)
        Me.cmbBanco.TabIndex = 152
        '
        'ComboItem3
        '
        Me.ComboItem3.Text = "Mensual"
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Quincenal"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        Me.LabelX1.Location = New System.Drawing.Point(6, 176)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(81, 15)
        Me.LabelX1.TabIndex = 162
        Me.LabelX1.Text = "Nro de Cheque*"
        '
        'grdChequesPropios
        '
        Me.grdChequesPropios.AllowUserToAddRows = False
        Me.grdChequesPropios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdChequesPropios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdChequesPropios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdChequesPropios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCheque, Me.Banco, Me.Monto, Me.FechaVenc, Me.Propietario, Me.IdTipoMoneda, Me.Observaciones, Me.IdCheque, Me.Utilizado})
        Me.grdChequesPropios.Location = New System.Drawing.Point(6, 6)
        Me.grdChequesPropios.Name = "grdChequesPropios"
        Me.grdChequesPropios.ReadOnly = True
        Me.grdChequesPropios.Size = New System.Drawing.Size(340, 164)
        Me.grdChequesPropios.TabIndex = 161
        '
        'NroCheque
        '
        Me.NroCheque.HeaderText = "NroCheque"
        Me.NroCheque.Name = "NroCheque"
        Me.NroCheque.ReadOnly = True
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        Me.Banco.ReadOnly = True
        Me.Banco.Width = 110
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        Me.Monto.Width = 75
        '
        'FechaVenc
        '
        Me.FechaVenc.HeaderText = "FechaVenc"
        Me.FechaVenc.Name = "FechaVenc"
        Me.FechaVenc.ReadOnly = True
        Me.FechaVenc.Visible = False
        '
        'Propietario
        '
        Me.Propietario.HeaderText = "Propietario"
        Me.Propietario.Name = "Propietario"
        Me.Propietario.ReadOnly = True
        Me.Propietario.Visible = False
        '
        'IdTipoMoneda
        '
        Me.IdTipoMoneda.HeaderText = "IdtipoMoneda"
        Me.IdTipoMoneda.Name = "IdTipoMoneda"
        Me.IdTipoMoneda.ReadOnly = True
        Me.IdTipoMoneda.Visible = False
        '
        'Observaciones
        '
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Visible = False
        '
        'IdCheque
        '
        Me.IdCheque.HeaderText = "IdCheque"
        Me.IdCheque.Name = "IdCheque"
        Me.IdCheque.ReadOnly = True
        Me.IdCheque.Visible = False
        '
        'Utilizado
        '
        Me.Utilizado.HeaderText = "Utilizado"
        Me.Utilizado.Name = "Utilizado"
        Me.Utilizado.ReadOnly = True
        Me.Utilizado.Visible = False
        '
        'TabCheques
        '
        Me.TabCheques.Controls.Add(Me.grdCheques)
        Me.TabCheques.Location = New System.Drawing.Point(4, 22)
        Me.TabCheques.Name = "TabCheques"
        Me.TabCheques.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCheques.Size = New System.Drawing.Size(421, 322)
        Me.TabCheques.TabIndex = 1
        Me.TabCheques.Text = "Cheques Terceros"
        Me.TabCheques.UseVisualStyleBackColor = True
        '
        'grdCheques
        '
        Me.grdCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCheques.Location = New System.Drawing.Point(9, 6)
        Me.grdCheques.Name = "grdCheques"
        Me.grdCheques.Size = New System.Drawing.Size(406, 310)
        Me.grdCheques.TabIndex = 12
        '
        'TabTransferencias
        '
        Me.TabTransferencias.Controls.Add(Me.btnModificarTransf)
        Me.TabTransferencias.Controls.Add(Me.txtObservacionesTransf)
        Me.TabTransferencias.Controls.Add(Me.LabelX22)
        Me.TabTransferencias.Controls.Add(Me.btnNuevoTransferencia)
        Me.TabTransferencias.Controls.Add(Me.cmbCuentaDestino)
        Me.TabTransferencias.Controls.Add(Me.cmbCuentaOrigen)
        Me.TabTransferencias.Controls.Add(Me.txtNroOpCliente)
        Me.TabTransferencias.Controls.Add(Me.LabelX21)
        Me.TabTransferencias.Controls.Add(Me.LabelX15)
        Me.TabTransferencias.Controls.Add(Me.cmbBancoOrigen)
        Me.TabTransferencias.Controls.Add(Me.LabelX11)
        Me.TabTransferencias.Controls.Add(Me.txtMontoTransf)
        Me.TabTransferencias.Controls.Add(Me.LabelX14)
        Me.TabTransferencias.Controls.Add(Me.cmbMonedaTransf)
        Me.TabTransferencias.Controls.Add(Me.btnAgregarTransf)
        Me.TabTransferencias.Controls.Add(Me.btnEliminarTransf)
        Me.TabTransferencias.Controls.Add(Me.LabelX16)
        Me.TabTransferencias.Controls.Add(Me.dtpFechaTransf)
        Me.TabTransferencias.Controls.Add(Me.LabelX17)
        Me.TabTransferencias.Controls.Add(Me.LabelX18)
        Me.TabTransferencias.Controls.Add(Me.cmbBancoDestino)
        Me.TabTransferencias.Controls.Add(Me.LabelX19)
        Me.TabTransferencias.Controls.Add(Me.grdTransferencias)
        Me.TabTransferencias.Location = New System.Drawing.Point(4, 22)
        Me.TabTransferencias.Name = "TabTransferencias"
        Me.TabTransferencias.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTransferencias.Size = New System.Drawing.Size(421, 322)
        Me.TabTransferencias.TabIndex = 2
        Me.TabTransferencias.Text = "Transferencias"
        Me.TabTransferencias.UseVisualStyleBackColor = True
        '
        'btnModificarTransf
        '
        Me.btnModificarTransf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificarTransf.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModificarTransf.Location = New System.Drawing.Point(233, 293)
        Me.btnModificarTransf.Name = "btnModificarTransf"
        Me.btnModificarTransf.Size = New System.Drawing.Size(55, 23)
        Me.btnModificarTransf.TabIndex = 11
        Me.btnModificarTransf.Text = "Modificar"
        '
        'txtObservacionesTransf
        '
        Me.txtObservacionesTransf.Decimals = CType(2, Byte)
        Me.txtObservacionesTransf.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtObservacionesTransf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesTransf.Format = TextBoxConFormatoVB.tbFormats.SpacedAlphaNumeric
        Me.txtObservacionesTransf.Location = New System.Drawing.Point(91, 266)
        Me.txtObservacionesTransf.Name = "txtObservacionesTransf"
        Me.txtObservacionesTransf.Size = New System.Drawing.Size(258, 20)
        Me.txtObservacionesTransf.TabIndex = 8
        Me.txtObservacionesTransf.Text_1 = Nothing
        Me.txtObservacionesTransf.Text_2 = Nothing
        Me.txtObservacionesTransf.Text_3 = Nothing
        Me.txtObservacionesTransf.Text_4 = Nothing
        Me.txtObservacionesTransf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtObservacionesTransf.UserValues = Nothing
        '
        'LabelX22
        '
        Me.LabelX22.AutoSize = True
        Me.LabelX22.BackColor = System.Drawing.Color.Transparent
        Me.LabelX22.Location = New System.Drawing.Point(9, 269)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX22.Size = New System.Drawing.Size(76, 15)
        Me.LabelX22.TabIndex = 174
        Me.LabelX22.Text = "Observaciones"
        '
        'btnNuevoTransferencia
        '
        Me.btnNuevoTransferencia.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoTransferencia.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevoTransferencia.Location = New System.Drawing.Point(111, 293)
        Me.btnNuevoTransferencia.Name = "btnNuevoTransferencia"
        Me.btnNuevoTransferencia.Size = New System.Drawing.Size(55, 23)
        Me.btnNuevoTransferencia.TabIndex = 9
        Me.btnNuevoTransferencia.Text = "Nuevo"
        '
        'cmbCuentaDestino
        '
        Me.cmbCuentaDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaDestino.DisplayMember = "Text"
        Me.cmbCuentaDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCuentaDestino.FormattingEnabled = True
        Me.cmbCuentaDestino.ItemHeight = 14
        Me.cmbCuentaDestino.Items.AddRange(New Object() {Me.ComboItem17, Me.ComboItem18})
        Me.cmbCuentaDestino.Location = New System.Drawing.Point(142, 154)
        Me.cmbCuentaDestino.Name = "cmbCuentaDestino"
        Me.cmbCuentaDestino.Size = New System.Drawing.Size(128, 20)
        Me.cmbCuentaDestino.TabIndex = 1
        '
        'ComboItem17
        '
        Me.ComboItem17.Text = "Mensual"
        '
        'ComboItem18
        '
        Me.ComboItem18.Text = "Quincenal"
        '
        'cmbCuentaOrigen
        '
        Me.cmbCuentaOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCuentaOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCuentaOrigen.DisplayMember = "Text"
        Me.cmbCuentaOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCuentaOrigen.FormattingEnabled = True
        Me.cmbCuentaOrigen.ItemHeight = 14
        Me.cmbCuentaOrigen.Items.AddRange(New Object() {Me.ComboItem13, Me.ComboItem14})
        Me.cmbCuentaOrigen.Location = New System.Drawing.Point(8, 154)
        Me.cmbCuentaOrigen.Name = "cmbCuentaOrigen"
        Me.cmbCuentaOrigen.Size = New System.Drawing.Size(128, 20)
        Me.cmbCuentaOrigen.TabIndex = 0
        '
        'ComboItem13
        '
        Me.ComboItem13.Text = "Mensual"
        '
        'ComboItem14
        '
        Me.ComboItem14.Text = "Quincenal"
        '
        'txtNroOpCliente
        '
        Me.txtNroOpCliente.Decimals = CType(2, Byte)
        Me.txtNroOpCliente.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtNroOpCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroOpCliente.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtNroOpCliente.Location = New System.Drawing.Point(9, 236)
        Me.txtNroOpCliente.Name = "txtNroOpCliente"
        Me.txtNroOpCliente.Size = New System.Drawing.Size(115, 20)
        Me.txtNroOpCliente.TabIndex = 5
        Me.txtNroOpCliente.Text_1 = Nothing
        Me.txtNroOpCliente.Text_2 = Nothing
        Me.txtNroOpCliente.Text_3 = Nothing
        Me.txtNroOpCliente.Text_4 = Nothing
        Me.txtNroOpCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNroOpCliente.UserValues = Nothing
        '
        'LabelX21
        '
        Me.LabelX21.AutoSize = True
        Me.LabelX21.BackColor = System.Drawing.Color.Transparent
        Me.LabelX21.Location = New System.Drawing.Point(9, 219)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX21.Size = New System.Drawing.Size(74, 15)
        Me.LabelX21.TabIndex = 172
        Me.LabelX21.Text = "Nro Operaci�n"
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        Me.LabelX15.BackColor = System.Drawing.Color.Transparent
        Me.LabelX15.Location = New System.Drawing.Point(9, 176)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX15.Size = New System.Drawing.Size(70, 15)
        Me.LabelX15.TabIndex = 170
        Me.LabelX15.Text = "Banco Origen"
        '
        'cmbBancoOrigen
        '
        Me.cmbBancoOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBancoOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBancoOrigen.DisplayMember = "Text"
        Me.cmbBancoOrigen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBancoOrigen.FormattingEnabled = True
        Me.cmbBancoOrigen.ItemHeight = 14
        Me.cmbBancoOrigen.Items.AddRange(New Object() {Me.ComboItem11, Me.ComboItem12})
        Me.cmbBancoOrigen.Location = New System.Drawing.Point(9, 193)
        Me.cmbBancoOrigen.Name = "cmbBancoOrigen"
        Me.cmbBancoOrigen.Size = New System.Drawing.Size(165, 20)
        Me.cmbBancoOrigen.TabIndex = 3
        '
        'ComboItem11
        '
        Me.ComboItem11.Text = "Mensual"
        '
        'ComboItem12
        '
        Me.ComboItem12.Text = "Quincenal"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        Me.LabelX11.BackColor = System.Drawing.Color.Transparent
        Me.LabelX11.Location = New System.Drawing.Point(142, 137)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX11.Size = New System.Drawing.Size(78, 15)
        Me.LabelX11.TabIndex = 168
        Me.LabelX11.Text = "Cuenta Destino"
        '
        'txtMontoTransf
        '
        Me.txtMontoTransf.Decimals = CType(2, Byte)
        Me.txtMontoTransf.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtMontoTransf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTransf.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtMontoTransf.Location = New System.Drawing.Point(219, 236)
        Me.txtMontoTransf.Name = "txtMontoTransf"
        Me.txtMontoTransf.Size = New System.Drawing.Size(62, 20)
        Me.txtMontoTransf.TabIndex = 7
        Me.txtMontoTransf.Text_1 = Nothing
        Me.txtMontoTransf.Text_2 = Nothing
        Me.txtMontoTransf.Text_3 = Nothing
        Me.txtMontoTransf.Text_4 = Nothing
        Me.txtMontoTransf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoTransf.UserValues = Nothing
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        Me.LabelX14.BackColor = System.Drawing.Color.Transparent
        Me.LabelX14.Location = New System.Drawing.Point(276, 137)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX14.Size = New System.Drawing.Size(42, 15)
        Me.LabelX14.TabIndex = 166
        Me.LabelX14.Text = "Moneda"
        Me.LabelX14.Visible = False
        '
        'cmbMonedaTransf
        '
        Me.cmbMonedaTransf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMonedaTransf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonedaTransf.DisplayMember = "Text"
        Me.cmbMonedaTransf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonedaTransf.FormattingEnabled = True
        Me.cmbMonedaTransf.ItemHeight = 14
        Me.cmbMonedaTransf.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8})
        Me.cmbMonedaTransf.Location = New System.Drawing.Point(276, 154)
        Me.cmbMonedaTransf.Name = "cmbMonedaTransf"
        Me.cmbMonedaTransf.Size = New System.Drawing.Size(73, 20)
        Me.cmbMonedaTransf.TabIndex = 2
        Me.cmbMonedaTransf.Visible = False
        '
        'ComboItem7
        '
        Me.ComboItem7.Text = "Mensual"
        '
        'ComboItem8
        '
        Me.ComboItem8.Text = "Quincenal"
        '
        'btnAgregarTransf
        '
        Me.btnAgregarTransf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarTransf.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAgregarTransf.Location = New System.Drawing.Point(172, 293)
        Me.btnAgregarTransf.Name = "btnAgregarTransf"
        Me.btnAgregarTransf.Size = New System.Drawing.Size(55, 23)
        Me.btnAgregarTransf.TabIndex = 10
        Me.btnAgregarTransf.Text = "Guardar"
        '
        'btnEliminarTransf
        '
        Me.btnEliminarTransf.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminarTransf.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminarTransf.Location = New System.Drawing.Point(294, 293)
        Me.btnEliminarTransf.Name = "btnEliminarTransf"
        Me.btnEliminarTransf.Size = New System.Drawing.Size(55, 23)
        Me.btnEliminarTransf.TabIndex = 12
        Me.btnEliminarTransf.Text = "Eliminar"
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        Me.LabelX16.BackColor = System.Drawing.Color.Transparent
        Me.LabelX16.Location = New System.Drawing.Point(219, 219)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX16.Size = New System.Drawing.Size(37, 15)
        Me.LabelX16.TabIndex = 164
        Me.LabelX16.Text = "Monto*"
        '
        'dtpFechaTransf
        '
        '
        '
        '
        Me.dtpFechaTransf.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFechaTransf.ButtonDropDown.Visible = True
        Me.dtpFechaTransf.Location = New System.Drawing.Point(130, 236)
        '
        '
        '
        Me.dtpFechaTransf.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        Me.dtpFechaTransf.MonthCalendar.DisplayMonth = New Date(2013, 5, 1, 0, 0, 0, 0)
        Me.dtpFechaTransf.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtpFechaTransf.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFechaTransf.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        Me.dtpFechaTransf.Name = "dtpFechaTransf"
        Me.dtpFechaTransf.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaTransf.TabIndex = 6
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        Me.LabelX17.BackColor = System.Drawing.Color.Transparent
        Me.LabelX17.Location = New System.Drawing.Point(130, 219)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX17.Size = New System.Drawing.Size(70, 15)
        Me.LabelX17.TabIndex = 163
        Me.LabelX17.Text = "Fecha Transf."
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        Me.LabelX18.BackColor = System.Drawing.Color.Transparent
        Me.LabelX18.Location = New System.Drawing.Point(184, 176)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX18.Size = New System.Drawing.Size(74, 15)
        Me.LabelX18.TabIndex = 162
        Me.LabelX18.Text = "Banco Destino"
        '
        'cmbBancoDestino
        '
        Me.cmbBancoDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbBancoDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBancoDestino.DisplayMember = "Text"
        Me.cmbBancoDestino.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbBancoDestino.FormattingEnabled = True
        Me.cmbBancoDestino.ItemHeight = 14
        Me.cmbBancoDestino.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
        Me.cmbBancoDestino.Location = New System.Drawing.Point(184, 193)
        Me.cmbBancoDestino.Name = "cmbBancoDestino"
        Me.cmbBancoDestino.Size = New System.Drawing.Size(165, 20)
        Me.cmbBancoDestino.TabIndex = 4
        '
        'ComboItem9
        '
        Me.ComboItem9.Text = "Mensual"
        '
        'ComboItem10
        '
        Me.ComboItem10.Text = "Quincenal"
        '
        'LabelX19
        '
        Me.LabelX19.AutoSize = True
        Me.LabelX19.BackColor = System.Drawing.Color.Transparent
        Me.LabelX19.Location = New System.Drawing.Point(9, 137)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX19.Size = New System.Drawing.Size(74, 15)
        Me.LabelX19.TabIndex = 161
        Me.LabelX19.Text = "Cuenta Origen"
        '
        'grdTransferencias
        '
        Me.grdTransferencias.AllowUserToAddRows = False
        Me.grdTransferencias.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTransferencias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTransferencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.BancoDestino, Me.ObservacionesTransf, Me.ID})
        Me.grdTransferencias.Location = New System.Drawing.Point(9, 8)
        Me.grdTransferencias.Name = "grdTransferencias"
        Me.grdTransferencias.ReadOnly = True
        Me.grdTransferencias.Size = New System.Drawing.Size(340, 125)
        Me.grdTransferencias.TabIndex = 151
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "NroOpCliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "CuentaOrigen"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 160
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "CuentaDestino"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaTransf"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "IdtipoMoneda"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "BancoOrigen"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 85
        '
        'BancoDestino
        '
        Me.BancoDestino.HeaderText = "BancoDestino"
        Me.BancoDestino.Name = "BancoDestino"
        Me.BancoDestino.ReadOnly = True
        Me.BancoDestino.Width = 90
        '
        'ObservacionesTransf
        '
        Me.ObservacionesTransf.HeaderText = "Observaciones"
        Me.ObservacionesTransf.Name = "ObservacionesTransf"
        Me.ObservacionesTransf.ReadOnly = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'TabTarjetas
        '
        Me.TabTarjetas.Controls.Add(Me.btnModificarTarjeta)
        Me.TabTarjetas.Controls.Add(Me.btnNuevoTarjeta)
        Me.TabTarjetas.Controls.Add(Me.FormattedTextBoxVB2)
        Me.TabTarjetas.Controls.Add(Me.LabelX20)
        Me.TabTarjetas.Controls.Add(Me.FormattedTextBoxVB1)
        Me.TabTarjetas.Controls.Add(Me.btnAgregarTarjeta)
        Me.TabTarjetas.Controls.Add(Me.btnEliminarTarjeta)
        Me.TabTarjetas.Controls.Add(Me.LabelX23)
        Me.TabTarjetas.Controls.Add(Me.LabelX25)
        Me.TabTarjetas.Controls.Add(Me.ComboBoxEx2)
        Me.TabTarjetas.Controls.Add(Me.grdTarjetas)
        Me.TabTarjetas.Location = New System.Drawing.Point(4, 22)
        Me.TabTarjetas.Name = "TabTarjetas"
        Me.TabTarjetas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTarjetas.Size = New System.Drawing.Size(421, 322)
        Me.TabTarjetas.TabIndex = 3
        Me.TabTarjetas.Text = "Tarjetas"
        Me.TabTarjetas.UseVisualStyleBackColor = True
        '
        'btnModificarTarjeta
        '
        Me.btnModificarTarjeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnModificarTarjeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnModificarTarjeta.Location = New System.Drawing.Point(239, 292)
        Me.btnModificarTarjeta.Name = "btnModificarTarjeta"
        Me.btnModificarTarjeta.Size = New System.Drawing.Size(55, 23)
        Me.btnModificarTarjeta.TabIndex = 167
        Me.btnModificarTarjeta.Text = "Modificar"
        '
        'btnNuevoTarjeta
        '
        Me.btnNuevoTarjeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnNuevoTarjeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnNuevoTarjeta.Location = New System.Drawing.Point(117, 292)
        Me.btnNuevoTarjeta.Name = "btnNuevoTarjeta"
        Me.btnNuevoTarjeta.Size = New System.Drawing.Size(55, 23)
        Me.btnNuevoTarjeta.TabIndex = 3
        Me.btnNuevoTarjeta.Text = "Nuevo"
        '
        'FormattedTextBoxVB2
        '
        Me.FormattedTextBoxVB2.Decimals = CType(2, Byte)
        Me.FormattedTextBoxVB2.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.FormattedTextBoxVB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattedTextBoxVB2.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.FormattedTextBoxVB2.Location = New System.Drawing.Point(189, 266)
        Me.FormattedTextBoxVB2.Name = "FormattedTextBoxVB2"
        Me.FormattedTextBoxVB2.Size = New System.Drawing.Size(60, 20)
        Me.FormattedTextBoxVB2.TabIndex = 1
        Me.FormattedTextBoxVB2.Text_1 = Nothing
        Me.FormattedTextBoxVB2.Text_2 = Nothing
        Me.FormattedTextBoxVB2.Text_3 = Nothing
        Me.FormattedTextBoxVB2.Text_4 = Nothing
        Me.FormattedTextBoxVB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FormattedTextBoxVB2.UserValues = Nothing
        '
        'LabelX20
        '
        Me.LabelX20.AutoSize = True
        Me.LabelX20.BackColor = System.Drawing.Color.Transparent
        Me.LabelX20.Location = New System.Drawing.Point(189, 246)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX20.Size = New System.Drawing.Size(44, 15)
        Me.LabelX20.TabIndex = 166
        Me.LabelX20.Text = "Recargo"
        '
        'FormattedTextBoxVB1
        '
        Me.FormattedTextBoxVB1.Decimals = CType(2, Byte)
        Me.FormattedTextBoxVB1.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.FormattedTextBoxVB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattedTextBoxVB1.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.FormattedTextBoxVB1.Location = New System.Drawing.Point(255, 266)
        Me.FormattedTextBoxVB1.Name = "FormattedTextBoxVB1"
        Me.FormattedTextBoxVB1.Size = New System.Drawing.Size(83, 20)
        Me.FormattedTextBoxVB1.TabIndex = 2
        Me.FormattedTextBoxVB1.Text_1 = Nothing
        Me.FormattedTextBoxVB1.Text_2 = Nothing
        Me.FormattedTextBoxVB1.Text_3 = Nothing
        Me.FormattedTextBoxVB1.Text_4 = Nothing
        Me.FormattedTextBoxVB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FormattedTextBoxVB1.UserValues = Nothing
        '
        'btnAgregarTarjeta
        '
        Me.btnAgregarTarjeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAgregarTarjeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAgregarTarjeta.Location = New System.Drawing.Point(178, 292)
        Me.btnAgregarTarjeta.Name = "btnAgregarTarjeta"
        Me.btnAgregarTarjeta.Size = New System.Drawing.Size(55, 23)
        Me.btnAgregarTarjeta.TabIndex = 159
        Me.btnAgregarTarjeta.Text = "Guardar"
        '
        'btnEliminarTarjeta
        '
        Me.btnEliminarTarjeta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEliminarTarjeta.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEliminarTarjeta.Location = New System.Drawing.Point(300, 292)
        Me.btnEliminarTarjeta.Name = "btnEliminarTarjeta"
        Me.btnEliminarTarjeta.Size = New System.Drawing.Size(55, 23)
        Me.btnEliminarTarjeta.TabIndex = 160
        Me.btnEliminarTarjeta.Text = "Eliminar"
        '
        'LabelX23
        '
        Me.LabelX23.AutoSize = True
        Me.LabelX23.BackColor = System.Drawing.Color.Transparent
        Me.LabelX23.Location = New System.Drawing.Point(255, 246)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX23.Size = New System.Drawing.Size(37, 15)
        Me.LabelX23.TabIndex = 164
        Me.LabelX23.Text = "Monto*"
        '
        'LabelX25
        '
        Me.LabelX25.AutoSize = True
        Me.LabelX25.BackColor = System.Drawing.Color.Transparent
        Me.LabelX25.Location = New System.Drawing.Point(10, 245)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX25.Size = New System.Drawing.Size(41, 15)
        Me.LabelX25.TabIndex = 162
        Me.LabelX25.Text = "Tarjeta*"
        '
        'ComboBoxEx2
        '
        Me.ComboBoxEx2.DisplayMember = "Text"
        Me.ComboBoxEx2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxEx2.FormattingEnabled = True
        Me.ComboBoxEx2.ItemHeight = 14
        Me.ComboBoxEx2.Items.AddRange(New Object() {Me.ComboItem15, Me.ComboItem16})
        Me.ComboBoxEx2.Location = New System.Drawing.Point(10, 266)
        Me.ComboBoxEx2.Name = "ComboBoxEx2"
        Me.ComboBoxEx2.Size = New System.Drawing.Size(173, 20)
        Me.ComboBoxEx2.TabIndex = 0
        '
        'ComboItem15
        '
        Me.ComboItem15.Text = "Mensual"
        '
        'ComboItem16
        '
        Me.ComboItem16.Text = "Quincenal"
        '
        'grdTarjetas
        '
        Me.grdTarjetas.AllowUserToAddRows = False
        Me.grdTarjetas.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTarjetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTarjetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.grdTarjetas.Location = New System.Drawing.Point(9, 8)
        Me.grdTarjetas.Name = "grdTarjetas"
        Me.grdTarjetas.ReadOnly = True
        Me.grdTarjetas.Size = New System.Drawing.Size(340, 231)
        Me.grdTarjetas.TabIndex = 151
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tarjeta"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 120
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Recargo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'TabNC
        '
        Me.TabNC.Controls.Add(Me.FormattedTextBoxVB3)
        Me.TabNC.Controls.Add(Me.LabelX24)
        Me.TabNC.Controls.Add(Me.ButtonX1)
        Me.TabNC.Controls.Add(Me.ButtonX2)
        Me.TabNC.Controls.Add(Me.ButtonX3)
        Me.TabNC.Controls.Add(Me.ButtonX4)
        Me.TabNC.Controls.Add(Me.LabelX8)
        Me.TabNC.Controls.Add(Me.cmbNC)
        Me.TabNC.Controls.Add(Me.DataGridView1)
        Me.TabNC.Location = New System.Drawing.Point(4, 22)
        Me.TabNC.Name = "TabNC"
        Me.TabNC.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNC.Size = New System.Drawing.Size(421, 322)
        Me.TabNC.TabIndex = 4
        Me.TabNC.Text = "Notas Credito"
        Me.TabNC.UseVisualStyleBackColor = True
        '
        'FormattedTextBoxVB3
        '
        Me.FormattedTextBoxVB3.Decimals = CType(2, Byte)
        Me.FormattedTextBoxVB3.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.FormattedTextBoxVB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormattedTextBoxVB3.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.FormattedTextBoxVB3.Location = New System.Drawing.Point(157, 236)
        Me.FormattedTextBoxVB3.Name = "FormattedTextBoxVB3"
        Me.FormattedTextBoxVB3.Size = New System.Drawing.Size(70, 20)
        Me.FormattedTextBoxVB3.TabIndex = 1
        Me.FormattedTextBoxVB3.Text_1 = Nothing
        Me.FormattedTextBoxVB3.Text_2 = Nothing
        Me.FormattedTextBoxVB3.Text_3 = Nothing
        Me.FormattedTextBoxVB3.Text_4 = Nothing
        Me.FormattedTextBoxVB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FormattedTextBoxVB3.UserValues = Nothing
        '
        'LabelX24
        '
        Me.LabelX24.AutoSize = True
        Me.LabelX24.BackColor = System.Drawing.Color.Transparent
        Me.LabelX24.Location = New System.Drawing.Point(157, 219)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX24.Size = New System.Drawing.Size(37, 15)
        Me.LabelX24.TabIndex = 171
        Me.LabelX24.Text = "Monto*"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(231, 292)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(55, 23)
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "Modificar"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(109, 292)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(55, 23)
        Me.ButtonX2.TabIndex = 2
        Me.ButtonX2.Text = "Nuevo"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(170, 292)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(55, 23)
        Me.ButtonX3.TabIndex = 3
        Me.ButtonX3.Text = "Guardar"
        '
        'ButtonX4
        '
        Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX4.Location = New System.Drawing.Point(292, 292)
        Me.ButtonX4.Name = "ButtonX4"
        Me.ButtonX4.Size = New System.Drawing.Size(55, 23)
        Me.ButtonX4.TabIndex = 5
        Me.ButtonX4.Text = "Eliminar"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.Transparent
        Me.LabelX8.Location = New System.Drawing.Point(8, 219)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX8.Size = New System.Drawing.Size(64, 15)
        Me.LabelX8.TabIndex = 169
        Me.LabelX8.Text = "Nota Cr�dito"
        '
        'cmbNC
        '
        Me.cmbNC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbNC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNC.DisplayMember = "Text"
        Me.cmbNC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbNC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNC.FormattingEnabled = True
        Me.cmbNC.ItemHeight = 14
        Me.cmbNC.Items.AddRange(New Object() {Me.ComboItem19, Me.ComboItem20})
        Me.cmbNC.Location = New System.Drawing.Point(8, 236)
        Me.cmbNC.Name = "cmbNC"
        Me.cmbNC.Size = New System.Drawing.Size(143, 20)
        Me.cmbNC.TabIndex = 0
        '
        'ComboItem19
        '
        Me.ComboItem19.Text = "Mensual"
        '
        'ComboItem20
        '
        Me.ComboItem20.Text = "Quincenal"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(340, 202)
        Me.DataGridView1.TabIndex = 167
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nota Cr�dito"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 110
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 75
        '
        'gpPago
        '
        Me.gpPago.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpPago.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpPago.Controls.Add(Me.txtIdGasto)
        Me.gpPago.Controls.Add(Me.txtID)
        Me.gpPago.Controls.Add(Me.Label24)
        Me.gpPago.Controls.Add(Me.Label23)
        Me.gpPago.Controls.Add(Me.Label22)
        Me.gpPago.Controls.Add(Me.Label21)
        Me.gpPago.Controls.Add(Me.txtRedondeo)
        Me.gpPago.Controls.Add(Me.lblResto)
        Me.gpPago.Controls.Add(Me.Label19)
        Me.gpPago.Controls.Add(Me.Label17)
        Me.gpPago.Controls.Add(Me.lblEntregaTransferencias)
        Me.gpPago.Controls.Add(Me.Label16)
        Me.gpPago.Controls.Add(Me.lblEntregaTarjetas)
        Me.gpPago.Controls.Add(Me.Label15)
        Me.gpPago.Controls.Add(Me.lblEntregaChequesPropios)
        Me.gpPago.Controls.Add(Me.Label13)
        Me.gpPago.Controls.Add(Me.Label11)
        Me.gpPago.Controls.Add(Me.txtMontoIva)
        Me.gpPago.Controls.Add(Me.Label8)
        Me.gpPago.Controls.Add(Me.lblTotalaPagar)
        Me.gpPago.Controls.Add(Me.lblMontoSinIVA)
        Me.gpPago.Controls.Add(Me.lblMontoIVA)
        Me.gpPago.Controls.Add(Me.chkAplicarIvaParcial)
        Me.gpPago.Controls.Add(Me.Label10)
        Me.gpPago.Controls.Add(Me.lblTotalaPagarSinIva)
        Me.gpPago.Controls.Add(Me.txtEntregaContado)
        Me.gpPago.Controls.Add(Me.lblEntregaCheques)
        Me.gpPago.Controls.Add(Me.Label6)
        Me.gpPago.Controls.Add(Me.lblEntregado)
        Me.gpPago.Location = New System.Drawing.Point(12, 18)
        Me.gpPago.Name = "gpPago"
        Me.gpPago.Size = New System.Drawing.Size(225, 352)
        '
        '
        '
        Me.gpPago.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpPago.Style.BackColorGradientAngle = 90
        Me.gpPago.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpPago.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPago.Style.BorderBottomWidth = 1
        Me.gpPago.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpPago.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPago.Style.BorderLeftWidth = 1
        Me.gpPago.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPago.Style.BorderRightWidth = 1
        Me.gpPago.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpPago.Style.BorderTopWidth = 1
        Me.gpPago.Style.CornerDiameter = 4
        Me.gpPago.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpPago.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpPago.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.gpPago.TabIndex = 186
        Me.gpPago.Text = "Forma de Pago..."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(117, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 15)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "IVA"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(37, 86)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(107, 15)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Subtotal sin IVA"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(-4, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 31)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Monto Aplica"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label21.Location = New System.Drawing.Point(71, 270)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 15)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Redondeo"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRedondeo
        '
        Me.txtRedondeo.Decimals = CType(2, Byte)
        Me.txtRedondeo.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtRedondeo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRedondeo.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtRedondeo.Location = New System.Drawing.Point(150, 269)
        Me.txtRedondeo.Name = "txtRedondeo"
        Me.txtRedondeo.Size = New System.Drawing.Size(63, 20)
        Me.txtRedondeo.TabIndex = 40
        Me.txtRedondeo.Text = "0"
        Me.txtRedondeo.Text_1 = Nothing
        Me.txtRedondeo.Text_2 = Nothing
        Me.txtRedondeo.Text_3 = Nothing
        Me.txtRedondeo.Text_4 = Nothing
        Me.txtRedondeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRedondeo.UserValues = Nothing
        '
        'lblResto
        '
        Me.lblResto.AutoSize = True
        Me.lblResto.BackColor = System.Drawing.Color.Transparent
        Me.lblResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResto.ForeColor = System.Drawing.Color.Red
        Me.lblResto.Location = New System.Drawing.Point(150, 318)
        Me.lblResto.Name = "lblResto"
        Me.lblResto.Size = New System.Drawing.Size(40, 13)
        Me.lblResto.TabIndex = 39
        Me.lblResto.Text = "Resto"
        Me.lblResto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(104, 318)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Resto"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label17.Location = New System.Drawing.Point(42, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 15)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Transferencias"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEntregaTransferencias
        '
        Me.lblEntregaTransferencias.BackColor = System.Drawing.Color.White
        Me.lblEntregaTransferencias.Enabled = False
        Me.lblEntregaTransferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregaTransferencias.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEntregaTransferencias.Location = New System.Drawing.Point(150, 223)
        Me.lblEntregaTransferencias.Name = "lblEntregaTransferencias"
        Me.lblEntregaTransferencias.Size = New System.Drawing.Size(63, 19)
        Me.lblEntregaTransferencias.TabIndex = 36
        Me.lblEntregaTransferencias.Text = "0"
        Me.lblEntregaTransferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(85, 248)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Tarjetas"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEntregaTarjetas
        '
        Me.lblEntregaTarjetas.BackColor = System.Drawing.Color.White
        Me.lblEntregaTarjetas.Enabled = False
        Me.lblEntregaTarjetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregaTarjetas.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEntregaTarjetas.Location = New System.Drawing.Point(150, 247)
        Me.lblEntregaTarjetas.Name = "lblEntregaTarjetas"
        Me.lblEntregaTarjetas.Size = New System.Drawing.Size(63, 19)
        Me.lblEntregaTarjetas.TabIndex = 34
        Me.lblEntregaTarjetas.Text = "0"
        Me.lblEntregaTarjetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label15.Location = New System.Drawing.Point(28, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Cheques Propios"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEntregaChequesPropios
        '
        Me.lblEntregaChequesPropios.BackColor = System.Drawing.Color.White
        Me.lblEntregaChequesPropios.Enabled = False
        Me.lblEntregaChequesPropios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregaChequesPropios.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEntregaChequesPropios.Location = New System.Drawing.Point(150, 173)
        Me.lblEntregaChequesPropios.Name = "lblEntregaChequesPropios"
        Me.lblEntregaChequesPropios.Size = New System.Drawing.Size(63, 19)
        Me.lblEntregaChequesPropios.TabIndex = 32
        Me.lblEntregaChequesPropios.Text = "0"
        Me.lblEntregaChequesPropios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label13.Location = New System.Drawing.Point(30, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 15)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Contado Efectivo"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label11.Location = New System.Drawing.Point(21, 199)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 15)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Cheques Terceros"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMontoIva
        '
        Me.txtMontoIva.Decimals = CType(2, Byte)
        Me.txtMontoIva.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtMontoIva.Enabled = False
        Me.txtMontoIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoIva.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtMontoIva.Location = New System.Drawing.Point(58, 62)
        Me.txtMontoIva.Name = "txtMontoIva"
        Me.txtMontoIva.Size = New System.Drawing.Size(53, 20)
        Me.txtMontoIva.TabIndex = 18
        Me.txtMontoIva.Text = "0"
        Me.txtMontoIva.Text_1 = Nothing
        Me.txtMontoIva.Text_2 = Nothing
        Me.txtMontoIva.Text_3 = Nothing
        Me.txtMontoIva.Text_4 = Nothing
        Me.txtMontoIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoIva.UserValues = Nothing
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(100, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Total"
        '
        'lblTotalaPagar
        '
        Me.lblTotalaPagar.BackColor = System.Drawing.Color.White
        Me.lblTotalaPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalaPagar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTotalaPagar.Location = New System.Drawing.Point(150, 115)
        Me.lblTotalaPagar.Name = "lblTotalaPagar"
        Me.lblTotalaPagar.Size = New System.Drawing.Size(63, 19)
        Me.lblTotalaPagar.TabIndex = 22
        Me.lblTotalaPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMontoSinIVA
        '
        Me.lblMontoSinIVA.BackColor = System.Drawing.Color.White
        Me.lblMontoSinIVA.Enabled = False
        Me.lblMontoSinIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoSinIVA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMontoSinIVA.Location = New System.Drawing.Point(150, 85)
        Me.lblMontoSinIVA.Name = "lblMontoSinIVA"
        Me.lblMontoSinIVA.Size = New System.Drawing.Size(63, 19)
        Me.lblMontoSinIVA.TabIndex = 28
        Me.lblMontoSinIVA.Text = "0"
        Me.lblMontoSinIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMontoIVA
        '
        Me.lblMontoIVA.BackColor = System.Drawing.Color.White
        Me.lblMontoIVA.Enabled = False
        Me.lblMontoIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoIVA.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMontoIVA.Location = New System.Drawing.Point(150, 62)
        Me.lblMontoIVA.Name = "lblMontoIVA"
        Me.lblMontoIVA.Size = New System.Drawing.Size(63, 19)
        Me.lblMontoIVA.TabIndex = 24
        Me.lblMontoIVA.Text = "0"
        Me.lblMontoIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAplicarIvaParcial
        '
        Me.chkAplicarIvaParcial.BackColor = System.Drawing.Color.Transparent
        Me.chkAplicarIvaParcial.Location = New System.Drawing.Point(101, 36)
        Me.chkAplicarIvaParcial.Name = "chkAplicarIvaParcial"
        Me.chkAplicarIvaParcial.Size = New System.Drawing.Size(112, 22)
        Me.chkAplicarIvaParcial.TabIndex = 17
        Me.chkAplicarIvaParcial.Text = "Aplicar IVA Parcial"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label10.Location = New System.Drawing.Point(48, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Total sin IVA"
        '
        'lblTotalaPagarSinIva
        '
        Me.lblTotalaPagarSinIva.BackColor = System.Drawing.Color.White
        Me.lblTotalaPagarSinIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalaPagarSinIva.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTotalaPagarSinIva.Location = New System.Drawing.Point(150, 5)
        Me.lblTotalaPagarSinIva.Name = "lblTotalaPagarSinIva"
        Me.lblTotalaPagarSinIva.Size = New System.Drawing.Size(63, 19)
        Me.lblTotalaPagarSinIva.TabIndex = 25
        Me.lblTotalaPagarSinIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEntregaContado
        '
        Me.txtEntregaContado.Decimals = CType(2, Byte)
        Me.txtEntregaContado.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtEntregaContado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntregaContado.Format = TextBoxConFormatoVB.tbFormats.SignedFloatingPointNumber
        Me.txtEntregaContado.Location = New System.Drawing.Point(150, 147)
        Me.txtEntregaContado.Name = "txtEntregaContado"
        Me.txtEntregaContado.Size = New System.Drawing.Size(63, 20)
        Me.txtEntregaContado.TabIndex = 7
        Me.txtEntregaContado.Text = "0"
        Me.txtEntregaContado.Text_1 = Nothing
        Me.txtEntregaContado.Text_2 = Nothing
        Me.txtEntregaContado.Text_3 = Nothing
        Me.txtEntregaContado.Text_4 = Nothing
        Me.txtEntregaContado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEntregaContado.UserValues = Nothing
        '
        'lblEntregaCheques
        '
        Me.lblEntregaCheques.BackColor = System.Drawing.Color.White
        Me.lblEntregaCheques.Enabled = False
        Me.lblEntregaCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregaCheques.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEntregaCheques.Location = New System.Drawing.Point(150, 198)
        Me.lblEntregaCheques.Name = "lblEntregaCheques"
        Me.lblEntregaCheques.Size = New System.Drawing.Size(63, 19)
        Me.lblEntregaCheques.TabIndex = 13
        Me.lblEntregaCheques.Text = "0"
        Me.lblEntregaCheques.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(63, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Total Neto"
        '
        'lblEntregado
        '
        Me.lblEntregado.BackColor = System.Drawing.Color.White
        Me.lblEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEntregado.Location = New System.Drawing.Point(150, 293)
        Me.lblEntregado.Name = "lblEntregado"
        Me.lblEntregado.Size = New System.Drawing.Size(63, 19)
        Me.lblEntregado.TabIndex = 14
        Me.lblEntregado.Text = "0"
        Me.lblEntregado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIdGasto
        '
        Me.txtIdGasto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdGasto.Decimals = CType(2, Byte)
        Me.txtIdGasto.DecSeparator = Global.Microsoft.VisualBasic.ChrW(44)
        Me.txtIdGasto.Enabled = False
        Me.txtIdGasto.Format = TextBoxConFormatoVB.tbFormats.UnsignedNumber
        Me.txtIdGasto.Location = New System.Drawing.Point(12, 35)
        Me.txtIdGasto.MaxLength = 8
        Me.txtIdGasto.Name = "txtIdGasto"
        Me.txtIdGasto.Size = New System.Drawing.Size(71, 20)
        Me.txtIdGasto.TabIndex = 51
        Me.txtIdGasto.Text_1 = Nothing
        Me.txtIdGasto.Text_2 = Nothing
        Me.txtIdGasto.Text_3 = Nothing
        Me.txtIdGasto.Text_4 = Nothing
        Me.txtIdGasto.UserValues = Nothing
        Me.txtIdGasto.Visible = False
        '
        'frmPagodeGastos_Recepciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 434)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmPagodeGastos_Recepciones"
        Me.Text = "Registro de Pagos de Clientes"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabChequesPropios.ResumeLayout(False)
        Me.TabChequesPropios.PerformLayout()
        CType(Me.dtpFechaCheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdChequesPropios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCheques.ResumeLayout(False)
        CType(Me.grdCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTransferencias.ResumeLayout(False)
        Me.TabTransferencias.PerformLayout()
        CType(Me.dtpFechaTransf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTransferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTarjetas.ResumeLayout(False)
        Me.TabTarjetas.PerformLayout()
        CType(Me.grdTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabNC.ResumeLayout(False)
        Me.TabNC.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpPago.ResumeLayout(False)
        Me.gpPago.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend Shadows WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BorrarElItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuscarDescripcionToolStripMenuItem As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtID As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gpPago As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtEntregaContado As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents lblEntregaCheques As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblEntregado As System.Windows.Forms.Label
    Friend WithEvents txtMontoIva As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalaPagar As System.Windows.Forms.Label
    Friend WithEvents lblMontoSinIVA As System.Windows.Forms.Label
    Friend WithEvents lblMontoIVA As System.Windows.Forms.Label
    Friend WithEvents chkAplicarIvaParcial As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalaPagarSinIva As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabChequesPropios As System.Windows.Forms.TabPage
    Friend WithEvents TabCheques As System.Windows.Forms.TabPage
    Friend WithEvents TabTransferencias As System.Windows.Forms.TabPage
    Friend WithEvents TabTarjetas As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblEntregaTarjetas As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblEntregaChequesPropios As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblEntregaTransferencias As System.Windows.Forms.Label
    Friend WithEvents txtMontoTransf As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbMonedaTransf As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
    Friend WithEvents btnAgregarTransf As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminarTransf As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaTransf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbBancoDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents grdTransferencias As System.Windows.Forms.DataGridView
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbBancoOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem11 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem12 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAgregarTarjeta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminarTarjeta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboBoxEx2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem15 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem16 As DevComponents.Editors.ComboItem
    Friend WithEvents grdTarjetas As System.Windows.Forms.DataGridView
    Friend WithEvents FormattedTextBoxVB2 As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents FormattedTextBoxVB1 As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents txtNroOpCliente As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbCuentaDestino As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem17 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem18 As DevComponents.Editors.ComboItem
    Friend WithEvents cmbCuentaOrigen As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem13 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem14 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNuevoTransferencia As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnNuevoTarjeta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnModificarTransf As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtObservacionesTransf As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblResto As System.Windows.Forms.Label
    Friend WithEvents btnModificarTarjeta As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtRedondeo As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TabNC As System.Windows.Forms.TabPage
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbNC As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem19 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem20 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FormattedTextBoxVB3 As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BancoDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesTransf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdCheques As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificarCheque As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtObservacionesCheque As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents btnNuevoCheque As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtMontoCheque As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents txtNroCheque As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnAgregarCheque As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEliminarCheque As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFechaCheque As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbBanco As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents grdChequesPropios As System.Windows.Forms.DataGridView
    Friend WithEvents NroCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaVenc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Propietario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdTipoMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Utilizado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbMoneda As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
    Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
    Friend WithEvents txtPropietario As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigo As TextBoxConFormatoVB.FormattedTextBoxVB
    Friend WithEvents txtIdGasto As TextBoxConFormatoVB.FormattedTextBoxVB
End Class
