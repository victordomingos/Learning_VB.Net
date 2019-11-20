Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_1.TextChanged
        Sum_items()
    End Sub


    Private Sub txt_2_TextChanged(sender As Object, e As EventArgs) Handles txt_2.TextChanged
        Sum_items()
    End Sub


    Private Sub Sum_items()
        Dim x As Double

        Try
            x = Convert.ToDouble(txt_1.Text) + Convert.ToDouble(txt_2.Text)
        Catch ex As Exception
            x = 0
        End Try

        lbl_sum.Text = "Sum: " + CStr(x)
    End Sub

End Class
