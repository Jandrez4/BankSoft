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
    public class SaldosController : Controller
    {
        SaldoL saldoL = new SaldoL();

        // GET: Saldos
        public ActionResult ListadoSaldoCliente()
        {
            return View(saldoL.ListadoSaldoCliente());
        }
    }
}