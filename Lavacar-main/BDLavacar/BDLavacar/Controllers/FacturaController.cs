using BDLavacar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace BDLavacar.Controllers
{
    public class FacturaController : Controller
    {
        bdlavacarEntities2 modeloBD = new bdlavacarEntities2();
        #region Ingresar

        #region Registrar
        public ActionResult insertaFactura(int Id_Factura_F)
        {
            sp_RetornaFacturaID_Result modelovista = new sp_RetornaFacturaID_Result();
            modelovista = this.modeloBD.sp_RetornaFacturaID(Id_Factura_F).FirstOrDefault();
            Session["Id_Factura_F"] = Id_Factura_F;
            Session["Nombre"] = modelovista.NombreCompleto;
            Session["cedula"] = modelovista.Cedula_P;
            Session["marca"] = modelovista.Tipo_MV;
            Session["placa"] = modelovista.Placa_V;
            Session["fecha"] = modelovista.Fecha_F;
            Session["total"] = modelovista.Total_F;
            AgregaServicioViewBag();
            return View(modelovista);
        }
        [HttpPost]
        public ActionResult insertaFactura(sp_RetornaFacturaID_Result modeloVista)
        {
            int cantRegistroAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistroAfectados = this.modeloBD.sp_InsertaServicioFactura(
                                        modeloVista.Id_Factura_FVS = Convert.ToInt32(Session["Id_Factura_F"]),
                                        modeloVista.Cantidad_FVS,
                                        modeloVista.Id_Servicio_FVS);
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

            AgregaServicioViewBag();
            return View();
        }
        #endregion

        #region Prefactura

        public ActionResult RegistraFactura()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistraFactura(sp_RetornaFacturas_Result modeloVista)
        {
            int cantRegistroAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistroAfectados = this.modeloBD.sp_RegistraFacturas(
                                        modeloVista.Id_Vehiculo_F,
                                        modeloVista.Id_Persona_F

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
            Response.Redirect("~/Factura/ListaPreFactura");


            return View();
        }
        #endregion

        #endregion


        #region Mostrar
        public ActionResult ListaPreFactura()
        {
            List<sp_RetornaFacturaNULL_Result> modeloVista =
            new List<sp_RetornaFacturaNULL_Result>();

            modeloVista = modeloBD.sp_RetornaFacturaNULL().ToList();
            return View(modeloVista);
        }

        public ActionResult KendoFactura()
        {
            return View();
        }

        [HttpPost]
        public ActionResult KendoFacturaLista()
        {
            List<sp_RetornaFacturaFinal_Result> listaPersonas =
               this.modeloBD.sp_RetornaFacturaFinal().ToList();
            return Json(new
            {
                resultado = listaPersonas
            });
        }


        public ActionResult MuestraServicios()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KendoFacturaServicio(int Id_Factura_F )
        {
            List<sp_RetornaFacturaServicio_Result> listaPersonas =
               this.modeloBD.sp_RetornaFacturaServicio(Id_Factura_F).ToList();
            return Json(new
            {
                resultado = listaPersonas
            });
        }

        #endregion

        #region Void
        void AgregaServicioViewBag()
        {
            this.ViewBag.Servicio = this.modeloBD.sp_RetornaServicios().ToList();
        }
        #endregion

        #region Json
        public ActionResult RetornaPersona()
        {
            List<sp_RetornaClientesPreFactura_Result> Persona = this.modeloBD.sp_RetornaClientesPreFactura().ToList();
            return Json(Persona);
        }

        public ActionResult RetornaVehiculo()
        {
            List<sp_RetornaVehiculoUI_Result> Carro = this.modeloBD.sp_RetornaVehiculoUI().ToList();
            return Json(Carro);
        }
        #endregion

        #region Eliminar
        public ActionResult PreFacturaEliminar(int Id_Factura_F)
        {
            sp_RetornaPreFacturaID_Result modelovista = new sp_RetornaPreFacturaID_Result();
            modelovista = this.modeloBD.sp_RetornaPreFacturaID(Id_Factura_F).FirstOrDefault();
            return View(modelovista);
        }

        [HttpPost]
        public ActionResult PreFacturaEliminar(sp_RetornaPreFacturaID_Result modelovista)
        {
            int cantRegistrosAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistrosAfectados = this.modeloBD.sp_EliminarPreFactura(
                    modelovista.Id_Factura_F);
            }
            catch (Exception error)
            {
                resultado = "Ocurrio un error: " + error.Message;
            }
            finally
            {
                if (cantRegistrosAfectados > 0)
                {
                    resultado += "Registro Eliminado";
                }
                else
                {
                    resultado += "No se pudo Eliminado";
                }

            }
            Response.Write("<script language=javascript>alert('" + resultado + "')</script>");
           
            return View(modelovista);


        }

        #endregion

    }
}