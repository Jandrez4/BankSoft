using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class RetiroE
    {
        [Key]
        public int Id_Retiro { get; set; }

        public double Valor_Retiro { get; set; }

        public ClienteE clienteE = new ClienteE();
    }
}
