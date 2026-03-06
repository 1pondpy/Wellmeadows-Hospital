Imports System.Configuration
Imports System.Data.SqlClient

Public Class Supplies_SearchPharmaName
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Dim tablePatient As New DataTable

    Public Property DrugID As String
    Public Property DrugName As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim keyword As String = TextBox1.Text.Trim()

        Dim sql As String =
            "SELECT dbo.PharmaSupply.*, dbo.Supplier.SupplierName, dbo.Supplier.Phone
            FROM dbo.PharmaSupply INNER JOIN dbo.Supplier ON dbo.PharmaSupply.SupplierID = dbo.Supplier.SupplierID
             WHERE dbo.PharmaSupply.DrugName LIKE @q;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.Add("@q", SqlDbType.NVarChar, 100).Value = "%" & keyword & "%"

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
        If e.RowIndex >= 0 Then
            DrugID = DataGridView1.Rows(e.RowIndex).Cells("DrugID").Value.ToString()
            DrugName = DataGridView1.Rows(e.RowIndex).Cells("DrugName").Value.ToString()

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Supplies_SearchPharmaName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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