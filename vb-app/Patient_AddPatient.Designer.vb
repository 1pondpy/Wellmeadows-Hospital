<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient_AddPatient
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
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim DateBirthLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim DateRegisteredLabel As System.Windows.Forms.Label
        Dim LocalDoctorIDLabel As System.Windows.Forms.Label
        Dim SexLabel1 As System.Windows.Forms.Label
        Dim MartialStatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_AddPatient))
        Me.PatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.DateBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.DateRegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LDTextbox = New System.Windows.Forms.TextBox()
        Me.localdoctorlabel = New System.Windows.Forms.Label()
        Me.SexComboBox = New System.Windows.Forms.ComboBox()
        Me.MartialStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.AddPatient = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStaffQual = New System.Windows.Forms.Button()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.PatientTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.PatientTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.PatientDataGridView = New System.Windows.Forms.DataGridView()
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
        PatientIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        DateBirthLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        DateRegisteredLabel = New System.Windows.Forms.Label()
        LocalDoctorIDLabel = New System.Windows.Forms.Label()
        SexLabel1 = New System.Windows.Forms.Label()
        MartialStatusLabel = New System.Windows.Forms.Label()
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientBindingNavigator.SuspendLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(56, 297)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(78, 17)
        PatientIDLabel.TabIndex = 2
        PatientIDLabel.Text = "*Patient ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.White
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        FirstNameLabel.Location = New System.Drawing.Point(56, 325)
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
        LastNameLabel.Location = New System.Drawing.Point(56, 353)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(85, 17)
        LastNameLabel.TabIndex = 6
        LastNameLabel.Text = "*Last Name:"
        '
        'DateBirthLabel
        '
        DateBirthLabel.AutoSize = True
        DateBirthLabel.BackColor = System.Drawing.Color.White
        DateBirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateBirthLabel.Location = New System.Drawing.Point(56, 382)
        DateBirthLabel.Name = "DateBirthLabel"
        DateBirthLabel.Size = New System.Drawing.Size(80, 17)
        DateBirthLabel.TabIndex = 8
        DateBirthLabel.Text = "*Date Birth:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AddressLabel.Location = New System.Drawing.Point(56, 438)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(69, 17)
        AddressLabel.TabIndex = 12
        AddressLabel.Text = "*Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.White
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PhoneLabel.Location = New System.Drawing.Point(56, 466)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(58, 17)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "*Phone:"
        '
        'DateRegisteredLabel
        '
        DateRegisteredLabel.AutoSize = True
        DateRegisteredLabel.BackColor = System.Drawing.Color.White
        DateRegisteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateRegisteredLabel.Location = New System.Drawing.Point(458, 321)
        DateRegisteredLabel.Name = "DateRegisteredLabel"
        DateRegisteredLabel.Size = New System.Drawing.Size(120, 17)
        DateRegisteredLabel.TabIndex = 18
        DateRegisteredLabel.Text = "*Date Registered:"
        '
        'LocalDoctorIDLabel
        '
        LocalDoctorIDLabel.AutoSize = True
        LocalDoctorIDLabel.BackColor = System.Drawing.Color.White
        LocalDoctorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        LocalDoctorIDLabel.Location = New System.Drawing.Point(486, 423)
        LocalDoctorIDLabel.Name = "LocalDoctorIDLabel"
        LocalDoctorIDLabel.Size = New System.Drawing.Size(92, 17)
        LocalDoctorIDLabel.TabIndex = 20
        LocalDoctorIDLabel.Text = "Local Doctor:"
        '
        'SexLabel1
        '
        SexLabel1.AutoSize = True
        SexLabel1.BackColor = System.Drawing.Color.White
        SexLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        SexLabel1.Location = New System.Drawing.Point(56, 407)
        SexLabel1.Name = "SexLabel1"
        SexLabel1.Size = New System.Drawing.Size(40, 17)
        SexLabel1.TabIndex = 23
        SexLabel1.Text = "*Sex:"
        '
        'MartialStatusLabel
        '
        MartialStatusLabel.AutoSize = True
        MartialStatusLabel.BackColor = System.Drawing.Color.White
        MartialStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        MartialStatusLabel.Location = New System.Drawing.Point(56, 494)
        MartialStatusLabel.Name = "MartialStatusLabel"
        MartialStatusLabel.Size = New System.Drawing.Size(103, 17)
        MartialStatusLabel.TabIndex = 24
        MartialStatusLabel.Text = "*Martial Status:"
        '
        'PatientBindingNavigator
        '
        Me.PatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientBindingNavigator.BindingSource = Me.PatientBindingSource
        Me.PatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientBindingNavigatorSaveItem})
        Me.PatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientBindingNavigator.Name = "PatientBindingNavigator"
        Me.PatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.PatientBindingNavigator.TabIndex = 0
        Me.PatientBindingNavigator.Text = "BindingNavigator1"
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
        'PatientBindingNavigatorSaveItem
        '
        Me.PatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientBindingNavigatorSaveItem.Name = "PatientBindingNavigatorSaveItem"
        Me.PatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(165, 294)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(244, 23)
        Me.PatientIDTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FirstNameTextBox.Location = New System.Drawing.Point(165, 322)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(244, 23)
        Me.FirstNameTextBox.TabIndex = 5
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LastNameTextBox.Location = New System.Drawing.Point(165, 350)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(244, 23)
        Me.LastNameTextBox.TabIndex = 7
        '
        'DateBirthDateTimePicker
        '
        Me.DateBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "DateBirth", True))
        Me.DateBirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateBirthDateTimePicker.Location = New System.Drawing.Point(165, 378)
        Me.DateBirthDateTimePicker.Name = "DateBirthDateTimePicker"
        Me.DateBirthDateTimePicker.Size = New System.Drawing.Size(244, 23)
        Me.DateBirthDateTimePicker.TabIndex = 9
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(165, 435)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(244, 23)
        Me.AddressTextBox.TabIndex = 13
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(165, 463)
        Me.PhoneTextBox.MaxLength = 10
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(244, 23)
        Me.PhoneTextBox.TabIndex = 15
        '
        'DateRegisteredDateTimePicker
        '
        Me.DateRegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientBindingSource, "DateRegistered", True))
        Me.DateRegisteredDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateRegisteredDateTimePicker.Location = New System.Drawing.Point(593, 319)
        Me.DateRegisteredDateTimePicker.Name = "DateRegisteredDateTimePicker"
        Me.DateRegisteredDateTimePicker.Size = New System.Drawing.Size(239, 23)
        Me.DateRegisteredDateTimePicker.TabIndex = 19
        '
        'LDTextbox
        '
        Me.LDTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "LocalDoctorID", True))
        Me.LDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LDTextbox.Location = New System.Drawing.Point(593, 420)
        Me.LDTextbox.Name = "LDTextbox"
        Me.LDTextbox.Size = New System.Drawing.Size(131, 23)
        Me.LDTextbox.TabIndex = 21
        '
        'localdoctorlabel
        '
        Me.localdoctorlabel.AutoSize = True
        Me.localdoctorlabel.BackColor = System.Drawing.Color.White
        Me.localdoctorlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.localdoctorlabel.Location = New System.Drawing.Point(456, 392)
        Me.localdoctorlabel.Name = "localdoctorlabel"
        Me.localdoctorlabel.Size = New System.Drawing.Size(331, 17)
        Me.localdoctorlabel.TabIndex = 22
        Me.localdoctorlabel.Text = "If reffered by local doctor, please input local doctor."
        '
        'SexComboBox
        '
        Me.SexComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "Sex", True))
        Me.SexComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SexComboBox.FormattingEnabled = True
        Me.SexComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.SexComboBox.Location = New System.Drawing.Point(165, 406)
        Me.SexComboBox.Name = "SexComboBox"
        Me.SexComboBox.Size = New System.Drawing.Size(244, 24)
        Me.SexComboBox.TabIndex = 24
        '
        'MartialStatusComboBox
        '
        Me.MartialStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientBindingSource, "MartialStatus", True))
        Me.MartialStatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MartialStatusComboBox.FormattingEnabled = True
        Me.MartialStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Divorced", "Widowed", "Seperated"})
        Me.MartialStatusComboBox.Location = New System.Drawing.Point(165, 491)
        Me.MartialStatusComboBox.Name = "MartialStatusComboBox"
        Me.MartialStatusComboBox.Size = New System.Drawing.Size(244, 24)
        Me.MartialStatusComboBox.TabIndex = 25
        '
        'AddPatient
        '
        Me.AddPatient.AutoSize = True
        Me.AddPatient.BackColor = System.Drawing.Color.White
        Me.AddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddPatient.Location = New System.Drawing.Point(44, 36)
        Me.AddPatient.Name = "AddPatient"
        Me.AddPatient.Size = New System.Drawing.Size(81, 17)
        Me.AddPatient.TabIndex = 26
        Me.AddPatient.Text = "Add Patient"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(595, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Local Doctor Name"
        '
        'SearchStaffQual
        '
        Me.SearchStaffQual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchStaffQual.Location = New System.Drawing.Point(727, 421)
        Me.SearchStaffQual.Name = "SearchStaffQual"
        Me.SearchStaffQual.Size = New System.Drawing.Size(34, 23)
        Me.SearchStaffQual.TabIndex = 27
        Me.SearchStaffQual.Text = "....."
        Me.SearchStaffQual.UseVisualStyleBackColor = True
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientTableAdapter = Me.PatientTableAdapter
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
        'PatientDataGridView
        '
        Me.PatientDataGridView.AutoGenerateColumns = False
        Me.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.PatientDataGridView.DataSource = Me.PatientBindingSource
        Me.PatientDataGridView.Location = New System.Drawing.Point(47, 62)
        Me.PatientDataGridView.Name = "PatientDataGridView"
        Me.PatientDataGridView.Size = New System.Drawing.Size(791, 220)
        Me.PatientDataGridView.TabIndex = 28
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DateBirth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DateBirth"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MartialStatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "MartialStatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateRegistered"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DateRegistered"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LocalDoctorID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "LocalDoctorID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Patient_AddPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.PatientDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffQual)
        Me.Controls.Add(Me.AddPatient)
        Me.Controls.Add(MartialStatusLabel)
        Me.Controls.Add(Me.MartialStatusComboBox)
        Me.Controls.Add(SexLabel1)
        Me.Controls.Add(Me.SexComboBox)
        Me.Controls.Add(Me.localdoctorlabel)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
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
        Me.Controls.Add(DateRegisteredLabel)
        Me.Controls.Add(Me.DateRegisteredDateTimePicker)
        Me.Controls.Add(LocalDoctorIDLabel)
        Me.Controls.Add(Me.LDTextbox)
        Me.Controls.Add(Me.PatientBindingNavigator)
        Me.Name = "Patient_AddPatient"
        Me.Text = " "
        CType(Me.PatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientBindingNavigator.ResumeLayout(False)
        Me.PatientBindingNavigator.PerformLayout()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As WellmeadowsDBDataSetTableAdapters.PatientTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientBindingNavigator As BindingNavigator
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
    Friend WithEvents PatientBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents DateBirthDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents DateRegisteredDateTimePicker As DateTimePicker
    Friend WithEvents LDTextbox As TextBox
    Friend WithEvents localdoctorlabel As Label
    Friend WithEvents SexComboBox As ComboBox
    Friend WithEvents MartialStatusComboBox As ComboBox
    Friend WithEvents AddPatient As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchStaffQual As Button
    Friend WithEvents PatientDataGridView As DataGridView
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
End Class
