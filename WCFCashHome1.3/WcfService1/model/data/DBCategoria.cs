using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1.model.data
{
    public class DBCategoria : DBConn
    {
        private Categoria categoria;

        public DBCategoria(Categoria categoria)
        {
            abrirConexao();
            this.categoria = categoria;
        }

        public string InsertCategoria()
        {

            try
            {
                string sql = "INSERT INTO CATEGORIA (tipoCategoria, descrição) "
                            + "VALUES (@CATEGORIA, @DESCRIÇÂO)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@CATEGORIA", categoria.TipoCategoria);
                cmd.Parameters.AddWithValue("@DESCRIÇÂO", categoria.Descricao);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "Categoria inserida com sucesso";
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar inserir" + "" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
        public String UpdateCategoria()
        {
            try
            {

                string sql = "UPDATE CATEGORIA SET tipoCategoria = @CATEGORIA, descrição = @DESCRIÇÂO" +
                             "WHERE emailConta = @EMAIL";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@CATEGORIA", categoria.TipoCategoria);
                cmd.Parameters.AddWithValue("@DESCRIÇÂO", categoria.Descricao);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "Categoria atualizada com sucesso";
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentatar atualizar" + "" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }
        public void DeleteCategoria()
        {
            try
            {
                string sql = "DELETE FROM CATEGORIA WHERE idCategoria = @ID";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@ID", categoria.IdCategoria);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentatar Deletar" + "" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public List<Categoria> ListarCategorias()
        {
            try
            {
                List<Categoria> listaCategoria = new List<Categoria>();

                string sql = "SELECT * FROM CATEGORIA";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    string tipoCategoria, descrição;
                    int idCategoria;

                    tipoCategoria = DbReader.GetString(DbReader.GetOrdinal("tipoCategoria"));
                    descrição = DbReader.GetString(DbReader.GetOrdinal("descrição"));
                    idCategoria = DbReader.GetInt16(DbReader.GetOrdinal("idCategoria"));


                    Categoria categoria = new Categoria();
                    

                    listaCategoria.Add(categoria);
                }
                DbReader.Close();
                cmd.Dispose();
                return listaCategoria;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar Selecionar" + " " + ex.Message);
            }

            finally
            {
                fecharConexao();
            }
        }
    }
}
