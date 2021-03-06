﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFCashHomeService.model;

namespace WCFCashHomeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        #region ações do cliente
        [OperationContract]
        string InsertClient(Cliente cliente);

        [OperationContract]
        string UpdateClient(Cliente cliente);

        [OperationContract]
        List<Cliente> ListarClientes(Cliente cliente);
        [OperationContract]
        Cliente PegarClientePorEmail(Cliente cliente);
        #endregion

        [OperationContract]
        string InsertConta(Conta cliente);




    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
