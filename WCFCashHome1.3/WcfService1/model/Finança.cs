using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFCashHomeService.model
{
    public class Finança
    {
        string dataInicio, dataFim, nome;
        int idConta, idCategoria;

        public Finança(string dataInicio, string dataFim, string nome, int idConta, int idCategoria)
        {
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
            this.nome = nome;
            this.idConta = idConta;
            this.idCategoria = idCategoria;
        }
        [DataMember(IsRequired = true)]
        public string DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }
        [DataMember(IsRequired = true)]
        public string DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        [DataMember(IsRequired = true)]
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        [DataMember(IsRequired = true)]
        public int IdConta
        {
            get { return idConta; }
            set { IdConta = value; }
        }

        [DataMember(IsRequired = true)]
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

    }
}