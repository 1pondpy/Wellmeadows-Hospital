<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplies_AddNonSurgicalSupply
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
        Dim NonSurItemIDLabel As System.Windows.Forms.Label
        Dim NonSurNameLabel As System.Windows.Forms.Label
        Dim NonSurDescLabel As System.Windows.Forms.Label
        Dim QtyInStockLabel As System.Windows.Forms.Label
        Dim ReorderLevelLabel As System.Windows.Forms.Label
        Dim CostPerUnitLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplies_AddNonSurgicalSupply))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.NonSurgicalSupplyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NonSurgicalSupplyTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.NonSurgicalSupplyTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.NonSurgicalSupplyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NonSurgicalSupplyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NonSurgicalSupplyDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NonSurItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.NonSurNameTextBox = New System.Windows.Forms.TextBox()
        Me.NonSurDescTextBox = New System.Windows.Forms.TextBox()
        Me.QtyInStockTextBox = New System.Windows.Forms.TextBox()
        Me.ReorderLevelTextBox = New System.Windows.Forms.TextBox()
        Me.CostPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        NonSurItemIDLabel = New System.Windows.Forms.Label()
        NonSurNameLabel = New System.Windows.Forms.Label()
        NonSurDescLabel = New System.Windows.Forms.Label()
        QtyInStockLabel = New System.Windows.Forms.Label()
        ReorderLevelLabel = New System.Windows.Forms.Label()
        CostPerUnitLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonSurgicalSupplyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NonSurgicalSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NonSurgicalSupplyBindingNavigator.SuspendLayout()
        CType(Me.NonSurgicalSupplyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NonSurItemIDLabel
        '
        NonSurItemIDLabel.AutoSize = True
        NonSurItemIDLabel.BackColor = System.Drawing.Color.White
        NonSurItemIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NonSurItemIDLabel.Location = New System.Drawing.Point(183, 364)
        NonSurItemIDLabel.Name = "NonSurItemIDLabel"
        NonSurItemIDLabel.Size = New System.Drawing.Size(60, 17)
        NonSurItemIDLabel.TabIndex = 2
        NonSurItemIDLabel.Text = "*Item ID:"
        '
        'NonSurNameLabel
        '
        NonSurNameLabel.AutoSize = True
        NonSurNameLabel.BackColor = System.Drawing.Color.White
        NonSurNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NonSurNameLabel.Location = New System.Drawing.Point(183, 392)
        NonSurNameLabel.Name = "NonSurNameLabel"
        NonSurNameLabel.Size = New System.Drawing.Size(84, 17)
        NonSurNameLabel.TabIndex = 4
        NonSurNameLabel.Text = "*Item Name:"
        '
        'NonSurDescLabel
        '
        NonSurDescLabel.AutoSize = True
        NonSurDescLabel.BackColor = System.Drawing.Color.White
        NonSurDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NonSurDescLabel.Location = New System.Drawing.Point(183, 420)
        NonSurDescLabel.Name = "NonSurDescLabel"
        NonSurDescLabel.Size = New System.Drawing.Size(83, 17)
        NonSurDescLabel.TabIndex = 6
        NonSurDescLabel.Text = "Description:"
        '
        'QtyInStockLabel
        '
        QtyInStockLabel.AutoSize = True
        QtyInStockLabel.BackColor = System.Drawing.Color.White
        QtyInStockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        QtyInStockLabel.Location = New System.Drawing.Point(183, 448)
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
        ReorderLevelLabel.Location = New System.Drawing.Point(450, 364)
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
        CostPerUnitLabel.Location = New System.Drawing.Point(450, 392)
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
        SupplierIDLabel.Location = New System.Drawing.Point(450, 420)
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
        Label1.Location = New System.Drawing.Point(76, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(166, 17)
        Label1.TabIndex = 16
        Label1.Text = "Add Non-Surgical Supply"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NonSurgicalSupplyBindingSource
        '
        Me.NonSurgicalSupplyBindingSource.DataMember = "NonSurgicalSupply"
        Me.NonSurgicalSupplyBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'NonSurgicalSupplyTableAdapter
        '
        Me.NonSurgicalSupplyTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.NonSurgicalSupplyTableAdapter = Me.NonSurgicalSupplyTableAdapter
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
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'NonSurgicalSupplyBindingNavigator
        '
        Me.NonSurgicalSupplyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NonSurgicalSupplyBindingNavigator.BindingSource = Me.NonSurgicalSupplyBindingSource
        Me.NonSurgicalSupplyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NonSurgicalSupplyBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NonSurgicalSupplyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NonSurgicalSupplyBindingNavigatorSaveItem})
        Me.NonSurgicalSupplyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NonSurgicalSupplyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NonSurgicalSupplyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NonSurgicalSupplyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NonSurgicalSupplyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NonSurgicalSupplyBindingNavigator.Name = "NonSurgicalSupplyBindingNavigator"
        Me.NonSurgicalSupplyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NonSurgicalSupplyBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.NonSurgicalSupplyBindingNavigator.TabIndex = 0
        Me.NonSurgicalSupplyBindingNavigator.Text = "BindingNavigator1"
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
        'NonSurgicalSupplyBindingNavigatorSaveItem
        '
        Me.NonSurgicalSupplyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NonSurgicalSupplyBindingNavigatorSaveItem.Image = CType(resources.GetObject("NonSurgicalSupplyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NonSurgicalSupplyBindingNavigatorSaveItem.Name = "NonSurgicalSupplyBindingNavigatorSaveItem"
        Me.NonSurgicalSupplyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NonSurgicalSupplyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NonSurgicalSupplyDataGridView
        '
        Me.NonSurgicalSupplyDataGridView.AutoGenerateColumns = False
        Me.NonSurgicalSupplyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NonSurgicalSupplyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.NonSurgicalSupplyDataGridView.DataSource = Me.NonSurgicalSupplyBindingSource
        Me.NonSurgicalSupplyDataGridView.Location = New System.Drawing.Point(73, 84)
        Me.NonSurgicalSupplyDataGridView.Name = "NonSurgicalSupplyDataGridView"
        Me.NonSurgicalSupplyDataGridView.Size = New System.Drawing.Size(746, 239)
        Me.NonSurgicalSupplyDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NonSurItemID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NonSurItemID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NonSurName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NonSurName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NonSurDesc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NonSurDesc"
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
        'NonSurItemIDTextBox
        '
        Me.NonSurItemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "NonSurItemID", True))
        Me.NonSurItemIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NonSurItemIDTextBox.Location = New System.Drawing.Point(282, 362)
        Me.NonSurItemIDTextBox.Name = "NonSurItemIDTextBox"
        Me.NonSurItemIDTextBox.Size = New System.Drawing.Size(137, 23)
        Me.NonSurItemIDTextBox.TabIndex = 3
        '
        'NonSurNameTextBox
        '
        Me.NonSurNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "NonSurName", True))
        Me.NonSurNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NonSurNameTextBox.Location = New System.Drawing.Point(282, 390)
        Me.NonSurNameTextBox.Name = "NonSurNameTextBox"
        Me.NonSurNameTextBox.Size = New System.Drawing.Size(137, 23)
        Me.NonSurNameTextBox.TabIndex = 5
        '
        'NonSurDescTextBox
        '
        Me.NonSurDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "NonSurDesc", True))
        Me.NonSurDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NonSurDescTextBox.Location = New System.Drawing.Point(282, 418)
        Me.NonSurDescTextBox.Name = "NonSurDescTextBox"
        Me.NonSurDescTextBox.Size = New System.Drawing.Size(137, 23)
        Me.NonSurDescTextBox.TabIndex = 7
        '
        'QtyInStockTextBox
        '
        Me.QtyInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "QtyInStock", True))
        Me.QtyInStockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QtyInStockTextBox.Location = New System.Drawing.Point(282, 446)
        Me.QtyInStockTextBox.Name = "QtyInStockTextBox"
        Me.QtyInStockTextBox.Size = New System.Drawing.Size(137, 23)
        Me.QtyInStockTextBox.TabIndex = 9
        '
        'ReorderLevelTextBox
        '
        Me.ReorderLevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "ReorderLevel", True))
        Me.ReorderLevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ReorderLevelTextBox.Location = New System.Drawing.Point(558, 362)
        Me.ReorderLevelTextBox.Name = "ReorderLevelTextBox"
        Me.ReorderLevelTextBox.Size = New System.Drawing.Size(121, 23)
        Me.ReorderLevelTextBox.TabIndex = 11
        '
        'CostPerUnitTextBox
        '
        Me.CostPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "CostPerUnit", True))
        Me.CostPerUnitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CostPerUnitTextBox.Location = New System.Drawing.Point(558, 390)
        Me.CostPerUnitTextBox.Name = "CostPerUnitTextBox"
        Me.CostPerUnitTextBox.Size = New System.Drawing.Size(121, 23)
        Me.CostPerUnitTextBox.TabIndex = 13
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NonSurgicalSupplyBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(558, 418)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(121, 23)
        Me.SupplierIDTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(560, 445)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Supplier Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(684, 416)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 24)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Supplies_AddNonSurgicalSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 582)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(NonSurItemIDLabel)
        Me.Controls.Add(Me.NonSurItemIDTextBox)
        Me.Controls.Add(NonSurNameLabel)
        Me.Controls.Add(Me.NonSurNameTextBox)
        Me.Controls.Add(NonSurDescLabel)
        Me.Controls.Add(Me.NonSurDescTextBox)
        Me.Controls.Add(QtyInStockLabel)
        Me.Controls.Add(Me.QtyInStockTextBox)
        Me.Controls.Add(ReorderLevelLabel)
        Me.Controls.Add(Me.ReorderLevelTextBox)
        Me.Controls.Add(CostPerUnitLabel)
        Me.Controls.Add(Me.CostPerUnitTextBox)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
        Me.Controls.Add(Me.NonSurgicalSupplyDataGridView)
        Me.Controls.Add(Me.NonSurgicalSupplyBindingNavigator)
        Me.Name = "Supplies_AddNonSurgicalSupply"
        Me.Text = "Supplies_AddNonSurgicalSupply"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonSurgicalSupplyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NonSurgicalSupplyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NonSurgicalSupplyBindingNavigator.ResumeLayout(False)
        Me.NonSurgicalSupplyBindingNavigator.PerformLayout()
        CType(Me.NonSurgicalSupplyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents NonSurgicalSupplyBindingSource As BindingSource
    Friend WithEvents NonSurgicalSupplyTableAdapter As WellmeadowsDBDataSetTableAdapters.NonSurgicalSupplyTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NonSurgicalSupplyBindingNavigator As BindingNavigator
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
    Friend WithEvents NonSurgicalSupplyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NonSurgicalSupplyDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents NonSurItemIDTextBox As TextBox
    Friend WithEvents NonSurNameTextBox As TextBox
    Friend WithEvents NonSurDescTextBox As TextBox
    Friend WithEvents QtyInStockTextBox As TextBox
    Friend WithEvents ReorderLevelTextBox As TextBox
    Friend WithEvents CostPerUnitTextBox As TextBox
    Friend WithEvents SupplierIDTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
