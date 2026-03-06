<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Requisition_Add
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.numQty = New System.Windows.Forms.NumericUpDown()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtDosage = New System.Windows.Forms.TextBox()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.dtpRequest = New System.Windows.Forms.DateTimePicker()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.cboWard = New System.Windows.Forms.ComboBox()
        Me.cboRequestedBy = New System.Windows.Forms.ComboBox()
        Me.cboReceivedBy = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvReq = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RequisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(189, 311)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(238, 24)
        Me.cboType.TabIndex = 0
        '
        'cboItem
        '
        Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Location = New System.Drawing.Point(189, 338)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(238, 24)
        Me.cboItem.TabIndex = 1
        '
        'numQty
        '
        Me.numQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.numQty.Location = New System.Drawing.Point(188, 365)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(239, 23)
        Me.numQty.TabIndex = 2
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDesc.Location = New System.Drawing.Point(188, 435)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(239, 23)
        Me.txtDesc.TabIndex = 3
        '
        'txtDosage
        '
        Me.txtDosage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtDosage.Location = New System.Drawing.Point(188, 462)
        Me.txtDosage.Name = "txtDosage"
        Me.txtDosage.Size = New System.Drawing.Size(239, 23)
        Me.txtDosage.TabIndex = 4
        '
        'txtMethod
        '
        Me.txtMethod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtMethod.Location = New System.Drawing.Point(188, 489)
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.Size = New System.Drawing.Size(239, 23)
        Me.txtMethod.TabIndex = 5
        '
        'dtpRequest
        '
        Me.dtpRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpRequest.Location = New System.Drawing.Point(188, 231)
        Me.dtpRequest.Name = "dtpRequest"
        Me.dtpRequest.Size = New System.Drawing.Size(239, 23)
        Me.dtpRequest.TabIndex = 6
        '
        'dtpDelivery
        '
        Me.dtpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.dtpDelivery.Location = New System.Drawing.Point(532, 296)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(239, 23)
        Me.dtpDelivery.TabIndex = 7
        '
        'cboWard
        '
        Me.cboWard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboWard.FormattingEnabled = True
        Me.cboWard.Location = New System.Drawing.Point(189, 257)
        Me.cboWard.Name = "cboWard"
        Me.cboWard.Size = New System.Drawing.Size(238, 24)
        Me.cboWard.TabIndex = 8
        '
        'cboRequestedBy
        '
        Me.cboRequestedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboRequestedBy.FormattingEnabled = True
        Me.cboRequestedBy.Location = New System.Drawing.Point(189, 284)
        Me.cboRequestedBy.Name = "cboRequestedBy"
        Me.cboRequestedBy.Size = New System.Drawing.Size(238, 24)
        Me.cboRequestedBy.TabIndex = 9
        '
        'cboReceivedBy
        '
        Me.cboReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cboReceivedBy.FormattingEnabled = True
        Me.cboReceivedBy.Location = New System.Drawing.Point(532, 263)
        Me.cboReceivedBy.Name = "cboReceivedBy"
        Me.cboReceivedBy.Size = New System.Drawing.Size(239, 24)
        Me.cboReceivedBy.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(556, 440)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 36)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvReq
        '
        Me.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReq.Location = New System.Drawing.Point(59, 50)
        Me.dgvReq.Name = "dgvReq"
        Me.dgvReq.RowHeadersWidth = 51
        Me.dgvReq.Size = New System.Drawing.Size(767, 153)
        Me.dgvReq.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(56, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ward Requisition Form"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(652, 440)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 36)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(78, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "*Request Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(129, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "*Ward:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(77, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "*Charge Nurse:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(87, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "*Supply Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(94, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*Item Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(109, 366)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "*Quantity:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(95, 435)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Description:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(116, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Dosage:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(118, 492)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Method:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(82, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(356, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "------------------------- If it has details -------------------------"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(529, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(245, 17)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "--------------- Received By ---------------"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEdit.Location = New System.Drawing.Point(556, 341)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(184, 42)
        Me.btnEdit.TabIndex = 26
        Me.btnEdit.Text = "Add Recipient"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Requisition_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvReq)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboReceivedBy)
        Me.Controls.Add(Me.cboRequestedBy)
        Me.Controls.Add(Me.cboWard)
        Me.Controls.Add(Me.dtpDelivery)
        Me.Controls.Add(Me.dtpRequest)
        Me.Controls.Add(Me.txtMethod)
        Me.Controls.Add(Me.txtDosage)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.cboType)
        Me.Name = "Requisition_Add"
        Me.Text = "Requisition_Add"
        CType(Me.numQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents numQty As NumericUpDown
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtDosage As TextBox
    Friend WithEvents txtMethod As TextBox
    Friend WithEvents dtpRequest As DateTimePicker
    Friend WithEvents dtpDelivery As DateTimePicker
    Friend WithEvents cboWard As ComboBox
    Friend WithEvents cboRequestedBy As ComboBox
    Friend WithEvents cboReceivedBy As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvReq As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents RequisitionBindingSource As BindingSource
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnEdit As Button
End Class
