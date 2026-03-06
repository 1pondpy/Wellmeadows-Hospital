<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ward_AddWeek
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
        Dim WeekIDLabel As System.Windows.Forms.Label
        Dim WeekNoLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ward_AddWeek))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.WeekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeekTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.WeekTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.WeekBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WeekBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WeekDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekIDTextBox = New System.Windows.Forms.TextBox()
        Me.WeekNoTextBox = New System.Windows.Forms.TextBox()
        Me.StartDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddWeek = New System.Windows.Forms.Label()
        WeekIDLabel = New System.Windows.Forms.Label()
        WeekNoLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WeekBindingNavigator.SuspendLayout()
        CType(Me.WeekDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WeekIDLabel
        '
        WeekIDLabel.AutoSize = True
        WeekIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WeekIDLabel.Location = New System.Drawing.Point(278, 316)
        WeekIDLabel.Name = "WeekIDLabel"
        WeekIDLabel.Size = New System.Drawing.Size(70, 17)
        WeekIDLabel.TabIndex = 2
        WeekIDLabel.Text = "*Week ID:"
        '
        'WeekNoLabel
        '
        WeekNoLabel.AutoSize = True
        WeekNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WeekNoLabel.Location = New System.Drawing.Point(278, 344)
        WeekNoLabel.Name = "WeekNoLabel"
        WeekNoLabel.Size = New System.Drawing.Size(75, 17)
        WeekNoLabel.TabIndex = 4
        WeekNoLabel.Text = "*Week No:"
        '
        'StartDateLabel
        '
        StartDateLabel.AutoSize = True
        StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StartDateLabel.Location = New System.Drawing.Point(278, 373)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(81, 17)
        StartDateLabel.TabIndex = 6
        StartDateLabel.Text = "*Start Date:"
        '
        'EndDateLabel
        '
        EndDateLabel.AutoSize = True
        EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        EndDateLabel.Location = New System.Drawing.Point(278, 401)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(76, 17)
        EndDateLabel.TabIndex = 8
        EndDateLabel.Text = "*End Date:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WeekBindingSource
        '
        Me.WeekBindingSource.DataMember = "Week"
        Me.WeekBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WeekTableAdapter
        '
        Me.WeekTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Me.WeekTableAdapter
        '
        'WeekBindingNavigator
        '
        Me.WeekBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WeekBindingNavigator.BindingSource = Me.WeekBindingSource
        Me.WeekBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WeekBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WeekBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WeekBindingNavigatorSaveItem})
        Me.WeekBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WeekBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WeekBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WeekBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WeekBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WeekBindingNavigator.Name = "WeekBindingNavigator"
        Me.WeekBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WeekBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.WeekBindingNavigator.TabIndex = 0
        Me.WeekBindingNavigator.Text = "BindingNavigator1"
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
        'WeekBindingNavigatorSaveItem
        '
        Me.WeekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WeekBindingNavigatorSaveItem.Image = CType(resources.GetObject("WeekBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WeekBindingNavigatorSaveItem.Name = "WeekBindingNavigatorSaveItem"
        Me.WeekBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WeekBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WeekDataGridView
        '
        Me.WeekDataGridView.AutoGenerateColumns = False
        Me.WeekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WeekDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.WeekDataGridView.DataSource = Me.WeekBindingSource
        Me.WeekDataGridView.Location = New System.Drawing.Point(105, 91)
        Me.WeekDataGridView.Name = "WeekDataGridView"
        Me.WeekDataGridView.Size = New System.Drawing.Size(675, 169)
        Me.WeekDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WeekID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WeekID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WeekNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WeekNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StartDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StartDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EndDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EndDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'WeekIDTextBox
        '
        Me.WeekIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeekBindingSource, "WeekID", True))
        Me.WeekIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WeekIDTextBox.Location = New System.Drawing.Point(359, 313)
        Me.WeekIDTextBox.Name = "WeekIDTextBox"
        Me.WeekIDTextBox.Size = New System.Drawing.Size(245, 23)
        Me.WeekIDTextBox.TabIndex = 3
        '
        'WeekNoTextBox
        '
        Me.WeekNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WeekBindingSource, "WeekNo", True))
        Me.WeekNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WeekNoTextBox.Location = New System.Drawing.Point(359, 341)
        Me.WeekNoTextBox.Name = "WeekNoTextBox"
        Me.WeekNoTextBox.Size = New System.Drawing.Size(245, 23)
        Me.WeekNoTextBox.TabIndex = 5
        '
        'StartDateDateTimePicker
        '
        Me.StartDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WeekBindingSource, "StartDate", True))
        Me.StartDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StartDateDateTimePicker.Location = New System.Drawing.Point(359, 369)
        Me.StartDateDateTimePicker.Name = "StartDateDateTimePicker"
        Me.StartDateDateTimePicker.Size = New System.Drawing.Size(245, 23)
        Me.StartDateDateTimePicker.TabIndex = 7
        '
        'EndDateDateTimePicker
        '
        Me.EndDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WeekBindingSource, "EndDate", True))
        Me.EndDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.EndDateDateTimePicker.Location = New System.Drawing.Point(359, 397)
        Me.EndDateDateTimePicker.Name = "EndDateDateTimePicker"
        Me.EndDateDateTimePicker.Size = New System.Drawing.Size(245, 23)
        Me.EndDateDateTimePicker.TabIndex = 9
        '
        'AddWeek
        '
        Me.AddWeek.AutoSize = True
        Me.AddWeek.BackColor = System.Drawing.Color.White
        Me.AddWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddWeek.Location = New System.Drawing.Point(102, 54)
        Me.AddWeek.Name = "AddWeek"
        Me.AddWeek.Size = New System.Drawing.Size(73, 17)
        Me.AddWeek.TabIndex = 10
        Me.AddWeek.Text = "Add Week"
        '
        'Ward_AddWeek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AddWeek)
        Me.Controls.Add(WeekIDLabel)
        Me.Controls.Add(Me.WeekIDTextBox)
        Me.Controls.Add(WeekNoLabel)
        Me.Controls.Add(Me.WeekNoTextBox)
        Me.Controls.Add(StartDateLabel)
        Me.Controls.Add(Me.StartDateDateTimePicker)
        Me.Controls.Add(EndDateLabel)
        Me.Controls.Add(Me.EndDateDateTimePicker)
        Me.Controls.Add(Me.WeekDataGridView)
        Me.Controls.Add(Me.WeekBindingNavigator)
        Me.Name = "Ward_AddWeek"
        Me.Text = "Ward_AddWeek"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WeekBindingNavigator.ResumeLayout(False)
        Me.WeekBindingNavigator.PerformLayout()
        CType(Me.WeekDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents WeekBindingSource As BindingSource
    Friend WithEvents WeekTableAdapter As WellmeadowsDBDataSetTableAdapters.WeekTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WeekBindingNavigator As BindingNavigator
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
    Friend WithEvents WeekBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WeekDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents WeekIDTextBox As TextBox
    Friend WithEvents WeekNoTextBox As TextBox
    Friend WithEvents StartDateDateTimePicker As DateTimePicker
    Friend WithEvents EndDateDateTimePicker As DateTimePicker
    Friend WithEvents AddWeek As Label
End Class
