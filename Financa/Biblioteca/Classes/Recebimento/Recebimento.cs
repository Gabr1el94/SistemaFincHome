using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Recebimento
    {
        private int Cod_receb;
        private Double Valor_receb;
        private string Descricao_receb;
        private Financa Cod_finc;

        public string Descricao_Receb
        {
            get { return Descricao_receb; }
            set { Descricao_receb = value; }
        }


        public int Cod_Receb
        {
            get { return Cod_receb; }
            set { Cod_receb = value; }
        }

        public Double Valor_Receb
        {
            get { return Valor_receb; }
            set { Valor_receb = value; }
        }

        public Financa Cod_Finc
        {
            get { return Cod_finc; }
            set { Cod_finc = value; }
        }


    }
}
