Imports MySql.Data.MySqlClient
Public Class Form1

    Dim username As String
    Dim password As String
    Dim role As String

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New MySqlCommand("SELECT * FROM `tbluser` WHERE `username`='" & txt_username.Text & "' AND `password`='" & txt_password.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True

                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                role = dr.Item("role").ToString
            Else
                found = False

                username = ""
                password = ""
                role = ""

            End If
            If found = True Then
                If Not (StrComp(txt_username.Text, username, CompareMethod.Binary) = 0 And StrComp(txt_password.Text, password, CompareMethod.Binary) = 0) Then
                    MsgBox("Warning: Wrong username and password", vbExclamation)
                Else
                    If UCase(role) = "ADMIN" Then
                        Me.Hide()
                        frm_mainAdmin.Show()
                    ElseIf UCase(role) = "CASHIER" Then
                        Me.Hide()
                        frm_mainCashier.Show()
                    End If
                    MsgBox("Welcome", vbInformation)
                    txt_password.Clear()
                    txt_username.Clear()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        If MsgBox("Are you sure you want to exit?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
End Class
