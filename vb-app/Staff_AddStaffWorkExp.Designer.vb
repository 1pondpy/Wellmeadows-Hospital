<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_AddStaffWorkExp
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
        Dim ExpIDLabel As System.Windows.Forms.Label
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_AddStaffWorkExp))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.StaffWorkExpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffWorkExpTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.StaffWorkExpTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.StaffWorkExpBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StaffWorkExpBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ExpIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SearchStaffWorkExp = New System.Windows.Forms.Button()
        Me.StaffWorkExpDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddWorkExp = New System.Windows.Forms.Label()
        ExpIDLabel = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffWorkExpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffWorkExpBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffWorkExpBindingNavigator.SuspendLayout()
        CType(Me.StaffWorkExpDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExpIDLabel
        '
        ExpIDLabel.AutoSize = True
        ExpIDLabel.BackColor = System.Drawing.Color.White
        ExpIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ExpIDLabel.Location = New System.Drawing.Point(229, 368)
        ExpIDLabel.Name = "ExpIDLabel"
        ExpIDLabel.Size = New System.Drawing.Size(57, 17)
        ExpIDLabel.TabIndex = 1
        ExpIDLabel.Text = "*Exp ID:"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.White
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffIDLabel.Location = New System.Drawing.Point(229, 306)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(63, 17)
        StaffIDLabel.TabIndex = 3
        StaffIDLabel.Text = "*Staff ID:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.AutoSize = True
        OrganizationLabel.BackColor = System.Drawing.Color.White
        OrganizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        OrganizationLabel.Location = New System.Drawing.Point(229, 395)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(98, 17)
        OrganizationLabel.TabIndex = 5
        OrganizationLabel.Text = "*Organization:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.BackColor = System.Drawing.Color.White
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PositionLabel.Location = New System.Drawing.Point(229, 421)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(67, 17)
        PositionLabel.TabIndex = 7
        PositionLabel.Text = "*Position:"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.BackColor = System.Drawing.Color.White
        StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StartDateLabel.Location = New System.Drawing.Point(229, 448)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(81, 17)
        StartDateLabel.TabIndex = 9
        StartDateLabel.Text = "*Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.BackColor = System.Drawing.Color.White
        EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        EndDateLabel.Location = New System.Drawing.Point(229, 474)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(76, 17)
        EndDateLabel.TabIndex = 11
        EndDateLabel.Text = "*End Date:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffWorkExpBindingSource
        '
        Me.StaffWorkExpBindingSource.DataMember = "StaffWorkExp"
        Me.StaffWorkExpBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'StaffWorkExpTableAdapter
        '
        Me.StaffWorkExpTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffAllocationTableAdapter = Nothing
        Me.TableAdapterManager.StaffQualificationTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Me.StaffWorkExpTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'StaffWorkExpBindingNavigator
        '
        Me.StaffWorkExpBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffWorkExpBindingNavigator.BindingSource = Me.StaffWorkExpBindingSource
        Me.StaffWorkExpBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffWorkExpBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffWorkExpBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffWorkExpBindingNavigatorSaveItem})
        Me.StaffWorkExpBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffWorkExpBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffWorkExpBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffWorkExpBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffWorkExpBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffWorkExpBindingNavigator.Name = "StaffWorkExpBindingNavigator"
        Me.StaffWorkExpBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffWorkExpBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.StaffWorkExpBindingNavigator.TabIndex = 0
        Me.StaffWorkExpBindingNavigator.Text = "BindingNavigator1"
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
        'StaffWorkExpBindingNavigatorSaveItem
        '
        Me.StaffWorkExpBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffWorkExpBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffWorkExpBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffWorkExpBindingNavigatorSaveItem.Name = "StaffWorkExpBindingNavigatorSaveItem"
        Me.StaffWorkExpBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StaffWorkExpBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ExpIDTextBox
        '
        Me.ExpIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffWorkExpBindingSource, "ExpID", True))
        Me.ExpIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ExpIDTextBox.Location = New System.Drawing.Point(338, 365)
        Me.ExpIDTextBox.Name = "ExpIDTextBox"
        Me.ExpIDTextBox.Size = New System.Drawing.Size(248, 23)
        Me.ExpIDTextBox.TabIndex = 2
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffWorkExpBindingSource, "StaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(338, 303)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(118, 23)
        Me.StaffIDTextBox.TabIndex = 4
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffWorkExpBindingSource, "Organization", True))
        Me.OrganizationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OrganizationTextBox.Location = New System.Drawing.Point(338, 392)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(248, 23)
        Me.OrganizationTextBox.TabIndex = 6
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffWorkExpBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PositionTextBox.Location = New System.Drawing.Point(338, 418)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(248, 23)
        Me.PositionTextBox.TabIndex = 8
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffWorkExpBindingSource, "StartDate", True))
        Me.StartDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(338, 444)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(248, 23)
        Me.StartDateDateTimePicker.TabIndex = 10
        '
        'EndDateDateTimePicker
        '
        Me.EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffWorkExpBindingSource, "EndDate", True))
        Me.EndDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EndDateDateTimePicker.Location = New System.Drawing.Point(338, 470)
        Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
        Me.EndDateDateTimePicker.Size = New System.Drawing.Size(248, 23)
        Me.EndDateDateTimePicker.TabIndex = 12
        '
        'SearchStaffWorkExp
        '
        Me.SearchStaffWorkExp.Location = New System.Drawing.Point(462, 303)
        Me.SearchStaffWorkExp.Name = "SearchStaffWorkExp"
        Me.SearchStaffWorkExp.Size = New System.Drawing.Size(38, 23)
        Me.SearchStaffWorkExp.TabIndex = 24
        Me.SearchStaffWorkExp.Text = "....."
        Me.SearchStaffWorkExp.UseVisualStyleBackColor = True
        '
        'StaffWorkExpDataGridView
        '
        Me.StaffWorkExpDataGridView.AutoGenerateColumns = False
        Me.StaffWorkExpDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffWorkExpDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StaffWorkExpDataGridView.DataSource = Me.StaffWorkExpBindingSource
        Me.StaffWorkExpDataGridView.Location = New System.Drawing.Point(51, 81)
        Me.StaffWorkExpDataGridView.Name = "StaffWorkExpDataGridView"
        Me.StaffWorkExpDataGridView.Size = New System.Drawing.Size(773, 194)
        Me.StaffWorkExpDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ExpID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ExpID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Organization"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Organization"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "EndDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "EndDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(341, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Staff Name"
        '
        'AddWorkExp
        '
        Me.AddWorkExp.AutoSize = True
        Me.AddWorkExp.BackColor = System.Drawing.Color.White
        Me.AddWorkExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddWorkExp.Location = New System.Drawing.Point(48, 45)
        Me.AddWorkExp.Name = "AddWorkExp"
        Me.AddWorkExp.Size = New System.Drawing.Size(177, 17)
        Me.AddWorkExp.TabIndex = 26
        Me.AddWorkExp.Text = "Add Staff Work Experience"
        '
        'Staff_AddStaffWorkExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AddWorkExp)
        Me.Controls.Add(Me.StaffWorkExpDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffWorkExp)
        Me.Controls.Add(ExpIDLabel)
        Me.Controls.Add(Me.ExpIDTextBox)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(OrganizationLabel)
        Me.Controls.Add(Me.OrganizationTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(StartDateLabel)
        Me.Controls.Add(Me.StartDateDateTimePicker)
        Me.Controls.Add(EndDateLabel)
        Me.Controls.Add(Me.EndDateDateTimePicker)
        Me.Controls.Add(Me.StaffWorkExpBindingNavigator)
        Me.Name = "Staff_AddStaffWorkExp"
        Me.Text = "Staff_AddStaffWorkExp"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffWorkExpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffWorkExpBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffWorkExpBindingNavigator.ResumeLayout(False)
        Me.StaffWorkExpBindingNavigator.PerformLayout()
        CType(Me.StaffWorkExpDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents StaffWorkExpBindingSource As BindingSource
    Friend WithEvents StaffWorkExpTableAdapter As WellmeadowsDBDataSetTableAdapters.StaffWorkExpTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffWorkExpBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffWorkExpBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ExpIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents StartDateDateTimePicker As DateTimePicker
    Friend WithEvents EndDateDateTimePicker As DateTimePicker
    Friend WithEvents SearchStaffWorkExp As Button
    Friend WithEvents StaffWorkExpDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents AddWorkExp As Label
End Class
