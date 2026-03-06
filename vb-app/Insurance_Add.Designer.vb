<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Insurance_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Insurance_Add))
        Dim InsuranceIDLabel As System.Windows.Forms.Label
        Dim InsuranceNameLabel As System.Windows.Forms.Label
        Dim CovTypeLabel As System.Windows.Forms.Label
        Dim CovPercentLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.InsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsuranceTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.InsuranceTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.InsuranceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.InsuranceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InsuranceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsuranceIDTextBox = New System.Windows.Forms.TextBox()
        Me.InsuranceNameTextBox = New System.Windows.Forms.TextBox()
        Me.CovTypeTextBox = New System.Windows.Forms.TextBox()
        Me.CovPercentTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNoTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        InsuranceIDLabel = New System.Windows.Forms.Label()
        InsuranceNameLabel = New System.Windows.Forms.Label()
        CovTypeLabel = New System.Windows.Forms.Label()
        CovPercentLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InsuranceBindingNavigator.SuspendLayout()
        CType(Me.InsuranceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(51, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Add Insurance"
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InsuranceBindingSource
        '
        Me.InsuranceBindingSource.DataMember = "Insurance"
        Me.InsuranceBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'InsuranceTableAdapter
        '
        Me.InsuranceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Nothing
        Me.TableAdapterManager.InpatientTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceTableAdapter = Me.InsuranceTableAdapter
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
        'InsuranceBindingNavigator
        '
        Me.InsuranceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InsuranceBindingNavigator.BindingSource = Me.InsuranceBindingSource
        Me.InsuranceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InsuranceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InsuranceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InsuranceBindingNavigatorSaveItem})
        Me.InsuranceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InsuranceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InsuranceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InsuranceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InsuranceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InsuranceBindingNavigator.Name = "InsuranceBindingNavigator"
        Me.InsuranceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InsuranceBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.InsuranceBindingNavigator.TabIndex = 11
        Me.InsuranceBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'InsuranceBindingNavigatorSaveItem
        '
        Me.InsuranceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InsuranceBindingNavigatorSaveItem.Image = CType(resources.GetObject("InsuranceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InsuranceBindingNavigatorSaveItem.Name = "InsuranceBindingNavigatorSaveItem"
        Me.InsuranceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InsuranceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InsuranceDataGridView
        '
        Me.InsuranceDataGridView.AutoGenerateColumns = False
        Me.InsuranceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InsuranceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InsuranceDataGridView.DataSource = Me.InsuranceBindingSource
        Me.InsuranceDataGridView.Location = New System.Drawing.Point(47, 81)
        Me.InsuranceDataGridView.Name = "InsuranceDataGridView"
        Me.InsuranceDataGridView.Size = New System.Drawing.Size(788, 248)
        Me.InsuranceDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InsuranceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InsuranceID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "InsuranceName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "InsuranceName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CovType"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CovType"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CovPercent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CovPercent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ContactNo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ContactNo"
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
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'InsuranceIDLabel
        '
        InsuranceIDLabel.AutoSize = True
        InsuranceIDLabel.BackColor = System.Drawing.Color.White
        InsuranceIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        InsuranceIDLabel.Location = New System.Drawing.Point(128, 361)
        InsuranceIDLabel.Name = "InsuranceIDLabel"
        InsuranceIDLabel.Size = New System.Drawing.Size(91, 17)
        InsuranceIDLabel.TabIndex = 11
        InsuranceIDLabel.Text = "Insurance ID:"
        '
        'InsuranceIDTextBox
        '
        Me.InsuranceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "InsuranceID", True))
        Me.InsuranceIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InsuranceIDTextBox.Location = New System.Drawing.Point(252, 358)
        Me.InsuranceIDTextBox.Name = "InsuranceIDTextBox"
        Me.InsuranceIDTextBox.Size = New System.Drawing.Size(166, 23)
        Me.InsuranceIDTextBox.TabIndex = 12
        '
        'InsuranceNameLabel
        '
        InsuranceNameLabel.AutoSize = True
        InsuranceNameLabel.BackColor = System.Drawing.Color.White
        InsuranceNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        InsuranceNameLabel.Location = New System.Drawing.Point(128, 390)
        InsuranceNameLabel.Name = "InsuranceNameLabel"
        InsuranceNameLabel.Size = New System.Drawing.Size(115, 17)
        InsuranceNameLabel.TabIndex = 13
        InsuranceNameLabel.Text = "Insurance Name:"
        '
        'InsuranceNameTextBox
        '
        Me.InsuranceNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "InsuranceName", True))
        Me.InsuranceNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InsuranceNameTextBox.Location = New System.Drawing.Point(252, 387)
        Me.InsuranceNameTextBox.Name = "InsuranceNameTextBox"
        Me.InsuranceNameTextBox.Size = New System.Drawing.Size(166, 23)
        Me.InsuranceNameTextBox.TabIndex = 14
        '
        'CovTypeLabel
        '
        CovTypeLabel.AutoSize = True
        CovTypeLabel.BackColor = System.Drawing.Color.White
        CovTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        CovTypeLabel.Location = New System.Drawing.Point(484, 361)
        CovTypeLabel.Name = "CovTypeLabel"
        CovTypeLabel.Size = New System.Drawing.Size(72, 17)
        CovTypeLabel.TabIndex = 15
        CovTypeLabel.Text = "Cov Type:"
        '
        'CovTypeTextBox
        '
        Me.CovTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "CovType", True))
        Me.CovTypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CovTypeTextBox.Location = New System.Drawing.Point(583, 358)
        Me.CovTypeTextBox.Name = "CovTypeTextBox"
        Me.CovTypeTextBox.Size = New System.Drawing.Size(166, 23)
        Me.CovTypeTextBox.TabIndex = 16
        '
        'CovPercentLabel
        '
        CovPercentLabel.AutoSize = True
        CovPercentLabel.BackColor = System.Drawing.Color.White
        CovPercentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        CovPercentLabel.Location = New System.Drawing.Point(484, 390)
        CovPercentLabel.Name = "CovPercentLabel"
        CovPercentLabel.Size = New System.Drawing.Size(89, 17)
        CovPercentLabel.TabIndex = 17
        CovPercentLabel.Text = "Cov Percent:"
        '
        'CovPercentTextBox
        '
        Me.CovPercentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "CovPercent", True))
        Me.CovPercentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CovPercentTextBox.Location = New System.Drawing.Point(583, 387)
        Me.CovPercentTextBox.Name = "CovPercentTextBox"
        Me.CovPercentTextBox.Size = New System.Drawing.Size(166, 23)
        Me.CovPercentTextBox.TabIndex = 18
        '
        'ContactNoLabel
        '
        ContactNoLabel.AutoSize = True
        ContactNoLabel.BackColor = System.Drawing.Color.White
        ContactNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        ContactNoLabel.Location = New System.Drawing.Point(128, 419)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(82, 17)
        ContactNoLabel.TabIndex = 19
        ContactNoLabel.Text = "Contact No:"
        '
        'ContactNoTextBox
        '
        Me.ContactNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "ContactNo", True))
        Me.ContactNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ContactNoTextBox.Location = New System.Drawing.Point(252, 416)
        Me.ContactNoTextBox.Name = "ContactNoTextBox"
        Me.ContactNoTextBox.Size = New System.Drawing.Size(166, 23)
        Me.ContactNoTextBox.TabIndex = 20
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        AddressLabel.Location = New System.Drawing.Point(128, 448)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 21
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddressTextBox.Location = New System.Drawing.Point(252, 445)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(166, 23)
        Me.AddressTextBox.TabIndex = 22
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.BackColor = System.Drawing.Color.White
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NotesLabel.Location = New System.Drawing.Point(128, 477)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(49, 17)
        NotesLabel.TabIndex = 23
        NotesLabel.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InsuranceBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NotesTextBox.Location = New System.Drawing.Point(252, 474)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(166, 23)
        Me.NotesTextBox.TabIndex = 24
        '
        'Insurance_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 591)
        Me.Controls.Add(InsuranceIDLabel)
        Me.Controls.Add(Me.InsuranceIDTextBox)
        Me.Controls.Add(InsuranceNameLabel)
        Me.Controls.Add(Me.InsuranceNameTextBox)
        Me.Controls.Add(CovTypeLabel)
        Me.Controls.Add(Me.CovTypeTextBox)
        Me.Controls.Add(CovPercentLabel)
        Me.Controls.Add(Me.CovPercentTextBox)
        Me.Controls.Add(ContactNoLabel)
        Me.Controls.Add(Me.ContactNoTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Me.InsuranceDataGridView)
        Me.Controls.Add(Me.InsuranceBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Insurance_Add"
        Me.Text = "Insurance_Add"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InsuranceBindingNavigator.ResumeLayout(False)
        Me.InsuranceBindingNavigator.PerformLayout()
        CType(Me.InsuranceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents InsuranceBindingSource As BindingSource
    Friend WithEvents InsuranceTableAdapter As WellmeadowsDBDataSetTableAdapters.InsuranceTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InsuranceBindingNavigator As BindingNavigator
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
    Friend WithEvents InsuranceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InsuranceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents InsuranceIDTextBox As TextBox
    Friend WithEvents InsuranceNameTextBox As TextBox
    Friend WithEvents CovTypeTextBox As TextBox
    Friend WithEvents CovPercentTextBox As TextBox
    Friend WithEvents ContactNoTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
End Class
