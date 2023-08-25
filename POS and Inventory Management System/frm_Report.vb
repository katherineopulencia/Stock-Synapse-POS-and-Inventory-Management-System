Imports System.IO
Imports MySql.Data.MySqlClient
Public Class frm_Report
    Private Sub frm_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_Report()
        Total()
    End Sub

    Sub Load_Report()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `grandtotal` FROM `tbl_pos` Group by billno", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `grandtotal` FROM `tbl_pos` WHERE billno like '%" & txt_search.Text & "%' Group by billno ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_Today_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_Today.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `grandtotal` FROM `tbl_pos` WHERE billdate like '%" & Date.Now.ToString("yyyy-MM-dd") & "%' Group by billno ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub rbtn_currentMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_currentMonth.CheckedChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `grandtotal` FROM `tbl_pos` WHERE billdate like '%" & Date.Now.ToString("MM") & "%' Group by billno ", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btn_Filter_Click(sender As Object, e As EventArgs) Handles btn_Filter.Click
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `billno`, `billdate`, `bmonth`, `bmonthyear`, `grandtotal` FROM `tbl_pos` WHERE billdate BETWEEN '" & date1 & "' AND '" & date2 & "' GROUP BY billno", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("billno"), dr.Item("billdate"), dr.Item("bmonth"), dr.Item("bmonthyear"), dr.Item("grandtotal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Total()
        Try
            Dim sum As Double = 0
            For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(5).Value
            Next
            lbl_totalDisplay.Text = Format(CDec(sum), "#,##0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub
End Class