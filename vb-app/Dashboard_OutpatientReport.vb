Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard_OutpatientReport
    Private ReadOnly connectionString As String =
     ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Private Sub Dashboard_OutpatientReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffCombo()
        LoadApptDateCombo()
        LoadApptTimeCombo()
    End Sub

    ' for only staff doctor
    Private Sub LoadStaffCombo()
        Dim sql As String =
            "SELECT StaffID,
            (FirstName + ' ' + LastName) AS StaffName
            FROM Staff
            WHERE Position = 'Doctor'
            ORDER BY FirstName, LastName;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim r = dt.NewRow()
                r("StaffID") = DBNull.Value
                r("StaffName") = "-- All Staff --"
                dt.Rows.InsertAt(r, 0)

                cboStaff.DataSource = dt
                cboStaff.DisplayMember = "StaffName"
                cboStaff.ValueMember = "StaffID"
            End Using
        End Using
    End Sub

    ' date ที่มีอยู่ใน appointment(date)
    Private Sub LoadApptDateCombo()
        Dim sql As String =
    "SELECT DISTINCT A.Date AS ApptDate
     FROM Appointment A
     ORDER BY ApptDate DESC;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                If Not dt.Columns.Contains("DisplayText") Then
                    dt.Columns.Add("DisplayText", GetType(String))
                End If
                For Each row As DataRow In dt.Rows
                    row("DisplayText") = CDate(row("ApptDate")).ToString("yyyy-MM-dd")
                Next

                Dim r = dt.NewRow()
                r("ApptDate") = DBNull.Value
                r("DisplayText") = "-- All Dates --"
                dt.Rows.InsertAt(r, 0)

                cboApptDate.DataSource = dt
                cboApptDate.DisplayMember = "DisplayText"
                cboApptDate.ValueMember = "ApptDate"
            End Using
        End Using
    End Sub

    ' time ที่มีอยู่ใน appointment(time)
    Private Sub LoadApptTimeCombo()
        Dim sql As String =
        "SELECT DISTINCT
                A.Time AS ApptTimeText
         FROM Appointment A
         ORDER BY A.Time;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' แทรก "All"
                Dim r = dt.NewRow()
                r("ApptTimeText") = "-- All Times --"
                dt.Rows.InsertAt(r, 0)

                cboApptTime.DataSource = dt
                cboApptTime.DisplayMember = "ApptTimeText"
                cboApptTime.ValueMember = "ApptTimeText"
            End Using
        End Using
    End Sub

    ' datagridview
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim staffIdObj As Object = cboStaff.SelectedValue
        Dim apptDateObj As Object = cboApptDate.SelectedValue
        Dim apptTimeTextObj As Object = cboApptTime.SelectedValue

        Dim sql As String =
        "SELECT * FROM AppointmentView
        WHERE (@StaffID  IS NULL OR ConsultantStaffID = @StaffID)
        AND (@ApptDate IS NULL OR ApptDate = @ApptDate)
        AND (@ApptTimeT IS NULL OR ApptTime = @ApptTimeT)
        ORDER BY AppointmentID ASC;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                ' @StaffID
                Dim pStaff = cmd.Parameters.Add("@StaffID", SqlDbType.Int)
                If staffIdObj Is Nothing OrElse staffIdObj Is DBNull.Value Then
                    pStaff.Value = DBNull.Value
                Else
                    pStaff.Value = CInt(staffIdObj)
                End If

                ' @ApptDate
                Dim pDate = cmd.Parameters.Add("@ApptDate", SqlDbType.Date)
                If apptDateObj Is Nothing OrElse apptDateObj Is DBNull.Value Then
                    pDate.Value = DBNull.Value
                Else
                    pDate.Value = CDate(apptDateObj).Date
                End If

                ' @ApptTimeT (string hh:mm tt)
                Dim pTime = cmd.Parameters.Add("@ApptTimeT", SqlDbType.VarChar, 20)
                If apptTimeTextObj Is Nothing OrElse apptTimeTextObj Is DBNull.Value _
                   OrElse apptTimeTextObj.ToString().StartsWith("--") Then
                    pTime.Value = DBNull.Value
                Else
                    pTime.Value = apptTimeTextObj.ToString()
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
                        MessageBox.Show("ไม่พบข้อมูลตามเงื่อนไขที่เลือก")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
