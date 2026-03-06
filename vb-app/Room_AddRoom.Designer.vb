<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Room_AddRoom
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
        Dim RoomIDLabel As System.Windows.Forms.Label
        Dim RoomNoLabel As System.Windows.Forms.Label
        Dim RoomTypeLabel As System.Windows.Forms.Label
        Dim CapacityLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Room_AddRoom))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.RoomTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.RoomBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RoomBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RoomDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomMana = New System.Windows.Forms.Label()
        Me.RoomIDTextBox = New System.Windows.Forms.TextBox()
        Me.RoomNoTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTypeTextBox = New System.Windows.Forms.TextBox()
        Me.CapacityTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        RoomIDLabel = New System.Windows.Forms.Label()
        RoomNoLabel = New System.Windows.Forms.Label()
        RoomTypeLabel = New System.Windows.Forms.Label()
        CapacityLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomBindingNavigator.SuspendLayout()
        CType(Me.RoomDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoomIDLabel
        '
        RoomIDLabel.AutoSize = True
        RoomIDLabel.BackColor = System.Drawing.Color.White
        RoomIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        RoomIDLabel.Location = New System.Drawing.Point(304, 346)
        RoomIDLabel.Name = "RoomIDLabel"
        RoomIDLabel.Size = New System.Drawing.Size(71, 17)
        RoomIDLabel.TabIndex = 3
        RoomIDLabel.Text = "*Room ID:"
        '
        'RoomNoLabel
        '
        RoomNoLabel.AutoSize = True
        RoomNoLabel.BackColor = System.Drawing.Color.White
        RoomNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        RoomNoLabel.Location = New System.Drawing.Point(304, 374)
        RoomNoLabel.Name = "RoomNoLabel"
        RoomNoLabel.Size = New System.Drawing.Size(76, 17)
        RoomNoLabel.TabIndex = 5
        RoomNoLabel.Text = "*Room No:"
        '
        'RoomTypeLabel
        '
        RoomTypeLabel.AutoSize = True
        RoomTypeLabel.BackColor = System.Drawing.Color.White
        RoomTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        RoomTypeLabel.Location = New System.Drawing.Point(304, 402)
        RoomTypeLabel.Name = "RoomTypeLabel"
        RoomTypeLabel.Size = New System.Drawing.Size(90, 17)
        RoomTypeLabel.TabIndex = 7
        RoomTypeLabel.Text = "*Room Type:"
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.BackColor = System.Drawing.Color.White
        CapacityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        CapacityLabel.Location = New System.Drawing.Point(304, 430)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(71, 17)
        CapacityLabel.TabIndex = 9
        CapacityLabel.Text = "*Capacity:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = System.Drawing.Color.White
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StatusLabel.Location = New System.Drawing.Point(304, 458)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(57, 17)
        StatusLabel.TabIndex = 11
        StatusLabel.Text = "*Status:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RoomTableAdapter = Me.RoomTableAdapter
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
        'RoomBindingNavigator
        '
        Me.RoomBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RoomBindingNavigator.BindingSource = Me.RoomBindingSource
        Me.RoomBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RoomBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RoomBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RoomBindingNavigatorSaveItem})
        Me.RoomBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RoomBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RoomBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RoomBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RoomBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RoomBindingNavigator.Name = "RoomBindingNavigator"
        Me.RoomBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RoomBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.RoomBindingNavigator.TabIndex = 0
        Me.RoomBindingNavigator.Text = "BindingNavigator1"
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
        'RoomBindingNavigatorSaveItem
        '
        Me.RoomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RoomBindingNavigatorSaveItem.Image = CType(resources.GetObject("RoomBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RoomBindingNavigatorSaveItem.Name = "RoomBindingNavigatorSaveItem"
        Me.RoomBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RoomBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RoomDataGridView
        '
        Me.RoomDataGridView.AutoGenerateColumns = False
        Me.RoomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.RoomDataGridView.DataSource = Me.RoomBindingSource
        Me.RoomDataGridView.Location = New System.Drawing.Point(89, 96)
        Me.RoomDataGridView.Name = "RoomDataGridView"
        Me.RoomDataGridView.Size = New System.Drawing.Size(708, 213)
        Me.RoomDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RoomID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RoomID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RoomNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RoomNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RoomType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RoomType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'RoomMana
        '
        Me.RoomMana.AutoSize = True
        Me.RoomMana.BackColor = System.Drawing.Color.White
        Me.RoomMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomMana.Location = New System.Drawing.Point(86, 54)
        Me.RoomMana.Name = "RoomMana"
        Me.RoomMana.Size = New System.Drawing.Size(131, 17)
        Me.RoomMana.TabIndex = 2
        Me.RoomMana.Text = "Room Management"
        '
        'RoomIDTextBox
        '
        Me.RoomIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "RoomID", True))
        Me.RoomIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomIDTextBox.Location = New System.Drawing.Point(400, 343)
        Me.RoomIDTextBox.Name = "RoomIDTextBox"
        Me.RoomIDTextBox.Size = New System.Drawing.Size(193, 23)
        Me.RoomIDTextBox.TabIndex = 4
        '
        'RoomNoTextBox
        '
        Me.RoomNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "RoomNo", True))
        Me.RoomNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomNoTextBox.Location = New System.Drawing.Point(400, 371)
        Me.RoomNoTextBox.Name = "RoomNoTextBox"
        Me.RoomNoTextBox.Size = New System.Drawing.Size(193, 23)
        Me.RoomNoTextBox.TabIndex = 6
        '
        'RoomTypeTextBox
        '
        Me.RoomTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "RoomType", True))
        Me.RoomTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RoomTypeTextBox.Location = New System.Drawing.Point(400, 399)
        Me.RoomTypeTextBox.Name = "RoomTypeTextBox"
        Me.RoomTypeTextBox.Size = New System.Drawing.Size(193, 23)
        Me.RoomTypeTextBox.TabIndex = 8
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Capacity", True))
        Me.CapacityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CapacityTextBox.Location = New System.Drawing.Point(400, 427)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(193, 23)
        Me.CapacityTextBox.TabIndex = 10
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Status", True))
        Me.StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Available", "Occupied", "Out of Service"})
        Me.StatusComboBox.Location = New System.Drawing.Point(400, 455)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(193, 24)
        Me.StatusComboBox.TabIndex = 12
        '
        'Room_AddRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(RoomIDLabel)
        Me.Controls.Add(Me.RoomIDTextBox)
        Me.Controls.Add(RoomNoLabel)
        Me.Controls.Add(Me.RoomNoTextBox)
        Me.Controls.Add(RoomTypeLabel)
        Me.Controls.Add(Me.RoomTypeTextBox)
        Me.Controls.Add(CapacityLabel)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(Me.RoomMana)
        Me.Controls.Add(Me.RoomDataGridView)
        Me.Controls.Add(Me.RoomBindingNavigator)
        Me.Name = "Room_AddRoom"
        Me.Text = "Room_AddRoom"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomBindingNavigator.ResumeLayout(False)
        Me.RoomBindingNavigator.PerformLayout()
        CType(Me.RoomDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As WellmeadowsDBDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RoomBindingNavigator As BindingNavigator
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
    Friend WithEvents RoomBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RoomDataGridView As DataGridView
    Friend WithEvents RoomMana As Label
    Friend WithEvents RoomIDTextBox As TextBox
    Friend WithEvents RoomNoTextBox As TextBox
    Friend WithEvents RoomTypeTextBox As TextBox
    Friend WithEvents CapacityTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
