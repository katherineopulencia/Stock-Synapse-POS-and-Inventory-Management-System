﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_discount
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
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.btn_updatediscount = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(31, 49)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(331, 25)
        Me.txt_discount.TabIndex = 0
        '
        'btn_updatediscount
        '
        Me.btn_updatediscount.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_updatediscount.FlatAppearance.BorderSize = 0
        Me.btn_updatediscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updatediscount.Location = New System.Drawing.Point(31, 90)
        Me.btn_updatediscount.Name = "btn_updatediscount"
        Me.btn_updatediscount.Size = New System.Drawing.Size(331, 31)
        Me.btn_updatediscount.TabIndex = 1
        Me.btn_updatediscount.Text = "UPDATE DISCOUNT"
        Me.btn_updatediscount.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Discount %"
        '
        'frm_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 153)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_updatediscount)
        Me.Controls.Add(Me.txt_discount)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_discount As TextBox
    Friend WithEvents btn_updatediscount As Button
    Friend WithEvents Label1 As Label
End Class
