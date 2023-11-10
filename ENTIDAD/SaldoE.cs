using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class SaldoE
    {
        [Key]
        public int Id_Saldo { get; set; }

        public double Saldo_Actual { get; set; }

        public ClienteE clienteE = new ClienteE();
    }
}
