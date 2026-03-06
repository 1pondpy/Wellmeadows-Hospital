Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices.ComTypes

Public Class Staff_SearchByWorkExp
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tableResult As New DataTable

    Public SelectedStaffID As String
    Public SelectedStaffName As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim posKey As String = txtPosition.Text.Trim()
        Dim orgKey As String = txtOrganization.Text.Trim()
        Dim nameKey As String = txtName.Text.Trim()

        Dim sql As String =
         "SELECT *
         FROM WorkExpView
         WHERE (@name = '' OR [Name] LIKE @nameLike) 
            AND(@pos = '' OR [Position] LIKE @posLike)
            AND (@org = '' OR [Organization] LIKE @orgLike)
         ORDER BY StaffID;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = nameKey
                cmd.Parameters.Add("@pos", SqlDbType.NVarChar, 100).Value = posKey
                cmd.Parameters.Add("@org", SqlDbType.NVarChar, 100).Value = orgKey
                cmd.Parameters.Add("@nameLike", SqlDbType.NVarChar, 100).Value = If(nameKey = "", "", "%" & nameKey & "%")
                cmd.Parameters.Add("@posLike", SqlDbType.NVarChar, 100).Value = If(posKey = "", "", "%" & posKey & "%")
                cmd.Parameters.Add("@orgLike", SqlDbType.NVarChar, 100).Value = If(orgKey = "", "", "%" & orgKey & "%")

                Using da As New SqlDataAdapter(cmd)
                    tableResult.Clear()
                    da.Fill(tableResult)
                End Using
            End Using
        End Using

        dgvResult.AutoGenerateColumns = True
        dgvResult.DataSource = tableResult
        dgvResult.Refresh()

        If tableResult.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับเงื่อนไข")
        End If
    End Sub


    Private Sub Staff_SearchByWorkExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dgvResult
            .ReadOnly = True
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With

    End Sub
End Class
