using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Categoria
    {
        private int Cod_categoria;
        private string Descricao_categoria;
        private string Tipo_categoria;

        public int Cod_Categoria
        {
            get { return Cod_categoria; }
            set { Cod_categoria = value; }
        }

        public string Descricao_Categoria
        {
            get { return Descricao_categoria; }
            set { Descricao_categoria = value; }
        }

        public string Tipo_Categoria
        {
            get { return Tipo_categoria; }
            set { Tipo_categoria = value; }
        }

    }
}
