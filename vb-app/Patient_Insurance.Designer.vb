<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Insurance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient_Insurance))
        Dim PatientIDLabel As System.Windows.Forms.Label
        Dim InsuranceIDLabel As System.Windows.Forms.Label
        Dim IsPrimaryLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim addpa As System.Windows.Forms.Label
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.PatientInsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientInsuranceTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.PatientInsuranceTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.PatientInsuranceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientInsuranceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientInsuranceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.InsuranceIDTextBox = New System.Windows.Forms.TextBox()
        Me.IsPrimaryCheckBox = New System.Windows.Forms.CheckBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddPatient = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        PatientIDLabel = New System.Windows.Forms.Label()
        InsuranceIDLabel = New System.Windows.Forms.Label()
        IsPrimaryLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        addpa = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInsuranceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientInsuranceBindingNavigator.SuspendLayout()
        CType(Me.PatientInsuranceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientInsuranceBindingSource
        '
        Me.PatientInsuranceBindingSource.DataMember = "PatientInsurance"
        Me.PatientInsuranceBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'PatientInsuranceTableAdapter
        '
        Me.PatientInsuranceTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientInsuranceTableAdapter = Me.PatientInsuranceTableAdapter
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
        'PatientInsuranceBindingNavigator
        '
        Me.PatientInsuranceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientInsuranceBindingNavigator.BindingSource = Me.PatientInsuranceBindingSource
        Me.PatientInsuranceBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientInsuranceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientInsuranceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientInsuranceBindingNavigatorSaveItem})
        Me.PatientInsuranceBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientInsuranceBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientInsuranceBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientInsuranceBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientInsuranceBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientInsuranceBindingNavigator.Name = "PatientInsuranceBindingNavigator"
        Me.PatientInsuranceBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientInsuranceBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.PatientInsuranceBindingNavigator.TabIndex = 0
        Me.PatientInsuranceBindingNavigator.Text = "BindingNavigator1"
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
        'PatientInsuranceBindingNavigatorSaveItem
        '
        Me.PatientInsuranceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientInsuranceBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientInsuranceBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientInsuranceBindingNavigatorSaveItem.Name = "PatientInsuranceBindingNavigatorSaveItem"
        Me.PatientInsuranceBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientInsuranceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PatientInsuranceDataGridView
        '
        Me.PatientInsuranceDataGridView.AutoGenerateColumns = False
        Me.PatientInsuranceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientInsuranceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.PatientInsuranceDataGridView.DataSource = Me.PatientInsuranceBindingSource
        Me.PatientInsuranceDataGridView.Location = New System.Drawing.Point(59, 85)
        Me.PatientInsuranceDataGridView.Name = "PatientInsuranceDataGridView"
        Me.PatientInsuranceDataGridView.Size = New System.Drawing.Size(751, 220)
        Me.PatientInsuranceDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientInsuranceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PatientInsuranceID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PatientID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InsuranceID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "InsuranceID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "IsPrimary"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "IsPrimary"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PatientIDLabel
        '
        PatientIDLabel.AutoSize = True
        PatientIDLabel.BackColor = System.Drawing.Color.White
        PatientIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PatientIDLabel.Location = New System.Drawing.Point(141, 368)
        PatientIDLabel.Name = "PatientIDLabel"
        PatientIDLabel.Size = New System.Drawing.Size(73, 17)
        PatientIDLabel.TabIndex = 4
        PatientIDLabel.Text = "Patient ID:"
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInsuranceBindingSource, "PatientID", True))
        Me.PatientIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PatientIDTextBox.Location = New System.Drawing.Point(236, 365)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(133, 23)
        Me.PatientIDTextBox.TabIndex = 5
        '
        'InsuranceIDLabel
        '
        InsuranceIDLabel.AutoSize = True
        InsuranceIDLabel.BackColor = System.Drawing.Color.White
        InsuranceIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        InsuranceIDLabel.Location = New System.Drawing.Point(123, 433)
        InsuranceIDLabel.Name = "InsuranceIDLabel"
        InsuranceIDLabel.Size = New System.Drawing.Size(91, 17)
        InsuranceIDLabel.TabIndex = 6
        InsuranceIDLabel.Text = "Insurance ID:"
        '
        'InsuranceIDTextBox
        '
        Me.InsuranceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInsuranceBindingSource, "InsuranceID", True))
        Me.InsuranceIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InsuranceIDTextBox.Location = New System.Drawing.Point(236, 430)
        Me.InsuranceIDTextBox.Name = "InsuranceIDTextBox"
        Me.InsuranceIDTextBox.Size = New System.Drawing.Size(133, 23)
        Me.InsuranceIDTextBox.TabIndex = 7
        '
        'IsPrimaryLabel
        '
        IsPrimaryLabel.AutoSize = True
        IsPrimaryLabel.BackColor = System.Drawing.Color.White
        IsPrimaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        IsPrimaryLabel.Location = New System.Drawing.Point(466, 371)
        IsPrimaryLabel.Name = "IsPrimaryLabel"
        IsPrimaryLabel.Size = New System.Drawing.Size(74, 17)
        IsPrimaryLabel.TabIndex = 8
        IsPrimaryLabel.Text = "Is Primary:"
        '
        'IsPrimaryCheckBox
        '
        Me.IsPrimaryCheckBox.BackColor = System.Drawing.Color.White
        Me.IsPrimaryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.PatientInsuranceBindingSource, "IsPrimary", True))
        Me.IsPrimaryCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.IsPrimaryCheckBox.Location = New System.Drawing.Point(550, 368)
        Me.IsPrimaryCheckBox.Name = "IsPrimaryCheckBox"
        Me.IsPrimaryCheckBox.Size = New System.Drawing.Size(133, 24)
        Me.IsPrimaryCheckBox.TabIndex = 9
        Me.IsPrimaryCheckBox.Text = "CheckBox1"
        Me.IsPrimaryCheckBox.UseVisualStyleBackColor = False
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.BackColor = System.Drawing.Color.White
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        NotesLabel.Location = New System.Drawing.Point(491, 433)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(49, 17)
        NotesLabel.TabIndex = 10
        NotesLabel.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientInsuranceBindingSource, "Notes", True))
        Me.NotesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.NotesTextBox.Location = New System.Drawing.Point(550, 430)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(133, 23)
        Me.NotesTextBox.TabIndex = 11
        '
        'addpa
        '
        addpa.AutoSize = True
        addpa.BackColor = System.Drawing.Color.White
        addpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        addpa.Location = New System.Drawing.Point(65, 44)
        addpa.Name = "addpa"
        addpa.Size = New System.Drawing.Size(147, 17)
        addpa.TabIndex = 12
        addpa.Text = "Add Patient Insurance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(238, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Patient Name"
        '
        'AddPatient
        '
        Me.AddPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddPatient.Location = New System.Drawing.Point(371, 365)
        Me.AddPatient.Name = "AddPatient"
        Me.AddPatient.Size = New System.Drawing.Size(32, 23)
        Me.AddPatient.TabIndex = 26
        Me.AddPatient.Text = "....."
        Me.AddPatient.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(238, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Insurance Name"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(371, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "....."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Patient_Insurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 591)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddPatient)
        Me.Controls.Add(addpa)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(IsPrimaryLabel)
        Me.Controls.Add(Me.IsPrimaryCheckBox)
        Me.Controls.Add(InsuranceIDLabel)
        Me.Controls.Add(Me.InsuranceIDTextBox)
        Me.Controls.Add(PatientIDLabel)
        Me.Controls.Add(Me.PatientIDTextBox)
        Me.Controls.Add(Me.PatientInsuranceDataGridView)
        Me.Controls.Add(Me.PatientInsuranceBindingNavigator)
        Me.Name = "Patient_Insurance"
        Me.Text = "Patient_Insurance"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInsuranceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientInsuranceBindingNavigator.ResumeLayout(False)
        Me.PatientInsuranceBindingNavigator.PerformLayout()
        CType(Me.PatientInsuranceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents PatientInsuranceBindingSource As BindingSource
    Friend WithEvents PatientInsuranceTableAdapter As WellmeadowsDBDataSetTableAdapters.PatientInsuranceTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientInsuranceBindingNavigator As BindingNavigator
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
    Friend WithEvents PatientInsuranceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PatientInsuranceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents InsuranceIDTextBox As TextBox
    Friend WithEvents IsPrimaryCheckBox As CheckBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddPatient As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
