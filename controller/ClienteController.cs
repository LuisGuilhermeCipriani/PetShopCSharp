using PetShopCSharp.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShopCSharp.controller
{
    class ClienteController
    {
        private List<Cliente> listaClientes;

        public ClienteController()
        {
            listaClientes = new List<Cliente>();
        }

        public void cadastrarCliente()
        {
            Cliente cliente = new Cliente();
            listaClientes.Add(cliente);
        }

        public List<Cliente> getListaClientes()
        {
            return listaClientes;
        }

    }
}
