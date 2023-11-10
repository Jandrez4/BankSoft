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
    public class RetiroL
    {
        RetiroDA retiroDA = new RetiroDA();

        public List<RetiroE> ListadoRetiros()
        {
            return retiroDA.ListadoRetiros();
        }

        public bool CrearRetiro(RetiroE retiroE)
        {
            return retiroDA.CrearRetiro(retiroE);
        }
    }
}
