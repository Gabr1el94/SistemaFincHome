using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService2.control;
using WcfService2.model;
using WcfService2.model.data;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
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
                return clienteTeste.PegarClientePorEmail(cliente.Email);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentatar atualizar" + "" + ex.Message);
            }
        }
    }
}
