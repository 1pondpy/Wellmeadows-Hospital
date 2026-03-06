Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard_StaffAllocation
    Private ReadOnly connectionString As String =
    ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Dashboard_StaffAllocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWardCombo()
        LoadWeekCombo()
    End Sub

    Private Sub LoadWardCombo()
        Dim sql = "SELECT WardID, WardName FROM Ward ORDER BY WardName"
        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' เพิ่ม "All Wards" ไว้บนสุด
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

    Private Sub LoadWeekCombo()
        Dim sql = "SELECT WeekID, StartDate, EndDate FROM [Week] ORDER BY StartDate DESC"
        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' เพิ่มคอลัมน์สำหรับแสดงผล
                If Not dt.Columns.Contains("DisplayText") Then
                    dt.Columns.Add("DisplayText", GetType(String))
                End If

                ' แปลงเป็นข้อความ "yyyy-MM-dd ถึง yyyy-MM-dd"
                For Each r As DataRow In dt.Rows
                    Dim s As Date = CDate(r("StartDate"))
                    Dim e As Date = CDate(r("EndDate"))
                    r("DisplayText") = $"{s:yyyy-MM-dd} ถึง {e:yyyy-MM-dd}"
                Next

                ' เพิ่ม All Weeks
                Dim rAll = dt.NewRow()
                rAll("WeekID") = 0
                rAll("StartDate") = DBNull.Value
                rAll("EndDate") = DBNull.Value
                rAll("DisplayText") = "-- All Weeks --"
                dt.Rows.InsertAt(rAll, 0)

                cboWeek.DataSource = dt
                cboWeek.DisplayMember = "DisplayText"
                cboWeek.ValueMember = "WeekID"
                cboWeek.SelectedValue = 0
            End Using
        End Using
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim weekId As Integer = CInt(cboWeek.SelectedValue)
        Dim wardId As Integer = CInt(cboWard.SelectedValue)

        ' Base SQL
        Dim sql As String =
            "SELECT * FROM StaffAlloView WHERE 1=1"

        ' ถ้าไม่ใช่ All Week ให้กรอง WeekID
        If weekId <> 0 Then
            sql &= " AND WeekID = @WeekID"
        End If

        ' ถ้าไม่ใช่ All Wards ให้กรอง WardID
        If wardId <> 0 Then
            sql &= " AND WardID = @WardID"
        End If

        sql &= " ORDER BY WardName, Name, ShiftName;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                If weekId <> 0 Then
                    cmd.Parameters.Add("@WeekID", SqlDbType.Int).Value = weekId
                End If
                If wardId <> 0 Then
                    cmd.Parameters.Add("@WardID", SqlDbType.Int).Value = wardId
                End If

                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvReport.DataSource = dt

                    ' แต่ง DataGridView
                    dgvReport.ReadOnly = True
                    dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvReport.MultiSelect = False
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                End Using
            End Using
        End Using
    End Sub
End Class
