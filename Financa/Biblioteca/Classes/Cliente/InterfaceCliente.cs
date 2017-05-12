using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes.Cliente
{
     public interface InterfaceCliente
    {
        void Insert(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Cliente cliente);
        bool Duplicidade(Cliente cliente);
        List<Cliente> Select(Cliente filtro);
    }
}
