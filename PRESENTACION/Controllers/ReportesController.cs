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
    public class ReportesController : Controller
    {
        ReporteL reporteL = new ReporteL();

        // GET: Reportes
        public ActionResult ListadoReporteClientes()
        {
            return View(reporteL.ListadoReporteClientes());
        }
    }
}