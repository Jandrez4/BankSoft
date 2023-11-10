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
    public class SaldoL
    {
        SaldoDA saldoDA = new SaldoDA();

        public List<SaldoE> ListadoSaldoCliente()
        {
            return saldoDA.ListadoSaldoCliente();
        }
    }
}
