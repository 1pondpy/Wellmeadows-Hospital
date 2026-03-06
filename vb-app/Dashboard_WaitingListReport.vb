Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard_WaitingListReport
    Private ReadOnly connectionString As String =
    ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Private Sub Dashboard_WaitingListReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWardCombo()

        ' ให้ DateTimePicker มี CheckBox เพื่อเปิด/ปิดการใช้ค่า (ไม่ติ๊ก = All Dates)
        dtFrom.ShowCheckBox = True
        dtTo.ShowCheckBox = True

        ' ค่าเริ่มต้น: กำหนดช่วง 7 วันล่าสุด และ "ติ๊ก" ไว้ (แปลว่าเริ่มต้นกรองตามช่วง)
        dtFrom.Value = Date.Today.AddDays(-7)
        dtTo.Value = Date.Today
        dtFrom.Checked = True
        dtTo.Checked = True
    End Sub

    Private Sub LoadWardCombo()
        Dim sql As String = "SELECT WardID, WardName FROM Ward ORDER BY WardName;"
        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' ใช้ 0 เป็นค่า All Wards (เลี่ยงปัญหา DBNull กับคอลัมน์ Int)
                Dim r = dt.NewRow()
                r("WardID") = 0
                r("WardName") = "-- All Wards --"
                dt.Rows.InsertAt(r, 0)

                cboWard.DataSource = dt
                cboWard.DisplayMember = "WardName"
                cboWard.ValueMember = "WardID"
                cboWard.SelectedValue = 0
            End Using
        End Using
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        ' อ่านค่า Ward (0 = All)
        Dim wardId As Integer = CInt(cboWard.SelectedValue)

        ' ตีความ All Dates:
        ' - ถ้า dtFrom หรือ dtTo "ไม่ติ๊ก" (Checked = False) -> ถือว่า All Dates (ไม่กรองวันที่)
        ' - ถ้าทั้งคู่ติ๊ก -> ใช้ช่วงวันที่ที่เลือก
        Dim useDateFilter As Boolean = (dtFrom.Checked AndAlso dtTo.Checked)

        ' สร้าง SQL แบบประกอบเงื่อนไข
        Dim sql As String = "SELECT * FROM dbo.InpatientWaitingListView WHERE 1=1"

        If wardId <> 0 Then
            sql &= " AND WardID = @WardID"
        End If

        If useDateFilter Then
            sql &= " AND CONVERT(date, DateWaitingList) BETWEEN @FromDate AND @ToDate"
        End If

        sql &= " ORDER BY DateWaitingList ASC, InpatientID ASC;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                If wardId <> 0 Then
                    cmd.Parameters.Add("@WardID", SqlDbType.Int).Value = wardId
                End If

                If useDateFilter Then
                    Dim fromDate As Date = dtFrom.Value.Date
                    Dim toDate As Date = dtTo.Value.Date
                    cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate
                    cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate
                End If

                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvReport.DataSource = dt
                    dgvReport.ReadOnly = True
                    dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvReport.MultiSelect = False
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    If dt.Rows.Count = 0 Then
                        Dim msg As String = If(useDateFilter,
                                               "ไม่พบข้อมูลผู้ป่วยที่กำลังรอเตียงตามช่วงวันที่ที่เลือก",
                                               "ไม่พบข้อมูลผู้ป่วยที่กำลังรอเตียง (All Dates)")
                        MessageBox.Show(msg)
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
