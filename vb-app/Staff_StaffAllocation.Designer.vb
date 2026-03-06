<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_StaffAllocation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim StaffAllocationIDLabel As System.Windows.Forms.Label
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim WeekIDLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_StaffAllocation))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.StaffAllocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffAllocationTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.StaffAllocationTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.StaffAllocationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StaffAllocationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffAllocationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffAllocationIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardTextBox = New System.Windows.Forms.TextBox()
        Me.WeekTextBox = New System.Windows.Forms.TextBox()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStaffAllocation = New System.Windows.Forms.Button()
        Me.StaffAllo = New System.Windows.Forms.Label()
        Me.SearchWardAllo = New System.Windows.Forms.Button()
        Me.SearchWeekAllo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        StaffAllocationIDLabel = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        WeekIDLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffAllocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffAllocationBindingNavigator.SuspendLayout()
        CType(Me.StaffAllocationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffAllocationIDLabel
        '
        StaffAllocationIDLabel.AutoSize = True
        StaffAllocationIDLabel.BackColor = System.Drawing.Color.White
        StaffAllocationIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffAllocationIDLabel.Location = New System.Drawing.Point(300, 291)
        StaffAllocationIDLabel.Name = "StaffAllocationIDLabel"
        StaffAllocationIDLabel.Size = New System.Drawing.Size(128, 17)
        StaffAllocationIDLabel.TabIndex = 2
        StaffAllocationIDLabel.Text = "*Staff Allocation ID:"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.White
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffIDLabel.Location = New System.Drawing.Point(300, 322)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(63, 17)
        StaffIDLabel.TabIndex = 4
        StaffIDLabel.Text = "*Staff ID:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.White
        WardIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WardIDLabel.Location = New System.Drawing.Point(300, 374)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(68, 17)
        WardIDLabel.TabIndex = 6
        WardIDLabel.Text = "*Ward ID:"
        '
        'WeekIDLabel
        '
        WeekIDLabel.AutoSize = True
        WeekIDLabel.BackColor = System.Drawing.Color.White
        WeekIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WeekIDLabel.Location = New System.Drawing.Point(300, 427)
        WeekIDLabel.Name = "WeekIDLabel"
        WeekIDLabel.Size = New System.Drawing.Size(70, 17)
        WeekIDLabel.TabIndex = 8
        WeekIDLabel.Text = "*Week ID:"
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.AutoSize = True
        ShiftNameLabel.BackColor = System.Drawing.Color.White
        ShiftNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ShiftNameLabel.Location = New System.Drawing.Point(300, 484)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(86, 17)
        ShiftNameLabel.TabIndex = 10
        ShiftNameLabel.Text = "*Shift Name:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffAllocationBindingSource
        '
        Me.StaffAllocationBindingSource.DataMember = "StaffAllocation"
        Me.StaffAllocationBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'StaffAllocationTableAdapter
        '
        Me.StaffAllocationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Nothing
        Me.TableAdapterManager.InpatientTableAdapter = Nothing
        Me.TableAdapterManager.LocalDoctorTableAdapter = Nothing
        Me.TableAdapterManager.MedRecordTableAdapter = Nothing
        Me.TableAdapterManager.NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager.NonSurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PharmaSupplyTableAdapter = Nothing
        Me.TableAdapterManager.RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.StaffAllocationTableAdapter = Me.StaffAllocationTableAdapter
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
        'StaffAllocationBindingNavigator
        '
        Me.StaffAllocationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffAllocationBindingNavigator.BindingSource = Me.StaffAllocationBindingSource
        Me.StaffAllocationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffAllocationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffAllocationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffAllocationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffAllocationBindingNavigatorSaveItem})
        Me.StaffAllocationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffAllocationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffAllocationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffAllocationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffAllocationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffAllocationBindingNavigator.Name = "StaffAllocationBindingNavigator"
        Me.StaffAllocationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffAllocationBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.StaffAllocationBindingNavigator.TabIndex = 0
        Me.StaffAllocationBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'StaffAllocationBindingNavigatorSaveItem
        '
        Me.StaffAllocationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffAllocationBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffAllocationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffAllocationBindingNavigatorSaveItem.Name = "StaffAllocationBindingNavigatorSaveItem"
        Me.StaffAllocationBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.StaffAllocationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffAllocationDataGridView
        '
        Me.StaffAllocationDataGridView.AutoGenerateColumns = False
        Me.StaffAllocationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffAllocationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.StaffAllocationDataGridView.DataSource = Me.StaffAllocationBindingSource
        Me.StaffAllocationDataGridView.Location = New System.Drawing.Point(90, 78)
        Me.StaffAllocationDataGridView.Name = "StaffAllocationDataGridView"
        Me.StaffAllocationDataGridView.RowHeadersWidth = 51
        Me.StaffAllocationDataGridView.Size = New System.Drawing.Size(700, 188)
        Me.StaffAllocationDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StaffAllocationID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StaffAllocationID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "WardID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "WardID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "WeekID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "WeekID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ShiftName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ShiftName"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'StaffAllocationIDTextBox
        '
        Me.StaffAllocationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffAllocationBindingSource, "StaffAllocationID", True))
        Me.StaffAllocationIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffAllocationIDTextBox.Location = New System.Drawing.Point(437, 288)
        Me.StaffAllocationIDTextBox.Name = "StaffAllocationIDTextBox"
        Me.StaffAllocationIDTextBox.Size = New System.Drawing.Size(146, 23)
        Me.StaffAllocationIDTextBox.TabIndex = 3
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffAllocationBindingSource, "StaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(437, 319)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(146, 23)
        Me.StaffIDTextBox.TabIndex = 5
        '
        'WardTextBox
        '
        Me.WardTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffAllocationBindingSource, "WardID", True))
        Me.WardTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WardTextBox.Location = New System.Drawing.Point(437, 371)
        Me.WardTextBox.Name = "WardTextBox"
        Me.WardTextBox.Size = New System.Drawing.Size(146, 23)
        Me.WardTextBox.TabIndex = 7
        '
        'WeekTextBox
        '
        Me.WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffAllocationBindingSource, "WeekID", True))
        Me.WeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WeekTextBox.Location = New System.Drawing.Point(437, 424)
        Me.WeekTextBox.Name = "WeekTextBox"
        Me.WeekTextBox.Size = New System.Drawing.Size(146, 23)
        Me.WeekTextBox.TabIndex = 9
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffAllocationBindingSource, "ShiftName", True))
        Me.ShiftNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Items.AddRange(New Object() {"Morning", "Afternoon", "Night"})
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(437, 481)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(146, 24)
        Me.ShiftNameComboBox.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(437, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Staff Name"
        '
        'SearchStaffAllocation
        '
        Me.SearchStaffAllocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchStaffAllocation.Location = New System.Drawing.Point(597, 318)
        Me.SearchStaffAllocation.Name = "SearchStaffAllocation"
        Me.SearchStaffAllocation.Size = New System.Drawing.Size(40, 23)
        Me.SearchStaffAllocation.TabIndex = 24
        Me.SearchStaffAllocation.Text = "....."
        Me.SearchStaffAllocation.UseVisualStyleBackColor = True
        '
        'StaffAllo
        '
        Me.StaffAllo.AutoSize = True
        Me.StaffAllo.BackColor = System.Drawing.Color.White
        Me.StaffAllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffAllo.Location = New System.Drawing.Point(90, 45)
        Me.StaffAllo.Name = "StaffAllo"
        Me.StaffAllo.Size = New System.Drawing.Size(102, 17)
        Me.StaffAllo.TabIndex = 26
        Me.StaffAllo.Text = "Staff Allocation"
        '
        'SearchWardAllo
        '
        Me.SearchWardAllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchWardAllo.Location = New System.Drawing.Point(597, 368)
        Me.SearchWardAllo.Name = "SearchWardAllo"
        Me.SearchWardAllo.Size = New System.Drawing.Size(40, 23)
        Me.SearchWardAllo.TabIndex = 27
        Me.SearchWardAllo.Text = "....."
        Me.SearchWardAllo.UseVisualStyleBackColor = True
        '
        'SearchWeekAllo
        '
        Me.SearchWeekAllo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchWeekAllo.Location = New System.Drawing.Point(597, 422)
        Me.SearchWeekAllo.Name = "SearchWeekAllo"
        Me.SearchWeekAllo.Size = New System.Drawing.Size(40, 23)
        Me.SearchWeekAllo.TabIndex = 28
        Me.SearchWeekAllo.Text = "....."
        Me.SearchWeekAllo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(437, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Ward Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(437, 453)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Start Date"
        '
        'Staff_StaffAllocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchWeekAllo)
        Me.Controls.Add(Me.SearchWardAllo)
        Me.Controls.Add(Me.StaffAllo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffAllocation)
        Me.Controls.Add(ShiftNameLabel)
        Me.Controls.Add(Me.ShiftNameComboBox)
        Me.Controls.Add(StaffAllocationIDLabel)
        Me.Controls.Add(Me.StaffAllocationIDTextBox)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardTextBox)
        Me.Controls.Add(WeekIDLabel)
        Me.Controls.Add(Me.WeekTextBox)
        Me.Controls.Add(Me.StaffAllocationDataGridView)
        Me.Controls.Add(Me.StaffAllocationBindingNavigator)
        Me.Name = "Staff_StaffAllocation"
        Me.Text = "Staff_StaffAllocation"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffAllocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffAllocationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffAllocationBindingNavigator.ResumeLayout(False)
        Me.StaffAllocationBindingNavigator.PerformLayout()
        CType(Me.StaffAllocationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents StaffAllocationBindingSource As BindingSource
    Friend WithEvents StaffAllocationTableAdapter As WellmeadowsDBDataSetTableAdapters.StaffAllocationTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffAllocationBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffAllocationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffAllocationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents StaffAllocationIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents WardTextBox As TextBox
    Friend WithEvents WeekTextBox As TextBox
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchStaffAllocation As Button
    Friend WithEvents StaffAllo As Label
    Friend WithEvents SearchWardAllo As Button
    Friend WithEvents SearchWeekAllo As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
