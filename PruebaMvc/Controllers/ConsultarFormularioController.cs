using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Views.AgregarFormulario
{
    public class ConsultarFormularioController : Controller
    {
        private String cedula = "1023";
        // GET: Consulta
        [Authorize]
        public ActionResult ConsultarFormulario()
        {
            FormularioRespuesta lista = new FormularioRespuesta(cedula);
            return View(lista);
        }
    }
}