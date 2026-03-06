Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub LoginSuccess(perms As HashSet(Of String))
        Dim main As New Wellmeadows()

        main.SetPermissions(perms)

        AddHandler main.FormClosed, Sub() Me.Close()

        Me.Hide()
        main.Show()          '
    End Sub
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' กด Enter ที่ txtPassword = ล็อกอิน
        Me.AcceptButton = btnLogin
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim u As String = txtUsername.Text.Trim()
        Dim p As String = txtPassword.Text

        If u = "" OrElse p = "" Then
            MessageBox.Show("กรุณากรอก Username/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
            Exit Sub
        End If

        Try
            Dim role As String = GetRoleFromDb(u, p)
            If String.IsNullOrEmpty(role) Then
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPassword.Clear()
                txtPassword.Focus()
                Exit Sub
            End If

            ' แปลง Role -> Permissions
            Dim perms As HashSet(Of String) = GetPermissionsForRole(role)

            ' เปิดฟอร์มหลักและส่งสิทธิไป
            Dim main As New Wellmeadows()
            main.SetPermissions(perms)
            main.Show()

            ' ซ่อนหน้า Login
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดระหว่างเข้าสู่ระบบ: " & ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ====== ดึง Role จากตาราง Users ======
    Private Function GetRoleFromDb(username As String, password As String) As String
        Using cn As New SqlConnection(connectionString)
            cn.Open()
            Dim sql As String =
                "SELECT [Role]
                 FROM Users
                 WHERE Username = @u AND [Password] = @p;"
            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = username
                cmd.Parameters.Add("@p", SqlDbType.NVarChar, 255).Value = password
                Dim o = cmd.ExecuteScalar()
                If o IsNot Nothing AndAlso o IsNot DBNull.Value Then
                    Return CStr(o)
                End If
            End Using
        End Using
        Return ""
    End Function

    Private Function GetPermissionsForRole(role As String) As HashSet(Of String)
        Dim hs As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

        Select Case role
            Case "Admin"
                hs.Add("User.Add")
                hs.Add("Staff.Add")
                hs.Add("Staff.Qual.Add")
                hs.Add("Staff.WorkExp.Add")
                hs.Add("Staff.Search.Qual")
                hs.Add("Staff.Search.WorkExp")
                hs.Add("Staff.Search.Name")
                hs.Add("Staff.Allocation.Manage")
                hs.Add("Report.StaffAllocation.View")

                hs.Add("Ward.Add")
                hs.Add("Week.Add")
                hs.Add("Room.Add")
                hs.Add("Bed.Manage")

                hs.Add("Patient.Add")
                hs.Add("Patient.NextOfKin.Add")
                hs.Add("Patient.Search.Name")
                hs.Add("Patient.Search.NextOfKin")

                hs.Add("Inpatient.Admit")
                hs.Add("Patient.Inpatient.Search")

                hs.Add("Appointment.Book")
                hs.Add("Patient.Outpatient.Search")

                hs.Add("Clinic.Add")
                hs.Add("LocalDoctor.Add")

                hs.Add("Supplies.Supplier.Add")
                hs.Add("Supplies.Pharma.Add")
                hs.Add("Supplies.Surgical.Add")
                hs.Add("Supplies.NonSurgical.Add")
                hs.Add("Supplies.Supplier.Search")
                hs.Add("Supplies.Pharma.Search")
                hs.Add("Supplies.Surgical.Search")
                hs.Add("Supplies.NonSurgical.Search")

                hs.Add("Report.Inpatient.View")
                hs.Add("Report.WaitingList.View")
                hs.Add("Report.Outpatient.View")
                hs.Add("Report.Medication.View")

                hs.Add("Medication.Record.View")

                hs.Add("Requisition.Add")
                hs.Add("Report.Requistion.View")
                hs.Add("ReqBudget")
                hs.Add("MostIns")
                hs.Add("Most")
                hs.Add("PatReceipt")

                hs.Add("PatInsAdd")
                hs.Add("PatInsSearch")

                hs.Add("InsAdd")
                hs.Add("InsSearch")


            Case "Personnel Officer", "Nurse"
                hs.Add("Staff.Add")
                hs.Add("Staff.Qual.Add")
                hs.Add("Staff.WorkExp.Add")
                hs.Add("Staff.Search.Qual")
                hs.Add("Staff.Search.WorkExp")
                hs.Add("Staff.Search.Name")
                hs.Add("Staff.Allocation.Manage")
                hs.Add("Report.StaffAllocation.View")

                hs.Add("Patient.Add")
                hs.Add("Patient.NextOfKin.Add")
                hs.Add("Patient.Search.Name")
                hs.Add("Patient.Search.NextOfKin")

                hs.Add("InsSearch")
                hs.Add("PatInsSearch")
                hs.Add("PatReceipt")



            Case "Charge Nurse", "Doctor"
                hs.Add("Staff.Search.Name")
                hs.Add("Staff.Allocation.Manage")
                hs.Add("Report.StaffAllocation.View")

                hs.Add("Ward.Add")
                hs.Add("Week.Add")
                hs.Add("Room.Add")
                hs.Add("Bed.Manage")

                hs.Add("Patient.Add")
                hs.Add("Patient.NextOfKin.Add")
                hs.Add("Patient.Search.Name")
                hs.Add("Patient.Search.NextOfKin")

                hs.Add("Inpatient.Admit")
                hs.Add("Patient.Inpatient.Search")

                hs.Add("Appointment.Book")
                hs.Add("Patient.Outpatient.Search")

                hs.Add("Report.Inpatient.View")
                hs.Add("Report.WaitingList.View")
                hs.Add("Report.Outpatient.View")
                hs.Add("Report.Medication.View")

                hs.Add("Medication.Record.View")

                hs.Add("Requisition.Add")
                hs.Add("Report.Requistion.View")

                hs.Add("ReqBudget")
                hs.Add("PatReceipt")

            Case "Medical Director"
                hs.Add("User.Add")
                hs.Add("Staff.Search.Qual")
                hs.Add("Staff.Search.WorkExp")
                hs.Add("Staff.Search.Name")
                hs.Add("Report.StaffAllocation.View")

                hs.Add("Patient.Add")
                hs.Add("Patient.NextOfKin.Add")
                hs.Add("Patient.Search.Name")
                hs.Add("Patient.Search.NextOfKin")

                hs.Add("Clinic.Add")
                hs.Add("LocalDoctor.Add")

                hs.Add("Report.Inpatient.View")
                hs.Add("Report.WaitingList.View")
                hs.Add("Report.Outpatient.View")

                hs.Add("Supplies.Supplier.Add")
                hs.Add("Supplies.Pharma.Add")
                hs.Add("Supplies.Surgical.Add")
                hs.Add("Supplies.NonSurgical.Add")
                hs.Add("Supplies.Supplier.Search")
                hs.Add("Supplies.Pharma.Search")
                hs.Add("Supplies.Surgical.Search")
                hs.Add("Supplies.NonSurgical.Search")

                hs.Add("Report.Requistion.View")
                hs.Add("ReqBudget")
                hs.Add("MostIns")
                hs.Add("Most")
                hs.Add("PatReceipt")

                hs.Add("PatInsAdd")
                hs.Add("PatInsSearch")

                hs.Add("InsAdd")
                hs.Add("InsSearch")
        End Select

        Return hs
    End Function

    ' ปิดโปรแกรมเมื่อปิดหน้า Login (กันแอปค้าง)
    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Application.OpenForms.Count = 0 Then
            Application.Exit()
        End If
    End Sub
End Class
