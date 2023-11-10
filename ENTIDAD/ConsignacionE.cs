using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class ConsignacionE
    {
        [Key]
        public int Id_Consignacion { get; set; }

        public long Documento_Envia { get; set; }

        public double Valor_Consignacion { get; set; }

        public ClienteE clienteE = new ClienteE();
    }
}
