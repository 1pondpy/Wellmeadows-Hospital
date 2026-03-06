<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ward_AddWardChargeNurse
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
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim ChargeNurseIDLabel1 As System.Windows.Forms.Label
        Dim WardNameLabel As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim TelExtnLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ward_AddWardChargeNurse))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.WardTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.WardBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.WardBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        Me.WardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboChargeNurse = New System.Windows.Forms.ComboBox()
        Me.WardNameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.TelExtnTextBox = New System.Windows.Forms.TextBox()
        Me.AddWard = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        ChargeNurseIDLabel1 = New System.Windows.Forms.Label()
        WardNameLabel = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        TelExtnLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WardBindingNavigator.SuspendLayout()
        CType(Me.WardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.White
        WardIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WardIDLabel.Location = New System.Drawing.Point(313, 336)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(68, 17)
        WardIDLabel.TabIndex = 1
        WardIDLabel.Text = "*Ward ID:"
        '
        'ChargeNurseIDLabel1
        '
        ChargeNurseIDLabel1.AutoSize = True
        ChargeNurseIDLabel1.BackColor = System.Drawing.Color.White
        ChargeNurseIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ChargeNurseIDLabel1.Location = New System.Drawing.Point(276, 449)
        ChargeNurseIDLabel1.Name = "ChargeNurseIDLabel1"
        ChargeNurseIDLabel1.Size = New System.Drawing.Size(105, 17)
        ChargeNurseIDLabel1.TabIndex = 10
        ChargeNurseIDLabel1.Text = "*Charge Nurse:"
        '
        'WardNameLabel
        '
        WardNameLabel.AutoSize = True
        WardNameLabel.BackColor = System.Drawing.Color.White
        WardNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WardNameLabel.Location = New System.Drawing.Point(289, 364)
        WardNameLabel.Name = "WardNameLabel"
        WardNameLabel.Size = New System.Drawing.Size(92, 17)
        WardNameLabel.TabIndex = 11
        WardNameLabel.Text = "*Ward Name:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.White
        LocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        LocationLabel.Location = New System.Drawing.Point(310, 392)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(71, 17)
        LocationLabel.TabIndex = 12
        LocationLabel.Text = "*Location:"
        '
        'TelExtnLabel
        '
        TelExtnLabel.AutoSize = True
        TelExtnLabel.BackColor = System.Drawing.Color.White
        TelExtnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        TelExtnLabel.Location = New System.Drawing.Point(313, 420)
        TelExtnLabel.Name = "TelExtnLabel"
        TelExtnLabel.Size = New System.Drawing.Size(68, 17)
        TelExtnLabel.TabIndex = 13
        TelExtnLabel.Text = "*Tel Extn:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "Ward"
        Me.WardBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.WardTableAdapter = Me.WardTableAdapter
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'WardBindingNavigator
        '
        Me.WardBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WardBindingNavigator.BackColor = System.Drawing.Color.White
        Me.WardBindingNavigator.BindingSource = Me.WardBindingSource
        Me.WardBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WardBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WardBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WardBindingNavigatorSaveItem})
        Me.WardBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WardBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WardBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WardBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WardBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WardBindingNavigator.Name = "WardBindingNavigator"
        Me.WardBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WardBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.WardBindingNavigator.TabIndex = 0
        Me.WardBindingNavigator.Text = "BindingNavigator1"
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
        'WardBindingNavigatorSaveItem
        '
        Me.WardBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WardBindingNavigatorSaveItem.Image = CType(resources.GetObject("WardBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WardBindingNavigatorSaveItem.Name = "WardBindingNavigatorSaveItem"
        Me.WardBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WardBindingNavigatorSaveItem.Text = "Save Data"
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "WardID", True))
        Me.WardIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WardIDTextBox.Location = New System.Drawing.Point(393, 333)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(172, 23)
        Me.WardIDTextBox.TabIndex = 2
        '
        'WardDataGridView
        '
        Me.WardDataGridView.AutoGenerateColumns = False
        Me.WardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.WardDataGridView.DataSource = Me.WardBindingSource
        Me.WardDataGridView.Location = New System.Drawing.Point(55, 86)
        Me.WardDataGridView.Name = "WardDataGridView"
        Me.WardDataGridView.Size = New System.Drawing.Size(770, 214)
        Me.WardDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WardID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WardID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WardName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WardName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TelExtn"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TelExtn"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ChargeNurseID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ChargeNurseID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'cboChargeNurse
        '
        Me.cboChargeNurse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "ChargeNurseID", True))
        Me.cboChargeNurse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboChargeNurse.FormattingEnabled = True
        Me.cboChargeNurse.Location = New System.Drawing.Point(393, 446)
        Me.cboChargeNurse.Name = "cboChargeNurse"
        Me.cboChargeNurse.Size = New System.Drawing.Size(172, 24)
        Me.cboChargeNurse.TabIndex = 11
        '
        'WardNameTextBox
        '
        Me.WardNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "WardName", True))
        Me.WardNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WardNameTextBox.Location = New System.Drawing.Point(393, 361)
        Me.WardNameTextBox.Name = "WardNameTextBox"
        Me.WardNameTextBox.Size = New System.Drawing.Size(172, 23)
        Me.WardNameTextBox.TabIndex = 12
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LocationTextBox.Location = New System.Drawing.Point(393, 389)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(172, 23)
        Me.LocationTextBox.TabIndex = 13
        '
        'TelExtnTextBox
        '
        Me.TelExtnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WardBindingSource, "TelExtn", True))
        Me.TelExtnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TelExtnTextBox.Location = New System.Drawing.Point(393, 417)
        Me.TelExtnTextBox.Name = "TelExtnTextBox"
        Me.TelExtnTextBox.Size = New System.Drawing.Size(172, 23)
        Me.TelExtnTextBox.TabIndex = 14
        '
        'AddWard
        '
        Me.AddWard.AutoSize = True
        Me.AddWard.BackColor = System.Drawing.Color.White
        Me.AddWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddWard.Location = New System.Drawing.Point(57, 51)
        Me.AddWard.Name = "AddWard"
        Me.AddWard.Size = New System.Drawing.Size(191, 17)
        Me.AddWard.TabIndex = 15
        Me.AddWard.Text = "Add Ward and Charge Nurse"
        '
        'Ward_AddWardChargeNurse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AddWard)
        Me.Controls.Add(TelExtnLabel)
        Me.Controls.Add(Me.TelExtnTextBox)
        Me.Controls.Add(LocationLabel)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(WardNameLabel)
        Me.Controls.Add(Me.WardNameTextBox)
        Me.Controls.Add(ChargeNurseIDLabel1)
        Me.Controls.Add(Me.cboChargeNurse)
        Me.Controls.Add(Me.WardDataGridView)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDTextBox)
        Me.Controls.Add(Me.WardBindingNavigator)
        Me.Name = "Ward_AddWardChargeNurse"
        Me.Text = "Ward & Charge Nurse"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WardBindingNavigator.ResumeLayout(False)
        Me.WardBindingNavigator.PerformLayout()
        CType(Me.WardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents WardTableAdapter As WellmeadowsDBDataSetTableAdapters.WardTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WardBindingNavigator As BindingNavigator
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
    Friend WithEvents WardBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WardIDTextBox As TextBox
    Friend WithEvents WardDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents cboChargeNurse As ComboBox
    Friend WithEvents WardNameTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents TelExtnTextBox As TextBox
    Friend WithEvents AddWard As Label
End Class
