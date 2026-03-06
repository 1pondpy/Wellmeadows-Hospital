<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_SearchByQual
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
        Me.WellmeadowsDBDataSet = New WellmeadowsHospital.WellmeadowsDBDataSet()
        Me.QualViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualViewTableAdapter = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.QualViewTableAdapter()
        Me.TableAdapterManager = New WellmeadowsHospital.WellmeadowsDBDataSetTableAdapters.TableAdapterManager()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtInstitution = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelInstituion = New System.Windows.Forms.Label()
        Me.SearchQual = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WellmeadowsDBDataSet
        '
        Me.WellmeadowsDBDataSet.DataSetName = "WellmeadowsDBDataSet"
        Me.WellmeadowsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AppointmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.ClinicTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtType.Location = New System.Drawing.Point(147, 95)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(180, 23)
        Me.txtType.TabIndex = 2
        '
        'txtInstitution
        '
        Me.txtInstitution.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtInstitution.Location = New System.Drawing.Point(147, 122)
        Me.txtInstitution.Name = "txtInstitution"
        Me.txtInstitution.Size = New System.Drawing.Size(180, 23)
        Me.txtInstitution.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(61, 156)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(266, 44)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(61, 227)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.RowHeadersWidth = 51
        Me.dgvResult.Size = New System.Drawing.Size(762, 293)
        Me.dgvResult.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Type : "
        '
        'LabelInstituion
        '
        Me.LabelInstituion.AutoSize = True
        Me.LabelInstituion.BackColor = System.Drawing.Color.White
        Me.LabelInstituion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelInstituion.Location = New System.Drawing.Point(64, 124)
        Me.LabelInstituion.Name = "LabelInstituion"
        Me.LabelInstituion.Size = New System.Drawing.Size(76, 17)
        Me.LabelInstituion.TabIndex = 7
        Me.LabelInstituion.Text = "Instituion : "
        '
        'SearchQual
        '
        Me.SearchQual.AutoSize = True
        Me.SearchQual.BackColor = System.Drawing.Color.White
        Me.SearchQual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchQual.Location = New System.Drawing.Point(63, 25)
        Me.SearchQual.Name = "SearchQual"
        Me.SearchQual.Size = New System.Drawing.Size(188, 17)
        Me.SearchQual.TabIndex = 8
        Me.SearchQual.Text = "Search Staff By Qualification"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(147, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 23)
        Me.txtName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(64, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name : "
        '
        'Staff_SearchByQual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.SearchQual)
        Me.Controls.Add(Me.LabelInstituion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtInstitution)
        Me.Controls.Add(Me.txtType)
        Me.Name = "Staff_SearchByQual"
        Me.Text = "Staff_SearchByQual"
        CType(Me.WellmeadowsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WellmeadowsDBDataSet As WellmeadowsDBDataSet
    Friend WithEvents QualViewBindingSource As BindingSource
    Friend WithEvents QualViewTableAdapter As WellmeadowsDBDataSetTableAdapters.QualViewTableAdapter
    Friend WithEvents TableAdapterManager As WellmeadowsDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtInstitution As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelInstituion As Label
    Friend WithEvents SearchQual As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
End Class
