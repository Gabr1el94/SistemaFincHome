using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    class Conta
    {
        private int Cod_conta;
        private Double Salario_conta;
        private DateTime Data_salario;
        private Cliente Cod_client;
<<<<<<< HEAD
        
=======

>>>>>>> origin/master

        public int Cod_Conta
        {
            get { return Cod_conta; }
            set { Cod_conta = value; }
        }

        public Double Salario_Conta
        {
            get { return Salario_conta; }
            set { Salario_conta = value; }
        }

        public DateTime Data_Salario
        {
            get { return Data_salario; }
            set { Data_salario = value; }
        }

        public Cliente Cod_Cliente
        {
            get { return Cod_client; }
            set { Cod_client = value; }
        }
    }
}
