Imports MySql.Data.MySqlClient

Public Class frm_ManageStock
    Dim j As Integer
    Private Sub frm_ManageStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Load_stock()
    End Sub


    Sub Load_stock()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock` FROM `tblproduct`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `procode`, `proname`, `progroup`, `uom`, `location`, `price`, `tax`, `totalprice`, `stock` FROM `tblproduct` WHERE procode LIKE '%" & txt_Search.Text & "%' OR proname LIKE '%" & txt_Search.Text & "%' OR progroup LIKE '%" & txt_Search.Text & "%'", conn)
            dr = cmd.ExecuteReader

            ' Clear existing rows before populating the DataGridView
            DataGridView1.Rows.Clear()

            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("procode"), dr.Item("proname"), dr.Item("progroup"), dr.Item("uom"), dr.Item("location"), dr.Item("price"), dr.Item("tax"), dr.Item("totalprice"), dr.Item("stock"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_UpdateStock_Click(sender As Object, e As EventArgs) Handles btn_UpdateStock.Click
        Try
            conn.Open()



            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New MySqlCommand("UPDATE `tblproduct` SET `stock`=@stock WHERE `procode`=@procode", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@stock", DataGridView1.Rows(j).Cells(9).Value.ToString)
                cmd.Parameters.AddWithValue("@procode", DataGridView1.Rows(j).Cells(1).Value.ToString)
                i = cmd.ExecuteNonQuery
            Next
            If i > 0 Then
                MsgBox("Stock Update Succesfully! ", vbInformation)
            Else
                MsgBox("Stock Update Failed ! ", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        Load_stock()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class