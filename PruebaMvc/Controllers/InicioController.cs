using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        [Authorize]
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult CrearFormularioDinamico()
        {
            return View();
        }

        public ActionResult CrearUsuarios()
        {
            return View();
        }
    }
}