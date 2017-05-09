using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Cliente
    {
        private int Cod_client;
        private string Nome_client;
        private string Cpf_client;
        private DateTime DtNasciment_client;
        private string Email_client;


        public int Codigo_Cliente
        {
            get { return Cod_client; }
            set { Cod_client = value; }
        }

        public string Nome_Cliente
        {
            get { return Nome_client; }
            set { Nome_client = value; }
        }

        public string Cpf_Cliente
        {
            get { return Cpf_client; }
            set { Cpf_client = value; }
        }

        public DateTime MyProperty
        {
            get { return DtNasciment_client; }
            set { DtNasciment_client = value; }
        }

        public string Email_Cliente
        {
            get { return Email_client; }
            set { Email_client = value; }
        }



    }
}
