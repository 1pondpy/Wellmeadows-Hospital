<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff_SearchByWorkExp
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
        Me.LabelInstituion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtOrganization = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.SearchWorkExp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelInstituion
        '
        Me.LabelInstituion.AutoSize = True
        Me.LabelInstituion.BackColor = System.Drawing.Color.White
        Me.LabelInstituion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelInstituion.Location = New System.Drawing.Point(63, 93)
        Me.LabelInstituion.Name = "LabelInstituion"
        Me.LabelInstituion.Size = New System.Drawing.Size(70, 17)
        Me.LabelInstituion.TabIndex = 13
        Me.LabelInstituion.Text = "Position : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(63, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Organization : "
        '
        'dgvResult
        '
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Location = New System.Drawing.Point(61, 234)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.RowHeadersWidth = 51
        Me.dgvResult.Size = New System.Drawing.Size(765, 285)
        Me.dgvResult.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSearch.Location = New System.Drawing.Point(61, 161)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(265, 47)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtOrganization
        '
        Me.txtOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtOrganization.Location = New System.Drawing.Point(170, 119)
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.Size = New System.Drawing.Size(160, 23)
        Me.txtOrganization.TabIndex = 9
        '
        'txtPosition
        '
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPosition.Location = New System.Drawing.Point(169, 90)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(160, 23)
        Me.txtPosition.TabIndex = 8
        '
        'SearchWorkExp
        '
        Me.SearchWorkExp.AutoSize = True
        Me.SearchWorkExp.BackColor = System.Drawing.Color.White
        Me.SearchWorkExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.SearchWorkExp.Location = New System.Drawing.Point(63, 24)
        Me.SearchWorkExp.Name = "SearchWorkExp"
        Me.SearchWorkExp.Size = New System.Drawing.Size(217, 17)
        Me.SearchWorkExp.TabIndex = 14
        Me.SearchWorkExp.Text = "Search Staff By Work Experience"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(63, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Name : "
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtName.Location = New System.Drawing.Point(169, 63)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(161, 23)
        Me.txtName.TabIndex = 15
        '
        'Staff_SearchByWorkExp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.SearchWorkExp)
        Me.Controls.Add(Me.LabelInstituion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOrganization)
        Me.Controls.Add(Me.txtPosition)
        Me.Name = "Staff_SearchByWorkExp"
        Me.Text = "Staff_SearchByWorkExp"
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelInstituion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtOrganization As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents SearchWorkExp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
End Class
