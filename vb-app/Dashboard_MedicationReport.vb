Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard_MedicationReport
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Dashboard_MedicationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStartDateCombo()
    End Sub

    ' โหลดวันที่จาก MedReportView
    Private Sub LoadStartDateCombo()
        Dim sql As String =
            "SELECT DISTINCT CAST(StartDate AS date) AS StartDateOnly
             FROM MedReportView
             ORDER BY StartDateOnly DESC;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                If Not dt.Columns.Contains("DisplayText") Then
                    dt.Columns.Add("DisplayText", GetType(String))
                End If

                For Each row As DataRow In dt.Rows
                    row("DisplayText") = CDate(row("StartDateOnly")).ToString("yyyy-MM-dd")
                Next

                ' ค่า default = All
                Dim r = dt.NewRow()
                r("StartDateOnly") = DBNull.Value
                r("DisplayText") = "-- All Dates --"
                dt.Rows.InsertAt(r, 0)

                cboStartDate.DataSource = dt
                cboStartDate.DisplayMember = "DisplayText"
                cboStartDate.ValueMember = "StartDateOnly"
            End Using
        End Using
    End Sub

    ' ปุ่มแสดงผล
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim fullNameKey As String = txtFullName.Text.Trim()
        Dim drugKey As String = txtDrugName.Text.Trim()
        Dim startDateObj As Object = cboStartDate.SelectedValue

        Dim sql As String =
            "SELECT *
             FROM MedReportView
             WHERE (@fullName = '' OR FullName LIKE @fullNameLike)
               AND (@drug = '' OR DrugName LIKE @drugLike)
               AND (@startDate IS NULL OR CAST(StartDate AS date) = @startDate)
             ORDER BY StartDate DESC, FullName ASC;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)

                ' FullName
                cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 200).Value = fullNameKey
                cmd.Parameters.Add("@fullNameLike", SqlDbType.NVarChar, 200).Value =
                    If(String.IsNullOrEmpty(fullNameKey), DBNull.Value, "%" & fullNameKey & "%")

                ' DrugName
                cmd.Parameters.Add("@drug", SqlDbType.NVarChar, 200).Value = drugKey
                cmd.Parameters.Add("@drugLike", SqlDbType.NVarChar, 200).Value =
                    If(String.IsNullOrEmpty(drugKey), DBNull.Value, "%" & drugKey & "%")

                ' StartDate
                Dim pStart = cmd.Parameters.Add("@startDate", SqlDbType.Date)
                If startDateObj Is Nothing OrElse startDateObj Is DBNull.Value Then
                    pStart.Value = DBNull.Value
                Else
                    pStart.Value = CDate(startDateObj)
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
