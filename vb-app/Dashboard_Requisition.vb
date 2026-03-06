Imports System.Configuration
Imports System.Data.SqlClient

Public Class Dashboard_Requisition

    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Dashboard_Requisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadWardCombo(cboWard, includeAll:=True)

            ' ค่าเริ่มต้น: เดือนปัจจุบัน
            Dim today = Date.Today
            Dim firstOfMonth As New Date(today.Year, today.Month, 1)
            dtpFrom.Value = firstOfMonth
            dtpTo.Value = today

            RunSearch() ' โหลดครั้งแรก
        Catch ex As Exception
            MessageBox.Show("โหลดหน้ารายงานล้มเหลว: " & ex.Message)
        End Try
    End Sub

    ' ====== LOADERS ======
    Private Sub LoadWardCombo(cbo As ComboBox, Optional includeAll As Boolean = False)
        Using cn As New SqlConnection(connectionString)
            Dim da As New SqlDataAdapter("SELECT WardID, WardName FROM Ward ORDER BY WardName;", cn)
            Dim dt As New DataTable()
            da.Fill(dt)

            If includeAll Then
                Dim r = dt.NewRow()
                r("WardID") = 0
                r("WardName") = "(All Wards)"
                dt.Rows.InsertAt(r, 0)
            End If

            cbo.DisplayMember = "WardName"
            cbo.ValueMember = "WardID"
            cbo.DataSource = dt
            If dt.Rows.Count > 0 Then cbo.SelectedIndex = 0
        End Using
    End Sub

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

    ' ====== SEARCH CORE ======
    Private Sub RunSearch()
        If dtpFrom.Value.Date > dtpTo.Value.Date Then
            MessageBox.Show("ช่วงวันที่ไม่ถูกต้อง: Date From ต้องไม่มากกว่า Date To")
            Return
        End If

        Dim wardId As Integer = SafeId(cboWard, "WardID")
        Dim fromDate As Date = dtpFrom.Value.Date
        Dim toDate As Date = dtpTo.Value.Date

        ' ใช้ตารางจริง เพื่อให้ฟิลเตอร์ได้ด้วย WardID (ไม่ต้องพึ่ง View)
        Dim sql As String =
    "SELECT 
        r.ReqID,
        w.WardName,
        CASE 
          WHEN r.DrugID IS NOT NULL THEN 'Drug'
          WHEN r.SurItemID IS NOT NULL THEN 'Surgical'
          WHEN r.NonSurItemID IS NOT NULL THEN 'NonSurgical'
        ELSE 'Unknown'
        END AS ItemType,
        COALESCE(d.DrugName, s.SurName, n.NonSurName) AS ItemName,
        r.Quantity,
        r.RequestDate,
        r.DeliveryDate,
        (srq.FirstName + ' ' + srq.LastName) AS RequestedBy,
        CASE WHEN srv.StaffID IS NULL THEN '(not received)' ELSE (srv.FirstName + ' ' + srv.LastName) END AS ReceivedBy,
        r.ReqDesc,
        r.Dosage,
        r.MethodOfAdmin
        FROM Requisition r
        LEFT JOIN Ward w ON w.WardID = r.WardID
        LEFT JOIN PharmaSupply d ON d.DrugID = r.DrugID
        LEFT JOIN SurgicalSupply s ON s.SurItemID = r.SurItemID
        LEFT JOIN NonSurgicalSupply n ON n.NonSurItemID = r.NonSurItemID
        LEFT JOIN Staff srq ON srq.StaffID = r.Staff_RequestedBy
        LEFT JOIN Staff srv ON srv.StaffID = r.Staff_ReceivedBy
        WHERE
         (@WardID = 0 OR r.WardID = @WardID)
         AND r.RequestDate >= @FromDate
         AND r.RequestDate <= @ToDate
        ORDER BY r.RequestDate DESC, r.ReqID DESC;"

        Using cn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, cn)
                cmd.Parameters.Add("@WardID", SqlDbType.Int).Value = wardId
                cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate
                cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate

                Dim dt As New DataTable()
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

                dgv.DataSource = dt
                FormatGrid()
            End Using
        End Using
    End Sub

    Private Sub FormatGrid()
        If dgv.Columns.Contains("RequestDate") Then
            dgv.Columns("RequestDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        End If
        If dgv.Columns.Contains("DeliveryDate") Then
            dgv.Columns("DeliveryDate").DefaultCellStyle.Format = "dd/MM/yyyy"
        End If
        If dgv.Columns.Contains("Quantity") Then
            dgv.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub



    ' ====== UI EVENTS ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RunSearch()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
