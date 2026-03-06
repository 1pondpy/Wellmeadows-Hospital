<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard_InsNoHaveGraph
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chtCoveragePie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chtCoveragePie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(45, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Patient Count by Insurance Company"
        '
        'chtCoveragePie
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtCoveragePie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtCoveragePie.Legends.Add(Legend1)
        Me.chtCoveragePie.Location = New System.Drawing.Point(45, 75)
        Me.chtCoveragePie.Name = "chtCoveragePie"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtCoveragePie.Series.Add(Series1)
        Me.chtCoveragePie.Size = New System.Drawing.Size(788, 454)
        Me.chtCoveragePie.TabIndex = 15
        Me.chtCoveragePie.Text = "Chart1"
        '
        'Dashboard_InsNoHaveGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 591)
        Me.Controls.Add(Me.chtCoveragePie)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Dashboard_InsNoHaveGraph"
        Me.Text = "Dashboard_InsNoHaveGraph"
        CType(Me.chtCoveragePie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents chtCoveragePie As DataVisualization.Charting.Chart
End Class
