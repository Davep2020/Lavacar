using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;

namespace BDLavacar.Controllers
{
    public class ClienteVistaController : Controller
    {
        bdlavacarEntities1 modeloBD = new bdlavacarEntities1();

        #region JSON
        public ActionResult RetornaProvincias()
        {
            List<RetornaProvincias_Result> provincias = this.modeloBD.RetornaProvincias(null).ToList();
            return Json(provincias);
        }
        public ActionResult RetornaCantones(int id_Provincia)
        {
            List<RetornaCantones_Result> cantones = this.modeloBD.RetornaCantones(null, id_Provincia).ToList();
            return Json(cantones);
        }

        public ActionResult RetornaDistritos(int id_Canton)
        {
            List<sp_RetornaDistritos_Result> distritos = this.modeloBD.sp_RetornaDistritos(null, id_Canton).ToList();
            return Json(distritos);
        }
        #endregion

        #region Listar
        public ActionResult ClientesVistaLista(string correo)
        {
            sp_RetornaVistaClientes_Result modeloVista = new sp_RetornaVistaClientes_Result();
            correo = Session["correoVista"].ToString();
            modeloVista = modeloBD.sp_RetornaVistaClientes(correo).FirstOrDefault();
            return View(modeloVista);
        }
        #endregion

        //#region Modificar
        ///// <summary>
        ///// Función Para modificar Datos 
        ///// </summary>
        ///// <param name="Id_Cliente_P"></param>
        ///// <returns></returns>
        //public ActionResult PersonaModifica(int Id_Cliente_P)
        //{
        //    sp_RetornaClientesID_Result modelovista = new sp_RetornaClientesID_Result();
        //    modelovista = this.modeloBD.sp_RetornaClientesID(Id_Cliente_P).FirstOrDefault();

        //    return View(modelovista);
        //}

        //[HttpPost]
        //public ActionResult PersonaModifica(sp_RetornaClientesID_Result modelovista)
        //{
        //    int cantRegistrosAfectados = 0;
        //    string resultado = "";
        //    try
        //    {
        //        cantRegistrosAfectados = this.modeloBD.sp_ModificaClientes(
        //            modelovista.Id_Cliente_P,
        //            Convert.ToInt16(modelovista.Cedula_P),
        //            modelovista.Genero_P,
        //            modelovista.Fecha_Nacimiento_P,
        //            modelovista.Nombre_P,
        //            modelovista.PApellido,
        //            modelovista.SApellido,
        //            modelovista.Correo_P,
        //            modelovista.id_Provincia,
        //            modelovista.id_Canton,
        //            modelovista.Id_TipoPersona_TP,
        //            modelovista.id_Distrito
        //            );
        //    }
        //    catch (Exception error)
        //    {
        //        resultado = "Ocurrio un error: " + error.Message;
        //    }
        //    finally
        //    {
        //        if (cantRegistrosAfectados > 0)
        //        {
        //            resultado += "Registro modificado";
        //        }
        //        else
        //        {
        //            resultado += "No se pudo modificar";
        //        }

        //    }
        //    Response.Write("<script language=javascript>alert('" + resultado + "')</script>");
        //    return View(modelovista);


        //}

        //#endregion

        #region void
        void AgregaTipoPersonaViewBag()
        {
            this.ViewBag.TipoPersona = this.modeloBD.sp_RetornaTipoPersona().ToList();
        }

        #endregion
    }
}