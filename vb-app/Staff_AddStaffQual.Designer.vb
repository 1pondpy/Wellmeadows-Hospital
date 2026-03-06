<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_AddStaffQual
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
        Dim QualIDLabel As System.Windows.Forms.Label
        Dim StaffIDLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_AddStaffQual))
        Me.StaffQualificationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffQualificationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.StaffQualificationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.StaffQualificationTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.StaffQualificationTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.StaffTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.StaffTableAdapter()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualViewTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.QualViewTableAdapter()
        Me.QualIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffIDTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SearchStaffQual = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaffQualificationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddStaffQual = New System.Windows.Forms.Label()
        QualIDLabel = New System.Windows.Forms.Label()
        StaffIDLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        CType(Me.StaffQualificationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffQualificationBindingNavigator.SuspendLayout()
        CType(Me.StaffQualificationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffQualificationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QualIDLabel
        '
        QualIDLabel.AutoSize = True
        QualIDLabel.BackColor = System.Drawing.Color.White
        QualIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        QualIDLabel.Location = New System.Drawing.Point(282, 372)
        QualIDLabel.Name = "QualIDLabel"
        QualIDLabel.Size = New System.Drawing.Size(64, 17)
        QualIDLabel.TabIndex = 11
        QualIDLabel.Text = "*Qual ID:"
        '
        'StaffIDLabel
        '
        StaffIDLabel.AutoSize = True
        StaffIDLabel.BackColor = System.Drawing.Color.White
        StaffIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StaffIDLabel.Location = New System.Drawing.Point(282, 313)
        StaffIDLabel.Name = "StaffIDLabel"
        StaffIDLabel.Size = New System.Drawing.Size(63, 17)
        StaffIDLabel.TabIndex = 13
        StaffIDLabel.Text = "*Staff ID:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.BackColor = System.Drawing.Color.White
        TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        TypeLabel.Location = New System.Drawing.Point(282, 400)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(49, 17)
        TypeLabel.TabIndex = 15
        TypeLabel.Text = "*Type:"
        '
        'InstitutionLabel
        '
        InstitutionLabel.AutoSize = True
        InstitutionLabel.BackColor = System.Drawing.Color.White
        InstitutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        InstitutionLabel.Location = New System.Drawing.Point(282, 428)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(77, 17)
        InstitutionLabel.TabIndex = 17
        InstitutionLabel.Text = "*Institution:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.BackColor = System.Drawing.Color.White
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DateLabel.Location = New System.Drawing.Point(282, 457)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(47, 17)
        DateLabel.TabIndex = 19
        DateLabel.Text = "*Date:"
        '
        'StaffQualificationBindingNavigator
        '
        Me.StaffQualificationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StaffQualificationBindingNavigator.BindingSource = Me.StaffQualificationBindingSource
        Me.StaffQualificationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StaffQualificationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StaffQualificationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StaffQualificationBindingNavigatorSaveItem})
        Me.StaffQualificationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StaffQualificationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StaffQualificationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StaffQualificationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StaffQualificationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StaffQualificationBindingNavigator.Name = "StaffQualificationBindingNavigator"
        Me.StaffQualificationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StaffQualificationBindingNavigator.Size = New System.Drawing.Size(884, 25)
        Me.StaffQualificationBindingNavigator.TabIndex = 0
        Me.StaffQualificationBindingNavigator.Text = "BindingNavigator1"
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
        'StaffQualificationBindingSource
        '
        Me.StaffQualificationBindingSource.DataMember = "StaffQualification"
        Me.StaffQualificationBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StaffQualificationBindingNavigatorSaveItem
        '
        Me.StaffQualificationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffQualificationBindingNavigatorSaveItem.Image = CType(resources.GetObject("StaffQualificationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StaffQualificationBindingNavigatorSaveItem.Name = "StaffQualificationBindingNavigatorSaveItem"
        Me.StaffQualificationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StaffQualificationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'StaffQualificationTableAdapter
        '
        Me.StaffQualificationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PatientInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PharmaSupplyTableAdapter = Nothing
        Me.TableAdapterManager.RequisitionTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.StaffAllocationTableAdapter = Nothing
        Me.TableAdapterManager.StaffQualificationTableAdapter = Me.StaffQualificationTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.StaffWorkExpTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalSupplyTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.WeekTableAdapter = Nothing
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'QualViewBindingSource
        '
        Me.QualViewBindingSource.DataMember = "QualView"
        Me.QualViewBindingSource.DataSource = Me.WellmeadowsDBDataSet
        '
        'QualViewTableAdapter
        '
        Me.QualViewTableAdapter.ClearBeforeFill = True
        '
        'QualIDTextBox
        '
        Me.QualIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffQualificationBindingSource, "QualID", True))
        Me.QualIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QualIDTextBox.Location = New System.Drawing.Point(365, 370)
        Me.QualIDTextBox.Name = "QualIDTextBox"
        Me.QualIDTextBox.Size = New System.Drawing.Size(241, 23)
        Me.QualIDTextBox.TabIndex = 12
        '
        'StaffIDTextBox
        '
        Me.StaffIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffQualificationBindingSource, "StaffID", True))
        Me.StaffIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StaffIDTextBox.Location = New System.Drawing.Point(365, 311)
        Me.StaffIDTextBox.Name = "StaffIDTextBox"
        Me.StaffIDTextBox.Size = New System.Drawing.Size(115, 23)
        Me.StaffIDTextBox.TabIndex = 14
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffQualificationBindingSource, "Type", True))
        Me.TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TypeTextBox.Location = New System.Drawing.Point(365, 398)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(241, 23)
        Me.TypeTextBox.TabIndex = 16
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffQualificationBindingSource, "Institution", True))
        Me.InstitutionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.InstitutionTextBox.Location = New System.Drawing.Point(365, 426)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(241, 23)
        Me.InstitutionTextBox.TabIndex = 18
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StaffQualificationBindingSource, "Date", True))
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DateDateTimePicker.Location = New System.Drawing.Point(365, 454)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(241, 23)
        Me.DateDateTimePicker.TabIndex = 20
        '
        'SearchStaffQual
        '
        Me.SearchStaffQual.Location = New System.Drawing.Point(486, 311)
        Me.SearchStaffQual.Name = "SearchStaffQual"
        Me.SearchStaffQual.Size = New System.Drawing.Size(40, 23)
        Me.SearchStaffQual.TabIndex = 21
        Me.SearchStaffQual.Text = "....."
        Me.SearchStaffQual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(366, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Staff Name"
        '
        'StaffQualificationDataGridView
        '
        Me.StaffQualificationDataGridView.AutoGenerateColumns = False
        Me.StaffQualificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffQualificationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.StaffQualificationDataGridView.DataSource = Me.StaffQualificationBindingSource
        Me.StaffQualificationDataGridView.Location = New System.Drawing.Point(59, 78)
        Me.StaffQualificationDataGridView.Name = "StaffQualificationDataGridView"
        Me.StaffQualificationDataGridView.Size = New System.Drawing.Size(762, 185)
        Me.StaffQualificationDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "QualID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "QualID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StaffID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StaffID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Institution"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Institution"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'AddStaffQual
        '
        Me.AddStaffQual.AutoSize = True
        Me.AddStaffQual.BackColor = System.Drawing.Color.White
        Me.AddStaffQual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddStaffQual.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddStaffQual.Location = New System.Drawing.Point(56, 43)
        Me.AddStaffQual.Name = "AddStaffQual"
        Me.AddStaffQual.Size = New System.Drawing.Size(148, 17)
        Me.AddStaffQual.TabIndex = 24
        Me.AddStaffQual.Text = "Add Staff Qualification"
        '
        'Staff_AddStaffQual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.AddStaffQual)
        Me.Controls.Add(Me.StaffQualificationDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchStaffQual)
        Me.Controls.Add(QualIDLabel)
        Me.Controls.Add(Me.QualIDTextBox)
        Me.Controls.Add(StaffIDLabel)
        Me.Controls.Add(Me.StaffIDTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(InstitutionLabel)
        Me.Controls.Add(Me.InstitutionTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(Me.StaffQualificationBindingNavigator)
        Me.Name = "Staff_AddStaffQual"
        Me.Text = "Staff_AddStaffQual"
        CType(Me.StaffQualificationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffQualificationBindingNavigator.ResumeLayout(False)
        Me.StaffQualificationBindingNavigator.PerformLayout()
        CType(Me.StaffQualificationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffQualificationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents StaffQualificationBindingSource As BindingSource
    Friend WithEvents StaffQualificationTableAdapter As WellmeadowsDBDataSetTableAdapters.StaffQualificationTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffQualificationBindingNavigator As BindingNavigator
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
    Friend WithEvents StaffQualificationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents StaffTableAdapter As WellmeadowsDBDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents QualViewBindingSource As BindingSource
    Friend WithEvents QualViewTableAdapter As WellmeadowsDBDataSetTableAdapters.QualViewTableAdapter
    Friend WithEvents QualIDTextBox As TextBox
    Friend WithEvents StaffIDTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents SearchStaffQual As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffQualificationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents AddStaffQual As Label
End Class
