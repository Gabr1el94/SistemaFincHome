using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes.Recebimento
{
    public class RecebimentoBDSqlServerParametros: ConexaoSqlServer
    {
        public void Inserir(Recebimento receber) {

            this.abrirConexao();

            this.fecharConexao();

        }
    }
}
