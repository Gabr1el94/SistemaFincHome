using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFCashHomeService.model
{
    public class Categoria
    {
        string tipoCategoria, descricao;
        int idCategoria;

        public Categoria(string tipoCategoria, string descricao)
        {
            this.tipoCategoria = tipoCategoria;
            this.descricao = descricao;
        }

        public Categoria()
        {
        }

        [DataMember(IsRequired = true)]
        public string TipoCategoria
        {
            get { return tipoCategoria; }
            set { tipoCategoria = value; }
        }

        [DataMember(IsRequired = true)]
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        [DataMember(IsRequired = true)]
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

    }
}