using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca.Classes.Cliente
{
    public class ClienteBDSqlServerParametros : ConexaoSqlServer
    {
       public void Insert(Cliente cliente)
        {
            try
            {
                this.abrirConexao();
                string sql="";
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }
    }
}
