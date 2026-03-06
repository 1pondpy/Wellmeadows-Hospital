<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_AddBed
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
        Dim BedIDLabel As System.Windows.Forms.Label
        Dim BedNoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim WardIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_AddBed))
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.BedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BedTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.BedTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.BedBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BedBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BedDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mama = New System.Windows.Forms.Label()
        Me.BedIDTextBox = New System.Windows.Forms.TextBox()
        Me.BedNoTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.WardIDTextBox = New System.Windows.Forms.TextBox()
        BedIDLabel = New System.Windows.Forms.Label()
        BedNoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        WardIDLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BedBindingNavigator.SuspendLayout()
        CType(Me.BedDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BedIDLabel
        '
        BedIDLabel.AutoSize = True
        BedIDLabel.BackColor = System.Drawing.Color.White
        BedIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        BedIDLabel.Location = New System.Drawing.Point(201, 400)
        BedIDLabel.Name = "BedIDLabel"
        BedIDLabel.Size = New System.Drawing.Size(59, 17)
        BedIDLabel.TabIndex = 3
        BedIDLabel.Text = "*Bed ID:"
        '
        'BedNoLabel
        '
        BedNoLabel.AutoSize = True
        BedNoLabel.BackColor = System.Drawing.Color.White
        BedNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        BedNoLabel.Location = New System.Drawing.Point(201, 428)
        BedNoLabel.Name = "BedNoLabel"
        BedNoLabel.Size = New System.Drawing.Size(64, 17)
        BedNoLabel.TabIndex = 5
        BedNoLabel.Text = "*Bed No:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.BackColor = System.Drawing.Color.White
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StatusLabel.Location = New System.Drawing.Point(457, 371)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(57, 17)
        StatusLabel.TabIndex = 7
        StatusLabel.Text = "*Status:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.BackColor = System.Drawing.Color.White
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DescriptionLabel.Location = New System.Drawing.Point(457, 398)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(83, 17)
        DescriptionLabel.TabIndex = 9
        DescriptionLabel.Text = "Description:"
        '
        'WardIDLabel
        '
        WardIDLabel.AutoSize = True
        WardIDLabel.BackColor = System.Drawing.Color.White
        WardIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        WardIDLabel.Location = New System.Drawing.Point(201, 371)
        WardIDLabel.Name = "WardIDLabel"
        WardIDLabel.Size = New System.Drawing.Size(68, 17)
        WardIDLabel.TabIndex = 11
        WardIDLabel.Text = "*Ward ID:"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BedBindingSource
        '
        Me.BedBindingSource.DataMember = "Bed"
        Me.BedBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'BedTableAdapter
        '
        Me.BedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Me.BedTableAdapter
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
        'BedBindingNavigator
        '
        Me.BedBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BedBindingNavigator.BindingSource = Me.BedBindingSource
        Me.BedBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BedBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BedBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BedBindingNavigatorSaveItem})
        Me.BedBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BedBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BedBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BedBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BedBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BedBindingNavigator.Name = "BedBindingNavigator"
        Me.BedBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BedBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.BedBindingNavigator.TabIndex = 0
        Me.BedBindingNavigator.Text = "BindingNavigator1"
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
        'BedBindingNavigatorSaveItem
        '
        Me.BedBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BedBindingNavigatorSaveItem.Image = CType(resources.GetObject("BedBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BedBindingNavigatorSaveItem.Name = "BedBindingNavigatorSaveItem"
        Me.BedBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BedBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BedDataGridView
        '
        Me.BedDataGridView.AutoGenerateColumns = False
        Me.BedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.BedDataGridView.DataSource = Me.BedBindingSource
        Me.BedDataGridView.Location = New System.Drawing.Point(67, 98)
        Me.BedDataGridView.Name = "BedDataGridView"
        Me.BedDataGridView.Size = New System.Drawing.Size(749, 239)
        Me.BedDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BedID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BedID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BedNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BedNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "WardID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "WardID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Mama
        '
        Me.Mama.AutoSize = True
        Me.Mama.BackColor = System.Drawing.Color.White
        Me.Mama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Mama.Location = New System.Drawing.Point(64, 57)
        Me.Mama.Name = "Mama"
        Me.Mama.Size = New System.Drawing.Size(119, 17)
        Me.Mama.TabIndex = 2
        Me.Mama.Text = "Bed Management"
        '
        'BedIDTextBox
        '
        Me.BedIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedBindingSource, "BedID", True))
        Me.BedIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BedIDTextBox.Location = New System.Drawing.Point(270, 397)
        Me.BedIDTextBox.Name = "BedIDTextBox"
        Me.BedIDTextBox.Size = New System.Drawing.Size(152, 23)
        Me.BedIDTextBox.TabIndex = 4
        '
        'BedNoTextBox
        '
        Me.BedNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedBindingSource, "BedNo", True))
        Me.BedNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BedNoTextBox.Location = New System.Drawing.Point(270, 425)
        Me.BedNoTextBox.Name = "BedNoTextBox"
        Me.BedNoTextBox.Size = New System.Drawing.Size(152, 23)
        Me.BedNoTextBox.TabIndex = 6
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedBindingSource, "Status", True))
        Me.StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Available", "Occupied", "Out of Service"})
        Me.StatusComboBox.Location = New System.Drawing.Point(546, 367)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(133, 24)
        Me.StatusComboBox.TabIndex = 8
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DescriptionTextBox.Location = New System.Drawing.Point(546, 398)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(133, 23)
        Me.DescriptionTextBox.TabIndex = 10
        '
        'WardIDTextBox
        '
        Me.WardIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedBindingSource, "WardID", True))
        Me.WardIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.WardIDTextBox.Location = New System.Drawing.Point(270, 368)
        Me.WardIDTextBox.Name = "WardIDTextBox"
        Me.WardIDTextBox.Size = New System.Drawing.Size(152, 23)
        Me.WardIDTextBox.TabIndex = 12
        '
        'Patient_AddBed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(BedIDLabel)
        Me.Controls.Add(Me.BedIDTextBox)
        Me.Controls.Add(BedNoLabel)
        Me.Controls.Add(Me.BedNoTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(WardIDLabel)
        Me.Controls.Add(Me.WardIDTextBox)
        Me.Controls.Add(Me.Mama)
        Me.Controls.Add(Me.BedDataGridView)
        Me.Controls.Add(Me.BedBindingNavigator)
        Me.Name = "Patient_AddBed"
        Me.Text = "Patient_AddBed"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BedBindingNavigator.ResumeLayout(False)
        Me.BedBindingNavigator.PerformLayout()
        CType(Me.BedDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents BedBindingSource As BindingSource
    Friend WithEvents BedTableAdapter As WellmeadowsDBDataSetTableAdapters.BedTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BedBindingNavigator As BindingNavigator
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
    Friend WithEvents BedBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BedDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Mama As Label
    Friend WithEvents BedIDTextBox As TextBox
    Friend WithEvents BedNoTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents WardIDTextBox As TextBox
End Class
