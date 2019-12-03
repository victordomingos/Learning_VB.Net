Public Class GestorProdutos
    Dim db As New MyDatabase
    Dim UnsavedChanges = False
    Private Sub GestorProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitComboBox(cmb_categorias, True)
        SetUnsavedChanges(False)
        AtualizaGrid(-1)
    End Sub

    ''' <summary>
    ''' Preenche a grid com produtos de uma certa categoria a partir da base dados.
    ''' Caso a categoria seja -1, mostra produtos todas as categorias.
    ''' </summary>
    ''' <param name="id_categoria"></param>
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

    ''' <summary>
    ''' Preenche a combobox com a lista de categorias
    ''' </summary>
    Private Sub InitComboBox(cmbox As ComboBox, apenasComStock As Boolean)
        Dim dt As DataTable
        If apenasComStock Then
            dt = db.ObterCategoriasComProdutosEmStock()
        Else
            dt = db.ObterTodasCategorias()
        End If

        Dim linha = dt.NewRow()
        linha(0) = -1
        linha(1) = "-- Selecionar categoria --"
        dt.Rows.InsertAt(linha, 0)
        cmbox.DataSource = dt
        cmbox.DisplayMember = "nome"
        cmbox.ValueMember = "id"
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub cmb_categorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_categorias.SelectedIndexChanged
        Dim cat As Integer
        If Integer.TryParse(cmb_categorias.SelectedValue.ToString(), cat) Then
            AtualizaGrid(cat)
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub grid1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub grid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        Dim id As Integer
        id = grid1.Rows(e.RowIndex).Cells(0).Value

        If id >= 0 Then
            Dim produto = db.ObterProduto(id)
            txt_cod_produto.Enabled = True
            txt_cod_produto.Text = id
            InitComboBox(cmb_detalhes_categoria, False)
            cmb_detalhes_categoria.SelectedValue = produto.Rows(0)(2)
            txt_designacao.Text = produto.Rows(0)(1)
            txt_qtd.Text = produto.Rows(0)(3)
            txt_cod_produto.Enabled = False
        End If

        SetUnsavedChanges(False)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        LimparForm()
    End Sub

    Private Sub LimparForm()
        Dim limparMesmo = True
        If UnsavedChanges Then
            Dim r = MessageBox.Show("Tem alterações por guardar. Tem a certeza de que pretende descartar essas alterações?",
                                     "Atenção",
                                     MessageBoxButtons.YesNo)

            If r = DialogResult.No Then
                limparMesmo = False
            End If
        End If

        If limparMesmo Then
            txt_cod_produto.Enabled = True
            txt_cod_produto.Text = ""
            InitComboBox(cmb_detalhes_categoria, False)
            cmb_detalhes_categoria.SelectedIndex = 0
            txt_designacao.Text = ""
            txt_qtd.Text = ""
            txt_cod_produto.Enabled = False
            SetUnsavedChanges(False)
        End If


    End Sub

    Private Sub txt_designacao_TextChanged(sender As Object, e As EventArgs) Handles txt_designacao.TextChanged
        SetUnsavedChanges(True)
    End Sub

    Private Sub cmb_detalhes_categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_detalhes_categoria.SelectedIndexChanged
        SetUnsavedChanges(True)
    End Sub

    Private Sub txt_qtd_TextChanged(sender As Object, e As EventArgs) Handles txt_qtd.TextChanged
        SetUnsavedChanges(True)
    End Sub

    Private Sub grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellContentClick

    End Sub

    Private Sub lbl_unsaved_Changes_Click(sender As Object, e As EventArgs) Handles lbl_unsaved_Changes.Click

    End Sub

    Private Sub SetUnsavedChanges(has_unsaved_changes As Boolean)
        Me.UnsavedChanges = has_unsaved_changes
        btn_cancelar.Visible = has_unsaved_changes
        btn_guardar.Visible = has_unsaved_changes
        lbl_unsaved_Changes.Visible = has_unsaved_changes
    End Sub

End Class
