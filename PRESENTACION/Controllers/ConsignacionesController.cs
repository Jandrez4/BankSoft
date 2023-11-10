using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Referencias 
using ENTIDAD;
using LOGICA;

namespace PRESENTACION.Controllers
{
    public class ConsignacionesController : Controller
    {
        ConsignacionL consignacionL = new ConsignacionL();

        // GET: Consignaciones
        public ActionResult ListadoConsignaciones()
        {
            return View(consignacionL.ListadoConsignaciones());
        }

        public ActionResult InsertarConsignacion()
        {
            List<ConsignacionE> listaConsignaciones = new List<ConsignacionE>();
            ConsignacionL consignacionL = new ConsignacionL();
            listaConsignaciones = consignacionL.ListadoConsignaciones();
            ViewBag.ListadoConsinaciones = listaConsignaciones;

            return View();
        }

        public ActionResult CrearConsignacion(int txtIdCliente, long txtDoc_Envia, long txtDoc_Cliente, long txtNum, double txtConsignacion)
        {
            ConsignacionE consignacionE = new ConsignacionE();
            consignacionE.clienteE.Id_Cliente = txtIdCliente;
            consignacionE.Documento_Envia = txtDoc_Envia;
            consignacionE.clienteE.Documento = txtDoc_Cliente;
            consignacionE.clienteE.Num_Cuenta = txtNum;
            consignacionE.Valor_Consignacion = txtConsignacion;

            string mensaje = "";

            if (consignacionL.CrearConsignacion(consignacionE) == true)
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('CONSIGNACION CREADA SATISFACTORIAMENTE');window.location.href=" +
                                    "'/Consignaciones/ListadoConsignaciones';</script>";
            }
            else
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('ERROR ---> CONSIGANCION NO CREADA');window.location.href=" +
                                    "'/Consignaciones/InsertarConsignacion';</script>";
            }

            return Content(mensaje);
        }
    }
}