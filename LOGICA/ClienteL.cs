using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using que conecta las otras capas
using ENTIDAD;
using DATA;

namespace LOGICA
{
    public class ClienteL
    {
        ClienteDA clienteDA = new ClienteDA();


        public List<ClienteE> ListadoClientes()
        {
            return clienteDA.ListadoClientes();
        }

        public bool AgregarCliente(ClienteE clienteE)
        {
            return clienteDA.AgregarCliente(clienteE);
        }

        public ClienteE BuscarId(int Id_Cliente)
        {
            return clienteDA.BuscarId(Id_Cliente);
        }

        public bool ActualizarCliente(ClienteE clienteE)
        {
            return clienteDA.ActualizarCliente(clienteE);
        }

        public bool EliminarCliente(int Id_Cliente)
        {
            return clienteDA.EliminarCliente(Id_Cliente);
        }
    }
}
