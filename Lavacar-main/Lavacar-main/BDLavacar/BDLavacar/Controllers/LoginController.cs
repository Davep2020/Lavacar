﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;

namespace BDLavacar.Controllers
{
    public class LoginController : Controller
    {

        bdlavacarEntities1 modeloBD = new bdlavacarEntities1();

  
        public ActionResult InicioSesion()
        {
            return View();
        }
        public ActionResult Validar(string pNombre, string pApellido1)
        {
            string mensaje = "";
            try
            {
                sp_RetornaLogueo_Result datosCliente = new sp_RetornaLogueo_Result();
                datosCliente = modeloBD.sp_RetornaLogueo(pNombre,pApellido1).FirstOrDefault();

                if (datosCliente == null)
                {
                    Response.Write("<script>alert('Datos Invalidos')</script>"); ;
                    this.Session.Add("Nombre", null);
                    this.Session.Add("Tipo", null);
                    this.Session.Add("Fecha", null);
                    this.Session.Add("UsuarioLogeado", null);
                }
                else
                {

                    Session.Add("Nombre" , datosCliente.@Nombre);
                    Session.Add("Tipo",datosCliente.@Tipo);
                    Session.Add("Fecha",datosCliente.@Fecha);
                    Session.Add("UsuarioLogeado",true);

                    if (Convert.ToInt32(this.Session["Tipo"]) == 1)
                    {
                        Response.Redirect("~/Factura/ListaPreFactura");
                    }
                    else if (Convert.ToInt32(this.Session["Tipo"]) == 2)
                    {
                        this.Response.Redirect("~/Servicios/ServicioLista");
                    }

                }
            }
            catch (Exception excepcionCapturada)
            {
                mensaje += $"Ocurrio un error:{excepcionCapturada.Message}";
            }

            return View();

                }
    }
}