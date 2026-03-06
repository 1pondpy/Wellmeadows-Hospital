Imports System.Configuration
Imports System.Data.SqlClient

Public Class Ward_AddWardChargeNurse
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub WardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WardBindingNavigatorSaveItem.Click
        ' ใส่ค่า ChargeNurseID จาก ComboBox ลงแถวปัจจุบัน
        Dim drv As DataRowView = TryCast(Me.WardBindingSource.Current, DataRowView)
        If drv IsNot Nothing AndAlso cboChargeNurse.SelectedValue IsNot Nothing Then
            drv("ChargeNurseID") = CInt(cboChargeNurse.SelectedValue)
        End If

        Me.Validate()
        Me.WardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WellmeadowsDBDataSet)
        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Ward_AssignChargeNurse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WardTableAdapter.Fill(Me.WellmeadowsDBDataSet.Ward)

        Using conn As New SqlConnection(connectionString)
            conn.Open()

            Dim sql As String =
            "SELECT StaffID, (FirstName + ' ' + LastName) AS FullName
             FROM Staff
             WHERE Position = 'Charge Nurse'
             ORDER BY FirstName, LastName;"

            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            dt.Columns.Add("DisplayText", GetType(String))
            For Each row As DataRow In dt.Rows
                row("DisplayText") = row("StaffID").ToString() & " - " & row("FullName").ToString()
            Next

            cboChargeNurse.DataSource = dt
            cboChargeNurse.DisplayMember = "DisplayText"
            cboChargeNurse.ValueMember = "StaffID"
            cboChargeNurse.DropDownStyle = ComboBoxStyle.DropDownList
        End Using

        ' ผูก SelectedValue กับฟิลด์ ChargeNurseID ใน WardBindingSource
        cboChargeNurse.DataBindings.Clear()
        cboChargeNurse.DataBindings.Add(New Binding(
        "SelectedValue",
        Me.WardBindingSource,
        "ChargeNurseID",
        True,
        DataSourceUpdateMode.OnPropertyChanged
    ))
    End Sub


End Class
