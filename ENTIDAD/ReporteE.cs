using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class ReporteE
    {
        [Key]
        public int Id_Reporte { get; set; }

        public double SaldoActual { get; set; }

        public ClienteE clienteE = new ClienteE();
    }
}
