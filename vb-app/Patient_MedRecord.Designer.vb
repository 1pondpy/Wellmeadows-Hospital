<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_MedRecord
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
        Dim MedIDLabel As System.Windows.Forms.Label
        Dim MethodOfAdminLabel As System.Windows.Forms.Label
        Dim UnitsPerDayLabel As System.Windows.Forms.Label
        Dim DiagNameLabel As System.Windows.Forms.Label
        Dim DiagDescLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim FinishDateLabel As System.Windows.Forms.Label
        Dim DrugIDLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_MedRecord))
        Dim QtyLabel As System.Windows.Forms.Label
        Me.MedRecordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.MedRecordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MedIDTextBox = New System.Windows.Forms.TextBox()
        Me.MethodOfAdminTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsPerDayTextBox = New System.Windows.Forms.TextBox()
        Me.DiagNameTextBox = New System.Windows.Forms.TextBox()
        Me.DiagDescTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FinishDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DrugIDTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchPatient = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MedRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.MedRecordTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.MedRecordTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.MedRecordGridViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedRecordGridViewTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.MedRecordGridViewTableAdapter()
        Me.QtyNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.MedRecordDataGridView = New System.Windows.Forms.DataGridView()
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
        MedIDLabel = New System.Windows.Forms.Label()
        MethodOfAdminLabel = New System.Windows.Forms.Label()
        UnitsPerDayLabel = New System.Windows.Forms.Label()
        DiagNameLabel = New System.Windows.Forms.Label()
        DiagDescLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        FinishDateLabel = New System.Windows.Forms.Label()
        DrugIDLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        QtyLabel = New System.Windows.Forms.Label()
        CType(Me.MedRecordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MedRecordBindingNavigator.SuspendLayout()
        CType(Me.MedRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedRecordGridViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedRecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MedIDLabel
        '
        MedIDLabel.AutoSize = True
        MedIDLabel.BackColor = System.Drawing.Color.White
        MedIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        MedIDLabel.Location = New System.Drawing.Point(67, 322)
        MedIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MedIDLabel.Name = "MedIDLabel"
        MedIDLabel.Size = New System.Drawing.Size(61, 17)
        MedIDLabel.TabIndex = 2
        MedIDLabel.Text = "*Med ID:"
        '
        'MethodOfAdminLabel
        '
        MethodOfAdminLabel.AutoSize = True
        MethodOfAdminLabel.BackColor = System.Drawing.Color.White
        MethodOfAdminLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        MethodOfAdminLabel.Location = New System.Drawing.Point(399, 408)
        MethodOfAdminLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MethodOfAdminLabel.Name = "MethodOfAdminLabel"
        MethodOfAdminLabel.Size = New System.Drawing.Size(126, 17)
        MethodOfAdminLabel.TabIndex = 4
        MethodOfAdminLabel.Text = "*Method Of Admin:"
        '
        'UnitsPerDayLabel
        '
        UnitsPerDayLabel.AutoSize = True
        UnitsPerDayLabel.BackColor = System.Drawing.Color.White
        UnitsPerDayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        UnitsPerDayLabel.Location = New System.Drawing.Point(399, 434)
        UnitsPerDayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        UnitsPerDayLabel.Name = "UnitsPerDayLabel"
        UnitsPerDayLabel.Size = New System.Drawing.Size(104, 17)
        UnitsPerDayLabel.TabIndex = 6
        UnitsPerDayLabel.Text = "*Units Per Day:"
        '
        'DiagNameLabel
        '
        DiagNameLabel.AutoSize = True
        DiagNameLabel.BackColor = System.Drawing.Color.White
        DiagNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DiagNameLabel.Location = New System.Drawing.Point(67, 408)
        DiagNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DiagNameLabel.Name = "DiagNameLabel"
        DiagNameLabel.Size = New System.Drawing.Size(87, 17)
        DiagNameLabel.TabIndex = 8
        DiagNameLabel.Text = "*Diag Name:"
        '
        'DiagDescLabel
        '
        DiagDescLabel.AutoSize = True
        DiagDescLabel.BackColor = System.Drawing.Color.White
        DiagDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DiagDescLabel.Location = New System.Drawing.Point(67, 436)
        DiagDescLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DiagDescLabel.Name = "DiagDescLabel"
        DiagDescLabel.Size = New System.Drawing.Size(82, 17)
        DiagDescLabel.TabIndex = 10
        DiagDescLabel.Text = "*Diag Desc:"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.BackColor = System.Drawing.Color.White
        StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StartDateLabel.Location = New System.Drawing.Point(399, 463)
        StartDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(81, 17)
        StartDateLabel.TabIndex = 12
        StartDateLabel.Text = "*Start Date:"
        '
        'FinishDateLabel
        '
        FinishDateLabel.AutoSize = True
        FinishDateLabel.BackColor = System.Drawing.Color.White
        FinishDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        FinishDateLabel.Location = New System.Drawing.Point(399, 492)
        FinishDateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FinishDateLabel.Name = "FinishDateLabel"
        FinishDateLabel.Size = New System.Drawing.Size(88, 17)
        FinishDateLabel.TabIndex = 14
        FinishDateLabel.Text = "*Finish Date:"
        '
        'DrugIDLabel
        '
        DrugIDLabel.AutoSize = True
        DrugIDLabel.BackColor = System.Drawing.Color.White
        DrugIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DrugIDLabel.Location = New System.Drawing.Point(399, 325)
        DrugIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DrugIDLabel.Name = "DrugIDLabel"
        DrugIDLabel.Size = New System.Drawing.Size(65, 17)
        DrugIDLabel.TabIndex = 16
        DrugIDLabel.Text = "*Drug ID:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(67, 350)
        PatientIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(78, 17)
        PatientIDLabel.TabIndex = 18
        PatientIDLabel.Text = "*Patient ID:"
        '
        'MedRecordBindingNavigator
        '
        Me.MedRecordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MedRecordBindingNavigator.BindingSource = Me.MedRecordBindingSource
        Me.MedRecordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MedRecordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MedRecordBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MedRecordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MedRecordBindingNavigatorSaveItem})
        Me.MedRecordBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MedRecordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MedRecordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MedRecordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MedRecordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MedRecordBindingNavigator.Name = "MedRecordBindingNavigator"
        Me.MedRecordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MedRecordBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.MedRecordBindingNavigator.TabIndex = 0
        Me.MedRecordBindingNavigator.Text = "BindingNavigator1"
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
        'MedRecordBindingNavigatorSaveItem
        '
        Me.MedRecordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MedRecordBindingNavigatorSaveItem.Image = CType(resources.GetObject("MedRecordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MedRecordBindingNavigatorSaveItem.Name = "MedRecordBindingNavigatorSaveItem"
        Me.MedRecordBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.MedRecordBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MedIDTextBox
        '
        Me.MedIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "MedID", True))
        Me.MedIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MedIDTextBox.Location = New System.Drawing.Point(163, 320)
        Me.MedIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MedIDTextBox.Name = "MedIDTextBox"
        Me.MedIDTextBox.Size = New System.Drawing.Size(152, 23)
        Me.MedIDTextBox.TabIndex = 3
        '
        'MethodOfAdminTextBox
        '
        Me.MethodOfAdminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "MethodOfAdmin", True))
        Me.MethodOfAdminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.MethodOfAdminTextBox.Location = New System.Drawing.Point(531, 405)
        Me.MethodOfAdminTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MethodOfAdminTextBox.Name = "MethodOfAdminTextBox"
        Me.MethodOfAdminTextBox.Size = New System.Drawing.Size(238, 23)
        Me.MethodOfAdminTextBox.TabIndex = 5
        '
        'UnitsPerDayTextBox
        '
        Me.UnitsPerDayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "UnitsPerDay", True))
        Me.UnitsPerDayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UnitsPerDayTextBox.Location = New System.Drawing.Point(531, 431)
        Me.UnitsPerDayTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UnitsPerDayTextBox.Name = "UnitsPerDayTextBox"
        Me.UnitsPerDayTextBox.Size = New System.Drawing.Size(238, 23)
        Me.UnitsPerDayTextBox.TabIndex = 7
        '
        'DiagNameTextBox
        '
        Me.DiagNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "DiagName", True))
        Me.DiagNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DiagNameTextBox.Location = New System.Drawing.Point(163, 405)
        Me.DiagNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DiagNameTextBox.Name = "DiagNameTextBox"
        Me.DiagNameTextBox.Size = New System.Drawing.Size(190, 23)
        Me.DiagNameTextBox.TabIndex = 9
        '
        'DiagDescTextBox
        '
        Me.DiagDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "DiagDesc", True))
        Me.DiagDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DiagDescTextBox.Location = New System.Drawing.Point(163, 433)
        Me.DiagDescTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DiagDescTextBox.Name = "DiagDescTextBox"
        Me.DiagDescTextBox.Size = New System.Drawing.Size(190, 23)
        Me.DiagDescTextBox.TabIndex = 11
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedRecordBindingSource, "StartDate", True))
        Me.StartDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(531, 459)
        Me.StartDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(238, 23)
        Me.StartDateDateTimePicker.TabIndex = 13
        '
        'FinishDateDateTimePicker
        '
        Me.FinishDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedRecordBindingSource, "FinishDate", True))
        Me.FinishDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FinishDateDateTimePicker.Location = New System.Drawing.Point(531, 487)
        Me.FinishDateDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.FinishDateDateTimePicker.Name = "FinishDateDateTimePicker"
        Me.FinishDateDateTimePicker.Size = New System.Drawing.Size(238, 23)
        Me.FinishDateDateTimePicker.TabIndex = 15
        '
        'DrugIDTextBox
        '
        Me.DrugIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "DrugID", True))
        Me.DrugIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DrugIDTextBox.Location = New System.Drawing.Point(468, 322)
        Me.DrugIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DrugIDTextBox.Name = "DrugIDTextBox"
        Me.DrugIDTextBox.Size = New System.Drawing.Size(153, 23)
        Me.DrugIDTextBox.TabIndex = 17
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MedRecordBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(163, 347)
        Me.PatientIDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(152, 23)
        Me.PatientIDTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(53, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Medication Record"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(164, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Patient Name"
        '
        'SearchPatient
        '
        Me.SearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchPatient.Location = New System.Drawing.Point(320, 349)
        Me.SearchPatient.Name = "SearchPatient"
        Me.SearchPatient.Size = New System.Drawing.Size(33, 22)
        Me.SearchPatient.TabIndex = 26
        Me.SearchPatient.Text = "....."
        Me.SearchPatient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(470, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 17)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Drug Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(623, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 24)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MedRecordBindingSource
        '
        Me.MedRecordBindingSource.DataMember = "MedRecord"
        Me.MedRecordBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedRecordTableAdapter
        '
        Me.MedRecordTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MedRecordTableAdapter = Me.MedRecordTableAdapter
        Me.TableAdapterManager.NextOfKinTableAdapter = Nothing
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
        'MedRecordGridViewBindingSource
        '
        Me.MedRecordGridViewBindingSource.DataMember = "MedRecordGridView"
        Me.MedRecordGridViewBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'MedRecordGridViewTableAdapter
        '
        Me.MedRecordGridViewTableAdapter.ClearBeforeFill = True
        '
        'QtyLabel
        '
        QtyLabel.AutoSize = True
        QtyLabel.BackColor = System.Drawing.Color.White
        QtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        QtyLabel.Location = New System.Drawing.Point(675, 325)
        QtyLabel.Name = "QtyLabel"
        QtyLabel.Size = New System.Drawing.Size(65, 17)
        QtyLabel.TabIndex = 29
        QtyLabel.Text = "Quantity:"
        '
        'QtyNumericUpDown
        '
        Me.QtyNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MedRecordBindingSource, "Qty", True))
        Me.QtyNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QtyNumericUpDown.Location = New System.Drawing.Point(746, 323)
        Me.QtyNumericUpDown.Name = "QtyNumericUpDown"
        Me.QtyNumericUpDown.Size = New System.Drawing.Size(55, 23)
        Me.QtyNumericUpDown.TabIndex = 30
        '
        'MedRecordDataGridView
        '
        Me.MedRecordDataGridView.AutoGenerateColumns = False
        Me.MedRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedRecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.MedRecordDataGridView.DataSource = Me.MedRecordBindingSource
        Me.MedRecordDataGridView.Location = New System.Drawing.Point(51, 74)
        Me.MedRecordDataGridView.Name = "MedRecordDataGridView"
        Me.MedRecordDataGridView.Size = New System.Drawing.Size(772, 220)
        Me.MedRecordDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MedID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "MedID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MethodOfAdmin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MethodOfAdmin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UnitsPerDay"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UnitsPerDay"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DiagName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DiagName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DiagDesc"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DiagDesc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "FinishDate"
        Me.DataGridViewTextBoxColumn7.HeaderText = "FinishDate"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DrugID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DrugID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Qty"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'Patient_MedRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.MedRecordDataGridView)
        Me.Controls.Add(QtyLabel)
        Me.Controls.Add(Me.QtyNumericUpDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchPatient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(MedIDLabel)
        Me.Controls.Add(Me.MedIDTextBox)
        Me.Controls.Add(MethodOfAdminLabel)
        Me.Controls.Add(Me.MethodOfAdminTextBox)
        Me.Controls.Add(UnitsPerDayLabel)
        Me.Controls.Add(Me.UnitsPerDayTextBox)
        Me.Controls.Add(DiagNameLabel)
        Me.Controls.Add(Me.DiagNameTextBox)
        Me.Controls.Add(DiagDescLabel)
        Me.Controls.Add(Me.DiagDescTextBox)
        Me.Controls.Add(StartDateLabel)
        Me.Controls.Add(Me.StartDateDateTimePicker)
        Me.Controls.Add(FinishDateLabel)
        Me.Controls.Add(Me.FinishDateDateTimePicker)
        Me.Controls.Add(DrugIDLabel)
        Me.Controls.Add(Me.DrugIDTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(Me.MedRecordBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Patient_MedRecord"
        Me.Text = "Patient_MedRecord"
        CType(Me.MedRecordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MedRecordBindingNavigator.ResumeLayout(False)
        Me.MedRecordBindingNavigator.PerformLayout()
        CType(Me.MedRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedRecordGridViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedRecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents MedRecordBindingSource As BindingSource
    Friend WithEvents MedRecordTableAdapter As WellmeadowsDBDataSetTableAdapters.MedRecordTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MedRecordBindingNavigator As BindingNavigator
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
    Friend WithEvents MedRecordBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MedIDTextBox As TextBox
    Friend WithEvents MethodOfAdminTextBox As TextBox
    Friend WithEvents UnitsPerDayTextBox As TextBox
    Friend WithEvents DiagNameTextBox As TextBox
    Friend WithEvents DiagDescTextBox As TextBox
    Friend WithEvents StartDateDateTimePicker As DateTimePicker
    Friend WithEvents FinishDateDateTimePicker As DateTimePicker
    Friend WithEvents DrugIDTextBox As TextBox
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchPatient As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MedRecordGridViewBindingSource As BindingSource
    Friend WithEvents MedRecordGridViewTableAdapter As WellmeadowsDBDataSetTableAdapters.MedRecordGridViewTableAdapter
    Friend WithEvents QtyNumericUpDown As NumericUpDown
    Friend WithEvents MedRecordDataGridView As DataGridView
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
