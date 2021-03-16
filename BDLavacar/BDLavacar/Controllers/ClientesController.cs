using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;

namespace BDLavacar.Controllers
{
    public class ClientesController : Controller
    {
        bdlavacarEntities modeloBD = new bdlavacarEntities();

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

        #region Insertar
        public ActionResult InsertarUsuario()
        {
            return View();

        }


        #endregion

        #region Listar
        public ActionResult ClientesLista()
        {
            List<sp_RetornaClientes_Result> modeloVista = 
                new List<sp_RetornaClientes_Result>();

            modeloVista = modeloBD.sp_RetornaClientes().ToList();
            return View(modeloVista);
        }
        #endregion

        #region Modificar
        /// <summary>
        /// Función Para modificar Datos 
        /// </summary>
        /// <param name="Id_Cliente_P"></param>
        /// <returns></returns>
        public ActionResult PersonaModifica(int Id_Cliente_P)
        {
            sp_RetornaClientesID_Result modelovista = new sp_RetornaClientesID_Result();
            modelovista = this.modeloBD.sp_RetornaClientesID(Id_Cliente_P).FirstOrDefault();
            this.Session["Provincia"] = modelovista.id_Provincia;
            this.Session["NProvincia"] = modelovista.nombreProvincia;
            this.Session["Canton"] = modelovista.id_Canton;
            this.Session["NCanton"] = modelovista.nombreCanton;
            this.Session["Distrito"] = modelovista.id_Distrito;
            this.Session["NDistrito"] = modelovista.nombreDistrito;
            
            return View(modelovista);
        }

        [HttpPost]
        public ActionResult PersonaModifica(sp_RetornaClientesID_Result modelovista)
        {
            int cantRegistrosAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistrosAfectados = this.modeloBD.sp_ModificaClientes(
                    modelovista.Id_Cliente_P,
                    modelovista.Cedula_P,
                    modelovista.Genero_P,
                    modelovista.Fecha_Nacimiento_P,
                    modelovista.Nombre_P,
                    modelovista.Correo_P,
                    modelovista.id_Provincia,
                    modelovista.id_Canton,
                    modelovista.Id_TipoPersona_TP,
                    modelovista.id_Distrito


                    );
            }
            catch (Exception error)
            {
                resultado = "Ocurrio un error: " + error.Message;
            }
            finally
            {
                if (cantRegistrosAfectados > 0)
                {
                    resultado += "Registro modificado";
                }
                else
                {
                    resultado += "No se pudo modificar";
                }

            }
            Response.Write("<script language=javascript>alert('" + resultado + "')</script>");
            return View(modelovista);


        }

        #endregion

        #region Eliminar
        public ActionResult PersonaEliminar(int Id_Cliente_P)
        {
            sp_RetornaClientesID_Result modelovista = new sp_RetornaClientesID_Result();
            modelovista = this.modeloBD.sp_RetornaClientesID(Id_Cliente_P).FirstOrDefault();
            return View(modelovista);
        }

        [HttpPost]
        public ActionResult PersonaEliminar(sp_RetornaClientesID_Result modelovista)
        {
            int cantRegistrosAfectados = 0;
            string resultado = "";
            try
            {
                cantRegistrosAfectados = this.modeloBD.sp_EliminaPersona(
                    modelovista.Id_Cliente_P);
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