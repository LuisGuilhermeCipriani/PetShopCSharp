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
     public class ClienteController
    {
        private List<Cliente> listaClientes;

        public ClienteController()
        {
            listaClientes = new List<Cliente>();
        }

        public void cadastrarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }

        public Boolean verificaCliente(Cliente cliente)
        {
            foreach (Cliente c in listaClientes)
            {
                if (c.getCpf().ToLower().Equals(c.getCpf().ToLower()))
                { 
                    return true;
                }
            }

            return false;
        }

        public List<Cliente> getListaClientes()
        {
            return listaClientes;
        }

    }
}
