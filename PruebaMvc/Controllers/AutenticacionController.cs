using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PruebaMvc.Controllers
{
    public class AutenticacionController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                using (PortalBecasEntities entities = new PortalBecasEntities())
                {
                    spConsultarUsuario_Result usuario = entities.spConsultarUsuario(model.NombreUsuario, model.Clave).FirstOrDefault();

                    if (usuario != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.NombreUsuario, false);
                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Inicio", "Inicio");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "El usuario o contraseña son incorrectos.");
                    }
                }
            }

            return View(model);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Inicio", "Inicio");
        }
    }
}