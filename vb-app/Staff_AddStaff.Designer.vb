<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_AddStaff
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
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim DateBirthLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim NINLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim SalaryScaleLabel As System.Windows.Forms.Label
        Dim HoursPerWeekLabel As System.Windows.Forms.Label
        Dim SexLabel1 As System.Windows.Forms.Label
        Dim PayTypeLabel1 As System.Windows.Forms.Label
        Dim ContractTypeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_AddStaff))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.StaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.NINTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryScaleTextBox = New System.Windows.Forms.TextBox()
        Me.HoursPerWeekTextBox = New System.Windows.Forms.TextBox()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.PayTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.ContractTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddStaff = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        DateBirthLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        NINLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        SalaryScaleLabel = New System.Windows.Forms.Label()
        HoursPerWeekLabel = New System.Windows.Forms.Label()
        SexLabel1 = New System.Windows.Forms.Label()
        PayTypeLabel1 = New System.Windows.Forms.Label()
        ContractTypeLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffBindingNavigator.SuspendLayout()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.White
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffIDLabel.Location = New System.Drawing.Point(93, 308)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(63, 17)
        StaffIDLabel.TabIndex = 1
        StaffIDLabel.Text = "*Staff ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.White
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        FirstNameLabel.Location = New System.Drawing.Point(93, 337)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(85, 17)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "*First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.BackColor = System.Drawing.Color.White
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        LastNameLabel.Location = New System.Drawing.Point(93, 366)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(85, 17)
        LastNameLabel.TabIndex = 5
        LastNameLabel.Text = "*Last Name:"
        '
        'DateBirthLabel
        '
        DateBirthLabel.AutoSize = True
        DateBirthLabel.BackColor = System.Drawing.Color.White
        DateBirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateBirthLabel.Location = New System.Drawing.Point(93, 395)
        DateBirthLabel.Name = "DateBirthLabel"
        DateBirthLabel.Size = New System.Drawing.Size(80, 17)
        DateBirthLabel.TabIndex = 7
        DateBirthLabel.Text = "*Date Birth:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AddressLabel.Location = New System.Drawing.Point(93, 453)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 17)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "*Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.White
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PhoneLabel.Location = New System.Drawing.Point(93, 482)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(58, 17)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "*Phone:"
        '
        'NINLabel
        '
        NINLabel.AutoSize = True
        NINLabel.BackColor = System.Drawing.Color.White
        NINLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NINLabel.Location = New System.Drawing.Point(455, 307)
        NINLabel.Name = "NINLabel"
        NINLabel.Size = New System.Drawing.Size(40, 17)
        NINLabel.TabIndex = 15
        NINLabel.Text = "*NIN:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.BackColor = System.Drawing.Color.White
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PositionLabel.Location = New System.Drawing.Point(455, 336)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(67, 17)
        PositionLabel.TabIndex = 17
        PositionLabel.Text = "*Position:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.BackColor = System.Drawing.Color.White
        SalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SalaryLabel.Location = New System.Drawing.Point(455, 365)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(57, 17)
        SalaryLabel.TabIndex = 19
        SalaryLabel.Text = "*Salary:"
        '
        'SalaryScaleLabel
        '
        SalaryScaleLabel.AutoSize = True
        SalaryScaleLabel.BackColor = System.Drawing.Color.White
        SalaryScaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SalaryScaleLabel.Location = New System.Drawing.Point(455, 394)
        SalaryScaleLabel.Name = "SalaryScaleLabel"
        SalaryScaleLabel.Size = New System.Drawing.Size(96, 17)
        SalaryScaleLabel.TabIndex = 21
        SalaryScaleLabel.Text = "*Salary Scale:"
        '
        'HoursPerWeekLabel
        '
        HoursPerWeekLabel.AutoSize = True
        HoursPerWeekLabel.BackColor = System.Drawing.Color.White
        HoursPerWeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        HoursPerWeekLabel.Location = New System.Drawing.Point(455, 453)
        HoursPerWeekLabel.Name = "HoursPerWeekLabel"
        HoursPerWeekLabel.Size = New System.Drawing.Size(121, 17)
        HoursPerWeekLabel.TabIndex = 25
        HoursPerWeekLabel.Text = "*Hours Per Week:"
        '
        'SexLabel1
        '
        SexLabel1.AutoSize = True
        SexLabel1.BackColor = System.Drawing.Color.White
        SexLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SexLabel1.Location = New System.Drawing.Point(94, 423)
        SexLabel1.Name = "SexLabel1"
        SexLabel1.Size = New System.Drawing.Size(40, 17)
        SexLabel1.TabIndex = 30
        SexLabel1.Text = "*Sex:"
        '
        'PayTypeLabel1
        '
        PayTypeLabel1.AutoSize = True
        PayTypeLabel1.BackColor = System.Drawing.Color.White
        PayTypeLabel1.Cursor = System.Windows.Forms.Cursors.Default
        PayTypeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PayTypeLabel1.Location = New System.Drawing.Point(455, 483)
        PayTypeLabel1.Name = "PayTypeLabel1"
        PayTypeLabel1.Size = New System.Drawing.Size(77, 17)
        PayTypeLabel1.TabIndex = 31
        PayTypeLabel1.Text = "*Pay Type:"
        '
        'ContractTypeLabel
        '
        ContractTypeLabel.AutoSize = True
        ContractTypeLabel.BackColor = System.Drawing.Color.White
        ContractTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ContractTypeLabel.Location = New System.Drawing.Point(455, 425)
        ContractTypeLabel.Name = "ContractTypeLabel"
        ContractTypeLabel.Size = New System.Drawing.Size(106, 17)
        ContractTypeLabel.TabIndex = 32
        ContractTypeLabel.Text = "*Contract Type:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'StaffBindingNavigator
        '
        Me.StaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffBindingNavigator.BindingSource = Me.StaffBindingSource
        Me.StaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffBindingNavigatorSaveItem})
        Me.StaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffBindingNavigator.Name = "StaffBindingNavigator"
        Me.StaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.StaffBindingNavigator.TabIndex = 0
        Me.StaffBindingNavigator.Text = "BindingNavigator1"
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
        'StaffBindingNavigatorSaveItem
        '
        Me.StaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffBindingNavigatorSaveItem.Name = "StaffBindingNavigatorSaveItem"
        Me.StaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.StaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "StaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(185, 306)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(236, 23)
        Me.StaffIDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FirstNameTextBox.Location = New System.Drawing.Point(185, 335)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(236, 23)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LastNameTextBox.Location = New System.Drawing.Point(185, 364)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(236, 23)
        Me.LastNameTextBox.TabIndex = 6
        '
        'DateBirthDateTimePicker
        '
        Me.DateBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffBindingSource, "DateBirth", True))
        Me.DateBirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateBirthDateTimePicker.Location = New System.Drawing.Point(185, 392)
        Me.DateBirthDateTimePicker.Name = "DateBirthDateTimePicker"
        Me.DateBirthDateTimePicker.Size = New System.Drawing.Size(236, 23)
        Me.DateBirthDateTimePicker.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(185, 451)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(236, 23)
        Me.AddressTextBox.TabIndex = 12
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(185, 480)
        Me.PhoneTextBox.MaxLength = 10
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(236, 23)
        Me.PhoneTextBox.TabIndex = 14
        '
        'NINTextBox
        '
        Me.NINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "NIN", True))
        Me.NINTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NINTextBox.Location = New System.Drawing.Point(583, 304)
        Me.NINTextBox.MaxLength = 13
        Me.NINTextBox.Name = "NINTextBox"
        Me.NINTextBox.Size = New System.Drawing.Size(206, 23)
        Me.NINTextBox.TabIndex = 16
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PositionTextBox.Location = New System.Drawing.Point(583, 333)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(206, 23)
        Me.PositionTextBox.TabIndex = 18
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SalaryTextBox.Location = New System.Drawing.Point(583, 362)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(206, 23)
        Me.SalaryTextBox.TabIndex = 20
        '
        'SalaryScaleTextBox
        '
        Me.SalaryScaleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "SalaryScale", True))
        Me.SalaryScaleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SalaryScaleTextBox.Location = New System.Drawing.Point(583, 391)
        Me.SalaryScaleTextBox.Name = "SalaryScaleTextBox"
        Me.SalaryScaleTextBox.Size = New System.Drawing.Size(206, 23)
        Me.SalaryScaleTextBox.TabIndex = 22
        '
        'HoursPerWeekTextBox
        '
        Me.HoursPerWeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "HoursPerWeek", True))
        Me.HoursPerWeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HoursPerWeekTextBox.Location = New System.Drawing.Point(583, 450)
        Me.HoursPerWeekTextBox.MaxLength = 3
        Me.HoursPerWeekTextBox.Name = "HoursPerWeekTextBox"
        Me.HoursPerWeekTextBox.Size = New System.Drawing.Size(206, 23)
        Me.HoursPerWeekTextBox.TabIndex = 26
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Sex", True))
        Me.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SexComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.SexComboBox.Location = New System.Drawing.Point(185, 420)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(236, 24)
        Me.SexComboBox.TabIndex = 31
        '
        'PayTypeComboBox
        '
        Me.PayTypeComboBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PayTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PayType", True))
        Me.PayTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PayTypeComboBox.FormattingEnabled = True
        Me.PayTypeComboBox.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.PayTypeComboBox.Location = New System.Drawing.Point(583, 480)
        Me.PayTypeComboBox.Name = "PayTypeComboBox"
        Me.PayTypeComboBox.Size = New System.Drawing.Size(206, 24)
        Me.PayTypeComboBox.TabIndex = 32
        '
        'ContractTypeComboBox
        '
        Me.ContractTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "ContractType", True))
        Me.ContractTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ContractTypeComboBox.FormattingEnabled = True
        Me.ContractTypeComboBox.Items.AddRange(New Object() {"Permanent", "Temporary"})
        Me.ContractTypeComboBox.Location = New System.Drawing.Point(583, 420)
        Me.ContractTypeComboBox.Name = "ContractTypeComboBox"
        Me.ContractTypeComboBox.Size = New System.Drawing.Size(206, 24)
        Me.ContractTypeComboBox.TabIndex = 33
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AutoGenerateColumns = False
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.StaffDataGridView.DataSource = Me.StaffBindingSource
        Me.StaffDataGridView.Location = New System.Drawing.Point(34, 74)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.RowHeadersWidth = 51
        Me.StaffDataGridView.Size = New System.Drawing.Size(816, 207)
        Me.StaffDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateBirth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateBirth"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NIN"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NIN"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Salary"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 125
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SalaryScale"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SalaryScale"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 125
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ContractType"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ContractType"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 125
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "HoursPerWeek"
        Me.DataGridViewTextBoxColumn13.HeaderText = "HoursPerWeek"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 125
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "PayType"
        Me.DataGridViewTextBoxColumn14.HeaderText = "PayType"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 125
        '
        'AddStaff
        '
        Me.AddStaff.AutoSize = True
        Me.AddStaff.BackColor = System.Drawing.Color.White
        Me.AddStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddStaff.Location = New System.Drawing.Point(31, 43)
        Me.AddStaff.Name = "AddStaff"
        Me.AddStaff.Size = New System.Drawing.Size(66, 17)
        Me.AddStaff.TabIndex = 34
        Me.AddStaff.Text = "Add Staff"
        '
        'Staff_AddStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AddStaff)
        Me.Controls.Add(Me.StaffDataGridView)
        Me.Controls.Add(ContractTypeLabel)
        Me.Controls.Add(Me.ContractTypeComboBox)
        Me.Controls.Add(PayTypeLabel1)
        Me.Controls.Add(Me.PayTypeComboBox)
        Me.Controls.Add(SexLabel1)
        Me.Controls.Add(Me.SexComboBox)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(DateBirthLabel)
        Me.Controls.Add(Me.DateBirthDateTimePicker)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(NINLabel)
        Me.Controls.Add(Me.NINTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(SalaryScaleLabel)
        Me.Controls.Add(Me.SalaryScaleTextBox)
        Me.Controls.Add(HoursPerWeekLabel)
        Me.Controls.Add(Me.HoursPerWeekTextBox)
        Me.Controls.Add(Me.StaffBindingNavigator)
        Me.Name = "Staff_AddStaff"
        Me.Text = "Staff_AddStaff"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffBindingNavigator.ResumeLayout(False)
        Me.StaffBindingNavigator.PerformLayout()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As WellmeadowsDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DateBirthDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents NINTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents SalaryScaleTextBox As TextBox
    Friend WithEvents HoursPerWeekTextBox As TextBox
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents PayTypeComboBox As ComboBox
    Friend WithEvents ContractTypeComboBox As ComboBox
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents AddStaff As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
End Class
