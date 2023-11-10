using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class ClienteE
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Required, Display(Name = "Nombres")]
        public string Nombre { get; set; }

        [Required, Display(Name = "Apellidos")]
        public string Apellido { get; set; }

        [Required, Display(Name = "Tipo de Documento")]
        public string Tipo_Documento { get; set; }

        [Required, Display(Name = "Documento de identidad")]
        public long Documento { get; set; }

        [Required, Display(Name = "Tipo de Cliente")]
        public string Tipo_Cliente { get; set; }

        [Required, Display(Name = "Tipo de Cuenta")]
        public string Tipo_Cuenta { get; set; }

        /*[Required, Display(Name = "Fecha Creacion")]
        public DateTime F_Creacion_Cuenta { get; set; }*/

        [Required, Display(Name = "Ciudad de Origen Cuenta")]
        public string Origen_Apertura_Cuenta { get; set; }

        [Required, Display(Name = "Numero de cuenta")]
        public long Num_Cuenta { get; set; }
    }
}
