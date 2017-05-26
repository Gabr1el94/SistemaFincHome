using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFCashHomeService.model;
using WCFCashHomeService.model.data;

namespace WCFCashHomeService.control
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