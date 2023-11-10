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
    public class RetirosController : Controller
    {
        RetiroL retiroL = new RetiroL();

        // GET: Retiros
        public ActionResult ListadoRetiros()
        {
            return View(retiroL.ListadoRetiros());
        }

        public ActionResult InsertarRetiro()
        {
            List<ClienteE> listaClientes = new List<ClienteE>();
            ClienteL clienteL = new ClienteL();
            listaClientes = clienteL.ListadoClientes();
            ViewBag.ListadoClientes = listaClientes;

            return View();
        }

        public ActionResult CrearRetiro(int txtID, long txtDocumento, long txtNum, double txtRetiro)
        {
            RetiroE retiroE = new RetiroE();
            retiroE.clienteE.Id_Cliente = txtID;
            retiroE.clienteE.Documento = txtDocumento;
            retiroE.clienteE.Num_Cuenta = txtNum;
            retiroE.Valor_Retiro = txtRetiro;

            string mensaje = "";

            if (retiroL.CrearRetiro(retiroE) == true)
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('RETIRO CREADO SATISFACTORIAMENTE');window.location.href=" +
                                    "'/Retiros/ListadoRetiros';</script>";
            }
            else
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('ERROR ---> RETIRO NO CREADO');window.location.href=" +
                                    "'/Retiros/InsertarRetiro';</script>";
            }

            return Content(mensaje);
        }            
        
    }
}