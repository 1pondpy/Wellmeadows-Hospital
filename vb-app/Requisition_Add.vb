Imports System.Configuration
Imports System.Data.SqlClient

Public Class Requisition_Add
    Private ReadOnly cs As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private _loading As Boolean = False

    ' ====== FORM LOAD ======
    Private Sub Requisition_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _loading = True

            ' ประเภทของที่จะเบิก
            cboType.Items.Clear()
            cboType.Items.AddRange(New String() {"Drug", "Surgical", "NonSurgical"})
            cboType.SelectedIndex = 0

            ' โหลดวอร์ด
            LoadWardCombo(cboWard)
            If cboWard.Items.Count > 0 Then cboWard.SelectedIndex = 0

            ' โหลด Charge Nurse
            LoadChargeNurse(cboRequestedBy)

            ' ผู้รับของ ใครก็ได้ (ว่างได้)
            LoadStaffCombo_All(cboReceivedBy, allowNull:=True)

            ' รายการสินค้าตามประเภทแรก
            LoadItems("Drug")

            ' ค่าเริ่มต้น
            numQty.Minimum = 1
            numQty.Value = 1
            dtpRequest.Value = Date.Today
            dtpDelivery.Value = Date.Today

            _loading = False

            ClearTextBoxes()

            ' โหลดตาราง
            LoadGrid()

        Catch ex As Exception
            _loading = False
            MessageBox.Show("โหลดฟอร์มล้มเหลว: " & ex.Message)
        End Try
    End Sub

    ' ====== LOADERS / HELPERS ======
    Private Sub LoadWardCombo(cbo As ComboBox)
        Using cn As New SqlConnection(cs)
            Dim da As New SqlDataAdapter("SELECT WardID, WardName FROM Ward ORDER BY WardName;", cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cbo.DisplayMember = "WardName"
            cbo.ValueMember = "WardID"
            cbo.DataSource = dt
        End Using
    End Sub

    Private Sub LoadStaffCombo_All(cbo As ComboBox, Optional allowNull As Boolean = False)
        Using cn As New SqlConnection(cs)
            Dim da As New SqlDataAdapter("
                SELECT StaffID, (FirstName + ' ' + LastName) AS FullName
                FROM Staff
                ORDER BY FirstName, LastName;", cn)
            Dim dt As New DataTable()
            da.Fill(dt)

            If allowNull Then
                Dim r = dt.NewRow()
                r("StaffID") = DBNull.Value
                r("FullName") = "(none)"
                dt.Rows.InsertAt(r, 0)
            End If

            cbo.DisplayMember = "FullName"
            cbo.ValueMember = "StaffID"
            cbo.DataSource = dt
        End Using
    End Sub

    ' โหลดรายชื่อ Charge Nurse (Position = 'Charge Nurse')
    Private Sub LoadChargeNurse(cbo As ComboBox)
        Using cn As New SqlConnection(cs)
            Dim da As New SqlDataAdapter("
                SELECT StaffID, (FirstName + ' ' + LastName) AS FullName
                FROM Staff
                WHERE [Position] = 'Charge Nurse'
                ORDER BY FirstName, LastName;", cn)
            Dim dt As New DataTable()
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                dt.Columns.Add("StaffID", GetType(Integer))
                dt.Columns.Add("FullName", GetType(String))
            End If

            cbo.DisplayMember = "FullName"
            cbo.ValueMember = "StaffID"
            cbo.DataSource = dt
            If dt.Rows.Count > 0 Then cbo.SelectedIndex = 0
        End Using
    End Sub

    ' โหลดสินค้าตามประเภท
    Private Sub LoadItems(itemType As String)
        Dim sql As String
        Select Case itemType
            Case "Drug"
                sql = "SELECT DrugID AS ItemID, DrugName AS ItemName FROM PharmaSupply ORDER BY DrugName;"
            Case "Surgical"
                sql = "SELECT SurItemID AS ItemID, SurName AS ItemName FROM SurgicalSupply ORDER BY SurName;"
            Case Else
                sql = "SELECT NonSurItemID AS ItemID, NonSurName AS ItemName FROM NonSurgicalSupply ORDER BY NonSurName;"
        End Select

        Using cn As New SqlConnection(cs)
            Dim da As New SqlDataAdapter(sql, cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            cboItem.DisplayMember = "ItemName"
            cboItem.ValueMember = "ItemID"
            cboItem.DataSource = dt
            If dt.Rows.Count > 0 Then cboItem.SelectedIndex = 0
        End Using
    End Sub

    ' ดึงค่า ID จาก ComboBox
    Private Function SafeId(cbo As ComboBox, idField As String) As Integer
        If cbo Is Nothing OrElse cbo.SelectedItem Is Nothing Then Return 0
        If cbo.SelectedValue Is Nothing OrElse TypeOf cbo.SelectedValue Is DBNull Then Return 0
        If TypeOf cbo.SelectedValue Is Integer Then Return CInt(cbo.SelectedValue)

        If TypeOf cbo.SelectedItem Is DataRowView Then
            Dim drv = DirectCast(cbo.SelectedItem, DataRowView)
            If drv.Row.Table.Columns.Contains(idField) AndAlso Not IsDBNull(drv(idField)) Then
                Return CInt(drv(idField))
            End If
        End If

        Dim s = cbo.SelectedValue.ToString()
        Dim n As Integer
        If Integer.TryParse(s, n) Then Return n
        Return 0
    End Function

    ' โหลด Grid
    Private Sub LoadGrid()
        Using cn As New SqlConnection(cs)
            Dim da As New SqlDataAdapter("
                SELECT *
                FROM RequisitionView
                ORDER BY RequestDate DESC, ReqID DESC;", cn)
            Dim dt As New DataTable()
            da.Fill(dt)
            RequisitionBindingSource.DataSource = dt
        End Using

        dgvReq.DataSource = RequisitionBindingSource
        dgvReq.ReadOnly = True
        dgvReq.AllowUserToAddRows = False
        dgvReq.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvReq.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub ClearForm()
        txtDesc.Clear()
        txtDosage.Clear()
        txtMethod.Clear()
        numQty.Value = 1
        dtpRequest.Value = Date.Today
        dtpDelivery.Value = Date.Today
        cboType.SelectedIndex = 0
        LoadItems("Drug")
    End Sub

    ' ====== EVENTS ======
    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If _loading Then Return
        If cboType.SelectedItem IsNot Nothing Then
            LoadItems(cboType.SelectedItem.ToString())
        End If
    End Sub

    Private Sub cboWard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWard.SelectedIndexChanged
        If _loading Then Return
        ' ไม่ได้ผูกกับวอร์ดโดยตรง → โหลด Charge Nurse ใหม่ก็พอ
        LoadChargeNurse(cboRequestedBy)
    End Sub

    ' ====== SAVE BUTTON ======
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboItem.SelectedValue Is Nothing Then
            MessageBox.Show("กรุณาเลือกรายการที่จะเบิก") : Return
        End If
        Dim wardId As Integer = SafeId(cboWard, "WardID")
        If wardId = 0 Then
            MessageBox.Show("กรุณาเลือกวอร์ด") : Return
        End If
        Dim reqBy As Integer = SafeId(cboRequestedBy, "StaffID")
        If reqBy = 0 Then
            MessageBox.Show("กรุณาเลือกผู้ขอเบิก (Charge Nurse)") : Return
        End If
        If Not IsChargeNurse(reqBy) Then
            MessageBox.Show("ผู้ขอเบิกต้องเป็น Charge Nurse")
            Return
        End If

        Dim itemType As String = cboType.SelectedItem.ToString()
        Dim itemID As Integer = SafeId(cboItem, "ItemID")
        Dim qty As Integer = CInt(numQty.Value)
        If qty <= 0 Then
            MessageBox.Show("Quantity ต้องมากกว่า 0") : Return
        End If

        Dim descText As String = txtDesc.Text.Trim()
        Dim dosage As Object = If(String.IsNullOrWhiteSpace(txtDosage.Text), CType(DBNull.Value, Object), txtDosage.Text.Trim())
        Dim method As Object = If(String.IsNullOrWhiteSpace(txtMethod.Text), CType(DBNull.Value, Object), txtMethod.Text.Trim())
        Dim recvId As Integer = SafeId(cboReceivedBy, "StaffID")
        Dim recvBy As Object = If(recvId = 0, CType(DBNull.Value, Object), recvId)

        Using cn As New SqlConnection(cs)
            cn.Open()
            Dim sql As String = "
INSERT INTO Requisition
    (ReqDesc, DrugID, SurItemID, NonSurItemID, Quantity, RequestDate, DeliveryDate,
     Dosage, MethodOfAdmin, Staff_RequestedBy, Staff_ReceivedBy, WardID)
VALUES
    (@Desc, @DrugID, @SurItemID, @NonSurItemID, @Qty, @ReqDate, @DelivDate,
     @Dosage, @Method, @ReqBy, @RecvBy, @WardID);"

            Using cmd As New SqlCommand(sql, cn)
                Dim drugId As Object = DBNull.Value
                Dim surId As Object = DBNull.Value
                Dim nonId As Object = DBNull.Value
                Select Case itemType
                    Case "Drug" : drugId = itemID
                    Case "Surgical" : surId = itemID
                    Case "NonSurgical" : nonId = itemID
                End Select

                cmd.Parameters.AddWithValue("@Desc", If(descText = "", CType(DBNull.Value, Object), descText))
                cmd.Parameters.AddWithValue("@DrugID", drugId)
                cmd.Parameters.AddWithValue("@SurItemID", surId)
                cmd.Parameters.AddWithValue("@NonSurItemID", nonId)
                cmd.Parameters.AddWithValue("@Qty", qty)
                cmd.Parameters.AddWithValue("@ReqDate", dtpRequest.Value.Date)
                cmd.Parameters.AddWithValue("@DelivDate", dtpDelivery.Value.Date)
                cmd.Parameters.AddWithValue("@Dosage", dosage)
                cmd.Parameters.AddWithValue("@Method", method)
                cmd.Parameters.AddWithValue("@ReqBy", reqBy)
                cmd.Parameters.AddWithValue("@RecvBy", recvBy)
                cmd.Parameters.AddWithValue("@WardID", wardId)

                Try
                    cmd.ExecuteNonQuery()
                    LoadGrid()
                    ClearForm()
                    MessageBox.Show("บันทึกใบเบิกสำเร็จ")
                Catch ex As SqlException
                    MessageBox.Show("บันทึกล้มเหลว: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' ====== BindingNavigator Save ======
    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        btnSave.PerformClick()
    End Sub

    ' ====== BindingNavigator Delete ======
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        If RequisitionBindingSource.Current Is Nothing Then Return

        Dim drv As DataRowView = TryCast(RequisitionBindingSource.Current, DataRowView)
        If drv Is Nothing OrElse Not drv.Row.Table.Columns.Contains("ReqID") Then Return

        Dim reqId As Integer = CInt(drv("ReqID"))
        If MessageBox.Show("คุณต้องการลบใบเบิกหมายเลข " & reqId & " ใช่หรือไม่?",
                           "ยืนยันการลบ", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using cn As New SqlConnection(cs)
            cn.Open()
            Using cmd As New SqlCommand("DELETE FROM Requisition WHERE ReqID = @id", cn)
                cmd.Parameters.AddWithValue("@id", reqId)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadGrid()
    End Sub

    ' ====== ตรวจสิทธิ์ Charge Nurse ======
    Private Function IsChargeNurse(staffId As Integer) As Boolean
        Using cn As New SqlConnection(cs)
            cn.Open()
            Using cmd As New SqlCommand("
                SELECT 1 FROM Staff WHERE StaffID = @StaffID AND [Position] = 'Charge Nurse';", cn)
                cmd.Parameters.AddWithValue("@StaffID", staffId)
                Dim o = cmd.ExecuteScalar()
                Return (o IsNot Nothing)
            End Using
        End Using
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvReq.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกรายการที่จะลบ")
            Return
        End If

        Dim ids As New List(Of Integer)

        ' เก็บ ReqID ของแถวที่เลือก
        For Each r As DataGridViewRow In dgvReq.SelectedRows
            If r.Cells("ReqID").Value IsNot Nothing Then
                ids.Add(CInt(r.Cells("ReqID").Value))
            End If
        Next

        If ids.Count = 0 Then Return

        ' ยืนยันก่อนลบ
        If MessageBox.Show("คุณต้องการลบ " & ids.Count & " รายการ ใช่หรือไม่?",
                           "ยืนยันการลบ",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' ลบจากฐานข้อมูล
        Using cn As New SqlConnection(cs)
            cn.Open()
            For Each id In ids
                Using cmd As New SqlCommand("DELETE FROM Requisition WHERE ReqID = @id", cn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using

        ' โหลดตารางใหม่
        LoadGrid()
        MessageBox.Show("ลบข้อมูลสำเร็จ")
    End Sub

    ' ====== EDIT / MARK RECEIVED ======
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' เลือกได้หลายแถวก็ได้ จะ set ผู้รับเป็นคนเดียวกันให้ทุกแถว
        If dgvReq.SelectedRows.Count = 0 Then
            MessageBox.Show("กรุณาเลือกรายการในตารางก่อน")
            Return
        End If

        Dim recvId As Integer = SafeId(cboReceivedBy, "StaffID")
        If recvId = 0 Then
            MessageBox.Show("กรุณาเลือกผู้รับของ (Received By) ก่อน")
            Return
        End If

        ' วันที่รับ ตาม dtpDelivery
        Dim delivDate As Date = dtpDelivery.Value.Date

        ' ยืนยันก่อนทำรายการ
        If MessageBox.Show("ยืนยันการบันทึกผู้รับของให้ " & dgvReq.SelectedRows.Count & " รายการ?",
                       "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' เก็บ ReqID ทั้งหมดจากแถวที่เลือก
        Dim ids As New List(Of Integer)
        For Each r As DataGridViewRow In dgvReq.SelectedRows
            If r.Cells("ReqID").Value IsNot Nothing Then
                ids.Add(CInt(r.Cells("ReqID").Value))
            End If
        Next
        If ids.Count = 0 Then Return

        ' อัปเดตเฉพาะรายการที่ยังไม่มีผู้รับ (Staff_ReceivedBy IS NULL)
        Dim affectedTotal As Integer = 0
        Using cn As New SqlConnection(cs)
            cn.Open()
            Dim sql As String =
"UPDATE Requisition
   SET Staff_ReceivedBy = @RecvBy,
       DeliveryDate     = @DelivDate
 WHERE ReqID = @ReqID
   AND Staff_ReceivedBy IS NULL;"

            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.Add("@RecvBy", SqlDbType.Int)
                cmd.Parameters.Add("@DelivDate", SqlDbType.Date)
                cmd.Parameters.Add("@ReqID", SqlDbType.Int)

                For Each id In ids
                    cmd.Parameters("@RecvBy").Value = recvId
                    cmd.Parameters("@DelivDate").Value = delivDate
                    cmd.Parameters("@ReqID").Value = id
                    affectedTotal += cmd.ExecuteNonQuery()
                Next
            End Using
        End Using

        LoadGrid()

        ' แจ้งผล: ถ้าบางใบถูกมาร์คไปแล้วก่อนหน้า (มีผู้รับแล้ว) ก็จะไม่ถูกอัปเดต (rows affected = 0)
        If affectedTotal = 0 Then
            MessageBox.Show("ไม่มีรายการใดถูกอัปเดต (อาจมีผู้รับของถูกบันทึกไว้ก่อนแล้ว)")
        ElseIf affectedTotal < ids.Count Then
            MessageBox.Show("บันทึกผู้รับของสำเร็จ " & affectedTotal & " รายการ (บางรายการมีผู้รับแล้ว)")
        Else
            MessageBox.Show("บันทึกผู้รับของสำเร็จ")
        End If
    End Sub

    Private Sub ClearTextBoxes()
        For Each tb As TextBox In Me.Controls.OfType(Of TextBox)()
            tb.Clear()
        Next
    End Sub

End Class
