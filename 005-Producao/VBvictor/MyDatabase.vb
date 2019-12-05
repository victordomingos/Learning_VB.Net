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

    Public Function ObterTodosProdutos() As DataTable
        Dim ssql = "SELECT p.id AS 'Cód.', 
                           p.nome AS 'Designação', 
                           c.nome AS 'Categoria', 
                           p.qtd AS 'Qdt.' 
                    FROM produto p 
                        INNER JOIN categoria c 
                            ON p.categoria_id=c.id"
        Return ObterDados(ssql)
    End Function

    Public Function ObterProdutosDeCategoria(id_categoria As Integer) As DataTable
        Dim ssql = $"SELECT p.id AS 'Cód.', 
                           p.nome AS 'Designação', 
                           c.nome AS 'Categoria', 
                           p.qtd AS 'Qdt.' 
                    FROM produto p 
                        INNER JOIN categoria c 
                            ON p.categoria_id=c.id
                    WHERE c.id={id_categoria.ToString}"
        Return ObterDados(ssql)
    End Function


    Public Function ObterTodasCategorias() As DataTable
        Dim ssql = "SELECT id, nome 
                    FROM categoria 
                    ORDER BY nome"
        Return ObterDados(ssql)
    End Function

    Public Function ObterCategoriasComProdutosEmStock() As DataTable
        Dim ssql = "SELECT c.id as id, c.nome as nome
                    FROM categoria c 
                        INNER JOIN produto p 
                            ON p.categoria_id=c.id 
                    WHERE p.qtd > 0 
                    ORDER BY nome"
        Return ObterDados(ssql)
    End Function


    Public Function ObterProduto(id As Integer) As DataTable
        Dim ssql = $"SELECT id, nome, categoria_id, qtd
                    FROM produto
                    WHERE id = {id}"
        Return ObterDados(ssql)
    End Function

    Public Function AtualizarProduto(id As Integer, nome As String, qtd As Integer, categoria_id As Integer) As Integer
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "UPDATE produto
                        SET nome=@nome, qtd=@qtd, categoria_id=@categoria_id
                        WHERE id=@id;"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@nome", nome)
                comando.Parameters.AddWithValue("@qtd", qtd)
                comando.Parameters.AddWithValue("@categoria_id", categoria_id)
                comando.Parameters.AddWithValue("@id", id)

                Try
                    comando.ExecuteNonQuery()
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function

    Public Function InserirProduto(nome As String, qtd As Integer, categoria_id As Integer) As Integer
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "INSERT INTO produto (nome, qtd, categoria_id) 
                        VALUES (@nome, @qtd, @categoria_id);"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@nome", nome)
                comando.Parameters.AddWithValue("@qtd", qtd)
                comando.Parameters.AddWithValue("@categoria_id", categoria_id)

                Try
                    comando.ExecuteNonQuery()
                Catch
                    Return 1
                End Try

                Return 0
            End Using
        End Using
    End Function

    Public Function DeleteProduct(id)
        Using c As New SqlConnection(Config.SC)
            c.Open()
            Dim ssql = "DELETE FROM produto WHERE id=@id;"

            Using comando As New SqlCommand(ssql, c)
                comando.Parameters.AddWithValue("@id", id)

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
