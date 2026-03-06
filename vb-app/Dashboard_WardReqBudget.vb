Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard_WardReqBudget
    Private ReadOnly connectionString As String =
    ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private _loading As Boolean = False
    ' ใช้ธงไว้รู้ว่าเงื่อนไขมีการเปลี่ยน แต่จะไม่รีเฟรชเองจนกว่าจะกด Filter
    Private _dirty As Boolean = False

    Private Sub Dashboard_WardBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _loading = True
            Me.Text = "Dashboard_WardBudget"

            dtFrom.Format = DateTimePickerFormat.Custom : dtFrom.CustomFormat = "dd/MM/yyyy"
            dtTo.Format = DateTimePickerFormat.Custom : dtTo.CustomFormat = "dd/MM/yyyy"

            LoadWardCombo()

            Dim firstOfMonth As New Date(Date.Today.Year, Date.Today.Month, 1)
            dtFrom.Value = firstOfMonth
            dtTo.Value = Date.Today

            dgv.DataSource = Nothing
            _dirty = True
            btnFilter.Enabled = True ' เผื่ออยากกดรันครั้งแรก
        Catch ex As Exception
            MessageBox.Show("Error on load: " & ex.Message)
        Finally
            _loading = False
        End Try
    End Sub

    Private Sub LoadWardCombo()
        Using con As New SqlConnection(connectionString)
            con.Open()
            Dim cmd As New SqlCommand("
                SELECT WardID, WardName
                FROM Ward
                ORDER BY WardName;", con)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            Dim dtWithAll As New DataTable()
            dtWithAll.Columns.Add("WardID", GetType(Integer))
            dtWithAll.Columns.Add("WardName", GetType(String))
            dtWithAll.Rows.Add(-1, "(All Wards)")
            For Each r As DataRow In dt.Rows
                dtWithAll.Rows.Add(r("WardID"), r("WardName"))
            Next

            cboWard.DataSource = dtWithAll
            cboWard.DisplayMember = "WardName"
            cboWard.ValueMember = "WardID"
            cboWard.SelectedValue = -1
        End Using
    End Sub

    ' ==== กดปุ่มแล้วค่อยรีเฟรชเสมอ ====
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        RefreshBudget()
        _dirty = False
    End Sub

    ' ==== เปลี่ยน Ward/วันที่ -> ทำแค่ mark ว่ามีการเปลี่ยน แต่ไม่รีเฟรช ====
    Private Sub cboWard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWard.SelectedIndexChanged
        If _loading Then Return
        _dirty = True
        ' ถ้าอยากสื่อผู้ใช้ว่า "กด Filter เพื่ออัปเดต" ก็ขึ้นสถานะ/enable ปุ่มได้
        btnFilter.Enabled = True
    End Sub

    Private Sub dt_ValueChanged(sender As Object, e As EventArgs) Handles dtFrom.ValueChanged, dtTo.ValueChanged
        If _loading Then Return
        _dirty = True
        btnFilter.Enabled = True
    End Sub

    Private Sub RefreshBudget()
        Try
            If dtFrom.Value.Date > dtTo.Value.Date Then
                MessageBox.Show("ช่วงวันที่ไม่ถูกต้อง: From > To")
                Return
            End If

            Dim wardId As Integer = CInt(cboWard.SelectedValue)

            Dim sql As String =
"
;WITH line_cost AS (
    SELECT
        r.WardID,
        r.ReqID,
        r.RequestDate,
        r.Quantity,
        COALESCE(s.CostPerUnit, ns.CostPerUnit, ps.CostPerUnit, 0) AS UnitCost
    FROM Requisition r
    LEFT JOIN SurgicalSupply       s  ON r.SurItemID     = s.SurItemID
    LEFT JOIN NonSurgicalSupply    ns ON r.NonSurItemID  = ns.NonSurItemID
    LEFT JOIN PharmaSupply         ps ON r.DrugID        = ps.DrugID
    WHERE r.RequestDate >= @from
      AND r.RequestDate < DATEADD(DAY, 1, @to)
      AND (@wardId = -1 OR r.WardID = @wardId)
)
SELECT
    w.WardID,
    w.WardName,
    SUM(CAST(lc.Quantity AS DECIMAL(18,2)) * CAST(lc.UnitCost AS DECIMAL(18,2))) AS TotalCost
FROM line_cost lc
INNER JOIN Ward w ON lc.WardID = w.WardID
GROUP BY w.WardID, w.WardName
ORDER BY w.WardName;
"

            Dim dt As New DataTable()
            Using con As New SqlConnection(connectionString)
                con.Open()
                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.Add("@from", SqlDbType.Date).Value = dtFrom.Value.Date
                    cmd.Parameters.Add("@to", SqlDbType.Date).Value = dtTo.Value.Date
                    cmd.Parameters.Add("@wardId", SqlDbType.Int).Value = wardId
                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgv.DataSource = dt
            dgv.ReadOnly = True
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.MultiSelect = False
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            If dt.Columns.Contains("TotalCost") Then
                dgv.Columns("TotalCost").DefaultCellStyle.Format = "N2"
            End If

            If dt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูลตามเงื่อนไข")
            End If
        Catch ex As Exception
            MessageBox.Show("Refresh error: " & ex.Message)
        End Try
    End Sub

End Class
