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
    public class ClientesController : Controller
    {
        // GET: Clientes
        ClienteL clienteL = new ClienteL();



        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult ListadoCliente()
        {
            return View(clienteL.ListadoClientes());
        }

        public ActionResult AgregarCliente()
        {
            return View();
        }

        public ActionResult InsertarCliente(string txtNombres, string txtApellidos,
                            long txtDocumento, string txtTipo_Cuenta, //DateTime txtFecha_Creacion,
                            string txtCiudad_Apertura, long txtNumero_Cuenta, string txtTipo_Cliente, string txtTipo_Documento)


        {
            ClienteE clienteE = new ClienteE();
            clienteE.Nombre = txtNombres;
            clienteE.Apellido = txtApellidos;
            clienteE.Documento = txtDocumento;
            clienteE.Tipo_Cuenta = txtTipo_Cuenta;
            //clienteE.F_Creacion_Cuenta = txtFecha_Creacion;
            clienteE.Origen_Apertura_Cuenta = txtCiudad_Apertura;
            clienteE.Num_Cuenta = txtNumero_Cuenta;
            clienteE.Tipo_Cliente = txtTipo_Cliente;
            clienteE.Tipo_Documento = txtTipo_Documento;

            string mensaje = "";

            if(clienteL.AgregarCliente(clienteE) == true)
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('CLIENTE  AGREGADO SATISFACTORIAMENTE');window.location.href=" +
                                    "'/Clientes/ListadoCliente';</script>";
            }
            else
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('ERROR ---> CLIENTE NO AGREGADO');window.location.href=" +
                                    "'/Clientes/AgregarCliente';</script>";
            }


            return Content(mensaje);
        }


        public ActionResult EditarCliente(int Id_Cliente)
        {
            return View(clienteL.BuscarId(Id_Cliente));
        }

        public ActionResult ActualizarCliente(int txtId, string txtNombres, string txtApellidos,
                       long txtDocumento, string txtTipo_Cuenta, //DateTime txtFecha_Creacion,
                       string txtCiudad_Apertura, long txtNumero_Cuenta, string txtTipo_Cliente, string txtTipo_Documento)
        {
            ClienteE clienteE = new ClienteE();
            clienteE.Id_Cliente = txtId;
            clienteE.Nombre = txtNombres;
            clienteE.Apellido = txtApellidos;
            clienteE.Documento = txtDocumento;
            clienteE.Tipo_Cuenta = txtTipo_Cuenta;
            //clienteE.F_Creacion_Cuenta = txtFecha_Creacion;
            clienteE.Origen_Apertura_Cuenta = txtCiudad_Apertura;
            clienteE.Num_Cuenta = txtNumero_Cuenta;
            clienteE.Tipo_Cliente = txtTipo_Cliente;
            clienteE.Tipo_Documento = txtTipo_Documento;

            string mensaje = "";

            if (clienteL.ActualizarCliente(clienteE) == true)
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('CLIENTE ACTUALIZADO SATISFACTORIAMENTE');window.location.href=" +
                                    "'/Clientes/ListadoCliente';</script>";
            }
            else
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                    "alert('ERROR ---> CLIENTE NO ACTUALIZADO');window.location.href=" +
                                    "'/Clientes/AgregarCliente';</script>";
            }


            return Content(mensaje);
        }


        public ActionResult EliminarCliente(int Id_Cliente)
        {
            string mensaje = "";

            if(clienteL.EliminarCliente(Id_Cliente) == true)
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                                   "alert('CLIENTE FUE ELIMINADO SATISFACTORIAMENTE');window.location.href=" +
                                   "'/Clientes/ListadoCliente';</script>";
            }
            else
            {
                mensaje = "<script language='javascript' type='text/javascript'>" +
                           "alert('ERROR ---> CLIENTE NO FUE ELIMINADO SATISFACTORIAMENTE');window.location.href=" +
                           "'/Clientes/ListadoCliente';</script>";
            }

            return Content(mensaje);
        }
    }
}