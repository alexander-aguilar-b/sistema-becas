using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult CrearOferente()
        {
            List<SelectListItem> Pais = new List<SelectListItem>();
            Pais.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Pais.Add(new SelectListItem() { Text = "Colombia", Value = "1" });
            Pais.Add(new SelectListItem() { Text = "Perú", Value = "2" });

            ViewBag.Pais = new SelectList(Pais, "Value", "Text");

            List<SelectListItem> TipoOferente = new List<SelectListItem>();
            TipoOferente.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            TipoOferente.Add(new SelectListItem() { Text = "Fundación", Value = "1" });
            TipoOferente.Add(new SelectListItem() { Text = "Organización", Value = "2" });

            ViewBag.TipoOferente = new SelectList(TipoOferente, "Value", "Text");

            Oferente oferente = new Oferente();
            return View(oferente);
        }

        public ActionResult GuardarOferente(Oferente oferente)
        {
            return View("~/Views/Usuario/CrearOferente.cshtml", oferente);
        }

        public ActionResult CrearAdministrador()
        {
            List<SelectListItem> Sede = new List<SelectListItem>();
            Sede.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Sede.Add(new SelectListItem() { Text = "Bogotá", Value = "1" });
            Sede.Add(new SelectListItem() { Text = "Bucaramanga", Value = "2" });

            ViewBag.Sede = new SelectList(Sede, "Value", "Text");

            Administrador administrador = new Administrador();
            return View(administrador);
        }

        public ActionResult GuardarAdministrador(Administrador administrador)
        {
            return View("~/Views/Usuario/CrearAdministrador.cshtml", administrador);
        }

        public ActionResult CrearSolicitante()
        {
            List<SelectListItem> TipoDocumento = new List<SelectListItem>();
            TipoDocumento.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            TipoDocumento.Add(new SelectListItem() { Text = "Cedula", Value = "1" });
            TipoDocumento.Add(new SelectListItem() { Text = "Tarjeta de identidad", Value = "2" });

            ViewBag.TipoDocumento = new SelectList(TipoDocumento, "Value", "Text");

            List<SelectListItem> Sexo = new List<SelectListItem>();
            Sexo.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Sexo.Add(new SelectListItem() { Text = "Masculino", Value = "1" });
            Sexo.Add(new SelectListItem() { Text = "Femenino", Value = "2" });

            ViewBag.Sexo = new SelectList(Sexo, "Value", "Text");

            List<SelectListItem> TipoPoblacion = new List<SelectListItem>();
            TipoPoblacion.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            TipoPoblacion.Add(new SelectListItem() { Text = "Desplazados", Value = "1" });
            TipoPoblacion.Add(new SelectListItem() { Text = "Vulnerables", Value = "2" });

            ViewBag.TipoPoblacion = new SelectList(TipoPoblacion, "Value", "Text");

            List<SelectListItem> Pais = new List<SelectListItem>();
            Pais.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Pais.Add(new SelectListItem() { Text = "Colombia", Value = "1" });
            Pais.Add(new SelectListItem() { Text = "Perú", Value = "2" });

            ViewBag.Pais = new SelectList(Pais, "Value", "Text");

            List<SelectListItem> Departamento = new List<SelectListItem>();
            Departamento.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Departamento.Add(new SelectListItem() { Text = "Cundinamarca", Value = "1" });
            Departamento.Add(new SelectListItem() { Text = "Santander", Value = "2" });

            ViewBag.Departamento = new SelectList(Departamento, "Value", "Text");

            List<SelectListItem> Ciudad = new List<SelectListItem>();
            Ciudad.Add(new SelectListItem() { Text = "Seleccione", Value = "0" });
            Ciudad.Add(new SelectListItem() { Text = "Bogotá", Value = "1" });
            Ciudad.Add(new SelectListItem() { Text = "Bucaramanga", Value = "2" });

            ViewBag.Ciudad = new SelectList(Ciudad, "Value", "Text");

            Solicitante solicitante = new Solicitante();
            return View(solicitante);
        }

        public ActionResult GuardarSolicitante(Solicitante solicitante)
        {
            return View("~/Views/Usuario/CrearSolicitante.cshtml", solicitante);
        }

        public ActionResult EliminarSolicitante()
        {
            Solicitante solicitante = new Solicitante();
            return View(solicitante);
        }

        public ActionResult BorrarSolicitante(Solicitante solicitante)
        {
            return View("~/Views/Usuario/CrearSolicitante.cshtml", solicitante);
        }
    }
}