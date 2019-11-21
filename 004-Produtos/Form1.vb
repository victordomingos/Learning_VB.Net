Public Class GestorProdutos
    Dim db As New MyDatabase
    Private Sub GestorProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
    End Sub


    Private Sub AtualizaGrid()
        grid1.DataSource = db.ObterTodosProdutos()
        grid1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

    End Sub
End Class
