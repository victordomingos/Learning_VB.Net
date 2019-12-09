Public Class FormRegistoViagens
    Dim db As New MyDatabase
    Dim UnsavedChangesList As New HashSet(Of Integer)

    Private Sub FormRegistoViagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_filtro.SelectedIndex = 0
    End Sub


    ''' <summary>
    ''' Preenche a grid com as viagens a partir da base dados.
    ''' </summary>
    Private Sub AtualizaGrid()
        Dim filtro As String
        Try
            filtro = cmb_filtro.SelectedItem.ToString()

            If filtro = "Apenas viagens de 2 ou mais dias" Then
                grid1.DataSource = db.ObterTodasViagens(2, True)
            ElseIf filtro = "Apenas viagens de 1 dia" Then
                grid1.DataSource = db.ObterTodasViagens(1, False)
            ElseIf filtro = "Mostrar todas as viagens" Then
                grid1.DataSource = db.ObterTodasViagens(0, True)
            End If
        Catch
            grid1.DataSource = db.ObterTodasViagens(0, True)
        End Try

        grid1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        grid1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        grid1.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        grid1.AllowUserToAddRows = False
        grid1.RowHeadersVisible = False
        grid1.ReadOnly = False
        grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Private Sub btn_limpar_bd_Click(sender As Object, e As EventArgs) Handles btn_limpar_bd.Click
        db.ApagarViagensEVeiculos()
        AtualizaGrid()
    End Sub

    Private Sub btn_lancar_registos_Click(sender As Object, e As EventArgs) Handles btn_lancar_registos.Click
        Dim id_fiat = db.InserirVeiculo("Fiat")
        Dim id_ford = db.InserirVeiculo("Ford")
        Dim id_opel = db.InserirVeiculo("Opel")
        db.InserirViagem(id_fiat, 2, 800)
        db.InserirViagem(id_ford, 1, 300)
        db.InserirViagem(id_opel, 2, 600)
        db.InserirViagem(id_fiat, 1, 400)
        db.InserirViagem(id_fiat, 1, 200)
        AtualizaGrid()
    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        AtualizaGrid()
    End Sub

    Private Sub btn_limpar_grid_Click(sender As Object, e As EventArgs) Handles btn_limpar_grid.Click
        grid1.DataSource = Nothing
        grid1.Refresh()
    End Sub

    Private Sub btn_viagens2dias_Click(sender As Object, e As EventArgs) Handles btn_viagens2dias.Click
        Dim veiculo As String
        Dim msg As String

        Try
            veiculo = grid1.SelectedRows(0).Cells(1).Value.ToString

            ''A partir da base de dados: ===============================
            'Dim veiculo_id = db.ObterPrimeiroVeiculoPorMarca(veiculo)
            'Dim viagens2dias = db.ContarViagensPorVeiculoEDuracao(veiculo_id, 2)


            'A partir da grid: =========================================
            Dim viagens2dias As Integer = 0
            For Each r In grid1.Rows
                If r.Cells(1).Value = veiculo And r.Cells(2).Value = 2 Then
                    viagens2dias += 1
                End If
            Next

            Dim viagens As String = If(viagens2dias = 1, "viagem", "viagens")

            If viagens2dias > 0 Then
                msg = $"O veiculo selecionado realizou {viagens2dias} {viagens} de 2 dias."
            Else
                msg = "O veiculo selecionado não realizou nenhuma viagem de 2 dias."
            End If
        Catch
            msg = "Por favor, selecione primeiro um veículo na lista de viagens."
        End Try

        MessageBox.Show(msg)
    End Sub

    Private Sub cmb_filtro_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmb_filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedIndexChanged
        AtualizaGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim veiculo_id = db.ObterPrimeiroVeiculoPorMarca(txt_marca.Text)
            Dim km = db.ObterDistanciaTotalPorVeiculo(veiculo_id)
            txt_km.Text = km.ToString
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Não foram encontrados registos correspondentes a esta pesquisa.")
        End Try

    End Sub

    Private Sub btn_viatura_mais_km_Click(sender As Object, e As EventArgs) Handles btn_viatura_mais_km.Click
        lbx_viatura_mais_km.Items.Clear()
        Dim marca = ""
        Dim km = 0
        For Each r In grid1.Rows
            If km < r.Cells(3).Value Then
                km = r.Cells(3).Value
                marca = r.Cells(1).Value
            End If
        Next
        lbx_viatura_mais_km.Items.Add(marca)
    End Sub

    Private Sub btn_atualizar_registos_Click(sender As Object, e As EventArgs) Handles btn_atualizar_registos.Click
        If UnsavedChangesList.Count = 0 Then
            MessageBox.Show("Não há quaisquer alterações pendentes.")
        Else
            Dim itemsToRemove As New HashSet(Of Integer)
            Try
                For Each i In UnsavedChangesList
                    Dim r = grid1.Rows(i)
                    Dim viagem_id = r.Cells(0).Value
                    Dim veiculo_id = db.ObterPrimeiroVeiculoPorMarca(r.Cells(1).Value)
                    Dim dias = Convert.ToInt32(r.Cells(2).Value)
                    Dim km = Convert.ToInt32(r.Cells(3).Value)
                    db.AtualizarViagem(viagem_id, veiculo_id, dias, km)
                    itemsToRemove.Add(i)
                Next

                For Each item In itemsToRemove
                    UnsavedChangesList.Remove(item)
                Next
            Catch ex As IndexOutOfRangeException
                MessageBox.Show("Não existe o veículo indicado. Por favor, verifique os dados introduzidos.")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                MessageBox.Show("Por favor, verifique os dados introduzidos.")
            End Try
        End If
    End Sub

    Private Sub grid1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellValueChanged
        If e.RowIndex > -1 Then
            UnsavedChangesList.Add(e.RowIndex)
        End If

    End Sub
End Class
