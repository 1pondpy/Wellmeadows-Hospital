Imports System.Data.SqlClient
Imports System.Configuration

Public Class Dashboard_InpatientReport
    Private ReadOnly connectionString As String =
        ConfigurationManager.ConnectionStrings("WellmeadowsDB").ConnectionString
    Private Sub Dashboard_InpatientReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWardCombo()
        LoadPlacedDateCombo()
    End Sub

    ' โหลดรายชื่อ Ward ใส่ ComboBox
    Private Sub LoadWardCombo()
        Dim sql As String =
            "SELECT WardID, WardName
             FROM Ward
             ORDER BY WardName;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' แทรกรายการ "All"
                Dim r = dt.NewRow()
                r("WardID") = DBNull.Value
                r("WardName") = "-- All Wards --"
                dt.Rows.InsertAt(r, 0)

                cboWard.DataSource = dt
                cboWard.DisplayMember = "WardName"
                cboWard.ValueMember = "WardID"
            End Using
        End Using
    End Sub

    ' โหลด DISTINCT วันที่รับไว้ (DatePlaced) จาก Inpatient
    Private Sub LoadPlacedDateCombo()
        Dim sql As String =
            "SELECT DISTINCT I.DatePlaced AS PlacedDate
             FROM Inpatient I
             WHERE I.DatePlaced IS NOT NULL
             ORDER BY PlacedDate DESC;"

        Using conn As New SqlConnection(connectionString)
            Using da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ' สร้างคอลัมน์สำหรับแสดงผลเป็นตัวหนังสือ
                If Not dt.Columns.Contains("DisplayText") Then
                    dt.Columns.Add("DisplayText", GetType(String))
                End If

                For Each row As DataRow In dt.Rows
                    row("DisplayText") = CDate(row("PlacedDate")).ToString("yyyy-MM-dd")
                Next

                ' แทรก "All"
                Dim r = dt.NewRow()
                r("PlacedDate") = DBNull.Value
                r("DisplayText") = "-- All Dates --"
                dt.Rows.InsertAt(r, 0)

                cboPlacedDate.DataSource = dt
                cboPlacedDate.DisplayMember = "DisplayText"
                cboPlacedDate.ValueMember = "PlacedDate"
            End Using
        End Using
    End Sub

    ' ปุ่มดูรายงาน
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim wardIdObj As Object = cboWard.SelectedValue
        Dim placedDateObj As Object = cboPlacedDate.SelectedValue

        Dim sql As String =
            "SELECT
                InpatientID,
                PatientID,
                PatientName,
                DatePlaced,       
                ExpectedDayStay,   
                DateLeave,         
                DateActualLeave,  
                DateWaitingList, 
                WardID,
                WardName,
                BedID,
                BedNo        
            FROM dbo.InpatientView
            WHERE (@WardID IS NULL OR WardID = @WardID)
              AND (@PlacedDate IS NULL OR CONVERT(date, DatePlaced) = @PlacedDate)
            ORDER BY InpatientID ASC;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, conn)
                ' @WardID
                Dim pWard = cmd.Parameters.Add("@WardID", SqlDbType.Int)
                If wardIdObj Is Nothing OrElse wardIdObj Is DBNull.Value Then
                    pWard.Value = DBNull.Value
                Else
                    pWard.Value = CInt(wardIdObj)
                End If

                ' @PlacedDate (DATE)
                Dim pDate = cmd.Parameters.Add("@PlacedDate", SqlDbType.Date)
                If placedDateObj Is Nothing OrElse placedDateObj Is DBNull.Value Then
                    pDate.Value = DBNull.Value
                Else
                    pDate.Value = CDate(placedDateObj).Date
                End If

                Using da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvReport.DataSource = dt
                    dgvReport.ReadOnly = True
                    dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    dgvReport.MultiSelect = False
                    dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("ไม่พบข้อมูลตามเงื่อนไขที่เลือก")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
