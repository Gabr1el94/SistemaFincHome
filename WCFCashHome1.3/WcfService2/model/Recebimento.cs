using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService2.model
{
    public class Recebimento
    {
        string dataRecebimento, tipo, status;
        float valorRecebimento;
        int idFinança;

        public Recebimento(string dataRecebimento, float valorRecebimento, string tipo, string status, int idFinança)
        {
            this.dataRecebimento = dataRecebimento;
            this.valorRecebimento = valorRecebimento;
            this.tipo = tipo;
            this.status = status;
            this.idFinança = idFinança;
        }

        [DataMember(IsRequired = true)]
        public string DataRecebimento
        {
            get { return dataRecebimento; }
            set { dataRecebimento = value; }
        }

        [DataMember(IsRequired = true)]
        public float ValorRecebimento
        {
            get { return valorRecebimento; }
            set { valorRecebimento = value; }
        }

        [DataMember(IsRequired = true)]
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DataMember(IsRequired = true)]
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        [DataMember(IsRequired = true)]
        public int IdFinança
        {
            get { return idFinança; }
            set { idFinança = value; }
        }
    }
}