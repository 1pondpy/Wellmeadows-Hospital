<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_AppointmentBooking
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
        Dim AppointmentIDLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim TimeLabel As System.Windows.Forms.Label
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim ConsultantStaffIDLabel As System.Windows.Forms.Label
        Dim RoomIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_AppointmentBooking))
        Me.AppBook = New System.Windows.Forms.Label()
        Me.AppointmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
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
        Me.AppointmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomIDTextBox = New System.Windows.Forms.TextBox()
        Me.SearchRoom = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchStaff = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchPatient = New System.Windows.Forms.Button()
        Me.AppointmentTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.AppointmentTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.AppointmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BedTableAdapter1 = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.BedTableAdapter()
        AppointmentIDLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TimeLabel = New System.Windows.Forms.Label()
        PatientIDLabel = New System.Windows.Forms.Label()
        ConsultantStaffIDLabel = New System.Windows.Forms.Label()
        RoomIDLabel = New System.Windows.Forms.Label()
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AppointmentBindingNavigator.SuspendLayout()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AppointmentIDLabel
        '
        AppointmentIDLabel.AutoSize = True
        AppointmentIDLabel.BackColor = System.Drawing.Color.White
        AppointmentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AppointmentIDLabel.Location = New System.Drawing.Point(70, 361)
        AppointmentIDLabel.Name = "AppointmentIDLabel"
        AppointmentIDLabel.Size = New System.Drawing.Size(113, 17)
        AppointmentIDLabel.TabIndex = 32
        AppointmentIDLabel.Text = "*Appointment ID:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.White
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateLabel.Location = New System.Drawing.Point(136, 386)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(47, 17)
        DateLabel.TabIndex = 34
        DateLabel.Text = "*Date:"
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.BackColor = System.Drawing.Color.White
        TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        TimeLabel.Location = New System.Drawing.Point(136, 413)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(48, 17)
        TimeLabel.TabIndex = 36
        TimeLabel.Text = "*Time:"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(513, 417)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(78, 17)
        PatientIDLabel.TabIndex = 38
        PatientIDLabel.Text = "*Patient ID:"
        '
        'ConsultantStaffIDLabel
        '
        ConsultantStaffIDLabel.AutoSize = True
        ConsultantStaffIDLabel.BackColor = System.Drawing.Color.White
        ConsultantStaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ConsultantStaffIDLabel.Location = New System.Drawing.Point(457, 467)
        ConsultantStaffIDLabel.Name = "ConsultantStaffIDLabel"
        ConsultantStaffIDLabel.Size = New System.Drawing.Size(134, 17)
        ConsultantStaffIDLabel.TabIndex = 40
        ConsultantStaffIDLabel.Text = "*Consultant Staff ID:"
        '
        'RoomIDLabel
        '
        RoomIDLabel.AutoSize = True
        RoomIDLabel.BackColor = System.Drawing.Color.White
        RoomIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        RoomIDLabel.Location = New System.Drawing.Point(518, 364)
        RoomIDLabel.Name = "RoomIDLabel"
        RoomIDLabel.Size = New System.Drawing.Size(71, 17)
        RoomIDLabel.TabIndex = 42
        RoomIDLabel.Text = "*Room ID:"
        '
        'AppBook
        '
        Me.AppBook.AutoSize = True
        Me.AppBook.BackColor = System.Drawing.Color.White
        Me.AppBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AppBook.Location = New System.Drawing.Point(42, 44)
        Me.AppBook.Name = "AppBook"
        Me.AppBook.Size = New System.Drawing.Size(142, 17)
        Me.AppBook.TabIndex = 2
        Me.AppBook.Text = "Appointment Booking"
        '
        'AppointmentBindingNavigator
        '
        Me.AppointmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AppointmentBindingNavigator.BindingSource = Me.AppointmentBindingSource
        Me.AppointmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AppointmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AppointmentBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.AppointmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AppointmentBindingNavigatorSaveItem})
        Me.AppointmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AppointmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AppointmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AppointmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AppointmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AppointmentBindingNavigator.Name = "AppointmentBindingNavigator"
        Me.AppointmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AppointmentBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.AppointmentBindingNavigator.TabIndex = 32
        Me.AppointmentBindingNavigator.Text = "BindingNavigator1"
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
        'AppointmentBindingSource
        '
        Me.AppointmentBindingSource.DataMember = "Appointment"
        Me.AppointmentBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'AppointmentBindingNavigatorSaveItem
        '
        Me.AppointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AppointmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("AppointmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AppointmentBindingNavigatorSaveItem.Name = "AppointmentBindingNavigatorSaveItem"
        Me.AppointmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.AppointmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AppointmentIDTextBox
        '
        Me.AppointmentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "AppointmentID", True))
        Me.AppointmentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AppointmentIDTextBox.Location = New System.Drawing.Point(192, 358)
        Me.AppointmentIDTextBox.Name = "AppointmentIDTextBox"
        Me.AppointmentIDTextBox.Size = New System.Drawing.Size(236, 23)
        Me.AppointmentIDTextBox.TabIndex = 33
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateDateTimePicker.Location = New System.Drawing.Point(192, 386)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(236, 23)
        Me.DateDateTimePicker.TabIndex = 35
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "Time", True))
        Me.TimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TimeTextBox.Location = New System.Drawing.Point(192, 414)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(236, 23)
        Me.TimeTextBox.TabIndex = 37
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(600, 411)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(134, 23)
        Me.PatientIDTextBox.TabIndex = 39
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "ConsultantStaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(600, 463)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(134, 23)
        Me.StaffIDTextBox.TabIndex = 41
        '
        'RoomIDTextBox
        '
        Me.RoomIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentBindingSource, "RoomID", True))
        Me.RoomIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomIDTextBox.Location = New System.Drawing.Point(600, 361)
        Me.RoomIDTextBox.Name = "RoomIDTextBox"
        Me.RoomIDTextBox.Size = New System.Drawing.Size(134, 23)
        Me.RoomIDTextBox.TabIndex = 43
        '
        'SearchRoom
        '
        Me.SearchRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchRoom.Location = New System.Drawing.Point(739, 361)
        Me.SearchRoom.Name = "SearchRoom"
        Me.SearchRoom.Size = New System.Drawing.Size(37, 23)
        Me.SearchRoom.TabIndex = 49
        Me.SearchRoom.Text = "....."
        Me.SearchRoom.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(602, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Room Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(602, 436)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Patient Name"
        '
        'SearchStaff
        '
        Me.SearchStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchStaff.Location = New System.Drawing.Point(739, 464)
        Me.SearchStaff.Name = "SearchStaff"
        Me.SearchStaff.Size = New System.Drawing.Size(37, 23)
        Me.SearchStaff.TabIndex = 46
        Me.SearchStaff.Text = "....."
        Me.SearchStaff.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(602, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Staff Name"
        '
        'SearchPatient
        '
        Me.SearchPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchPatient.Location = New System.Drawing.Point(739, 412)
        Me.SearchPatient.Name = "SearchPatient"
        Me.SearchPatient.Size = New System.Drawing.Size(37, 23)
        Me.SearchPatient.TabIndex = 44
        Me.SearchPatient.Text = "....."
        Me.SearchPatient.UseVisualStyleBackColor = True
        '
        'AppointmentTableAdapter
        '
        Me.AppointmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Me.AppointmentTableAdapter
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
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'AppointmentDataGridView
        '
        Me.AppointmentDataGridView.AutoGenerateColumns = False
        Me.AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.AppointmentDataGridView.DataSource = Me.AppointmentBindingSource
        Me.AppointmentDataGridView.Location = New System.Drawing.Point(45, 80)
        Me.AppointmentDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.AppointmentDataGridView.Name = "AppointmentDataGridView"
        Me.AppointmentDataGridView.RowHeadersWidth = 51
        Me.AppointmentDataGridView.RowTemplate.Height = 24
        Me.AppointmentDataGridView.Size = New System.Drawing.Size(795, 243)
        Me.AppointmentDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AppointmentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "AppointmentID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ConsultantStaffID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ConsultantStaffID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RoomID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RoomID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'BedTableAdapter1
        '
        Me.BedTableAdapter1.ClearBeforeFill = True
        '
        'Patient_AppointmentBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AppointmentDataGridView)
        Me.Controls.Add(Me.SearchRoom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SearchStaff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchPatient)
        Me.Controls.Add(AppointmentIDLabel)
        Me.Controls.Add(Me.AppointmentIDTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(TimeLabel)
        Me.Controls.Add(Me.TimeTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(ConsultantStaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(RoomIDLabel)
        Me.Controls.Add(Me.RoomIDTextBox)
        Me.Controls.Add(Me.AppointmentBindingNavigator)
        Me.Controls.Add(Me.AppBook)
        Me.Name = "Patient_AppointmentBooking"
        Me.Text = "Patient_AppointmentBooking"
        CType(Me.AppointmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AppointmentBindingNavigator.ResumeLayout(False)
        Me.AppointmentBindingNavigator.PerformLayout()
        CType(Me.AppointmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents AppBook As Label
    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents AppointmentBindingSource As BindingSource
    Friend WithEvents AppointmentTableAdapter As WellmeadowsDBDataSetTableAdapters.AppointmentTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentBindingNavigator As BindingNavigator
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
    Friend WithEvents AppointmentBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AppointmentIDTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents RoomIDTextBox As TextBox
    Friend WithEvents SearchRoom As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SearchStaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchPatient As Button
    Friend WithEvents AppointmentDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents BedTableAdapter1 As WellmeadowsDBDataSetTableAdapters.BedTableAdapter
End Class
