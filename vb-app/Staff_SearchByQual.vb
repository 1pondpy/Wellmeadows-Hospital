Imports System.Configuration
Imports System.Data.SqlClient

Public Class Staff_SearchByQual
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tableResult As New DataTable

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim typeKey As String = txtType.Text.Trim()
        Dim instKey As String = txtInstitution.Text.Trim()
        Dim nameKey As String = txtName.Text.Trim()

        Dim sql As String =
            "SELECT * FROM QualView
             WHERE (@name = '' OR [Name] LIKE @nameLike)
             AND (@type = '' OR [Type] LIKE @typeLike)
             AND (@inst = '' OR [Institution] LIKE @instLike)
             ORDER BY StaffID;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = nameKey
                cmd.Parameters.Add("@type", SqlDbType.NVarChar, 100).Value = typeKey
                cmd.Parameters.Add("@inst", SqlDbType.NVarChar, 100).Value = instKey
                cmd.Parameters.Add("@nameLike", SqlDbType.NVarChar, 100).Value = If(nameKey = "", "", "%" & nameKey & "%")
                cmd.Parameters.Add("@typeLike", SqlDbType.NVarChar, 100).Value = If(typeKey = "", "", "%" & typeKey & "%")
                cmd.Parameters.Add("@instLike", SqlDbType.NVarChar, 100).Value = If(instKey = "", "", "%" & instKey & "%")

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


    Private Sub SearchByQualificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
