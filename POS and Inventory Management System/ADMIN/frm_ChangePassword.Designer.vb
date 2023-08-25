<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ChangePassword
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
        Me.txt_oldpassword = New System.Windows.Forms.TextBox()
        Me.txt_newpassword = New System.Windows.Forms.TextBox()
        Me.txt_reenterPassword = New System.Windows.Forms.TextBox()
        Me.btn_changePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_oldpassword
        '
        Me.txt_oldpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_oldpassword.Location = New System.Drawing.Point(53, 80)
        Me.txt_oldpassword.Name = "txt_oldpassword"
        Me.txt_oldpassword.Size = New System.Drawing.Size(278, 25)
        Me.txt_oldpassword.TabIndex = 0
        Me.txt_oldpassword.UseSystemPasswordChar = True
        '
        'txt_newpassword
        '
        Me.txt_newpassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_newpassword.Location = New System.Drawing.Point(53, 136)
        Me.txt_newpassword.Name = "txt_newpassword"
        Me.txt_newpassword.Size = New System.Drawing.Size(278, 25)
        Me.txt_newpassword.TabIndex = 1
        '
        'txt_reenterPassword
        '
        Me.txt_reenterPassword.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_reenterPassword.Location = New System.Drawing.Point(53, 202)
        Me.txt_reenterPassword.Name = "txt_reenterPassword"
        Me.txt_reenterPassword.Size = New System.Drawing.Size(278, 25)
        Me.txt_reenterPassword.TabIndex = 2
        Me.txt_reenterPassword.UseSystemPasswordChar = True
        '
        'btn_changePassword
        '
        Me.btn_changePassword.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_changePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_changePassword.FlatAppearance.BorderSize = 0
        Me.btn_changePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_changePassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_changePassword.ForeColor = System.Drawing.Color.White
        Me.btn_changePassword.Location = New System.Drawing.Point(53, 247)
        Me.btn_changePassword.Name = "btn_changePassword"
        Me.btn_changePassword.Size = New System.Drawing.Size(278, 31)
        Me.btn_changePassword.TabIndex = 3
        Me.btn_changePassword.Text = "CHANGE PASSWORD"
        Me.btn_changePassword.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter your OLD Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter your NEW Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Re-enter your NEW Password"
        '
        'frm_ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_changePassword)
        Me.Controls.Add(Me.txt_reenterPassword)
        Me.Controls.Add(Me.txt_newpassword)
        Me.Controls.Add(Me.txt_oldpassword)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_oldpassword As TextBox
    Friend WithEvents txt_newpassword As TextBox
    Friend WithEvents txt_reenterPassword As TextBox
    Friend WithEvents btn_changePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
