Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class Dashboard_PatientReceipt

    Private _patientID As Integer = -1

    Private ReadOnly cs As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString

    Private Sub Patient_Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DateTimePicker ให้ติ๊ก/ไม่ติ๊กเพื่อแปลว่าใช้/ไม่ใช้ช่วงวันที่
        dtFrom.ShowCheckBox = True
        dtTo.ShowCheckBox = True
        dtFrom.Value = Date.Today.AddDays(-7)
        dtTo.Value = Date.Today
        dtFrom.Checked = True
        dtTo.Checked = True

        ' เตรียม DataGridView
        SetupGrid()
        ClearTotals()
    End Sub

    Private Sub SetupGrid()
        With dgvLines
            .AutoGenerateColumns = False
            .Columns.Clear()

            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "MedDate",
            .HeaderText = "Date",
            .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "dd/MM/yyyy"},
            .Width = 80
        })
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "DrugName",
            .HeaderText = "Drug",
            .Width = 100
        })
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "MethodOfAdmin",
            .HeaderText = "Admin Method",
            .Width = 80
        })
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Dosage",
            .HeaderText = "Dosage",
            .Width = 70
        })
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "Qty",
            .HeaderText = "Quantity",
            .DefaultCellStyle = New DataGridViewCellStyle With {.Alignment = DataGridViewContentAlignment.MiddleRight},
            .Width = 55
        })
            .Columns.Add(New DataGridViewTextBoxColumn() With {
            .DataPropertyName = "CostPerUnit",
            .HeaderText = "Cost/Unit",
            .DefaultCellStyle = New DataGridViewCellStyle With {.Format = "N2", .Alignment = DataGridViewContentAlignment.MiddleRight},
            .Width = 60
        })

            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub ClearTotals()
        lblSubtotal.Text = "0.00"
        lblVat.Text = "0.00"
        lblTotal.Text = "0.00"
    End Sub

    Private Sub btnSearchPatient_Click(sender As Object, e As EventArgs) Handles btnSearchPatient.Click
        ' เปิดฟอร์มค้นหา แล้วรับค่า PatientID/Name กลับ
        Dim sForm As New Patient_SearchPatientName()
        If sForm.ShowDialog(Me) = DialogResult.OK Then
            _patientID = sForm.PatientID   ' ให้ฟอร์มค้นหามี Property นี้
            txtPatientName.Text = sForm.PatientName
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If _patientID <= 0 Then
            MessageBox.Show("กรุณาเลือกผู้ป่วยก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim useDate As Integer = If(dtFrom.Checked AndAlso dtTo.Checked, 1, 0)
        Dim fromDate As Date = dtFrom.Value.Date
        Dim toDate As Date = dtTo.Value.Date

        Dim dt As New DataTable()

        Using conn As New SqlConnection(cs)
            Using cmd As New SqlCommand("
                SELECT
                    mr.MedID,
                    mr.StartDate AS MedDate,   -- ใช้ StartDate แทน MedDate
                    ps.DrugID,
                    ps.DrugName,
                    ps.MethodOfAdmin,
                    ps.Dosage,
                    mr.UnitsPerDay AS Qty,     -- ใช้ UnitsPerDay แทน Qty
                    ps.CostPerUnit,
                    CAST(mr.UnitsPerDay * ps.CostPerUnit AS DECIMAL(18,2)) AS LineTotal
                FROM MedRecord mr
                JOIN PharmaSupply ps ON ps.DrugID = mr.DrugID
                WHERE mr.PatientID = @PatientID
                  AND (@UseDate = 0 OR (mr.StartDate >= @FromDate AND mr.StartDate < DATEADD(DAY,1,@ToDate)))
                ORDER BY mr.StartDate, ps.DrugName;", conn)

                cmd.Parameters.Add("@PatientID", SqlDbType.Int).Value = _patientID
                cmd.Parameters.Add("@UseDate", SqlDbType.Int).Value = useDate
                cmd.Parameters.Add("@FromDate", SqlDbType.Date).Value = fromDate
                cmd.Parameters.Add("@ToDate", SqlDbType.Date).Value = toDate

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        dgvLines.DataSource = dt

        ' คำนวณยอดรวม + ภาษีมูลค่าเพิ่ม (ตัวอย่าง 7%)
        Dim subtotal As Decimal = 0D
        For Each r As DataRow In dt.Rows
            If Not IsDBNull(r("LineTotal")) Then
                subtotal += CDec(r("LineTotal"))
            End If
        Next

        Dim vatRate As Decimal = 0.07D  ' ปรับได้ตามต้องการ
        Dim vat As Decimal = Math.Round(subtotal * vatRate, 2, MidpointRounding.AwayFromZero)
        Dim total As Decimal = subtotal + vat

        lblSubtotal.Text = subtotal.ToString("N2")
        lblVat.Text = vat.ToString("N2")
        lblTotal.Text = total.ToString("N2")

        If dt.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบรายการยาในช่วงที่ระบุ", "ข้อมูลว่าง", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


End Class
