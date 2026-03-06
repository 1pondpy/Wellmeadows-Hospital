Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Ward_SearchWeek
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable

    Public WeekStartDate As String
    Public WeekID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim sql As String =
            "SELECT *
             FROM dbo.Week;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)

                Using da As New SqlDataAdapter(cmd)
                    tablePatient.Clear()                 ' เคลียร์ผลเดิมก่อน
                    da.Fill(tablePatient)
                End Using
            End Using
        End Using

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = tablePatient
        DataGridView1.Refresh()

        If tablePatient.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการที่ตรงกับคำค้นหา")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        PickRow(e.RowIndex)
    End Sub

    Private Sub PickRow(rowIndex As Integer)
        If rowIndex < 0 OrElse rowIndex >= DataGridView1.Rows.Count Then Return
        Dim row = DataGridView1.Rows(rowIndex)

        WeekID = row.Cells("WeekID").Value.ToString()

        ' จัดรูปแบบวันที่ให้สวย/สม่ำเสมอ (กัน DBNull)
        Dim raw = row.Cells("StartDate").Value
        If raw IsNot Nothing AndAlso raw IsNot DBNull.Value Then
            Dim d As DateTime
            If DateTime.TryParse(raw.ToString(), d) Then
                WeekStartDate = d.ToString("yyyy-MM-dd")   ' เปลี่ยนเป็น "dd/MM/yyyy" ได้ตามต้องการ
            Else
                WeekStartDate = raw.ToString()
            End If
        Else
            WeekStartDate = ""
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Ward_SearchWeek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView1
            .ReadOnly = True
            .EditMode = DataGridViewEditMode.EditProgrammatically
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
    End Sub
End Class