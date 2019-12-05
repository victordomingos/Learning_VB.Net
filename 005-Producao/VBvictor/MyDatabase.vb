Imports System.Data.SqlClient

Public Class MyDatabase
    Private Function ObterDados(ssql As String) As DataTable
        Using con As New SqlConnection(Config.SC)
            Dim command = con.CreateCommand()
            command.CommandText = ssql
            Dim da = New SqlDataAdapter(command)
            Dim dt = New DataTable()
            da.Fill(dt)
            con.Close()
            Return dt
        End Using
    End Function

    ''' <summary>
    ''' Obtem uma lista das viagens a partir da base de dados, a partir do nº de dias
    ''' 
    ''' </summary>
    ''' <param name="dias">Nº de dias que durou a viagem (usar 0 para incluir todas as viagens)</param>
    ''' <param name="incluirViagensComMaisDias">Especificar se é pretendido nº exato de dias, 
    '''                                         ou nº dias igual o superior 
    ''' </param>
    ''' <returns></returns>
    Public Function ObterTodasViagens(dias As Integer, incluirViagensComMaisDias As Boolean) As DataTable
        Dim filtro = " "

        If dias <> 0 Then
            filtro += " WHERE v.dias"
            If incluirViagensComMaisDias Then
                filtro += ">"
            End If

            filtro += $"={dias} "
        End If

        Dim ssql = $"SELECT v.id AS 'Cód.Viagem', 
                           c.marca AS 'Veículo', 
                           v.dias AS 'Duração', 
                           v.km AS 'Distância' 
                    FROM viagem v 
                        INNER JOIN veiculo c 
                            ON v.veiculo_id=c.id 
                    {filtro} 
                    ORDER BY v.id"

        Return ObterDados(ssql)
    End Function


    'Public Function ObterProdutosDeCategoria(id_categoria As Integer) As DataTable
    '    Dim ssql = $"SELECT p.id AS 'Cód.', 
    '                       p.nome AS 'Designação', 
    '                       c.nome AS 'Categoria', 
    '                       p.qtd AS 'Qdt.' 
    '                FROM produto p 
    '                    INNER JOIN categoria c 
    '                        ON p.categoria_id=c.id
    '                WHERE c.id={id_categoria.ToString}"
    '    Return ObterDados(ssql)
    'End Function


    'Public Function ObterTodasCategorias() As DataTable
    '    Dim ssql = "SELECT id, nome 
    '                FROM categoria 
    '                ORDER BY nome"
    '    Return ObterDados(ssql)
    'End Function

    'Public Function ObterCategoriasComProdutosEmStock() As DataTable
    '    Dim ssql = "SELECT c.id as id, c.nome as nome
    '                FROM categoria c 
    '                    INNER JOIN produto p 
    '                        ON p.categoria_id=c.id 
    '                WHERE p.qtd > 0 
    '                ORDER BY nome"
    '    Return ObterDados(ssql)
    'End Function


    'Public Function ObterProduto(id As Integer) As DataTable
    '    Dim ssql = $"SELECT id, nome, categoria_id, qtd
    '                FROM produto
    '                WHERE id = {id}"
    '    Return ObterDados(ssql)
    'End Function

    'Public Function AtualizarProduto(id As Integer, nome As String, qtd As Integer, categoria_id As Integer) As Integer
    '    Using c As New SqlConnection(Config.SC)
    '        c.Open()
    '        Dim ssql = "UPDATE produto
    '                    SET nome=@nome, qtd=@qtd, categoria_id=@categoria_id
    '                    WHERE id=@id;"

    '        Using comando As New SqlCommand(ssql, c)
    '            comando.Parameters.AddWithValue("@nome", nome)
    '            comando.Parameters.AddWithValue("@qtd", qtd)
    '            comando.Parameters.AddWithValue("@categoria_id", categoria_id)
    '            comando.Parameters.AddWithValue("@id", id)

    '            Try
    '                comando.ExecuteNonQuery()
    '            Catch
    '                Return 1
    '            End Try

    '            Return 0
    '        End Using
    '    End Using
    'End Function



    Public Function InserirViagem(veiculo_id As String, dias As Integer, km As Integer) As Integer
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "INSERT INTO viagem (veiculo_id, dias, km) 
                        VALUES (@veiculo_id, @dias, @km);"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@veiculo_id", veiculo_id)
                comando.Parameters.AddWithValue("@dias", dias)
                comando.Parameters.AddWithValue("@km", km)

                Try
                    comando.ExecuteNonQuery()
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function

    Public Function InserirVeiculo(marca As String) As Integer
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "INSERT INTO veiculo (marca) 
                        VALUES (@marca);"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@marca", marca)

                Try
                    comando.ExecuteNonQuery()
                    Return ObterPrimeiroVeiculoPorMarca(marca)
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function


    Public Function ObterPrimeiroVeiculoPorMarca(marca As String) As Integer
        Dim ssql = $"SELECT TOP 1 id 
                    FROM veiculo 
                    WHERE marca='{marca}'"
        Dim dt = ObterDados(ssql)
        Return Integer.Parse(dt.Rows(0)(0))
    End Function


    Public Function ApagarViagensEVeiculos()
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "DELETE FROM viagem; DELETE FROM veiculo;"

            Using comando As New SqlCommand(ssql, c)
                Try
                    comando.ExecuteNonQuery()
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function

    Public Function ObterDistanciaTotalPorVeiculo(veiculo_id As Integer) As Integer
        Dim ssql = $"SELECT SUM(km) 
                    FROM viagem 
                    WHERE veiculo_id={veiculo_id}"
        Dim dt = ObterDados(ssql)
        Dim v = dt.Rows(0)(0).ToString
        Dim n = Integer.Parse(v)
        Return n
    End Function

    Public Function ContarViagensPorVeiculoEDuracao(veiculo_id As Integer, dias As Integer) As Integer
        Dim ssql = $"SELECT COUNT(id) 
                    FROM viagem 
                    WHERE veiculo_id={veiculo_id} AND dias={dias}"
        Dim dt = ObterDados(ssql)
        Dim v = dt.Rows(0)(0).ToString
        Dim n = Integer.Parse(v)
        Return n
    End Function
End Class
