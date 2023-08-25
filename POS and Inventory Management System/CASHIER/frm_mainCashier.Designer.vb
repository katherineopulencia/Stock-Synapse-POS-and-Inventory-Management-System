<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainCashier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.btp_billdate = New System.Windows.Forms.DateTimePicker()
        Me.txt_searchProduct_barcode = New System.Windows.Forms.TextBox()
        Me.txt_billno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_changePass = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_setDiscount = New System.Windows.Forms.Button()
        Me.btn_report = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_subtotalPrice = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_payMode = New System.Windows.Forms.ComboBox()
        Me.txt_AmountReceived = New System.Windows.Forms.TextBox()
        Me.lbl_Change = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.lbl_TotalTax = New System.Windows.Forms.Label()
        Me.lbl_totalPrice = New System.Windows.Forms.Label()
        Me.lbl_NoOfItems = New System.Windows.Forms.Label()
        Me.btn_Pay = New System.Windows.Forms.Button()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_OverAllGrandTotal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1231, 77)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(480, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "SYNAPSE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(455, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 45)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STOCK"
        '
        'lbl_time
        '
        Me.lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_time.Font = New System.Drawing.Font("Segoe UI Semibold", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_time.Location = New System.Drawing.Point(1012, 9)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(216, 57)
        Me.lbl_time.TabIndex = 35
        Me.lbl_time.Text = "0.00"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_date)
        Me.Panel2.Controls.Add(Me.btp_billdate)
        Me.Panel2.Controls.Add(Me.txt_searchProduct_barcode)
        Me.Panel2.Controls.Add(Me.txt_billno)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1231, 76)
        Me.Panel2.TabIndex = 1
        '
        'lbl_date
        '
        Me.lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_date.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_date.Location = New System.Drawing.Point(1075, 12)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(144, 42)
        Me.lbl_date.TabIndex = 36
        Me.lbl_date.Text = "0.00"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btp_billdate
        '
        Me.btp_billdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.btp_billdate.Location = New System.Drawing.Point(582, 12)
        Me.btp_billdate.Name = "btp_billdate"
        Me.btp_billdate.Size = New System.Drawing.Size(141, 25)
        Me.btp_billdate.TabIndex = 14
        '
        'txt_searchProduct_barcode
        '
        Me.txt_searchProduct_barcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_searchProduct_barcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_searchProduct_barcode.ForeColor = System.Drawing.Color.Black
        Me.txt_searchProduct_barcode.Location = New System.Drawing.Point(97, 45)
        Me.txt_searchProduct_barcode.Name = "txt_searchProduct_barcode"
        Me.txt_searchProduct_barcode.Size = New System.Drawing.Size(625, 25)
        Me.txt_searchProduct_barcode.TabIndex = 13
        '
        'txt_billno
        '
        Me.txt_billno.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_billno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_billno.Location = New System.Drawing.Point(97, 12)
        Me.txt_billno.Name = "txt_billno"
        Me.txt_billno.Size = New System.Drawing.Size(360, 25)
        Me.txt_billno.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 34)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Product " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/ Barcode:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Bill No :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Bill Date :"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_changePass, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_remove, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_setDiscount, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_report, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 666)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1231, 58)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(1053, 3)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(175, 52)
        Me.btn_logout.TabIndex = 21
        Me.btn_logout.Text = "LOGOUT"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_changePass
        '
        Me.btn_changePass.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_changePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changePass.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_changePass.FlatAppearance.BorderSize = 0
        Me.btn_changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changePass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_changePass.ForeColor = System.Drawing.Color.White
        Me.btn_changePass.Location = New System.Drawing.Point(878, 3)
        Me.btn_changePass.Name = "btn_changePass"
        Me.btn_changePass.Size = New System.Drawing.Size(169, 52)
        Me.btn_changePass.TabIndex = 20
        Me.btn_changePass.Text = "CHANGE PASSWORD"
        Me.btn_changePass.UseVisualStyleBackColor = False
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_remove.FlatAppearance.BorderSize = 0
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(703, 3)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(169, 52)
        Me.btn_remove.TabIndex = 19
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(178, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(169, 52)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(3, 3)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(169, 52)
        Me.btn_new.TabIndex = 15
        Me.btn_new.Text = "NEW "
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_setDiscount
        '
        Me.btn_setDiscount.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_setDiscount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_setDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_setDiscount.FlatAppearance.BorderSize = 0
        Me.btn_setDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setDiscount.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_setDiscount.ForeColor = System.Drawing.Color.White
        Me.btn_setDiscount.Location = New System.Drawing.Point(353, 3)
        Me.btn_setDiscount.Name = "btn_setDiscount"
        Me.btn_setDiscount.Size = New System.Drawing.Size(169, 52)
        Me.btn_setDiscount.TabIndex = 17
        Me.btn_setDiscount.Text = "SET DISCOUNT "
        Me.btn_setDiscount.UseVisualStyleBackColor = False
        '
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_report.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_report.ForeColor = System.Drawing.Color.White
        Me.btn_report.Location = New System.Drawing.Point(528, 3)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Size = New System.Drawing.Size(169, 52)
        Me.btn_report.TabIndex = 18
        Me.btn_report.Text = "REPORT"
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.lbl_subtotalPrice)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cbo_payMode)
        Me.Panel3.Controls.Add(Me.txt_AmountReceived)
        Me.Panel3.Controls.Add(Me.lbl_Change)
        Me.Panel3.Controls.Add(Me.lbl_GrandTotal)
        Me.Panel3.Controls.Add(Me.lbl_discount)
        Me.Panel3.Controls.Add(Me.lbl_TotalTax)
        Me.Panel3.Controls.Add(Me.lbl_totalPrice)
        Me.Panel3.Controls.Add(Me.lbl_NoOfItems)
        Me.Panel3.Controls.Add(Me.btn_Pay)
        Me.Panel3.Controls.Add(Me.txt_discount)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lbl_OverAllGrandTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(918, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(313, 513)
        Me.Panel3.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(68, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 59)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "₱"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_subtotalPrice
        '
        Me.lbl_subtotalPrice.BackColor = System.Drawing.Color.White
        Me.lbl_subtotalPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_subtotalPrice.ForeColor = System.Drawing.Color.Black
        Me.lbl_subtotalPrice.Location = New System.Drawing.Point(223, 139)
        Me.lbl_subtotalPrice.Name = "lbl_subtotalPrice"
        Me.lbl_subtotalPrice.Size = New System.Drawing.Size(78, 33)
        Me.lbl_subtotalPrice.TabIndex = 33
        Me.lbl_subtotalPrice.Text = "0.00"
        Me.lbl_subtotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Sub Total"
        '
        'cbo_payMode
        '
        Me.cbo_payMode.FormattingEnabled = True
        Me.cbo_payMode.Items.AddRange(New Object() {"CASH", "GCASH"})
        Me.cbo_payMode.Location = New System.Drawing.Point(140, 344)
        Me.cbo_payMode.Name = "cbo_payMode"
        Me.cbo_payMode.Size = New System.Drawing.Size(146, 25)
        Me.cbo_payMode.TabIndex = 31
        '
        'txt_AmountReceived
        '
        Me.txt_AmountReceived.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_AmountReceived.Location = New System.Drawing.Point(140, 384)
        Me.txt_AmountReceived.Name = "txt_AmountReceived"
        Me.txt_AmountReceived.Size = New System.Drawing.Size(146, 25)
        Me.txt_AmountReceived.TabIndex = 30
        '
        'lbl_Change
        '
        Me.lbl_Change.BackColor = System.Drawing.Color.White
        Me.lbl_Change.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Change.ForeColor = System.Drawing.Color.Black
        Me.lbl_Change.Location = New System.Drawing.Point(223, 415)
        Me.lbl_Change.Name = "lbl_Change"
        Me.lbl_Change.Size = New System.Drawing.Size(78, 33)
        Me.lbl_Change.TabIndex = 29
        Me.lbl_Change.Text = "0.00"
        Me.lbl_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.BackColor = System.Drawing.Color.White
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(223, 290)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(78, 33)
        Me.lbl_GrandTotal.TabIndex = 28
        Me.lbl_GrandTotal.Text = "0.00"
        Me.lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_discount
        '
        Me.lbl_discount.BackColor = System.Drawing.Color.White
        Me.lbl_discount.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_discount.ForeColor = System.Drawing.Color.Black
        Me.lbl_discount.Location = New System.Drawing.Point(223, 249)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(78, 33)
        Me.lbl_discount.TabIndex = 27
        Me.lbl_discount.Text = "0.00"
        Me.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_TotalTax
        '
        Me.lbl_TotalTax.BackColor = System.Drawing.Color.White
        Me.lbl_TotalTax.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_TotalTax.ForeColor = System.Drawing.Color.Black
        Me.lbl_TotalTax.Location = New System.Drawing.Point(223, 179)
        Me.lbl_TotalTax.Name = "lbl_TotalTax"
        Me.lbl_TotalTax.Size = New System.Drawing.Size(78, 33)
        Me.lbl_TotalTax.TabIndex = 26
        Me.lbl_TotalTax.Text = "0.00"
        Me.lbl_TotalTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_totalPrice
        '
        Me.lbl_totalPrice.BackColor = System.Drawing.Color.White
        Me.lbl_totalPrice.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_totalPrice.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalPrice.Location = New System.Drawing.Point(223, 214)
        Me.lbl_totalPrice.Name = "lbl_totalPrice"
        Me.lbl_totalPrice.Size = New System.Drawing.Size(78, 33)
        Me.lbl_totalPrice.TabIndex = 25
        Me.lbl_totalPrice.Text = "0.00"
        Me.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_NoOfItems
        '
        Me.lbl_NoOfItems.BackColor = System.Drawing.Color.White
        Me.lbl_NoOfItems.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_NoOfItems.ForeColor = System.Drawing.Color.Black
        Me.lbl_NoOfItems.Location = New System.Drawing.Point(223, 101)
        Me.lbl_NoOfItems.Name = "lbl_NoOfItems"
        Me.lbl_NoOfItems.Size = New System.Drawing.Size(78, 33)
        Me.lbl_NoOfItems.TabIndex = 24
        Me.lbl_NoOfItems.Text = "0.00"
        Me.lbl_NoOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Pay
        '
        Me.btn_Pay.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_Pay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Pay.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_Pay.FlatAppearance.BorderSize = 0
        Me.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Pay.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_Pay.ForeColor = System.Drawing.Color.White
        Me.btn_Pay.Location = New System.Drawing.Point(0, 461)
        Me.btn_Pay.Name = "btn_Pay"
        Me.btn_Pay.Size = New System.Drawing.Size(313, 52)
        Me.btn_Pay.TabIndex = 23
        Me.btn_Pay.Text = "PAY "
        Me.btn_Pay.UseVisualStyleBackColor = False
        '
        'txt_discount
        '
        Me.txt_discount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_discount.Location = New System.Drawing.Point(104, 256)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(41, 25)
        Me.txt_discount.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 425)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 17)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Change"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 384)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Amount Received"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(25, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 17)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Payment Mode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Grand Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Discount %"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 189)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Total Tax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Total Price "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "No of Items"
        '
        'lbl_OverAllGrandTotal
        '
        Me.lbl_OverAllGrandTotal.BackColor = System.Drawing.Color.White
        Me.lbl_OverAllGrandTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_OverAllGrandTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_OverAllGrandTotal.Location = New System.Drawing.Point(140, 27)
        Me.lbl_OverAllGrandTotal.Name = "lbl_OverAllGrandTotal"
        Me.lbl_OverAllGrandTotal.Size = New System.Drawing.Size(161, 59)
        Me.lbl_OverAllGrandTotal.TabIndex = 0
        Me.lbl_OverAllGrandTotal.Text = "0.00"
        Me.lbl_OverAllGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 153)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(918, 513)
        Me.DataGridView1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 41
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 113
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Product Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Product Group"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 119
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 61
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Tax %"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 67
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Sub Total"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 87
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "Qty"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 53
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "Total"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 61
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frm_mainCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1231, 724)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_mainCashier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Synapse: POS and Inventory Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btp_billdate As DateTimePicker
    Friend WithEvents txt_searchProduct_barcode As TextBox
    Friend WithEvents txt_billno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_changePass As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents btn_report As Button
    Friend WithEvents btn_setDiscount As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents cbo_payMode As ComboBox
    Friend WithEvents txt_AmountReceived As TextBox
    Friend WithEvents lbl_Change As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents lbl_TotalTax As Label
    Friend WithEvents lbl_totalPrice As Label
    Friend WithEvents lbl_NoOfItems As Label
    Friend WithEvents btn_Pay As Button
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_OverAllGrandTotal As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_subtotalPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
