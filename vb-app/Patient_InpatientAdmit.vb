Imports System.Configuration
Imports System.Data.SqlClient

Public Class Patient_InpatientAdmit

    ' =====[ CONFIG ]==========================================================
    Private ReadOnly connectionString As String =
    ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    ' =====[ FORM LOAD ]=======================================================
    Private Sub Patient_InpatientAdmit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ▼ ถ้าใช้ DataSet/Adapter จาก Designer ให้ Fill มาก่อน
        Try
            ' โหลดข้อมูล Inpatient เดิม (หากต้องการ)
            Me.InpatientTableAdapter.Fill(Me.WellmeadowsDBDataSet.Inpatient)
        Catch : End Try

        ' ต้องแน่ใจว่า TableAdapterManager รู้จัก InpatientTableAdapter
        Me.TableAdapterManager.InpatientTableAdapter = Me.InpatientTableAdapter

        ' โหลดรายการวอร์ดเข้าคอมโบ
        LoadWards()

        ' ผูกคอมโบเข้ากับฟิลด์ใน Inpatient
        BindCombos()

        ' เตียงปิดไว้ก่อนจนกว่าจะเลือกวอร์ด
        cboBed.Enabled = False

        ' ถ้าแถวปัจจุบันมี Ward อยู่แล้ว ให้โหลดเตียงของวอร์ดนั้น
        If cboWard.SelectedValue IsNot Nothing AndAlso Not TypeOf cboWard.SelectedValue Is DataRowView Then
            LoadBeds(Convert.ToInt32(cboWard.SelectedValue))
            cboBed.Enabled = True
        End If
    End Sub

    ' =====[ BINDING COMBOS ]==================================================
    Private Sub BindCombos()
        ' ผูก cboWard กับฟิลด์ WardID ของ Inpatient (อัปเดตทันทีที่เปลี่ยน)
        cboWard.DataBindings.Clear()
        cboWard.DataBindings.Add("SelectedValue", InpatientBindingSource, "WardID",
                                 True, DataSourceUpdateMode.OnPropertyChanged)

        ' ผูก cboBed กับฟิลด์ BedID ของ Inpatient แต่ไม่ให้เขียน NULL อัตโนมัติเวลาคลียร์
        cboBed.DataBindings.Clear()
        cboBed.DataBindings.Add("SelectedValue", InpatientBindingSource, "BedID",
                                True, DataSourceUpdateMode.Never)
    End Sub

    ' =====[ LOAD WARDS/BEDS ]=================================================
    Private Sub LoadWards()
        Using cn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter("SELECT WardID, WardName FROM Ward ORDER BY WardName", cn)
            Dim dt As New DataTable()
            da.Fill(dt)

            cboWard.DataSource = dt
            cboWard.DisplayMember = "WardName"
            cboWard.ValueMember = "WardID"
            cboWard.SelectedIndex = -1
        End Using
    End Sub

    Private Sub LoadBeds(wardId As Integer)
        Using cn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("
                SELECT BedID,
                       COALESCE(CAST(BedNo AS varchar(10)), CAST(BedID AS varchar(10))) AS BedNo
                FROM Bed
                WHERE WardID = @WardID
                ORDER BY BedNo;", cn)
            cmd.Parameters.AddWithValue("@WardID", wardId)

            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            cboBed.DataSource = dt
            cboBed.DisplayMember = "BedNo"
            cboBed.ValueMember = "BedID"
            cboBed.SelectedIndex = -1
        End Using
    End Sub

    ' เมื่อเปลี่ยนวอร์ด → โหลดเตียงของวอร์ดนั้น
    Private Sub cboWard_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboWard.SelectedValueChanged
        If cboWard.SelectedValue Is Nothing OrElse TypeOf cboWard.SelectedValue Is DataRowView Then
            cboBed.DataSource = Nothing
            cboBed.Enabled = False
            Exit Sub
        End If

        Dim wardId As Integer = Convert.ToInt32(cboWard.SelectedValue)
        LoadBeds(wardId)
        cboBed.Enabled = True
        cboBed.SelectedIndex = -1      ' เคลียร์ให้ผู้ใช้เลือกใหม่ (DataSourceUpdateMode.Never ป้องกันเขียน NULL)
    End Sub

    ' เมื่อผู้ใช้เลือกเตียงจริง ๆ ค่อยเขียนค่า BedID เข้า DataRow
    Private Sub cboBed_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboBed.SelectionChangeCommitted
        If cboBed.SelectedIndex >= 0 Then
            Dim drv = TryCast(InpatientBindingSource.Current, DataRowView)
            If drv IsNot Nothing Then drv("BedID") = Convert.ToInt32(cboBed.SelectedValue)
        End If
    End Sub

    ' =====[ SEARCH PATIENT DIALOG ]===========================================
    Private Sub SearchStaffQual_Click(sender As Object, e As EventArgs) Handles SearchStaffQual.Click
        Dim sForm As New Patient_SearchPatientName()
        sForm.ShowDialog()

        ' สมมติฟอร์มค้นหาตั้งค่า Property PatientID/PatientName ไว้
        PatientIDTextBox.Text = sForm.PatientID
        Label1.Text = sForm.PatientName
    End Sub

    Private Sub InpatientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InpatientBindingNavigatorSaveItem.Click

        Me.Validate()
        Me.InpatientBindingSource.EndEdit()
        Me.InpatientTableAdapter.Update(Me.WellmeadowsDBDataSet.Inpatient)

        MessageBox.Show("บันทึกแล้ว")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sForm As Staff_SearchStaffName
        sForm = New Staff_SearchStaffName()
        sForm.ShowDialog()
        StaffIDTextBox.Text = sForm.StaffID
        Label3.Text = sForm.StaffName
    End Sub
End Class