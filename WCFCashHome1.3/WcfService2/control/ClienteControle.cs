﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService2.model;
using WcfService2.model.data;

namespace WcfService2.control
{
    public class ClienteControle
    {
       private Cliente clienteTeste;

        public ClienteControle (Cliente cliente)
        {
            this.clienteTeste = cliente;
        }

        private string ValidaCliente()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            DBCliente db = new DBCliente(clienteTeste);
            listaCliente = db.ListarClientes();

            foreach(Cliente cliente in listaCliente)
            {
                if(cliente.Email == this.clienteTeste.Email)
                {
                    return "Email já cadastrado";
                }
            }

            return "Cliente válido";
        }

        public String ClienteValidoInsert()
        {
            String validar = ValidaCliente();

            if(validar == "Cliente válido")
            {
                DBCliente db = new DBCliente(clienteTeste);
                String result = db.InsertClient();
                return result;
            }
            return validar;
        }

        public String ClienteValidoUpdate()
        {
            String validar = ValidaCliente();

            if (validar == "Cliente válido")
            {
                DBCliente db = new DBCliente(clienteTeste);
                String result = db.UpdateClient();
                return result;
            }
            return validar;
        }
    }
}