<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_NextOfKin
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
        Dim NextOfKinIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_NextOfKin))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.NextOfKinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NextOfKinTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.NextOfKinTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.NextOfKinBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.NextOfKinBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NextOfKinDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NextOfKinIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStaffQual = New System.Windows.Forms.Button()
        NextOfKinIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NextOfKinBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NextOfKinBindingNavigator.SuspendLayout()
        CType(Me.NextOfKinDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NextOfKinIDLabel
        '
        NextOfKinIDLabel.AutoSize = True
        NextOfKinIDLabel.BackColor = System.Drawing.Color.White
        NextOfKinIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NextOfKinIDLabel.Location = New System.Drawing.Point(386, 327)
        NextOfKinIDLabel.Name = "NextOfKinIDLabel"
        NextOfKinIDLabel.Size = New System.Drawing.Size(105, 17)
        NextOfKinIDLabel.TabIndex = 2
        NextOfKinIDLabel.Text = "*Next Of Kin ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.White
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        FirstNameLabel.Location = New System.Drawing.Point(386, 354)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(85, 17)
        FirstNameLabel.TabIndex = 4
        FirstNameLabel.Text = "*First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.BackColor = System.Drawing.Color.White
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        LastNameLabel.Location = New System.Drawing.Point(386, 381)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(85, 17)
        LastNameLabel.TabIndex = 6
        LastNameLabel.Text = "*Last Name:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.BackColor = System.Drawing.Color.White
        RelationshipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        RelationshipLabel.Location = New System.Drawing.Point(386, 408)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(95, 17)
        RelationshipLabel.TabIndex = 8
        RelationshipLabel.Text = "*Relationship:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AddressLabel.Location = New System.Drawing.Point(386, 435)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 17)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "*Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.White
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PhoneLabel.Location = New System.Drawing.Point(386, 462)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 12
        PhoneLabel.Text = "Phone:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(85, 327)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(78, 17)
        PatientIDLabel.TabIndex = 14
        PatientIDLabel.Text = "*Patient ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.White
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Label2.Location = New System.Drawing.Point(49, 44)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(156, 17)
        Label2.TabIndex = 26
        Label2.Text = "Add Patient Next Of Kin"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NextOfKinBindingSource
        '
        Me.NextOfKinBindingSource.DataMember = "NextOfKin"
        Me.NextOfKinBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'NextOfKinTableAdapter
        '
        Me.NextOfKinTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.NextOfKinTableAdapter = Me.NextOfKinTableAdapter
        Me.TableAdapterManager.NonSurgicalSupplyTableAdapter = Nothing
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
        'NextOfKinBindingNavigator
        '
        Me.NextOfKinBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NextOfKinBindingNavigator.BindingSource = Me.NextOfKinBindingSource
        Me.NextOfKinBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NextOfKinBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NextOfKinBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NextOfKinBindingNavigatorSaveItem})
        Me.NextOfKinBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.NextOfKinBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NextOfKinBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NextOfKinBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NextOfKinBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NextOfKinBindingNavigator.Name = "NextOfKinBindingNavigator"
        Me.NextOfKinBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NextOfKinBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.NextOfKinBindingNavigator.TabIndex = 0
        Me.NextOfKinBindingNavigator.Text = "BindingNavigator1"
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
        'NextOfKinBindingNavigatorSaveItem
        '
        Me.NextOfKinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextOfKinBindingNavigatorSaveItem.Image = CType(resources.GetObject("NextOfKinBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NextOfKinBindingNavigatorSaveItem.Name = "NextOfKinBindingNavigatorSaveItem"
        Me.NextOfKinBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NextOfKinBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NextOfKinDataGridView
        '
        Me.NextOfKinDataGridView.AutoGenerateColumns = False
        Me.NextOfKinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NextOfKinDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.NextOfKinDataGridView.DataSource = Me.NextOfKinBindingSource
        Me.NextOfKinDataGridView.Location = New System.Drawing.Point(52, 81)
        Me.NextOfKinDataGridView.Name = "NextOfKinDataGridView"
        Me.NextOfKinDataGridView.Size = New System.Drawing.Size(753, 210)
        Me.NextOfKinDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NextOfKinID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NextOfKinID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Relationship"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Relationship"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 60
        '
        'NextOfKinIDTextBox
        '
        Me.NextOfKinIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "NextOfKinID", True))
        Me.NextOfKinIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NextOfKinIDTextBox.Location = New System.Drawing.Point(493, 324)
        Me.NextOfKinIDTextBox.Name = "NextOfKinIDTextBox"
        Me.NextOfKinIDTextBox.Size = New System.Drawing.Size(208, 23)
        Me.NextOfKinIDTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FirstNameTextBox.Location = New System.Drawing.Point(493, 351)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(208, 23)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LastNameTextBox.Location = New System.Drawing.Point(493, 378)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(208, 23)
        Me.LastNameTextBox.TabIndex = 7
        '
        'RelationshipTextBox
        '
        Me.RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "Relationship", True))
        Me.RelationshipTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RelationshipTextBox.Location = New System.Drawing.Point(493, 405)
        Me.RelationshipTextBox.Name = "RelationshipTextBox"
        Me.RelationshipTextBox.Size = New System.Drawing.Size(208, 23)
        Me.RelationshipTextBox.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(493, 432)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(208, 23)
        Me.AddressTextBox.TabIndex = 11
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(493, 459)
        Me.PhoneTextBox.MaxLength = 10
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(208, 23)
        Me.PhoneTextBox.TabIndex = 13
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NextOfKinBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(169, 324)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(116, 23)
        Me.PatientIDTextBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(171, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Patient Name"
        '
        'SearchStaffQual
        '
        Me.SearchStaffQual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchStaffQual.Location = New System.Drawing.Point(291, 324)
        Me.SearchStaffQual.Name = "SearchStaffQual"
        Me.SearchStaffQual.Size = New System.Drawing.Size(38, 23)
        Me.SearchStaffQual.TabIndex = 24
        Me.SearchStaffQual.Text = "....."
        Me.SearchStaffQual.UseVisualStyleBackColor = True
        '
        'Patient_NextOfKin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffQual)
        Me.Controls.Add(NextOfKinIDLabel)
        Me.Controls.Add(Me.NextOfKinIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(RelationshipLabel)
        Me.Controls.Add(Me.RelationshipTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(Me.NextOfKinDataGridView)
        Me.Controls.Add(Me.NextOfKinBindingNavigator)
        Me.Name = "Patient_NextOfKin"
        Me.Text = "Patient_NextOfKin"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextOfKinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NextOfKinBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NextOfKinBindingNavigator.ResumeLayout(False)
        Me.NextOfKinBindingNavigator.PerformLayout()
        CType(Me.NextOfKinDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents NextOfKinBindingSource As BindingSource
    Friend WithEvents NextOfKinTableAdapter As WellmeadowsDBDataSetTableAdapters.NextOfKinTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NextOfKinBindingNavigator As BindingNavigator
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
    Friend WithEvents NextOfKinBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NextOfKinDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents NextOfKinIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents RelationshipTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchStaffQual As Button
End Class
