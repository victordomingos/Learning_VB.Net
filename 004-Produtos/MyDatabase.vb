Imports System.Data.SqlClient

Public Class MyDatabase
    Private Function ObterDados(ssql As String) As DataTable
        Using con As New SqlConnection(Config.SC)
            Dim command As SqlCommand = con.CreateCommand()
            command.CommandText = ssql
            Dim da As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dt As DataTable = New DataTable()
            da.Fill(dt)
            con.Close()

            Return dt

        End Using
    End Function

    Public Function ObterTodosProdutos() As DataTable
        Dim ssql As String = "SELECT p.id AS 'Cód.', p.nome AS 'Designação', c.nome AS 'Categoria', p.qtd AS 'Qdt.' FROM produto p INNER JOIN categoria c ON p.categoria_id=c.id"
        Return ObterDados(ssql)
    End Function

    Public Function ObterProdutosDeCategoria(id_categoria As Integer) As DataTable
        Dim ssql As String = "SELECT p.id AS 'Cód.', p.nome AS 'Designação', c.nome AS 'Categoria', p.qtd AS 'Qdt.' FROM produto p INNER JOIN categoria c ON p.categoria_id=c.id"
        ssql += " WHERE c.id=" + id_categoria.ToString
        Return ObterDados(ssql)
    End Function


    Public Function ObterTodasCategorias() As DataTable
        Dim ssql As String = "SELECT id, nome FROM categoria ORDER BY nome"
        Return ObterDados(ssql)
    End Function


    Public Function InserirAssociado(nome As String, qtd As Integer) As Integer
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql As String = "INSERT INTO produto (nome, qtd) VALUES (@nome, @qtd);"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@nome", nome)
                comando.Parameters.AddWithValue("@qtd", qtd)

                Try
                    comando.ExecuteNonQuery()
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function
End Class
