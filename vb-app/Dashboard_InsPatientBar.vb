Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Drawing

Public Class Dashboard_InsPatientBar
    Private ReadOnly cs As String = ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Dashboard_InsPatientBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPatientCountChart()
    End Sub

    Private Sub LoadPatientCountChart()
        Dim dt As New DataTable()

        ' --- ดึงข้อมูลจาก DB ---
        Using cn As New SqlConnection(cs)
            cn.Open()
            Dim sql As String =
                ";WITH counts AS (" & vbCrLf &
                "   SELECT COALESCE(i.InsuranceName, 'Unknown Insurance') AS InsuranceName," & vbCrLf &
                "          COUNT(DISTINCT pi.PatientID) AS Patient_Count" & vbCrLf &
                "   FROM dbo.PatientInsurance pi" & vbCrLf &
                "   INNER JOIN dbo.Insurance i ON i.InsuranceID = pi.InsuranceID" & vbCrLf &
                "   GROUP BY COALESCE(i.InsuranceName, 'Unknown Insurance')" & vbCrLf &
                "), noins AS (" & vbCrLf &
                "   SELECT 'No Insurance' AS InsuranceName," & vbCrLf &
                "          COUNT(*) AS Patient_Count" & vbCrLf &
                "   FROM dbo.Patient p" & vbCrLf &
                "   WHERE NOT EXISTS (" & vbCrLf &
                "       SELECT 1 FROM dbo.PatientInsurance pi WHERE pi.PatientID = p.PatientID" & vbCrLf &
                "   )" & vbCrLf &
                ")" & vbCrLf &
                "SELECT * FROM counts" & vbCrLf &
                "UNION ALL" & vbCrLf &
                "SELECT * FROM noins" & vbCrLf &
                "WHERE Patient_Count > 0" & vbCrLf &
                "ORDER BY Patient_Count DESC, InsuranceName;"

            Using da As New SqlDataAdapter(sql, cn)
                da.Fill(dt)
            End Using
        End Using

        ' --- กันกรณีไม่มีข้อมูล ---
        If dt.Rows.Count = 0 Then
            chtPatientByInsurance.Series.Clear()
            chtPatientByInsurance.Titles.Clear()
            chtPatientByInsurance.ChartAreas.Clear()
            chtPatientByInsurance.ChartAreas.Add(New ChartArea("MainArea"))
            chtPatientByInsurance.Titles.Add("Patients by Insurance (no data)")
            Return
        End If

        ' --- ตั้งค่า Chart ---
        With chtPatientByInsurance
            .SuspendLayout()

            .Series.Clear()
            .Legends.Clear()
            .Titles.Clear()
            .ChartAreas.Clear()

            ' ChartArea
            Dim area As New ChartArea("MainArea")
            ' กริด: ปิดเส้นแนวตั้ง, แนวนอนเป็นสีจาง
            area.AxisX.MajorGrid.Enabled = False
            area.AxisY.MajorGrid.Enabled = True
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid

            ' Label/Title ของแกน
            area.AxisX.Title = "Insurance Company"
            area.AxisY.Title = "Number of Patients"
            area.AxisX.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            area.AxisY.TitleFont = New Font("Segoe UI", 11, FontStyle.Bold)
            area.AxisX.LabelStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            area.AxisY.LabelStyle.Font = New Font("Segoe UI", 10, FontStyle.Regular)

            ' แกน X ให้แสดงทุก label และเอียงเล็กน้อยกรณีชื่อยาว
            area.AxisX.Interval = 1
            area.AxisX.LabelStyle.Angle = -20
            area.AxisX.MajorTickMark.Enabled = False
            area.AxisY.MajorTickMark.Enabled = False

            ' ขอบกราฟจาง ๆ
            area.BorderColor = Color.WhiteSmoke
            area.BorderDashStyle = ChartDashStyle.Solid

            .ChartAreas.Add(area)

            ' Series
            Dim s = .Series.Add("Patient_Count")
            s.ChartType = SeriesChartType.Column
            s.XValueMember = "InsuranceName"
            s.YValueMembers = "Patient_Count"

            ' สีทุกแท่งเป็น LightPink
            .Palette = ChartColorPalette.None
            s.Color = Color.LightPink

            ' ตัวเลขบนแท่ง + รูปแบบตัวเลข
            s.IsValueShownAsLabel = True
            s.LabelFormat = "#,0"
            s.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            ' Title กราฟ
            Dim t = .Titles.Add("Patients by Insurance Company")
            t.Font = New Font("Segoe UI", 14, FontStyle.Bold)

            ' DataSource
            .DataSource = dt
            .DataBind()

            .ResumeLayout()
        End With
    End Sub

End Class
