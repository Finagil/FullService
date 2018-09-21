<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFullService
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbHide = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtRenta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbService = New System.Windows.Forms.ComboBox()
        Me.ServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDataSet1 = New FullService.ProductionDataSet()
        Me.txtSimulador = New System.Windows.Forms.Button()
        Me.LbImporte = New System.Windows.Forms.Label()
        Me.AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonCargar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboAnexo = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtDiasT = New System.Windows.Forms.TextBox()
        Me.LbAjuste = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.TxtTtot = New System.Windows.Forms.TextBox()
        Me.TxtTseg = New System.Windows.Forms.TextBox()
        Me.TxtTiva = New System.Windows.Forms.TextBox()
        Me.TxtTpag = New System.Windows.Forms.TextBox()
        Me.TxtTint = New System.Windows.Forms.TextBox()
        Me.TxtTCAP = New System.Windows.Forms.TextBox()
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.GridExtra = New System.Windows.Forms.DataGridView()
        Me.ServicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumMesesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IVA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ServiciosAdicionalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BaddExtra = New System.Windows.Forms.Button()
        Me.DfechaVenc = New System.Windows.Forms.DateTimePicker()
        Me.Dfechacon = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtExtra = New System.Windows.Forms.TextBox()
        Me.ComboPeriodo = New System.Windows.Forms.ComboBox()
        Me.LIPeriodosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboPlazo = New System.Windows.Forms.ComboBox()
        Me.LIPlazosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumMeses = New System.Windows.Forms.TextBox()
        Me.ComboSeguro = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGracia = New System.Windows.Forms.TextBox()
        Me.ComboPagoIgual = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboCapital = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GridAmortizaciones = New System.Windows.Forms.DataGridView()
        Me.Pago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInsoluto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Extra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IvaInteres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seguro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LI_PlazosTableAdapter = New FullService.ProductionDataSetTableAdapters.LI_PlazosTableAdapter()
        Me.ServiciosTableAdapter = New FullService.ProductionDataSetTableAdapters.ServiciosTableAdapter()
        Me.ClientesTableAdapter = New FullService.ProductionDataSetTableAdapters.ClientesTableAdapter()
        Me.LI_PeriodosTableAdapter = New FullService.ProductionDataSetTableAdapters.LI_PeriodosTableAdapter()
        Me.AnexosTableAdapter = New FullService.ProductionDataSetTableAdapters.AnexosTableAdapter()
        Me.CkIva = New System.Windows.Forms.CheckBox()
        Me.CkTasaGrp = New System.Windows.Forms.CheckBox()
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosAdicionalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbHide
        '
        Me.LbHide.AutoSize = True
        Me.LbHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHide.Location = New System.Drawing.Point(854, 593)
        Me.LbHide.Name = "LbHide"
        Me.LbHide.Size = New System.Drawing.Size(11, 13)
        Me.LbHide.TabIndex = 169
        Me.LbHide.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(856, 572)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 13)
        Me.Label9.TabIndex = 168
        Me.Label9.Text = "Mensualidad con IVA"
        '
        'TxtRenta
        '
        Me.TxtRenta.Enabled = False
        Me.TxtRenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRenta.Location = New System.Drawing.Point(866, 588)
        Me.TxtRenta.Name = "TxtRenta"
        Me.TxtRenta.Size = New System.Drawing.Size(113, 21)
        Me.TxtRenta.TabIndex = 167
        Me.TxtRenta.Text = "0.00"
        Me.TxtRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(159, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 13)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "Importe Total Servicio "
        '
        'CmbService
        '
        Me.CmbService.DataSource = Me.ServiciosBindingSource
        Me.CmbService.DisplayMember = "Descripcion"
        Me.CmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbService.FormattingEnabled = True
        Me.CmbService.Location = New System.Drawing.Point(162, 98)
        Me.CmbService.Name = "CmbService"
        Me.CmbService.Size = New System.Drawing.Size(198, 21)
        Me.CmbService.TabIndex = 135
        Me.CmbService.ValueMember = "ID_Servicio"
        '
        'ServiciosBindingSource
        '
        Me.ServiciosBindingSource.DataMember = "Servicios"
        Me.ServiciosBindingSource.DataSource = Me.ProductionDataSet1
        '
        'ProductionDataSet1
        '
        Me.ProductionDataSet1.DataSetName = "ProductionDataSet1"
        Me.ProductionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSimulador
        '
        Me.txtSimulador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimulador.Location = New System.Drawing.Point(866, 124)
        Me.txtSimulador.Name = "txtSimulador"
        Me.txtSimulador.Size = New System.Drawing.Size(128, 37)
        Me.txtSimulador.TabIndex = 163
        Me.txtSimulador.Text = "Simulador"
        Me.txtSimulador.UseVisualStyleBackColor = True
        '
        'LbImporte
        '
        Me.LbImporte.AutoSize = True
        Me.LbImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnexosBindingSource, "Impeq", True))
        Me.LbImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbImporte.Location = New System.Drawing.Point(865, 48)
        Me.LbImporte.Name = "LbImporte"
        Me.LbImporte.Size = New System.Drawing.Size(19, 13)
        Me.LbImporte.TabIndex = 162
        Me.LbImporte.Text = "..."
        '
        'AnexosBindingSource
        '
        Me.AnexosBindingSource.DataMember = "Anexos"
        Me.AnexosBindingSource.DataSource = Me.ProductionDataSet1
        '
        'ButtonCargar
        '
        Me.ButtonCargar.Enabled = False
        Me.ButtonCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCargar.Location = New System.Drawing.Point(866, 72)
        Me.ButtonCargar.Name = "ButtonCargar"
        Me.ButtonCargar.Size = New System.Drawing.Size(128, 37)
        Me.ButtonCargar.TabIndex = 161
        Me.ButtonCargar.Text = "Cargar Tabla"
        Me.ButtonCargar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(865, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Anexos Sin Pago"
        '
        'ComboAnexo
        '
        Me.ComboAnexo.DataSource = Me.AnexosBindingSource
        Me.ComboAnexo.DisplayMember = "AnexoX"
        Me.ComboAnexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAnexo.FormattingEnabled = True
        Me.ComboAnexo.Location = New System.Drawing.Point(868, 23)
        Me.ComboAnexo.Name = "ComboAnexo"
        Me.ComboAnexo.Size = New System.Drawing.Size(126, 21)
        Me.ComboAnexo.TabIndex = 159
        Me.ComboAnexo.ValueMember = "Anexo"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(16, 576)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox1.TabIndex = 158
        Me.CheckBox1.Text = "Cliente"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxtDiasT
        '
        Me.TxtDiasT.Enabled = False
        Me.TxtDiasT.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiasT.Location = New System.Drawing.Point(162, 575)
        Me.TxtDiasT.Name = "TxtDiasT"
        Me.TxtDiasT.Size = New System.Drawing.Size(45, 18)
        Me.TxtDiasT.TabIndex = 157
        Me.TxtDiasT.Text = "0"
        Me.TxtDiasT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDiasT.Visible = False
        '
        'LbAjuste
        '
        Me.LbAjuste.AutoSize = True
        Me.LbAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAjuste.Location = New System.Drawing.Point(381, 599)
        Me.LbAjuste.Name = "LbAjuste"
        Me.LbAjuste.Size = New System.Drawing.Size(45, 12)
        Me.LbAjuste.TabIndex = 156
        Me.LbAjuste.Text = "Ajuste :"
        Me.LbAjuste.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 13)
        Me.Label11.TabIndex = 153
        Me.Label11.Text = "Cliente (Persona Moral)"
        '
        'ComboCliente
        '
        Me.ComboCliente.DataSource = Me.ClientesBindingSource
        Me.ComboCliente.DisplayMember = "Nombre"
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(15, 179)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(424, 21)
        Me.ComboCliente.TabIndex = 142
        Me.ComboCliente.ValueMember = "Cliente"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ProductionDataSet1
        '
        'BtPrint
        '
        Me.BtPrint.Enabled = False
        Me.BtPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPrint.Location = New System.Drawing.Point(16, 575)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(131, 37)
        Me.BtPrint.TabIndex = 152
        Me.BtPrint.Text = "Imprimir"
        Me.BtPrint.UseVisualStyleBackColor = True
        Me.BtPrint.Visible = False
        '
        'TxtTtot
        '
        Me.TxtTtot.Enabled = False
        Me.TxtTtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTtot.Location = New System.Drawing.Point(768, 575)
        Me.TxtTtot.Name = "TxtTtot"
        Me.TxtTtot.Size = New System.Drawing.Size(80, 18)
        Me.TxtTtot.TabIndex = 151
        Me.TxtTtot.Text = "0.00"
        Me.TxtTtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTtot.Visible = False
        '
        'TxtTseg
        '
        Me.TxtTseg.Enabled = False
        Me.TxtTseg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTseg.Location = New System.Drawing.Point(688, 575)
        Me.TxtTseg.Name = "TxtTseg"
        Me.TxtTseg.Size = New System.Drawing.Size(80, 18)
        Me.TxtTseg.TabIndex = 150
        Me.TxtTseg.Text = "0.00"
        Me.TxtTseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTseg.Visible = False
        '
        'TxtTiva
        '
        Me.TxtTiva.Enabled = False
        Me.TxtTiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTiva.Location = New System.Drawing.Point(608, 575)
        Me.TxtTiva.Name = "TxtTiva"
        Me.TxtTiva.Size = New System.Drawing.Size(80, 18)
        Me.TxtTiva.TabIndex = 149
        Me.TxtTiva.Text = "0.00"
        Me.TxtTiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTiva.Visible = False
        '
        'TxtTpag
        '
        Me.TxtTpag.Enabled = False
        Me.TxtTpag.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTpag.Location = New System.Drawing.Point(445, 575)
        Me.TxtTpag.Name = "TxtTpag"
        Me.TxtTpag.Size = New System.Drawing.Size(80, 18)
        Me.TxtTpag.TabIndex = 148
        Me.TxtTpag.Text = "0.00"
        Me.TxtTpag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTpag.Visible = False
        '
        'TxtTint
        '
        Me.TxtTint.Enabled = False
        Me.TxtTint.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTint.Location = New System.Drawing.Point(365, 575)
        Me.TxtTint.Name = "TxtTint"
        Me.TxtTint.Size = New System.Drawing.Size(80, 18)
        Me.TxtTint.TabIndex = 147
        Me.TxtTint.Text = "0.00"
        Me.TxtTint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTint.Visible = False
        '
        'TxtTCAP
        '
        Me.TxtTCAP.Enabled = False
        Me.TxtTCAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTCAP.Location = New System.Drawing.Point(285, 575)
        Me.TxtTCAP.Name = "TxtTCAP"
        Me.TxtTCAP.Size = New System.Drawing.Size(80, 18)
        Me.TxtTCAP.TabIndex = 146
        Me.TxtTCAP.Text = "0.00"
        Me.TxtTCAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTCAP.Visible = False
        '
        'Bcalcular
        '
        Me.Bcalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bcalcular.Location = New System.Drawing.Point(594, 177)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(258, 23)
        Me.Bcalcular.TabIndex = 140
        Me.Bcalcular.Text = "Calcular Renta del Servicio"
        Me.Bcalcular.UseVisualStyleBackColor = True
        '
        'GridExtra
        '
        Me.GridExtra.AllowUserToAddRows = False
        Me.GridExtra.AutoGenerateColumns = False
        Me.GridExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridExtra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicioDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.NumMesesDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn, Me.IVA})
        Me.GridExtra.DataSource = Me.ServiciosAdicionalesBindingSource
        Me.GridExtra.Location = New System.Drawing.Point(383, 8)
        Me.GridExtra.Name = "GridExtra"
        Me.GridExtra.ReadOnly = True
        Me.GridExtra.Size = New System.Drawing.Size(469, 163)
        Me.GridExtra.TabIndex = 154
        '
        'ServicioDataGridViewTextBoxColumn
        '
        Me.ServicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.HeaderText = "Servicio"
        Me.ServicioDataGridViewTextBoxColumn.Name = "ServicioDataGridViewTextBoxColumn"
        Me.ServicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServicioDataGridViewTextBoxColumn.Width = 200
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        DataGridViewCellStyle1.Format = "n2"
        Me.MontoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        Me.MontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumMesesDataGridViewTextBoxColumn
        '
        Me.NumMesesDataGridViewTextBoxColumn.DataPropertyName = "NumMeses"
        Me.NumMesesDataGridViewTextBoxColumn.HeaderText = "NumMeses"
        Me.NumMesesDataGridViewTextBoxColumn.Name = "NumMesesDataGridViewTextBoxColumn"
        Me.NumMesesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'IVA
        '
        Me.IVA.DataPropertyName = "IVA"
        Me.IVA.HeaderText = "IVA"
        Me.IVA.Name = "IVA"
        Me.IVA.ReadOnly = True
        '
        'ServiciosAdicionalesBindingSource
        '
        Me.ServiciosAdicionalesBindingSource.DataMember = "ServiciosAdicionales"
        Me.ServiciosAdicionalesBindingSource.DataSource = Me.ProductionDataSet1
        '
        'BaddExtra
        '
        Me.BaddExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BaddExtra.Location = New System.Drawing.Point(260, 134)
        Me.BaddExtra.Name = "BaddExtra"
        Me.BaddExtra.Size = New System.Drawing.Size(100, 24)
        Me.BaddExtra.TabIndex = 139
        Me.BaddExtra.Text = "Agrega S."
        Me.BaddExtra.UseVisualStyleBackColor = True
        '
        'DfechaVenc
        '
        Me.DfechaVenc.Location = New System.Drawing.Point(162, 59)
        Me.DfechaVenc.Name = "DfechaVenc"
        Me.DfechaVenc.Size = New System.Drawing.Size(200, 20)
        Me.DfechaVenc.TabIndex = 133
        '
        'Dfechacon
        '
        Me.Dfechacon.CustomFormat = ""
        Me.Dfechacon.Location = New System.Drawing.Point(162, 20)
        Me.Dfechacon.Name = "Dfechacon"
        Me.Dfechacon.Size = New System.Drawing.Size(198, 20)
        Me.Dfechacon.TabIndex = 132
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Fecha 1ra Renta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(159, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Fecha Contrato"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(16, 101)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(92, 20)
        Me.TxtMonto.TabIndex = 130
        Me.TxtMonto.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Facturas c/IVA"
        '
        'TxtExtra
        '
        Me.TxtExtra.Location = New System.Drawing.Point(162, 137)
        Me.TxtExtra.Name = "TxtExtra"
        Me.TxtExtra.Size = New System.Drawing.Size(92, 20)
        Me.TxtExtra.TabIndex = 136
        Me.TxtExtra.Text = "0"
        '
        'ComboPeriodo
        '
        Me.ComboPeriodo.DataSource = Me.LIPeriodosBindingSource
        Me.ComboPeriodo.DisplayMember = "Descripcion"
        Me.ComboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPeriodo.FormattingEnabled = True
        Me.ComboPeriodo.Location = New System.Drawing.Point(16, 60)
        Me.ComboPeriodo.Name = "ComboPeriodo"
        Me.ComboPeriodo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPeriodo.TabIndex = 126
        Me.ComboPeriodo.ValueMember = "Dias"
        '
        'LIPeriodosBindingSource
        '
        Me.LIPeriodosBindingSource.DataMember = "LI_Periodos"
        Me.LIPeriodosBindingSource.DataSource = Me.ProductionDataSet1
        '
        'ComboPlazo
        '
        Me.ComboPlazo.DataSource = Me.LIPlazosBindingSource
        Me.ComboPlazo.DisplayMember = "Descripcion"
        Me.ComboPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPlazo.FormattingEnabled = True
        Me.ComboPlazo.Location = New System.Drawing.Point(16, 20)
        Me.ComboPlazo.Name = "ComboPlazo"
        Me.ComboPlazo.Size = New System.Drawing.Size(94, 21)
        Me.ComboPlazo.TabIndex = 123
        Me.ComboPlazo.ValueMember = "id"
        '
        'LIPlazosBindingSource
        '
        Me.LIPlazosBindingSource.DataMember = "LI_Plazos"
        Me.LIPlazosBindingSource.DataSource = Me.ProductionDataSet1
        '
        'TxtTasa
        '
        Me.TxtTasa.Enabled = False
        Me.TxtTasa.Location = New System.Drawing.Point(16, 140)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(74, 20)
        Me.TxtTasa.TabIndex = 131
        Me.TxtTasa.Text = "15"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(159, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Servicios Adicionales"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "Periodicidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Plazo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Tasa Anual"
        '
        'TxtNumMeses
        '
        Me.TxtNumMeses.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServiciosBindingSource, "NumMeses", True))
        Me.TxtNumMeses.Location = New System.Drawing.Point(246, 98)
        Me.TxtNumMeses.Name = "TxtNumMeses"
        Me.TxtNumMeses.ReadOnly = True
        Me.TxtNumMeses.Size = New System.Drawing.Size(15, 20)
        Me.TxtNumMeses.TabIndex = 166
        '
        'ComboSeguro
        '
        Me.ComboSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboSeguro.FormattingEnabled = True
        Me.ComboSeguro.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboSeguro.Location = New System.Drawing.Point(889, 483)
        Me.ComboSeguro.Name = "ComboSeguro"
        Me.ComboSeguro.Size = New System.Drawing.Size(59, 21)
        Me.ComboSeguro.TabIndex = 127
        Me.ComboSeguro.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(885, 467)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "Seguro de Vida"
        Me.Label5.Visible = False
        '
        'TxtGracia
        '
        Me.TxtGracia.Location = New System.Drawing.Point(908, 444)
        Me.TxtGracia.Name = "TxtGracia"
        Me.TxtGracia.Size = New System.Drawing.Size(26, 20)
        Me.TxtGracia.TabIndex = 164
        Me.TxtGracia.Text = "1"
        Me.TxtGracia.Visible = False
        '
        'ComboPagoIgual
        '
        Me.ComboPagoIgual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPagoIgual.Enabled = False
        Me.ComboPagoIgual.FormattingEnabled = True
        Me.ComboPagoIgual.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboPagoIgual.Location = New System.Drawing.Point(843, 405)
        Me.ComboPagoIgual.Name = "ComboPagoIgual"
        Me.ComboPagoIgual.Size = New System.Drawing.Size(59, 21)
        Me.ComboPagoIgual.TabIndex = 137
        Me.ComboPagoIgual.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(839, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 155
        Me.Label12.Text = "Pagos Iguales"
        Me.Label12.Visible = False
        '
        'ComboCapital
        '
        Me.ComboCapital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCapital.FormattingEnabled = True
        Me.ComboCapital.Items.AddRange(New Object() {"SI", "NO"})
        Me.ComboCapital.Location = New System.Drawing.Point(843, 444)
        Me.ComboCapital.Name = "ComboCapital"
        Me.ComboCapital.Size = New System.Drawing.Size(59, 21)
        Me.ComboCapital.TabIndex = 134
        Me.ComboCapital.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(839, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 13)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Capital 1ra Amortizacion"
        Me.Label10.Visible = False
        '
        'GridAmortizaciones
        '
        Me.GridAmortizaciones.AllowUserToAddRows = False
        Me.GridAmortizaciones.AllowUserToDeleteRows = False
        Me.GridAmortizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAmortizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Pago, Me.FechaVencimiento, Me.Dias, Me.SaldoInsoluto, Me.Extra, Me.Capital, Me.Interes, Me.pagos, Me.IvaInteres, Me.Seguro, Me.PagoTotal, Me.Costo})
        Me.GridAmortizaciones.Location = New System.Drawing.Point(12, 207)
        Me.GridAmortizaciones.Name = "GridAmortizaciones"
        Me.GridAmortizaciones.ReadOnly = True
        Me.GridAmortizaciones.Size = New System.Drawing.Size(976, 363)
        Me.GridAmortizaciones.TabIndex = 144
        Me.GridAmortizaciones.Visible = False
        '
        'Pago
        '
        Me.Pago.HeaderText = "No Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        Me.Pago.Width = 40
        '
        'FechaVencimiento
        '
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaVencimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaVencimiento.HeaderText = "Fecha Vencimiento"
        Me.FechaVencimiento.Name = "FechaVencimiento"
        Me.FechaVencimiento.ReadOnly = True
        Me.FechaVencimiento.Width = 70
        '
        'Dias
        '
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Dias.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dias.HeaderText = "Días"
        Me.Dias.Name = "Dias"
        Me.Dias.ReadOnly = True
        Me.Dias.Width = 40
        '
        'SaldoInsoluto
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SaldoInsoluto.DefaultCellStyle = DataGridViewCellStyle4
        Me.SaldoInsoluto.HeaderText = "Saldo Insoluto"
        Me.SaldoInsoluto.Name = "SaldoInsoluto"
        Me.SaldoInsoluto.ReadOnly = True
        Me.SaldoInsoluto.Width = 80
        '
        'Extra
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Extra.DefaultCellStyle = DataGridViewCellStyle5
        Me.Extra.HeaderText = "Pago Ext."
        Me.Extra.Name = "Extra"
        Me.Extra.ReadOnly = True
        Me.Extra.Visible = False
        Me.Extra.Width = 80
        '
        'Capital
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.Capital.DefaultCellStyle = DataGridViewCellStyle6
        Me.Capital.HeaderText = "Capital"
        Me.Capital.Name = "Capital"
        Me.Capital.ReadOnly = True
        Me.Capital.Width = 80
        '
        'Interes
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.Interes.DefaultCellStyle = DataGridViewCellStyle7
        Me.Interes.HeaderText = "Interes"
        Me.Interes.Name = "Interes"
        Me.Interes.ReadOnly = True
        Me.Interes.Width = 80
        '
        'pagos
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.pagos.DefaultCellStyle = DataGridViewCellStyle8
        Me.pagos.HeaderText = "Pago"
        Me.pagos.Name = "pagos"
        Me.pagos.ReadOnly = True
        Me.pagos.Width = 80
        '
        'IvaInteres
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.IvaInteres.DefaultCellStyle = DataGridViewCellStyle9
        Me.IvaInteres.HeaderText = "Iva Interes"
        Me.IvaInteres.Name = "IvaInteres"
        Me.IvaInteres.ReadOnly = True
        Me.IvaInteres.Visible = False
        Me.IvaInteres.Width = 80
        '
        'Seguro
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.Seguro.DefaultCellStyle = DataGridViewCellStyle10
        Me.Seguro.HeaderText = "Seguro de Vida"
        Me.Seguro.Name = "Seguro"
        Me.Seguro.ReadOnly = True
        Me.Seguro.Visible = False
        Me.Seguro.Width = 80
        '
        'PagoTotal
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.PagoTotal.DefaultCellStyle = DataGridViewCellStyle11
        Me.PagoTotal.HeaderText = "Pago Total"
        Me.PagoTotal.Name = "PagoTotal"
        Me.PagoTotal.ReadOnly = True
        Me.PagoTotal.Visible = False
        Me.PagoTotal.Width = 80
        '
        'Costo
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.Costo.DefaultCellStyle = DataGridViewCellStyle12
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 207)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(976, 362)
        Me.CrystalReportViewer1.TabIndex = 170
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LI_PlazosTableAdapter
        '
        Me.LI_PlazosTableAdapter.ClearBeforeFill = True
        '
        'ServiciosTableAdapter
        '
        Me.ServiciosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'LI_PeriodosTableAdapter
        '
        Me.LI_PeriodosTableAdapter.ClearBeforeFill = True
        '
        'AnexosTableAdapter
        '
        Me.AnexosTableAdapter.ClearBeforeFill = True
        '
        'CkIva
        '
        Me.CkIva.AutoSize = True
        Me.CkIva.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ServiciosBindingSource, "Iva", True))
        Me.CkIva.Enabled = False
        Me.CkIva.Location = New System.Drawing.Point(363, 102)
        Me.CkIva.Name = "CkIva"
        Me.CkIva.Size = New System.Drawing.Size(15, 14)
        Me.CkIva.TabIndex = 172
        Me.CkIva.UseVisualStyleBackColor = True
        '
        'CkTasaGrp
        '
        Me.CkTasaGrp.AutoSize = True
        Me.CkTasaGrp.Location = New System.Drawing.Point(96, 142)
        Me.CkTasaGrp.Name = "CkTasaGrp"
        Me.CkTasaGrp.Size = New System.Drawing.Size(15, 14)
        Me.CkTasaGrp.TabIndex = 173
        Me.CkTasaGrp.UseVisualStyleBackColor = True
        '
        'FrmFullService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 617)
        Me.Controls.Add(Me.CkTasaGrp)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.LbHide)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtRenta)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CmbService)
        Me.Controls.Add(Me.txtSimulador)
        Me.Controls.Add(Me.LbImporte)
        Me.Controls.Add(Me.ButtonCargar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboAnexo)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TxtDiasT)
        Me.Controls.Add(Me.LbAjuste)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboCliente)
        Me.Controls.Add(Me.BtPrint)
        Me.Controls.Add(Me.TxtTtot)
        Me.Controls.Add(Me.TxtTseg)
        Me.Controls.Add(Me.TxtTiva)
        Me.Controls.Add(Me.TxtTpag)
        Me.Controls.Add(Me.TxtTint)
        Me.Controls.Add(Me.TxtTCAP)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.GridExtra)
        Me.Controls.Add(Me.BaddExtra)
        Me.Controls.Add(Me.DfechaVenc)
        Me.Controls.Add(Me.Dfechacon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtExtra)
        Me.Controls.Add(Me.ComboPeriodo)
        Me.Controls.Add(Me.ComboPlazo)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNumMeses)
        Me.Controls.Add(Me.GridAmortizaciones)
        Me.Controls.Add(Me.ComboSeguro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtGracia)
        Me.Controls.Add(Me.ComboPagoIgual)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ComboCapital)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CkIva)
        Me.Name = "FrmFullService"
        Me.Text = "Cotizacion FullService"
        CType(Me.ServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosAdicionalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPeriodosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIPlazosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAmortizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbHide As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtRenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CmbService As ComboBox
    Friend WithEvents txtSimulador As Button
    Friend WithEvents LbImporte As Label
    Friend WithEvents ButtonCargar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboAnexo As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TxtDiasT As TextBox
    Friend WithEvents LbAjuste As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboCliente As ComboBox
    Friend WithEvents BtPrint As Button
    Friend WithEvents TxtTtot As TextBox
    Friend WithEvents TxtTseg As TextBox
    Friend WithEvents TxtTiva As TextBox
    Friend WithEvents TxtTpag As TextBox
    Friend WithEvents TxtTint As TextBox
    Friend WithEvents TxtTCAP As TextBox
    Friend WithEvents Bcalcular As Button
    Friend WithEvents GridExtra As DataGridView
    Friend WithEvents BaddExtra As Button
    Friend WithEvents DfechaVenc As DateTimePicker
    Friend WithEvents Dfechacon As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtExtra As TextBox
    Friend WithEvents ComboPeriodo As ComboBox
    Friend WithEvents ComboPlazo As ComboBox
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumMeses As TextBox
    Friend WithEvents ComboSeguro As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtGracia As TextBox
    Friend WithEvents ComboPagoIgual As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboCapital As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GridAmortizaciones As DataGridView
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ProductionDataSet1 As ProductionDataSet
    Friend WithEvents LIPlazosBindingSource As BindingSource
    Friend WithEvents LI_PlazosTableAdapter As ProductionDataSetTableAdapters.LI_PlazosTableAdapter
    Friend WithEvents ServiciosBindingSource As BindingSource
    Friend WithEvents ServiciosTableAdapter As ProductionDataSetTableAdapters.ServiciosTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As ProductionDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents LIPeriodosBindingSource As BindingSource
    Friend WithEvents LI_PeriodosTableAdapter As ProductionDataSetTableAdapters.LI_PeriodosTableAdapter
    Friend WithEvents AnexosBindingSource As BindingSource
    Friend WithEvents AnexosTableAdapter As ProductionDataSetTableAdapters.AnexosTableAdapter
    Friend WithEvents ServiciosAdicionalesBindingSource As BindingSource
    Friend WithEvents Pago As DataGridViewTextBoxColumn
    Friend WithEvents FechaVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents Dias As DataGridViewTextBoxColumn
    Friend WithEvents SaldoInsoluto As DataGridViewTextBoxColumn
    Friend WithEvents Extra As DataGridViewTextBoxColumn
    Friend WithEvents Capital As DataGridViewTextBoxColumn
    Friend WithEvents Interes As DataGridViewTextBoxColumn
    Friend WithEvents pagos As DataGridViewTextBoxColumn
    Friend WithEvents IvaInteres As DataGridViewTextBoxColumn
    Friend WithEvents Seguro As DataGridViewTextBoxColumn
    Friend WithEvents PagoTotal As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents CkIva As CheckBox
    Friend WithEvents ServicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumMesesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IVA As DataGridViewCheckBoxColumn
    Friend WithEvents CkTasaGrp As CheckBox
End Class
