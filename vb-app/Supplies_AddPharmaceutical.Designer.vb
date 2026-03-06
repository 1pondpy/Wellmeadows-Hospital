<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplies_AddPharmaceutical
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DrugIDLabel As System.Windows.Forms.Label
        Dim DrugNameLabel As System.Windows.Forms.Label
        Dim DrugDescLabel As System.Windows.Forms.Label
        Dim DosageLabel As System.Windows.Forms.Label
        Dim MethodOfAdminLabel As System.Windows.Forms.Label
        Dim QtyInStockLabel As System.Windows.Forms.Label
        Dim ReorderLevelLabel As System.Windows.Forms.Label
        Dim CostPerUnitLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplies_AddPharmaceutical))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.PharmaSupplyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaSupplyTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.PharmaSupplyTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.PharmaSupplyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PharmaSupplyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PharmaSupplyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugIDTextBox = New System.Windows.Forms.TextBox()
        Me.DrugNameTextBox = New System.Windows.Forms.TextBox()
        Me.DrugDescTextBox = New System.Windows.Forms.TextBox()
        Me.DosageTextBox = New System.Windows.Forms.TextBox()
        Me.MethodOfAdminTextBox = New System.Windows.Forms.TextBox()
        Me.QtyInStockTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.CostPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        DrugIDLabel = New System.Windows.Forms.Label()
        DrugNameLabel = New System.Windows.Forms.Label()
        DrugDescLabel = New System.Windows.Forms.Label()
        DosageLabel = New System.Windows.Forms.Label()
        MethodOfAdminLabel = New System.Windows.Forms.Label()
        QtyInStockLabel = New System.Windows.Forms.Label()
        ReorderLevelLabel = New System.Windows.Forms.Label()
        CostPerUnitLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaSupplyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PharmaSupplyBindingNavigator.SuspendLayout()
        CType(Me.PharmaSupplyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrugIDLabel
        '
        DrugIDLabel.AutoSize = True
        DrugIDLabel.BackColor = System.Drawing.Color.White
        DrugIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DrugIDLabel.Location = New System.Drawing.Point(143, 343)
        DrugIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DrugIDLabel.Name = "DrugIDLabel"
        DrugIDLabel.Size = New System.Drawing.Size(65, 17)
        DrugIDLabel.TabIndex = 23
        DrugIDLabel.Text = "*Drug ID:"
        '
        'DrugNameLabel
        '
        DrugNameLabel.AutoSize = True
        DrugNameLabel.BackColor = System.Drawing.Color.White
        DrugNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DrugNameLabel.Location = New System.Drawing.Point(143, 369)
        DrugNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DrugNameLabel.Name = "DrugNameLabel"
        DrugNameLabel.Size = New System.Drawing.Size(89, 17)
        DrugNameLabel.TabIndex = 25
        DrugNameLabel.Text = "*Drug Name:"
        '
        'DrugDescLabel
        '
        DrugDescLabel.AutoSize = True
        DrugDescLabel.BackColor = System.Drawing.Color.White
        DrugDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DrugDescLabel.Location = New System.Drawing.Point(143, 396)
        DrugDescLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DrugDescLabel.Name = "DrugDescLabel"
        DrugDescLabel.Size = New System.Drawing.Size(79, 17)
        DrugDescLabel.TabIndex = 27
        DrugDescLabel.Text = "Drug Desc:"
        '
        'DosageLabel
        '
        DosageLabel.AutoSize = True
        DosageLabel.BackColor = System.Drawing.Color.White
        DosageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DosageLabel.Location = New System.Drawing.Point(462, 339)
        DosageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DosageLabel.Name = "DosageLabel"
        DosageLabel.Size = New System.Drawing.Size(66, 17)
        DosageLabel.TabIndex = 29
        DosageLabel.Text = "*Dosage:"
        '
        'MethodOfAdminLabel
        '
        MethodOfAdminLabel.AutoSize = True
        MethodOfAdminLabel.BackColor = System.Drawing.Color.White
        MethodOfAdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        MethodOfAdminLabel.Location = New System.Drawing.Point(462, 366)
        MethodOfAdminLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MethodOfAdminLabel.Name = "MethodOfAdminLabel"
        MethodOfAdminLabel.Size = New System.Drawing.Size(126, 17)
        MethodOfAdminLabel.TabIndex = 31
        MethodOfAdminLabel.Text = "*Method Of Admin:"
        '
        'QtyInStockLabel
        '
        QtyInStockLabel.AutoSize = True
        QtyInStockLabel.BackColor = System.Drawing.Color.White
        QtyInStockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        QtyInStockLabel.Location = New System.Drawing.Point(462, 393)
        QtyInStockLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        QtyInStockLabel.Name = "QtyInStockLabel"
        QtyInStockLabel.Size = New System.Drawing.Size(93, 17)
        QtyInStockLabel.TabIndex = 33
        QtyInStockLabel.Text = "*Qty In Stock:"
        '
        'ReorderLevelLabel
        '
        ReorderLevelLabel.AutoSize = True
        ReorderLevelLabel.BackColor = System.Drawing.Color.White
        ReorderLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ReorderLevelLabel.Location = New System.Drawing.Point(462, 419)
        ReorderLevelLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ReorderLevelLabel.Name = "ReorderLevelLabel"
        ReorderLevelLabel.Size = New System.Drawing.Size(102, 17)
        ReorderLevelLabel.TabIndex = 35
        ReorderLevelLabel.Text = "Reorder Level:"
        '
        'CostPerUnitLabel
        '
        CostPerUnitLabel.AutoSize = True
        CostPerUnitLabel.BackColor = System.Drawing.Color.White
        CostPerUnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        CostPerUnitLabel.Location = New System.Drawing.Point(462, 446)
        CostPerUnitLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CostPerUnitLabel.Name = "CostPerUnitLabel"
        CostPerUnitLabel.Size = New System.Drawing.Size(95, 17)
        CostPerUnitLabel.TabIndex = 37
        CostPerUnitLabel.Text = "Cost Per Unit:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.BackColor = System.Drawing.Color.White
        SupplierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SupplierIDLabel.Location = New System.Drawing.Point(143, 423)
        SupplierIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(86, 17)
        SupplierIDLabel.TabIndex = 39
        SupplierIDLabel.Text = "*Supplier ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(52, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add Pharmaceutical"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(385, 419)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(239, 447)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Supplier Name"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmaSupplyBindingSource
        '
        Me.PharmaSupplyBindingSource.DataMember = "PharmaSupply"
        Me.PharmaSupplyBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'PharmaSupplyTableAdapter
        '
        Me.PharmaSupplyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Nothing
        Me.TableAdapterManager.InpatientTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedRecordTableAdapter = Nothing
        Me.TableAdapterManager.NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager.NonSurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.PatientInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PharmaSupplyTableAdapter = Me.PharmaSupplyTableAdapter
        Me.TableAdapterManager.RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.StaffAllocationTableAdapter = Nothing
        Me.TableAdapterManager.StaffQualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'PharmaSupplyBindingNavigator
        '
        Me.PharmaSupplyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PharmaSupplyBindingNavigator.BindingSource = Me.PharmaSupplyBindingSource
        Me.PharmaSupplyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PharmaSupplyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PharmaSupplyBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.PharmaSupplyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PharmaSupplyBindingNavigatorSaveItem})
        Me.PharmaSupplyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PharmaSupplyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PharmaSupplyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PharmaSupplyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PharmaSupplyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PharmaSupplyBindingNavigator.Name = "PharmaSupplyBindingNavigator"
        Me.PharmaSupplyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PharmaSupplyBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.PharmaSupplyBindingNavigator.TabIndex = 23
        Me.PharmaSupplyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PharmaSupplyBindingNavigatorSaveItem
        '
        Me.PharmaSupplyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PharmaSupplyBindingNavigatorSaveItem.Image = CType(resources.GetObject("PharmaSupplyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PharmaSupplyBindingNavigatorSaveItem.Name = "PharmaSupplyBindingNavigatorSaveItem"
        Me.PharmaSupplyBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.PharmaSupplyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PharmaSupplyDataGridView
        '
        Me.PharmaSupplyDataGridView.AutoGenerateColumns = False
        Me.PharmaSupplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PharmaSupplyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PharmaSupplyDataGridView.DataSource = Me.PharmaSupplyBindingSource
        Me.PharmaSupplyDataGridView.Location = New System.Drawing.Point(55, 94)
        Me.PharmaSupplyDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.PharmaSupplyDataGridView.Name = "PharmaSupplyDataGridView"
        Me.PharmaSupplyDataGridView.RowHeadersWidth = 51
        Me.PharmaSupplyDataGridView.RowTemplate.Height = 24
        Me.PharmaSupplyDataGridView.Size = New System.Drawing.Size(780, 209)
        Me.PharmaSupplyDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DrugID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DrugID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DrugName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DrugName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DrugDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DrugDesc"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Dosage"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Dosage"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MethodOfAdmin"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MethodOfAdmin"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "QtyInStock"
        Me.DataGridViewTextBoxColumn6.HeaderText = "QtyInStock"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ReorderLevel"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CostPerUnit"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CostPerUnit"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DrugIDTextBox
        '
        Me.DrugIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "DrugID", True))
        Me.DrugIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DrugIDTextBox.Location = New System.Drawing.Point(237, 339)
        Me.DrugIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugIDTextBox.Name = "DrugIDTextBox"
        Me.DrugIDTextBox.Size = New System.Drawing.Size(144, 23)
        Me.DrugIDTextBox.TabIndex = 24
        '
        'DrugNameTextBox
        '
        Me.DrugNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "DrugName", True))
        Me.DrugNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DrugNameTextBox.Location = New System.Drawing.Point(237, 366)
        Me.DrugNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugNameTextBox.Name = "DrugNameTextBox"
        Me.DrugNameTextBox.Size = New System.Drawing.Size(144, 23)
        Me.DrugNameTextBox.TabIndex = 26
        '
        'DrugDescTextBox
        '
        Me.DrugDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "DrugDesc", True))
        Me.DrugDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DrugDescTextBox.Location = New System.Drawing.Point(237, 393)
        Me.DrugDescTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugDescTextBox.Name = "DrugDescTextBox"
        Me.DrugDescTextBox.Size = New System.Drawing.Size(144, 23)
        Me.DrugDescTextBox.TabIndex = 28
        '
        'DosageTextBox
        '
        Me.DosageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "Dosage", True))
        Me.DosageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DosageTextBox.Location = New System.Drawing.Point(593, 337)
        Me.DosageTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DosageTextBox.Name = "DosageTextBox"
        Me.DosageTextBox.Size = New System.Drawing.Size(158, 23)
        Me.DosageTextBox.TabIndex = 30
        '
        'MethodOfAdminTextBox
        '
        Me.MethodOfAdminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "MethodOfAdmin", True))
        Me.MethodOfAdminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MethodOfAdminTextBox.Location = New System.Drawing.Point(593, 363)
        Me.MethodOfAdminTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MethodOfAdminTextBox.Name = "MethodOfAdminTextBox"
        Me.MethodOfAdminTextBox.Size = New System.Drawing.Size(158, 23)
        Me.MethodOfAdminTextBox.TabIndex = 32
        '
        'QtyInStockTextBox
        '
        Me.QtyInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "QtyInStock", True))
        Me.QtyInStockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QtyInStockTextBox.Location = New System.Drawing.Point(593, 390)
        Me.QtyInStockTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QtyInStockTextBox.Name = "QtyInStockTextBox"
        Me.QtyInStockTextBox.Size = New System.Drawing.Size(158, 23)
        Me.QtyInStockTextBox.TabIndex = 34
        '
        'ReorderLevelTextBox
        '
        Me.ReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "ReorderLevel", True))
        Me.ReorderLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ReorderLevelTextBox.Location = New System.Drawing.Point(593, 417)
        Me.ReorderLevelTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
        Me.ReorderLevelTextBox.Size = New System.Drawing.Size(158, 23)
        Me.ReorderLevelTextBox.TabIndex = 36
        '
        'CostPerUnitTextBox
        '
        Me.CostPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "CostPerUnit", True))
        Me.CostPerUnitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CostPerUnitTextBox.Location = New System.Drawing.Point(593, 444)
        Me.CostPerUnitTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CostPerUnitTextBox.Name = "CostPerUnitTextBox"
        Me.CostPerUnitTextBox.Size = New System.Drawing.Size(158, 23)
        Me.CostPerUnitTextBox.TabIndex = 38
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PharmaSupplyBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(237, 419)
        Me.SupplierIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(144, 23)
        Me.SupplierIDTextBox.TabIndex = 40
        '
        'Supplies_AddPharmaceutical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(DrugIDLabel)
        Me.Controls.Add(Me.DrugIDTextBox)
        Me.Controls.Add(DrugNameLabel)
        Me.Controls.Add(Me.DrugNameTextBox)
        Me.Controls.Add(DrugDescLabel)
        Me.Controls.Add(Me.DrugDescTextBox)
        Me.Controls.Add(DosageLabel)
        Me.Controls.Add(Me.DosageTextBox)
        Me.Controls.Add(MethodOfAdminLabel)
        Me.Controls.Add(Me.MethodOfAdminTextBox)
        Me.Controls.Add(QtyInStockLabel)
        Me.Controls.Add(Me.QtyInStockTextBox)
        Me.Controls.Add(ReorderLevelLabel)
        Me.Controls.Add(Me.ReorderLevelTextBox)
        Me.Controls.Add(CostPerUnitLabel)
        Me.Controls.Add(Me.CostPerUnitTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(Me.PharmaSupplyDataGridView)
        Me.Controls.Add(Me.PharmaSupplyBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Supplies_AddPharmaceutical"
        Me.Text = "Supplies_AddPharmaceutical"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaSupplyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PharmaSupplyBindingNavigator.ResumeLayout(False)
        Me.PharmaSupplyBindingNavigator.PerformLayout()
        CType(Me.PharmaSupplyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents PharmaSupplyBindingSource As BindingSource
    Friend WithEvents PharmaSupplyTableAdapter As WellmeadowsDBDataSetTableAdapters.PharmaSupplyTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PharmaSupplyBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PharmaSupplyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PharmaSupplyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DrugIDTextBox As TextBox
    Friend WithEvents DrugNameTextBox As TextBox
    Friend WithEvents DrugDescTextBox As TextBox
    Friend WithEvents DosageTextBox As TextBox
    Friend WithEvents MethodOfAdminTextBox As TextBox
    Friend WithEvents QtyInStockTextBox As TextBox
    Friend WithEvents ReorderLevelTextBox As TextBox
    Friend WithEvents CostPerUnitTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
End Class
