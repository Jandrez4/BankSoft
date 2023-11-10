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
    public class ConsignacionL
    {
        ConsignacionDA consignacionDA = new ConsignacionDA();

        public List<ConsignacionE> ListadoConsignaciones()
        {
            return consignacionDA.ListadoConsignaciones();
        }

        public bool CrearConsignacion(ConsignacionE consignacionE)
        {
            return consignacionDA.CrearConsignacion(consignacionE);
        }
    }
}
