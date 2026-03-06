Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing

Public Class Dashboard_InsNoHaveGraph
    Private ReadOnly cs As String = ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Dashboard_InsCoveragePie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCoveragePieChart()
    End Sub

    Private Sub LoadCoveragePieChart()
        Dim dt As New DataTable()

        ' --- ดึงข้อมูลจาก DB ---
        Using cn As New SqlConnection(cs)
            cn.Open()
            Dim sql As String =
                "SELECT CoverageGroup, COUNT(*) AS Patient_Count
                FROM (
                    SELECT 
                        p.PatientID,
                        CASE 
                            WHEN EXISTS (
                                SELECT 1 
                                FROM dbo.PatientInsurance pi 
                                WHERE pi.PatientID = p.PatientID
                            ) THEN 'Has Insurance'
                            ELSE 'No Insurance'
                        END AS CoverageGroup
                    FROM dbo.Patient p
                ) x
                GROUP BY CoverageGroup;
                "

            Using da As New SqlDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using

        ' --- กันกรณีไม่มีข้อมูล ---
        If dt.Rows.Count = 0 Then
            chtCoveragePie.Series.Clear()
            chtCoveragePie.Titles.Clear()
            chtCoveragePie.ChartAreas.Clear()
            chtCoveragePie.ChartAreas.Add(New ChartArea("MainArea"))
            chtCoveragePie.Titles.Add("Coverage Split (no data)")
            Return
        End If

        ' --- ตั้งค่า Chart ---
        With chtCoveragePie
            .SuspendLayout()

            .Series.Clear()
            .Legends.Clear()
            .Titles.Clear()
            .ChartAreas.Clear()

            ' ChartArea
            Dim area As New ChartArea("MainArea")
            area.BackColor = Color.White
            .ChartAreas.Add(area)

            ' Series
            Dim s = .Series.Add("Coverage")
            s.ChartType = SeriesChartType.Pie
            s.XValueMember = "CoverageGroup"
            s.YValueMembers = "Patient_Count"

            ' สี Slice (Has Insurance = LightPink, No Insurance = LightGray)
            .Palette = ChartColorPalette.None
            s.Points.DataBind(dt.DefaultView, "CoverageGroup", "Patient_Count", Nothing)
            If s.Points.Count >= 1 Then s.Points(0).Color = Color.LightPink
            If s.Points.Count >= 2 Then s.Points(1).Color = Color.LightGray

            ' Label บนชิ้น Pie
            s.IsValueShownAsLabel = True
            s.Label = "#PERCENT{P1}" & vbCrLf & "#VALX"
            s.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            ' Legend
            Dim legend As New Legend("Legend1")
            legend.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .Legends.Add(legend)
            s.LegendText = "#VALX (#VALY)"

            ' Title กราฟ
            Dim t = .Titles.Add("Proportion of Patients With vs Without Insurance")
            t.Font = New Font("Segoe UI", 14, FontStyle.Bold)

            ' DataSource
            .DataSource = dt
            .DataBind()

            .ResumeLayout()
        End With
    End Sub
End Class
