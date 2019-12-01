Public Class GestorProdutos
    Dim db As New MyDatabase
    Private Sub GestorProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitComboBox()
        AtualizaGrid(-1)
    End Sub


    Private Sub AtualizaGrid(id_categoria As Integer)
        If id_categoria < 0 Then
            grid1.DataSource = db.ObterTodosProdutos()
        Else
            grid1.DataSource = db.ObterProdutosDeCategoria(id_categoria)
        End If
        grid1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        grid1.AllowUserToAddRows = False
        grid1.RowHeadersVisible = False
        grid1.ReadOnly = True
        grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub InitComboBox()
        Dim dt As DataTable = db.ObterTodasCategorias()
        Dim linha As DataRow = dt.NewRow()
        linha(0) = -1
        linha(1) = "-- Selecionar categoria --"
        dt.Rows.InsertAt(linha, 0)
        cmb_categorias.DataSource = dt
        cmb_categorias.DisplayMember = "nome"
        cmb_categorias.ValueMember = "id"
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub cmb_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_categorias.SelectedIndexChanged
        Dim cat As Integer
        If Integer.TryParse(cmb_categorias.SelectedValue.ToString(), cat) Then
            AtualizaGrid(cat)
        End If
    End Sub
End Class
