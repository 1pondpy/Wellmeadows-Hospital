Public Class Wellmeadows

    Private Sub Wellmeadows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MapMenuTags()
        SetMdiClientBackColor(ColorTranslator.FromHtml("#FADDE3"))
    End Sub

    Private Sub SetMdiClientBackColor(c As Color, Optional bgImg As Image = Nothing)
        Dim client = Me.Controls.OfType(Of MdiClient)().FirstOrDefault()
        If client Is Nothing Then Return
        client.BackColor = c
        If bgImg IsNot Nothing Then
            client.BackgroundImage = bgImg
            client.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub OpenChild(Of T As {Form, New})()
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is T Then
                child.Activate()
                Return
            End If
        Next


        Dim f As New T()
        f.MdiParent = Me
        f.FormBorderStyle = FormBorderStyle.None
        f.ControlBox = False
        f.Text = GetType(T).Name
        f.Dock = DockStyle.Fill
        f.ShowInTaskbar = False
        f.Show()
    End Sub



    Private Sub MapMenuTags()
        AddUsersToolStripMenuItem.Tag = "User.Add"

        ' ===== Staff =====
        AddStaffToolStripMenuItem.Tag = "Staff.Add"
        AddStaffQualificationToolStripMenuItem.Tag = "Staff.Qual.Add"
        AddStaffWorkExperienceToolStripMenuItem.Tag = "Staff.WorkExp.Add"
        ByQualificationToolStripMenuItem.Tag = "Staff.Search.Qual"
        ByWorkExperienceToolStripMenuItem.Tag = "Staff.Search.WorkExp"
        ByNameToolStripMenuItem.Tag = "Staff.Search.Name"
        StaffAllocationToolStripMenuItem1.Tag = "Staff.Allocation.Manage"
        StaffAllocationReportToolStripMenuItem.Tag = "Report.StaffAllocation.View"

        ' ===== Ward / Week / Room / Bed =====
        AddWardToolStripMenuItem.Tag = "Ward.Add"
        AddWeekToolStripMenuItem.Tag = "Week.Add"
        AddRoomToolStripMenuItem.Tag = "Room.Add"
        BedManagementForInpatientToolStripMenuItem.Tag = "Bed.Manage"
        InpatientAdmissionToolStripMenuItem.Tag = "Inpatient.Admit"
        AddRequisitionToolStripMenuItem.Tag = "Requisition.Add"

        ' ===== Patient =====
        AddPatientToolStripMenuItem1.Tag = "Patient.Add"
        AddPatientNextOfKinToolStripMenuItem.Tag = "Patient.NextOfKin.Add"
        SearchPatientByNameToolStripMenuItem.Tag = "Patient.Search.Name"
        SearchPatientNextOfKinToolStripMenuItem.Tag = "Patient.Search.NextOfKin"
        SearchInpatientByNameToolStripMenuItem.Tag = "Patient.Inpatient.Search"
        SearchOutpatientByNameToolStripMenuItem.Tag = "Patient.Outpatient.Search"
        AddPatientInsuranceToolStripMenuItem.Tag = "PatInsAdd"
        SearchPatieintInsuranceToolStripMenuItem.Tag = "PatInsSearch"


        ' ===== Others =====
        AddClinicToolStripMenuItem.Tag = "Clinic.Add"
        AddLocalDoctorToolStripMenuItem.Tag = "LocalDoctor.Add"
        AppointmentBookingToolStripMenuItem.Tag = "Appointment.Book"
        AddInsuranceToolStripMenuItem.Tag = "InsAdd"
        SearchInsuranceToolStripMenuItem.Tag = "InsSearch"

        ' ===== Supplies =====
        AddSupplierToolStripMenuItem.Tag = "Supplies.Supplier.Add"
        AddPharmaceuticalToolStripMenuItem.Tag = "Supplies.Pharma.Add"
        AddSurgicalSupplyToolStripMenuItem.Tag = "Supplies.Surgical.Add"
        AddNonSurgicalSupplyToolStripMenuItem.Tag = "Supplies.NonSurgical.Add"
        SearchSupplierByNameToolStripMenuItem.Tag = "Supplies.Supplier.Search"
        SearchPharmaceuticalToolStripMenuItem.Tag = "Supplies.Pharma.Search"
        SearchSurgicalSupplyByNameToolStripMenuItem.Tag = "Supplies.Surgical.Search"
        SearchNonSurgicalSupplyByNameToolStripMenuItem.Tag = "Supplies.NonSurgical.Search"

        ' ===== Reports / Dashboard =====
        InpatientReportToolStripMenuItem1.Tag = "Report.Inpatient.View"
        InPToolStripMenuItem.Tag = "Report.WaitingList.View"
        OutpatientReportToolStripMenuItem1.Tag = "Report.Outpatient.View"
        MedicationReportToolStripMenuItem.Tag = "Report.Medication.View"
        RequistionReportToolStripMenuItem.Tag = "Report.Requistion.View"
        RequistionBudgetToolStripMenuItem.Tag = "ReqBudget"
        MostUsedInsuranceToolStripMenuItem.Tag = "MostIns"
        MostToolStripMenuItem.Tag = "Most"
        PatientReceiptToolStripMenuItem.Tag = "PatReceipt"

        ' ===== Medication =====
        MedicationRecordToolStripMenuItem1.Tag = "Medication.Record.View"
    End Sub

    ' ===== Wellmeadows.vb =====
    Private _perms As HashSet(Of String)

    ' เรียกจากหน้า Login หลังตรวจสอบรหัสผ่าน/ดึง role สำเร็จ
    Public Sub SetPermissions(perms As HashSet(Of String))
        _perms = perms
        MapMenuTags()                          ' ผูก Tag ให้เมนูทั้งหมด
        ApplyPermissionsToMenu(MenuStrip1)     ' เปิด/ปิดเมนูตามสิทธิ
    End Sub

    Private Sub ApplyPermissionsToMenu(ms As MenuStrip)
        For Each it As ToolStripItem In ms.Items
            ApplyToItemRecursive(TryCast(it, ToolStripMenuItem))
        Next
    End Sub

    Private Sub ApplyToItemRecursive(item As ToolStripMenuItem)
        If item Is Nothing Then Return

        Dim required As String = If(TryCast(item.Tag, String), "").Trim()
        item.Visible = CanAccess(required)

        ' ตรวจลูก ๆ
        For Each child As ToolStripItem In item.DropDownItems
            ApplyToItemRecursive(TryCast(child, ToolStripMenuItem))
        Next

        ' ถ้าพ่อถูกซ่อน แต่มีลูกที่อนุญาต → เปิดพ่อไว้เพื่อให้เข้าถึงลูกได้
        If Not item.Visible Then
            For Each child As ToolStripItem In item.DropDownItems
                If child.Visible Then
                    item.Visible = True
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Function CanAccess(required As String) As Boolean
        If _perms Is Nothing OrElse _perms.Count = 0 Then Return False
        If _perms.Contains("*") Then Return True                 ' Admin
        If String.IsNullOrEmpty(required) Then Return True       ' เมนู public
        For Each need In required.Split(","c).Select(Function(s) s.Trim())
            If _perms.Contains(need) Then Return True
        Next
        Return False
    End Function

    ' ป้องกันเปิดฟอร์มซ้ำ (เลือกใช้ได้เพื่อให้โค้ดคลีน)
    Private Sub OpenOrActivate(Of T As {Form, New})()
        Dim exists = MdiChildren.OfType(Of T)().FirstOrDefault()
        If exists IsNot Nothing Then
            exists.BringToFront()
            exists.Focus()
        Else
            Dim frm As New T()
            frm.MdiParent = Me
            frm.FormBorderStyle = FormBorderStyle.None
            frm.ControlBox = False
            frm.Text = ""
            frm.Dock = DockStyle.Fill
            frm.Show()
        End If
    End Sub





    Private Sub AddStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffToolStripMenuItem.Click
        Dim frm As New Staff_AddStaff
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddStaffQualificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffQualificationToolStripMenuItem.Click
        Dim frm As New Staff_AddStaffQual
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddStaffWorkExperienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffWorkExperienceToolStripMenuItem.Click
        Dim frm As New Staff_AddStaffWorkExp
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ByQualificationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByQualificationToolStripMenuItem.Click
        Dim frm As New Staff_SearchByQual
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ByWorkExperienceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByWorkExperienceToolStripMenuItem.Click
        Dim frm As New Staff_SearchByWorkExp
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddWardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddWardToolStripMenuItem.Click
        Dim frm As New Ward_AddWardChargeNurse
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AssignChargeNurseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New Ward_AddWardChargeNurse
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddWeekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddWeekToolStripMenuItem.Click
        Dim frm As New Ward_AddWeek
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub StaffAllocationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StaffAllocationToolStripMenuItem1.Click
        Dim frm As New Staff_StaffAllocation
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Sub AddPatientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddPatientToolStripMenuItem1.Click
        Dim frm As New Patient_AddPatient
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddClinicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddClinicToolStripMenuItem.Click
        Dim frm As New Clinic_AddClinic
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddLocalDoctorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLocalDoctorToolStripMenuItem.Click
        Dim frm As New LD_AddLocalDoctor
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddPatientNextOfKinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPatientNextOfKinToolStripMenuItem.Click
        Dim frm As New Patient_NextOfKin
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AppointmentBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentBookingToolStripMenuItem.Click
        Dim frm As New Patient_AppointmentBooking
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRoomToolStripMenuItem.Click
        Dim frm As New Room_AddRoom
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub BedManagementForInpatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BedManagementForInpatientToolStripMenuItem.Click
        Dim frm As New Patient_AddBed
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub InpatientAdmissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InpatientAdmissionToolStripMenuItem.Click
        Dim frm As New Patient_InpatientAdmit
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Sub InpatientReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InpatientReportToolStripMenuItem1.Click
        Dim frm As New Dashboard_InpatientReport
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub InPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InPToolStripMenuItem.Click
        Dim frm As New Dashboard_WaitingListReport
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub StaffAllocationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffAllocationReportToolStripMenuItem.Click
        Dim frm As New Dashboard_StaffAllocation
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub OutpatientReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OutpatientReportToolStripMenuItem1.Click
        Dim frm As New Dashboard_OutpatientReport
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub


    Private Sub AddSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSupplierToolStripMenuItem.Click
        Dim frm As New Supplies_AddSupplier
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddPharmaceuticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPharmaceuticalToolStripMenuItem.Click
        Dim frm As New Supplies_AddPharmaceutical
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub ByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByNameToolStripMenuItem.Click
        Dim frm As New Staff_SearchStaffName_1
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchPatientByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPatientByNameToolStripMenuItem.Click
        Dim frm As New Patient_SearchPatientName_1
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchPatientNextOfKinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPatientNextOfKinToolStripMenuItem.Click
        Dim frm As New Patient_SearchPatientNextOfKin
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchInpatientByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchInpatientByNameToolStripMenuItem.Click
        Dim frm As New Patient_SearchInpatientName
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchOutpatientByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchOutpatientByNameToolStripMenuItem.Click
        Dim frm As New Patient_SearchOutpatientName
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchPharmaceuticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPharmaceuticalToolStripMenuItem.Click
        Dim frm As New Supplies_SearchPharmaName_1
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchSupplierByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchSupplierByNameToolStripMenuItem.Click
        Dim frm As New Supplies_SearchSupplierName_1
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddSurgicalSupplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSurgicalSupplyToolStripMenuItem.Click
        Dim frm As New Supplies_AddSurgicalSupply
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddNonSurgicalSupplyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNonSurgicalSupplyToolStripMenuItem.Click
        Dim frm As New Supplies_AddNonSurgicalSupply
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchSurgicalSupplyByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchSurgicalSupplyByNameToolStripMenuItem.Click
        Dim frm As New Supplies_SearchSurSupplyName
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchNonSurgicalSupplyByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchNonSurgicalSupplyByNameToolStripMenuItem.Click
        Dim frm As New Supplies_SearchNonSurSupplyName
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MedicationRecordReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm As New Dashboard_MedicationReport
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddRequisitionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRequisitionToolStripMenuItem.Click
        Dim frm As New Requisition_Add
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub Wellmeadows_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ShowInTaskbar = True
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    ' กันเหนียว: ถ้าฟอร์มหลักถูกปิด ให้จบแอปเสมอ
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
        Application.Exit()   ' ปิด message loop ทั้งหมด
    End Sub

    Private Sub RequistionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequistionReportToolStripMenuItem.Click
        Dim frm As New Dashboard_Requisition
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub RequistionBudgetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequistionBudgetToolStripMenuItem.Click
        OpenChild(Of Dashboard_WardReqBudget)()
    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        Dim frm As New Users
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub PatientReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientReceiptToolStripMenuItem.Click
        Dim frm As New Dashboard_PatientReceipt
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddInsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddInsuranceToolStripMenuItem.Click
        Dim frm As New Insurance_Add
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MostUsedInsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostUsedInsuranceToolStripMenuItem.Click
        Dim frm As New Dashboard_InsPatientBar
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostToolStripMenuItem.Click
        Dim frm As New Dashboard_InsNoHaveGraph
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub AddPatientInsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPatientInsuranceToolStripMenuItem.Click
        Dim frm As New Patient_Insurance
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchInsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchInsuranceToolStripMenuItem.Click
        Dim frm As New Insurance_Search_1
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MedicationRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MedicationRecordToolStripMenuItem1.Click
        Dim frm As New Patient_MedRecord
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub SearchPatieintInsuranceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPatieintInsuranceToolStripMenuItem.Click
        Dim frm As New Patient_SearchInsurance
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub

    Private Sub MedicationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicationReportToolStripMenuItem.Click
        Dim frm As New Dashboard_MedicationReport
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        frm.ControlBox = False
        frm.Text = ""
        frm.Dock = DockStyle.Fill
        frm.Show()
    End Sub
End Class