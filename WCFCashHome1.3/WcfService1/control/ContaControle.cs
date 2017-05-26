﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.model;
using WcfService1.model.data;

namespace WcfService1.control
{
    public class ContaControle
    {
        Conta contaTeste;

        public ContaControle(Conta conta)
        {
            contaTeste = conta;
        }

        private string ValidaCampos()
        {

            if (contaTeste.EmailCliente == null || contaTeste.EmailCliente == "" || contaTeste.EmailCliente.Length > 50)
            {
                return "Email inválido";
            }
            

            return "Conta válida";
        }

        public String ContaValidaInsert()
        {
            String validar = ValidaCampos();

            if (validar == "Conta válida")
            {
                DBConta db = new DBConta(contaTeste);
                String result = db.InsertConta();
                return result;
            }
            return validar;
        }
    }
}