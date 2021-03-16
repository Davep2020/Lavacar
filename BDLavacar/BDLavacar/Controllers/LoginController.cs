using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BDLavacar.Models;

namespace BDLavacar.Controllers
{
    public class LoginController : Controller
    {

        bdlavacarEntities modeloBD = new bdlavacarEntities();

        public ActionResult login()
        {
            return View();
        }
    }
}