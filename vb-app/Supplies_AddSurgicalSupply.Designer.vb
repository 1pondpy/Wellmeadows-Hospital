<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplies_AddSurgicalSupply
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
        Dim SurItemIDLabel As System.Windows.Forms.Label
        Dim SurNameLabel As System.Windows.Forms.Label
        Dim SurDescLabel As System.Windows.Forms.Label
        Dim QtyInStockLabel As System.Windows.Forms.Label
        Dim ReorderLevelLabel As System.Windows.Forms.Label
        Dim CostPerUnitLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplies_AddSurgicalSupply))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.SurgicalSupplyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SurgicalSupplyTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.SurgicalSupplyTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.SurgicalSupplyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SurgicalSupplyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SurgicalSupplyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.SurNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurDescTextBox = New System.Windows.Forms.TextBox()
        Me.QtyInStockTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.CostPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        SurItemIDLabel = New System.Windows.Forms.Label()
        SurNameLabel = New System.Windows.Forms.Label()
        SurDescLabel = New System.Windows.Forms.Label()
        QtyInStockLabel = New System.Windows.Forms.Label()
        ReorderLevelLabel = New System.Windows.Forms.Label()
        CostPerUnitLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurgicalSupplyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurgicalSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SurgicalSupplyBindingNavigator.SuspendLayout()
        CType(Me.SurgicalSupplyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SurItemIDLabel
        '
        SurItemIDLabel.AutoSize = True
        SurItemIDLabel.BackColor = System.Drawing.Color.White
        SurItemIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SurItemIDLabel.Location = New System.Drawing.Point(181, 361)
        SurItemIDLabel.Name = "SurItemIDLabel"
        SurItemIDLabel.Size = New System.Drawing.Size(60, 17)
        SurItemIDLabel.TabIndex = 2
        SurItemIDLabel.Text = "*Item ID:"
        '
        'SurNameLabel
        '
        SurNameLabel.AutoSize = True
        SurNameLabel.BackColor = System.Drawing.Color.White
        SurNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SurNameLabel.Location = New System.Drawing.Point(181, 389)
        SurNameLabel.Name = "SurNameLabel"
        SurNameLabel.Size = New System.Drawing.Size(84, 17)
        SurNameLabel.TabIndex = 4
        SurNameLabel.Text = "*Item Name:"
        '
        'SurDescLabel
        '
        SurDescLabel.AutoSize = True
        SurDescLabel.BackColor = System.Drawing.Color.White
        SurDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SurDescLabel.Location = New System.Drawing.Point(182, 418)
        SurDescLabel.Name = "SurDescLabel"
        SurDescLabel.Size = New System.Drawing.Size(83, 17)
        SurDescLabel.TabIndex = 6
        SurDescLabel.Text = "Description:"
        '
        'QtyInStockLabel
        '
        QtyInStockLabel.AutoSize = True
        QtyInStockLabel.BackColor = System.Drawing.Color.White
        QtyInStockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        QtyInStockLabel.Location = New System.Drawing.Point(181, 445)
        QtyInStockLabel.Name = "QtyInStockLabel"
        QtyInStockLabel.Size = New System.Drawing.Size(93, 17)
        QtyInStockLabel.TabIndex = 8
        QtyInStockLabel.Text = "*Qty In Stock:"
        '
        'ReorderLevelLabel
        '
        ReorderLevelLabel.AutoSize = True
        ReorderLevelLabel.BackColor = System.Drawing.Color.White
        ReorderLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ReorderLevelLabel.Location = New System.Drawing.Point(434, 361)
        ReorderLevelLabel.Name = "ReorderLevelLabel"
        ReorderLevelLabel.Size = New System.Drawing.Size(102, 17)
        ReorderLevelLabel.TabIndex = 10
        ReorderLevelLabel.Text = "Reorder Level:"
        '
        'CostPerUnitLabel
        '
        CostPerUnitLabel.AutoSize = True
        CostPerUnitLabel.BackColor = System.Drawing.Color.White
        CostPerUnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        CostPerUnitLabel.Location = New System.Drawing.Point(434, 389)
        CostPerUnitLabel.Name = "CostPerUnitLabel"
        CostPerUnitLabel.Size = New System.Drawing.Size(95, 17)
        CostPerUnitLabel.TabIndex = 12
        CostPerUnitLabel.Text = "Cost Per Unit:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.BackColor = System.Drawing.Color.White
        SupplierIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SupplierIDLabel.Location = New System.Drawing.Point(434, 433)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(86, 17)
        SupplierIDLabel.TabIndex = 14
        SupplierIDLabel.Text = "*Supplier ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.White
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Label1.Location = New System.Drawing.Point(66, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(135, 17)
        Label1.TabIndex = 25
        Label1.Text = "Add Surgical Supply"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SurgicalSupplyBindingSource
        '
        Me.SurgicalSupplyBindingSource.DataMember = "SurgicalSupply"
        Me.SurgicalSupplyBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'SurgicalSupplyTableAdapter
        '
        Me.SurgicalSupplyTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PharmaSupplyTableAdapter = Nothing
        Me.TableAdapterManager.RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.StaffAllocationTableAdapter = Nothing
        Me.TableAdapterManager.StaffQualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Me.SurgicalSupplyTableAdapter
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'SurgicalSupplyBindingNavigator
        '
        Me.SurgicalSupplyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SurgicalSupplyBindingNavigator.BindingSource = Me.SurgicalSupplyBindingSource
        Me.SurgicalSupplyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SurgicalSupplyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SurgicalSupplyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SurgicalSupplyBindingNavigatorSaveItem})
        Me.SurgicalSupplyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SurgicalSupplyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SurgicalSupplyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SurgicalSupplyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SurgicalSupplyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SurgicalSupplyBindingNavigator.Name = "SurgicalSupplyBindingNavigator"
        Me.SurgicalSupplyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SurgicalSupplyBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.SurgicalSupplyBindingNavigator.TabIndex = 0
        Me.SurgicalSupplyBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SurgicalSupplyBindingNavigatorSaveItem
        '
        Me.SurgicalSupplyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SurgicalSupplyBindingNavigatorSaveItem.Image = CType(resources.GetObject("SurgicalSupplyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SurgicalSupplyBindingNavigatorSaveItem.Name = "SurgicalSupplyBindingNavigatorSaveItem"
        Me.SurgicalSupplyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SurgicalSupplyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SurgicalSupplyDataGridView
        '
        Me.SurgicalSupplyDataGridView.AutoGenerateColumns = False
        Me.SurgicalSupplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SurgicalSupplyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SurgicalSupplyDataGridView.DataSource = Me.SurgicalSupplyBindingSource
        Me.SurgicalSupplyDataGridView.Location = New System.Drawing.Point(69, 81)
        Me.SurgicalSupplyDataGridView.Name = "SurgicalSupplyDataGridView"
        Me.SurgicalSupplyDataGridView.Size = New System.Drawing.Size(746, 242)
        Me.SurgicalSupplyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SurItemID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SurItemID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SurName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SurName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SurDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SurDesc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "QtyInStock"
        Me.DataGridViewTextBoxColumn4.HeaderText = "QtyInStock"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ReorderLevel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CostPerUnit"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CostPerUnit"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'SurItemIDTextBox
        '
        Me.SurItemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "SurItemID", True))
        Me.SurItemIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SurItemIDTextBox.Location = New System.Drawing.Point(281, 359)
        Me.SurItemIDTextBox.Name = "SurItemIDTextBox"
        Me.SurItemIDTextBox.Size = New System.Drawing.Size(131, 23)
        Me.SurItemIDTextBox.TabIndex = 3
        '
        'SurNameTextBox
        '
        Me.SurNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "SurName", True))
        Me.SurNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SurNameTextBox.Location = New System.Drawing.Point(281, 387)
        Me.SurNameTextBox.Name = "SurNameTextBox"
        Me.SurNameTextBox.Size = New System.Drawing.Size(131, 23)
        Me.SurNameTextBox.TabIndex = 5
        '
        'SurDescTextBox
        '
        Me.SurDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "SurDesc", True))
        Me.SurDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SurDescTextBox.Location = New System.Drawing.Point(281, 415)
        Me.SurDescTextBox.Name = "SurDescTextBox"
        Me.SurDescTextBox.Size = New System.Drawing.Size(131, 23)
        Me.SurDescTextBox.TabIndex = 7
        '
        'QtyInStockTextBox
        '
        Me.QtyInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "QtyInStock", True))
        Me.QtyInStockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QtyInStockTextBox.Location = New System.Drawing.Point(281, 443)
        Me.QtyInStockTextBox.Name = "QtyInStockTextBox"
        Me.QtyInStockTextBox.Size = New System.Drawing.Size(131, 23)
        Me.QtyInStockTextBox.TabIndex = 9
        '
        'ReorderLevelTextBox
        '
        Me.ReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "ReorderLevel", True))
        Me.ReorderLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ReorderLevelTextBox.Location = New System.Drawing.Point(542, 358)
        Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
        Me.ReorderLevelTextBox.Size = New System.Drawing.Size(121, 23)
        Me.ReorderLevelTextBox.TabIndex = 11
        '
        'CostPerUnitTextBox
        '
        Me.CostPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "CostPerUnit", True))
        Me.CostPerUnitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CostPerUnitTextBox.Location = New System.Drawing.Point(542, 386)
        Me.CostPerUnitTextBox.Name = "CostPerUnitTextBox"
        Me.CostPerUnitTextBox.Size = New System.Drawing.Size(121, 23)
        Me.CostPerUnitTextBox.TabIndex = 13
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalSupplyBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(542, 430)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(120, 23)
        Me.SupplierIDTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(543, 456)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Supplier Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(667, 430)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 24)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Supplies_AddSurgicalSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 586)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SurItemIDLabel)
        Me.Controls.Add(Me.SurItemIDTextBox)
        Me.Controls.Add(SurNameLabel)
        Me.Controls.Add(Me.SurNameTextBox)
        Me.Controls.Add(SurDescLabel)
        Me.Controls.Add(Me.SurDescTextBox)
        Me.Controls.Add(QtyInStockLabel)
        Me.Controls.Add(Me.QtyInStockTextBox)
        Me.Controls.Add(ReorderLevelLabel)
        Me.Controls.Add(Me.ReorderLevelTextBox)
        Me.Controls.Add(CostPerUnitLabel)
        Me.Controls.Add(Me.CostPerUnitTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(Me.SurgicalSupplyDataGridView)
        Me.Controls.Add(Me.SurgicalSupplyBindingNavigator)
        Me.Name = "Supplies_AddSurgicalSupply"
        Me.Text = "Supplies_AddSurgicalSupply"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurgicalSupplyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurgicalSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SurgicalSupplyBindingNavigator.ResumeLayout(False)
        Me.SurgicalSupplyBindingNavigator.PerformLayout()
        CType(Me.SurgicalSupplyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents SurgicalSupplyBindingSource As BindingSource
    Friend WithEvents SurgicalSupplyTableAdapter As WellmeadowsDBDataSetTableAdapters.SurgicalSupplyTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SurgicalSupplyBindingNavigator As BindingNavigator
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
    Friend WithEvents SurgicalSupplyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SurgicalSupplyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents SurItemIDTextBox As TextBox
    Friend WithEvents SurNameTextBox As TextBox
    Friend WithEvents SurDescTextBox As TextBox
    Friend WithEvents QtyInStockTextBox As TextBox
    Friend WithEvents ReorderLevelTextBox As TextBox
    Friend WithEvents CostPerUnitTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
