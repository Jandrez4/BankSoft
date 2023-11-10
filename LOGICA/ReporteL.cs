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
    public class ReporteL
    {
        ReporteDA reporteDA = new ReporteDA();

        public List<ReporteE> ListadoReporteClientes()
        {
            return reporteDA.ListadoReporteClientes();
        }

    }
    
}
