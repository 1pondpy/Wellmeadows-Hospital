Imports System.Configuration
Imports System.Data.SqlClient

Public Class Room_SearchRoom
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tableRoom As New DataTable

    Public RoomType As String
    Public RoomID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT RoomID,
                    RoomNo,
                    RoomType,
                    Status
             FROM dbo.Room
             WHERE RoomType LIKE @q;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

                Using da As New SqlDataAdapter(cmd)
                    tableRoom.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(tableRoom)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tableRoom
        DataGridView1.Refresh()

        If tableRoom.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then Return
        RoomID = DataGridView1.Rows(e.RowIndex).Cells("RoomID").Value.ToString()
        RoomType = DataGridView1.Rows(e.RowIndex).Cells("RoomType").Value.ToString()
        Me.Close()
    End Sub
End Class