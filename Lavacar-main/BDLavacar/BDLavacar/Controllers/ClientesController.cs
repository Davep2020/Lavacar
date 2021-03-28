using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;
using System.Net.Mail;
using System.Net;
namespace BDLavacar.Controllers
{
    public class ClientesController : Controller
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

        #region Insertar
        public ActionResult InsertarUsuario()
        {
            AgregaTipoPersonaViewBag();
            return View();

        }

        //[HttpPost]
        //public ActionResult InsertarUsuario(sp_RetornaClientes_Result modeloVista)
        //{
        //    int registros = 0;
        //    string mensaje = "";

        //    try
        //    {
        //        registros = modeloBD.sp_InsertarPersona(
        //            modeloVista.Cedula_P,
        //            modeloVista.Genero_P,
        //            modeloVista.Fecha_Nacimiento_P,
        //            modeloVista.Nombre_P,
        //            modeloVista.Correo_P,
        //            modeloVista.Provincia,
        //           modeloVista.canton,
        //            modeloVista.distrito,
        //             modeloVista.Tipo_TP
        //            );
        //    }
        //    catch (Exception e)
        //    {
        //        mensaje = "Ocurrió un error: " + e.Message;
        //    }
        //    finally
        //    {
        //        if (registros > 0)
        //        {
        //            Session["Correo"] = modeloVista.Correo_P;
        //            Session["Nombre"] = modeloVista.Nombre_P;
        //            mensaje = "Registro insertado.";
        //            EnviarCorreo();
        //        }
        //        else
        //        {
        //            mensaje = "No se pudo insertar.";
        //        }
        //    }

        //    Response.Write("<script laguage=JavaScript>alert('" + mensaje + "');</script>");
        //    AgregaTipoPersonaViewBag();
        //    return View();
        //}

        #endregion

        #region Listar
        //public ActionResult ClientesLista()
        //{
        //    List<sp_RetornaClientes_Result> modeloVista = 
        //        new List<sp_RetornaClientes_Result>();

        //    modeloVista = modeloBD.sp_RetornaClientes().ToList();
        //    return View(modeloVista);
        //}
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

        #region void
        void AgregaTipoPersonaViewBag()
        {
            this.ViewBag.TipoPersona = this.modeloBD.sp_RetornaTipoPersona().ToList();
        }

 

        void EnviarCorreo()
        {
        
            string mensaje = "";
            try
            {

 
                string tomail = "";
                tomail = Session["Correo"].ToString();
                string datos = "";
                datos = Session["Nombre"].ToString();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("Aseguradora@gmail.com");
                mail.To.Add(tomail);
                mail.Subject = "Su cuenta en lavemeelMCQUEEN";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<h1>Estimado cliente:  </h1>" + datos + ", gracias por confiar en Seguros el Equipo del Siglo XXI. Para nosotros es un placer servirle." + "</br>";
                mail.Body += "<h1>Sus credenciales para ingresar son los siguientes: </h1>" + "</br>";
                mail.Body += "<h1>Usuario: </h1>" + tomail;
                mail.Body += "<h1>Clave: Cc2021* </h1>" ;
                mail.Body += "<h1>Gracias CUCHAO</h1>";
                mail.Body += "</body>";
                mail.Body += "</html>";

                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("AseguradoraPuriscal@gmail.com", "gl9#^oWWV#er");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                mensaje += "El correo fue enviado.";
            }
            catch (Exception excepcion)
            {
                //Mensaje de error si no funciona
                mensaje += $"Ocurrió un error:{excepcion.Message}";
            }

            ///mostrar el mensaje
            Response.Write("<script>alert('" + mensaje + "')</script>"); ;
        }
        #endregion
    }
}