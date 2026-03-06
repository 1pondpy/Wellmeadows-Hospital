<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_OutpatientReport
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.cboApptTime = New System.Windows.Forms.ComboBox()
        Me.cboApptDate = New System.Windows.Forms.ComboBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Outpatient Report"
        '
        'dgvReport
        '
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(55, 238)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.Size = New System.Drawing.Size(771, 278)
        Me.dgvReport.TabIndex = 8
        '
        'cboStaff
        '
        Me.cboStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboStaff.FormattingEnabled = True
        Me.cboStaff.Location = New System.Drawing.Point(179, 69)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(170, 24)
        Me.cboStaff.TabIndex = 9
        '
        'cboApptTime
        '
        Me.cboApptTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboApptTime.FormattingEnabled = True
        Me.cboApptTime.Location = New System.Drawing.Point(179, 138)
        Me.cboApptTime.Name = "cboApptTime"
        Me.cboApptTime.Size = New System.Drawing.Size(170, 24)
        Me.cboApptTime.TabIndex = 10
        '
        'cboApptDate
        '
        Me.cboApptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboApptDate.FormattingEnabled = True
        Me.cboApptDate.Location = New System.Drawing.Point(179, 104)
        Me.cboApptDate.Name = "cboApptDate"
        Me.cboApptDate.Size = New System.Drawing.Size(170, 24)
        Me.cboApptDate.TabIndex = 11
        '
        'btnView
        '
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnView.Location = New System.Drawing.Point(55, 177)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(294, 42)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "Search"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(58, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Choose Doctor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(58, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Choose Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(58, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Choose Time:"
        '
        'Dashboard_OutpatientReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cboApptDate)
        Me.Controls.Add(Me.cboApptTime)
        Me.Controls.Add(Me.cboStaff)
        Me.Controls.Add(Me.dgvReport)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Dashboard_OutpatientReport"
        Me.Text = "Dashboard_OutpatientReport"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents cboStaff As ComboBox
    Friend WithEvents cboApptTime As ComboBox
    Friend WithEvents cboApptDate As ComboBox
    Friend WithEvents btnView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
