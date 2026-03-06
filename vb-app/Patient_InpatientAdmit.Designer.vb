<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patient_InpatientAdmit
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
        Dim InpatientIDLabel As System.Windows.Forms.Label
        Dim DateWaitingListLabel As System.Windows.Forms.Label
        Dim ExpectedDayStayLabel As System.Windows.Forms.Label
        Dim DatePlacedLabel As System.Windows.Forms.Label
        Dim DateLeaveLabel As System.Windows.Forms.Label
        Dim DateActualLeaveLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim BedIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_InpatientAdmit))
        Dim StaffIDLabel As System.Windows.Forms.Label
        Me.InpatientBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InpatientBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InpatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateWaitingListDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ExpectedDayStayTextBox = New System.Windows.Forms.TextBox()
        Me.DatePlacedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateLeaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateActualLeaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.cboBed = New System.Windows.Forms.ComboBox()
        Me.cboWard = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStaffQual = New System.Windows.Forms.Button()
        Me.InpatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.InpatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
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
        Me.InpatientTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.InpatientTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        InpatientIDLabel = New System.Windows.Forms.Label()
        DateWaitingListLabel = New System.Windows.Forms.Label()
        ExpectedDayStayLabel = New System.Windows.Forms.Label()
        DatePlacedLabel = New System.Windows.Forms.Label()
        DateLeaveLabel = New System.Windows.Forms.Label()
        DateActualLeaveLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        BedIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        CType(Me.InpatientBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InpatientBindingNavigator.SuspendLayout()
        CType(Me.InpatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InpatientIDLabel
        '
        InpatientIDLabel.AutoSize = True
        InpatientIDLabel.BackColor = System.Drawing.Color.White
        InpatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        InpatientIDLabel.Location = New System.Drawing.Point(90, 327)
        InpatientIDLabel.Name = "InpatientIDLabel"
        InpatientIDLabel.Size = New System.Drawing.Size(88, 17)
        InpatientIDLabel.TabIndex = 2
        InpatientIDLabel.Text = "*Inpatient ID:"
        '
        'DateWaitingListLabel
        '
        DateWaitingListLabel.AutoSize = True
        DateWaitingListLabel.BackColor = System.Drawing.Color.White
        DateWaitingListLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateWaitingListLabel.Location = New System.Drawing.Point(418, 365)
        DateWaitingListLabel.Name = "DateWaitingListLabel"
        DateWaitingListLabel.Size = New System.Drawing.Size(124, 17)
        DateWaitingListLabel.TabIndex = 4
        DateWaitingListLabel.Text = "*Date Waiting List:"
        '
        'ExpectedDayStayLabel
        '
        ExpectedDayStayLabel.AutoSize = True
        ExpectedDayStayLabel.BackColor = System.Drawing.Color.White
        ExpectedDayStayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ExpectedDayStayLabel.Location = New System.Drawing.Point(418, 392)
        ExpectedDayStayLabel.Name = "ExpectedDayStayLabel"
        ExpectedDayStayLabel.Size = New System.Drawing.Size(136, 17)
        ExpectedDayStayLabel.TabIndex = 6
        ExpectedDayStayLabel.Text = "*Expected Day Stay:"
        '
        'DatePlacedLabel
        '
        DatePlacedLabel.AutoSize = True
        DatePlacedLabel.BackColor = System.Drawing.Color.White
        DatePlacedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DatePlacedLabel.Location = New System.Drawing.Point(418, 421)
        DatePlacedLabel.Name = "DatePlacedLabel"
        DatePlacedLabel.Size = New System.Drawing.Size(89, 17)
        DatePlacedLabel.TabIndex = 8
        DatePlacedLabel.Text = "Date Placed:"
        '
        'DateLeaveLabel
        '
        DateLeaveLabel.AutoSize = True
        DateLeaveLabel.BackColor = System.Drawing.Color.White
        DateLeaveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateLeaveLabel.Location = New System.Drawing.Point(418, 449)
        DateLeaveLabel.Name = "DateLeaveLabel"
        DateLeaveLabel.Size = New System.Drawing.Size(85, 17)
        DateLeaveLabel.TabIndex = 10
        DateLeaveLabel.Text = "Date Leave:"
        '
        'DateActualLeaveLabel
        '
        DateActualLeaveLabel.AutoSize = True
        DateActualLeaveLabel.BackColor = System.Drawing.Color.White
        DateActualLeaveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateActualLeaveLabel.Location = New System.Drawing.Point(418, 477)
        DateActualLeaveLabel.Name = "DateActualLeaveLabel"
        DateActualLeaveLabel.Size = New System.Drawing.Size(128, 17)
        DateActualLeaveLabel.TabIndex = 12
        DateActualLeaveLabel.Text = "Date Actual Leave:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(90, 362)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(78, 17)
        PatientIDLabel.TabIndex = 14
        PatientIDLabel.Text = "*Patient ID:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.White
        WardIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WardIDLabel.Location = New System.Drawing.Point(90, 416)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(68, 17)
        WardIDLabel.TabIndex = 18
        WardIDLabel.Text = "*Ward ID:"
        '
        'BedIDLabel
        '
        BedIDLabel.AutoSize = True
        BedIDLabel.BackColor = System.Drawing.Color.White
        BedIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        BedIDLabel.Location = New System.Drawing.Point(90, 450)
        BedIDLabel.Name = "BedIDLabel"
        BedIDLabel.Size = New System.Drawing.Size(59, 17)
        BedIDLabel.TabIndex = 16
        BedIDLabel.Text = "*Bed ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.White
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Label2.Location = New System.Drawing.Point(52, 41)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(130, 17)
        Label2.TabIndex = 28
        Label2.Text = "Inpatient Admission"
        '
        'InpatientBindingNavigator
        '
        Me.InpatientBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InpatientBindingNavigator.BindingSource = Me.InpatientBindingSource
        Me.InpatientBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InpatientBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InpatientBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InpatientBindingNavigatorSaveItem})
        Me.InpatientBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InpatientBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InpatientBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InpatientBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InpatientBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InpatientBindingNavigator.Name = "InpatientBindingNavigator"
        Me.InpatientBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InpatientBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.InpatientBindingNavigator.TabIndex = 0
        Me.InpatientBindingNavigator.Text = "BindingNavigator1"
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
        'InpatientBindingNavigatorSaveItem
        '
        Me.InpatientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InpatientBindingNavigatorSaveItem.Image = CType(resources.GetObject("InpatientBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InpatientBindingNavigatorSaveItem.Name = "InpatientBindingNavigatorSaveItem"
        Me.InpatientBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InpatientBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InpatientIDTextBox
        '
        Me.InpatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientBindingSource, "InpatientID", True))
        Me.InpatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InpatientIDTextBox.Location = New System.Drawing.Point(181, 324)
        Me.InpatientIDTextBox.Name = "InpatientIDTextBox"
        Me.InpatientIDTextBox.Size = New System.Drawing.Size(156, 23)
        Me.InpatientIDTextBox.TabIndex = 3
        '
        'DateWaitingListDateTimePicker
        '
        Me.DateWaitingListDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InpatientBindingSource, "DateWaitingList", True))
        Me.DateWaitingListDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateWaitingListDateTimePicker.Location = New System.Drawing.Point(562, 361)
        Me.DateWaitingListDateTimePicker.Name = "DateWaitingListDateTimePicker"
        Me.DateWaitingListDateTimePicker.Size = New System.Drawing.Size(240, 23)
        Me.DateWaitingListDateTimePicker.TabIndex = 5
        '
        'ExpectedDayStayTextBox
        '
        Me.ExpectedDayStayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientBindingSource, "ExpectedDayStay", True))
        Me.ExpectedDayStayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ExpectedDayStayTextBox.Location = New System.Drawing.Point(562, 389)
        Me.ExpectedDayStayTextBox.Name = "ExpectedDayStayTextBox"
        Me.ExpectedDayStayTextBox.Size = New System.Drawing.Size(240, 23)
        Me.ExpectedDayStayTextBox.TabIndex = 7
        '
        'DatePlacedDateTimePicker
        '
        Me.DatePlacedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InpatientBindingSource, "DatePlaced", True))
        Me.DatePlacedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DatePlacedDateTimePicker.Location = New System.Drawing.Point(562, 417)
        Me.DatePlacedDateTimePicker.Name = "DatePlacedDateTimePicker"
        Me.DatePlacedDateTimePicker.Size = New System.Drawing.Size(240, 23)
        Me.DatePlacedDateTimePicker.TabIndex = 9
        '
        'DateLeaveDateTimePicker
        '
        Me.DateLeaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InpatientBindingSource, "DateLeave", True))
        Me.DateLeaveDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateLeaveDateTimePicker.Location = New System.Drawing.Point(562, 445)
        Me.DateLeaveDateTimePicker.Name = "DateLeaveDateTimePicker"
        Me.DateLeaveDateTimePicker.Size = New System.Drawing.Size(240, 23)
        Me.DateLeaveDateTimePicker.TabIndex = 11
        '
        'DateActualLeaveDateTimePicker
        '
        Me.DateActualLeaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InpatientBindingSource, "DateActualLeave", True))
        Me.DateActualLeaveDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateActualLeaveDateTimePicker.Location = New System.Drawing.Point(562, 473)
        Me.DateActualLeaveDateTimePicker.Name = "DateActualLeaveDateTimePicker"
        Me.DateActualLeaveDateTimePicker.Size = New System.Drawing.Size(240, 23)
        Me.DateActualLeaveDateTimePicker.TabIndex = 13
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(181, 359)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(156, 23)
        Me.PatientIDTextBox.TabIndex = 15
        '
        'cboBed
        '
        Me.cboBed.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboBed.FormattingEnabled = True
        Me.cboBed.Location = New System.Drawing.Point(181, 447)
        Me.cboBed.Name = "cboBed"
        Me.cboBed.Size = New System.Drawing.Size(156, 24)
        Me.cboBed.TabIndex = 19
        '
        'cboWard
        '
        Me.cboWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboWard.FormattingEnabled = True
        Me.cboWard.Location = New System.Drawing.Point(181, 413)
        Me.cboWard.Name = "cboWard"
        Me.cboWard.Size = New System.Drawing.Size(156, 24)
        Me.cboWard.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(184, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Patient Name"
        '
        'SearchStaffQual
        '
        Me.SearchStaffQual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchStaffQual.Location = New System.Drawing.Point(341, 359)
        Me.SearchStaffQual.Name = "SearchStaffQual"
        Me.SearchStaffQual.Size = New System.Drawing.Size(38, 23)
        Me.SearchStaffQual.TabIndex = 26
        Me.SearchStaffQual.Text = "....."
        Me.SearchStaffQual.UseVisualStyleBackColor = True
        '
        'InpatientDataGridView
        '
        Me.InpatientDataGridView.AutoGenerateColumns = False
        Me.InpatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InpatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.InpatientDataGridView.DataSource = Me.InpatientBindingSource
        Me.InpatientDataGridView.Location = New System.Drawing.Point(79, 77)
        Me.InpatientDataGridView.Name = "InpatientDataGridView"
        Me.InpatientDataGridView.Size = New System.Drawing.Size(748, 220)
        Me.InpatientDataGridView.TabIndex = 28
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.White
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffIDLabel.Location = New System.Drawing.Point(90, 483)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(72, 17)
        StaffIDLabel.TabIndex = 28
        StaffIDLabel.Text = "Attending:"
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientBindingSource, "StaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(181, 480)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(156, 23)
        Me.StaffIDTextBox.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(343, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InpatientBindingSource
        '
        Me.InpatientBindingSource.DataMember = "Inpatient"
        Me.InpatientBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InpatientID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InpatientID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DateWaitingList"
        Me.DataGridViewTextBoxColumn2.HeaderText = "DateWaitingList"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ExpectedDayStay"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ExpectedDayStay"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DatePlaced"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DatePlaced"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DateLeave"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DateLeave"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateActualLeave"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateActualLeave"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BedID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BedID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "WardID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "WardID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'InpatientTableAdapter
        '
        Me.InpatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Nothing
        Me.TableAdapterManager.InpatientTableAdapter = Me.InpatientTableAdapter
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
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(184, 506)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Staff Name"
        '
        'Patient_InpatientAdmit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(Me.InpatientDataGridView)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffQual)
        Me.Controls.Add(Me.cboWard)
        Me.Controls.Add(Me.cboBed)
        Me.Controls.Add(InpatientIDLabel)
        Me.Controls.Add(Me.InpatientIDTextBox)
        Me.Controls.Add(DateWaitingListLabel)
        Me.Controls.Add(Me.DateWaitingListDateTimePicker)
        Me.Controls.Add(ExpectedDayStayLabel)
        Me.Controls.Add(Me.ExpectedDayStayTextBox)
        Me.Controls.Add(DatePlacedLabel)
        Me.Controls.Add(Me.DatePlacedDateTimePicker)
        Me.Controls.Add(DateLeaveLabel)
        Me.Controls.Add(Me.DateLeaveDateTimePicker)
        Me.Controls.Add(DateActualLeaveLabel)
        Me.Controls.Add(Me.DateActualLeaveDateTimePicker)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(BedIDLabel)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.InpatientBindingNavigator)
        Me.Name = "Patient_InpatientAdmit"
        Me.Text = "Patient_InpatientAdmit"
        CType(Me.InpatientBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InpatientBindingNavigator.ResumeLayout(False)
        Me.InpatientBindingNavigator.PerformLayout()
        CType(Me.InpatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents InpatientBindingSource As BindingSource
    Friend WithEvents InpatientTableAdapter As WellmeadowsDBDataSetTableAdapters.InpatientTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InpatientBindingNavigator As BindingNavigator
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
    Friend WithEvents InpatientBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InpatientIDTextBox As TextBox
    Friend WithEvents DateWaitingListDateTimePicker As DateTimePicker
    Friend WithEvents ExpectedDayStayTextBox As TextBox
    Friend WithEvents DatePlacedDateTimePicker As DateTimePicker
    Friend WithEvents DateLeaveDateTimePicker As DateTimePicker
    Friend WithEvents DateActualLeaveDateTimePicker As DateTimePicker
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents cboBed As ComboBox
    Friend WithEvents cboWard As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchStaffQual As Button
    Friend WithEvents InpatientDataGridView As DataGridView
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
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
