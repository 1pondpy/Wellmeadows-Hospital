<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clinic_AddClinic
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
        Dim ClinicNoLabel As System.Windows.Forms.Label
        Dim ClinicNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clinic_AddClinic))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.ClinicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.ClinicTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.ClinicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClinicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClinicDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClinicNoTextBox = New System.Windows.Forms.TextBox()
        Me.ClinicNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        ClinicNoLabel = New System.Windows.Forms.Label()
        ClinicNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClinicBindingNavigator.SuspendLayout()
        CType(Me.ClinicDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClinicNoLabel
        '
        ClinicNoLabel.AutoSize = True
        ClinicNoLabel.BackColor = System.Drawing.Color.White
        ClinicNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ClinicNoLabel.Location = New System.Drawing.Point(257, 328)
        ClinicNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ClinicNoLabel.Name = "ClinicNoLabel"
        ClinicNoLabel.Size = New System.Drawing.Size(108, 17)
        ClinicNoLabel.TabIndex = 2
        ClinicNoLabel.Text = "*Clinic Number :"
        '
        'ClinicNameLabel
        '
        ClinicNameLabel.AutoSize = True
        ClinicNameLabel.BackColor = System.Drawing.Color.White
        ClinicNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ClinicNameLabel.Location = New System.Drawing.Point(270, 354)
        ClinicNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ClinicNameLabel.Name = "ClinicNameLabel"
        ClinicNameLabel.Size = New System.Drawing.Size(95, 17)
        ClinicNameLabel.TabIndex = 4
        ClinicNameLabel.Text = "*Clinic Name :"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AddressLabel.Location = New System.Drawing.Point(292, 383)
        AddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(73, 17)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "*Address :"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BackColor = System.Drawing.Color.White
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PhoneLabel.Location = New System.Drawing.Point(303, 412)
        PhoneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(62, 17)
        PhoneLabel.TabIndex = 8
        PhoneLabel.Text = "*Phone :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.White
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Label1.Location = New System.Drawing.Point(95, 53)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 17)
        Label1.TabIndex = 10
        Label1.Text = "Add Clinic"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicBindingSource
        '
        Me.ClinicBindingSource.DataMember = "Clinic"
        Me.ClinicBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'ClinicTableAdapter
        '
        Me.ClinicTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Me.ClinicTableAdapter
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
        'ClinicBindingNavigator
        '
        Me.ClinicBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClinicBindingNavigator.BindingSource = Me.ClinicBindingSource
        Me.ClinicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClinicBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClinicBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ClinicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClinicBindingNavigatorSaveItem})
        Me.ClinicBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClinicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClinicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClinicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClinicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClinicBindingNavigator.Name = "ClinicBindingNavigator"
        Me.ClinicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClinicBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.ClinicBindingNavigator.TabIndex = 0
        Me.ClinicBindingNavigator.Text = "BindingNavigator1"
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
        'ClinicBindingNavigatorSaveItem
        '
        Me.ClinicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClinicBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClinicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClinicBindingNavigatorSaveItem.Name = "ClinicBindingNavigatorSaveItem"
        Me.ClinicBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.ClinicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClinicDataGridView
        '
        Me.ClinicDataGridView.AutoGenerateColumns = False
        Me.ClinicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClinicDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ClinicDataGridView.DataSource = Me.ClinicBindingSource
        Me.ClinicDataGridView.Location = New System.Drawing.Point(98, 101)
        Me.ClinicDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.ClinicDataGridView.Name = "ClinicDataGridView"
        Me.ClinicDataGridView.RowHeadersWidth = 51
        Me.ClinicDataGridView.RowTemplate.Height = 24
        Me.ClinicDataGridView.Size = New System.Drawing.Size(677, 179)
        Me.ClinicDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ClinicNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ClinicNo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ClinicName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ClinicName"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'ClinicNoTextBox
        '
        Me.ClinicNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "ClinicNo", True))
        Me.ClinicNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClinicNoTextBox.Location = New System.Drawing.Point(378, 325)
        Me.ClinicNoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ClinicNoTextBox.Name = "ClinicNoTextBox"
        Me.ClinicNoTextBox.Size = New System.Drawing.Size(179, 23)
        Me.ClinicNoTextBox.TabIndex = 3
        '
        'ClinicNameTextBox
        '
        Me.ClinicNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "ClinicName", True))
        Me.ClinicNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ClinicNameTextBox.Location = New System.Drawing.Point(378, 352)
        Me.ClinicNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ClinicNameTextBox.Name = "ClinicNameTextBox"
        Me.ClinicNameTextBox.Size = New System.Drawing.Size(179, 23)
        Me.ClinicNameTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(378, 380)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(179, 23)
        Me.AddressTextBox.TabIndex = 7
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClinicBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PhoneTextBox.Location = New System.Drawing.Point(378, 409)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(179, 23)
        Me.PhoneTextBox.TabIndex = 9
        '
        'Clinic_AddClinic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(ClinicNameLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(ClinicNoLabel)
        Me.Controls.Add(Me.ClinicNoTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.ClinicNameTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.ClinicDataGridView)
        Me.Controls.Add(Me.ClinicBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Clinic_AddClinic"
        Me.Text = "Clinic_AddClinic"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClinicBindingNavigator.ResumeLayout(False)
        Me.ClinicBindingNavigator.PerformLayout()
        CType(Me.ClinicDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents ClinicBindingSource As BindingSource
    Friend WithEvents ClinicTableAdapter As WellmeadowsDBDataSetTableAdapters.ClinicTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClinicBindingNavigator As BindingNavigator
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
    Friend WithEvents ClinicBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClinicDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents ClinicNoTextBox As TextBox
    Friend WithEvents ClinicNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
End Class
