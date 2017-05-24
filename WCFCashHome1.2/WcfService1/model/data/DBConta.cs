using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WcfService1.model.data
{
    public class DBConta : DBConn
    {
        Conta contaCliente;

        public DBConta(Conta conta)
        {
            abrirConexao();
            contaCliente = conta;
        }

        public string InsertConta()
        {

            try
            {
                string sql = "INSERT INTO Conta (salarioConta, emailCliente) "
                            + "VALUES (@SALARIO, @EMAIL)";

                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@SALARIO", contaCliente.SalarioConta);
                cmd.Parameters.AddWithValue("@EMAIL", contaCliente.EmailCliente);
                cmd.CommandType = CommandType.Text;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return "Conta inserida com sucesso";
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
    }
}