using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Despesas
    {
        private int Cod_des;
        private string Descricao_des;
        private Double Juros_des;
        private DateTime Vencimento_des;
        private Double Valor_des;
        private Financa Cod_finc;

        public int Cod_Des
        {
            get { return Cod_des; }
            set { Cod_des = value; }
        }

        public string Descricao_Des
        {
            get { return Descricao_des; }
            set { Descricao_des = value; }
        }

        public Double Juros_Des
        {
            get { return Juros_des; }
            set { Juros_des = value; }
        }

        public DateTime Vencimento_Des
        {
            get { return Vencimento_des; }
            set { Vencimento_des = value; }
        }

        public Double Valor_Des
        {
            get { return Valor_des; }
            set { Valor_des = value; }
        }

        public Financa Cod_Finc
        {
            get { return Cod_finc; }
            set { Cod_finc = value; }
        }
    }
}
