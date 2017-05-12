using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes.Cliente
{
    public class ClienteBDSqlServerParametros : ConexaoSqlServer,InterfaceCliente
    {
       public void Insert(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql= "insert into Cliente(Nome_client,Senha_client,Cpf_client,DtNasciment_client,Email_client) ";
                sql += "values (@Nome_client,@Senha_client,@Cpf_client,@DtNasciment_client,@Email_client) ";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nome_client", SqlDbType.VarChar);
                cmd.Parameters["@Nome_client"].Value = cliente.Nome_Cliente;

                cmd.Parameters.Add("@Senha_client", SqlDbType.VarChar);
                cmd.Parameters["Senha_client"].Value = cliente.Senha_Client;

                cmd.Parameters.Add("@Cpf_client", SqlDbType.VarChar);
                cmd.Parameters["Cpf_client"].Value = cliente.Cpf_Cliente;

                cmd.Parameters.Add("@DtNasciment_client", SqlDbType.Date);
                cmd.Parameters["DtNasciment_client"].Value = cliente.DtNasciment_Client;

                cmd.Parameters.Add("@Email_client", SqlDbType.VarChar);
                cmd.Parameters["Email_client"].Value = cliente.Email_Cliente;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao inserir os dados" + ex.Message);
            }
        }

        public void Update(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql = "update Cliente set Nome_client=@Nome_client,Senha_client=@Senha_client,DtNasciment_client=@DtNasciment_client,Email_client=@Email_client where Email_client=@Email_client";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@Nome_client", SqlDbType.VarChar);
                cmd.Parameters["@Nome_client"].Value = cliente.Nome_Cliente;

                cmd.Parameters.Add("@Senha_client", SqlDbType.VarChar);
                cmd.Parameters["Senha_client"].Value = cliente.Senha_Client;

                cmd.Parameters.Add("@Cpf_client", SqlDbType.VarChar);
                cmd.Parameters["Cpf_client"].Value = cliente.Cpf_Cliente;

                cmd.Parameters.Add("@DtNasciment_client", SqlDbType.Date);
                cmd.Parameters["DtNasciment_client"].Value = cliente.DtNasciment_Client;

                cmd.Parameters.Add("@Email_client", SqlDbType.VarChar);
                cmd.Parameters["Email_client"].Value = cliente.Email_Cliente;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao atualizar os dados  " + ex.Message);
            }
          
        }

        public void Delete(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql = "delete from Cliente where Cpf_client=@Cpf_client and Senha_client=@Senha_client";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                cmd.Parameters.Add("@Cpf_client", SqlDbType.VarChar);
                cmd.Parameters["Cpf_client"].Value = cliente.Email_Cliente;

                cmd.Parameters.Add("@Senha_client", SqlDbType.VarChar);
                cmd.Parameters["Senha_client"].Value = cliente.Senha_Client;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar seus dados  " + ex.Message);
            }
        }

        public bool Duplicidade(Cliente cliente)
        {
            bool retorno = false;

            try
            {
                this.abrirConexao();
                string sql= "SELECT Cod_client,Nome_client,Senha_client,Cpf_client,DtNasciment_client,Email_client FROM Cliente where Cpf_client=@Cpf_client";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@Cpf_client", SqlDbType.VarChar);
                cmd.Parameters["Cpf_client"].Value = cliente.Email_Cliente;
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }
                //fechando o leitor de resultados
                DbReader.Close();
               
                //liberando
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
              
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao inserir pra consultar os dados " + ex.Message);
            }
            return retorno;
        }



        public List<Cliente> Select(Cliente filtro)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                this.abrirConexao();
                string sql= "select Nome_client,Senha_client,Cpf_client,DtNasciment_client,Email_client from Cliente where Nome_client=Nome_client ";

                if (filtro.Nome_Cliente != null && filtro.Nome_Cliente.Trim().Equals("") == false)
                {
                    sql += " and Nome_client like '%@Nome_client%'";
                }

                
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                if (filtro.Nome_Cliente != null && filtro.Nome_Cliente.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@Senha_client", SqlDbType.VarChar);
                   cmd.Parameters["Nome_client"].Value = filtro.Nome_Cliente;
                }
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Nome_Cliente = DbReader.GetString(DbReader.GetOrdinal("Nome_client"));
                    retorno.Add(cliente);
                }
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir de consultar os dados  " + ex.Message);
            }
            return retorno;
        }

      
    }
}
