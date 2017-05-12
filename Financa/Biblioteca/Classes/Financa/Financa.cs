using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
   public class Financa
    {
        private int Cod_fin;
        private DateTime DtEmissao_fin;
        private string Nome_fin;
        private Boolean Ativo_finc;
        private Conta Cod_conta;
        private Categoria Cod_categoria;

        public int Cod_Fin
        {
            get { return Cod_fin; }
            set { Cod_fin = value; }
        }

        public DateTime DtEmissao_Fin
        {
            get { return DtEmissao_fin; }
            set { DtEmissao_fin = value; }
        }

        public string Nome_Fin
        {
            get { return Nome_fin; }
            set { Nome_fin = value; }
        }

        public Boolean Ativo_Finc
        {
            get { return Ativo_finc; }
            set { Ativo_finc = value; }
        }

        public Conta Cod_Conta
        {
            get { return Cod_conta; }
            set { Cod_conta = value; }
        }

        public Categoria Cod_Categoria
        {
            get { return Cod_categoria; }
            set { Cod_categoria = value; }
        }

    }
}
