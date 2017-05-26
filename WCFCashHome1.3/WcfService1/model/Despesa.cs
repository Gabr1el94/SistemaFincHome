using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.model
{
    public class Despesa
    {
        string dataValidade, dataEmissao;
        Boolean status;
        float valorDespesa;
        int idFinança;


        public Despesa(String dataValidade, String dataEmissao, Boolean status, float valor, int idFinança)
        {
            this.dataValidade = dataValidade;
            this.dataEmissao = dataEmissao;
            this.status = status;  
            this.valorDespesa = valor;
            this.idFinança = idFinança;
        }

        [DataMember(IsRequired = true)]
        public string DataValidade
        {
            get { return dataValidade; }
            set { dataValidade = value; }
        }

        [DataMember(IsRequired = true)]
        public string DataEmissao
        {
            get { return DataEmissao; }
            set { DataEmissao = value; }
        }

        [DataMember(IsRequired = true)]
        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        [DataMember(IsRequired = true)]
        public float ValorDespesa
        {
            get { return valorDespesa; }
            set { valorDespesa = value; }
        }

        [DataMember(IsRequired = true)]
        public int IdFinança
        {
            get { return idFinança; }
            set { idFinança = value; }
        }
    }
}