using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;


namespace BDLavacar.Controllers
{
    public class FacturaController : Controller
    {
        bdlavacarEntities1 modeloBD = new bdlavacarEntities1();
        #region Ingresar
        public ActionResult RegistraFactura()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistraFactura(sp_RetornaServicios_Result modeloVista)
        {
            int cantRegistroAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistroAfectados = this.modeloBD.sp_InsertaServicio(
                                        modeloVista.Codigo_S,
                                        modeloVista.Descripcion_S,
                                        modeloVista.Precio_S,
                                        modeloVista.Tipo_S
                                        );
            }
            catch (Exception error)
            {
                resultado = "Ocurrio un error: " + error.Message;
            }
            finally
            {
                if (cantRegistroAfectados > 0)
                {
                    resultado += "Registro Insertado";
                }
                else
                {
                    resultado += "No se pudo insertar";
                }
            }

            Response.Write("<script language=javascript>alert('" + resultado + "');</script>");


            return View();
        }
        #endregion

        #region Json
        public ActionResult RetornaPersona()
        {
            List<sp_RetornaClientes_Result> Persona = this.modeloBD.sp_RetornaClientes().ToList();
            return Json(Persona);
        }
        public ActionResult RetornaVehiculo()
        {
            List<sp_RetornaVehiculoUI_Result> Carro = this.modeloBD.sp_RetornaVehiculoUI().ToList();
            return Json(Carro);
        }
        #endregion
    }
}