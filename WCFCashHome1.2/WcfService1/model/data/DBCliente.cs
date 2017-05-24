using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1.model.data
{
    public class DBCliente : DBConn
        
    {
        Cliente cliente;

        public DBCliente(Cliente cliente)
        {
            abrirConexao();
            this.cliente = cliente;
        }

        public DBCliente()
        {
            abrirConexao();
        }

        public string InsertClient()
        {

            try
            {
                string sql = "INSERT INTO CLIENTE (nomeCliente, emailCliente, senha ,cpf, dataNascimento) "
                            + "VALUES (@NOME, @EMAIL, @SENHA, @CPF, @DATANASCIMENTO)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("@SENHA", cliente.Senha);
                cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("@DATANASCIMENTO", cliente.DataNascimento);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "Cliente inserido com sucesso";
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

        public String UpdateClient()
        {
            try
            {

                string sql = "UPDATE CLIENTE SET nomeCliente = @NOME, emailCliente = @EMAIL, dataNascimento = @DATANASCIMENTO" +
                             " ,cpf = @CPF, senha = @SENHA WHERE emailCliente = @EMAIL";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("@SENHA", cliente.Senha);
                cmd.Parameters.AddWithValue("@CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("@DATANASCIMENTO", cliente.DataNascimento);

                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "Cliente atualizado com sucesso";
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao tentatar modificar" + "" + ex.Message);
            }
            finally
            {
                fecharConexao();
            }
        }

        public void DeleteClient()
        {
            try
            {
                string sql = "DELETE FROM Cliente WHERE emailCliente = @EMAIL";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@EMAIL", cliente.Email);
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

        public List<Cliente> ListarClientes()
        {
            try
            {
                List<Cliente> listaCliente = new List<Cliente>();

                string sql = "SELECT * FROM Cliente ORDER BY nomeCliente";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    String nome;
                    String email;
                    String senha;
                    String cpf;
                    String dataNascimento;

                    nome = DbReader.GetString(DbReader.GetOrdinal("nomeCliente"));
                    email = DbReader.GetString(DbReader.GetOrdinal("emailCliente"));
                    senha = DbReader.GetString(DbReader.GetOrdinal("senha"));
                    cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    dataNascimento = DbReader.GetDataTypeName(DbReader.GetOrdinal("dataNascimento"));

                    Cliente cliente = new Cliente(nome, email, senha, cpf, dataNascimento);
                    listaCliente.Add(cliente);
                }
                DbReader.Close();
                cmd.Dispose();
                return listaCliente;
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
