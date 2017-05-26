using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.control;
using WcfService1.model;
using WcfService1.model.data;

namespace WcfService1
{
    
    public class Service1 : IService1
    {
        public string InsertClient(Cliente cliente)
        {
            try
            {
                String result;
                ClienteControle clienteTeste = new ClienteControle(cliente);
                result = clienteTeste.ClienteValidoInsert();
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar inserir" + "" + ex.Message);
            }
        }

        public string UpdateClient(Cliente cliente)
        {
            try
            {

                String result;
                ClienteControle clienteTeste = new ClienteControle(cliente);
                result = clienteTeste.ClienteValidoUpdate();
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar atualizar" + "" + ex.Message);
            }
        }

        public string InsertConta(Conta conta)
        {
            try
            {
                String result;
                ContaControle contaTeste = new ContaControle(conta);
                result = contaTeste.ContaValidaInsert();
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar inserir:" + " " + ex.Message);
            }
        }

        public List<Cliente> ListarClientes(Cliente cliente)
        {
            try
            {

                List<Cliente> result;
                DBCliente clienteTeste = new DBCliente(cliente);
                result = clienteTeste.ListarClientes();
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar atualizar" + "" + ex.Message);
            }
        }

        public Cliente PegarClientePorEmail(Cliente cliente)
        {
            try
            {
                DBCliente clienteTeste = new DBCliente(cliente);
                return  clienteTeste.PegarClientePorEmail(cliente.Email);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar atualizar" + "" + ex.Message);
            }
        }
    }
}
