using PruebaMvc.DAL;
using PruebaMvc.Models;
using PruebaMvc.ModelsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Controllers
{
    public class UsuarioController : Controller
    {
        OfertaDALServicio ofertaDALServicio = new OfertaDALServicio();

		public UsuarioController()
		{
			ViewBag.ConsultaRealizada = false;
		}

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

            OferenteCrear oferente = new OferenteCrear();
            return View("~/Views/Usuario/CrearOferente.cshtml", oferente);
        }

        public ActionResult GuardarOferente(OferenteCrear oferente)
        {
            string resultado = "";
            OferenteConsulta oferenteNuevo = new OferenteConsulta();
            oferenteNuevo = ofertaDALServicio.crearOferente(oferente);
            ViewBag.Message = "El oferente fue creado correctamente";
            return View("~/Views/Usuario/ConsultarOferente.cshtml", oferenteNuevo);
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

            SolicitanteCrear solicitante = new SolicitanteCrear();
            return View("~/Views/Usuario/CrearSolicitante.cshtml", solicitante);
        }

        public ActionResult GuardarSolicitante(SolicitanteCrear solicitante)
        {
            string resultado = "";
            SolicitanteConsulta solicitanteNuevo = new SolicitanteConsulta();
            solicitanteNuevo = ofertaDALServicio.crearSolicitante(solicitante);
            ViewBag.Message = "El solicitante fue creado correctamente";
            return View("~/Views/Usuario/ConsultarSolicitante.cshtml", solicitanteNuevo);
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

        public ActionResult consultarOferente()
        {
            OferenteConsulta oferente = new OferenteConsulta();
            return View("~/Views/Usuario/ConsultarOferente.cshtml", oferente);
        }

		[HttpGet]
		public ActionResult consultarOferenteId()
		{
			return View("ConsultarOferente");
		}

		[HttpPost]
        public ActionResult consultarOferenteId(String idOferente)
        {

            OferenteConsulta oferente = new OferenteConsulta();
            try
            {
                oferente = ofertaDALServicio.obtenerOferente(idOferente);
				ViewBag.ConsultaRealizada = true;
			}
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al aplicar a la oferta. " + ex.Message;
            }



            return View("~/Views/Usuario/ConsultarOferente.cshtml", oferente);
        }



        public ActionResult consultarSolicitante()
        {
            SolicitanteConsulta solicitante = new SolicitanteConsulta();
            return View("~/Views/Usuario/ConsultarSolicitante.cshtml", solicitante);
        }

		[HttpGet]
		public ActionResult consultarSolicitanteId()
		{
			return View("ConsultarSolicitante");
		}

		[HttpPost]
		public ActionResult consultarSolicitanteId(String idSolicitante)
        {
            SolicitanteConsulta solicitante = new SolicitanteConsulta();

            try
            {
                solicitante = ofertaDALServicio.obtenerSolicitante(idSolicitante);
				ViewBag.ConsultaRealizada = true;
			}
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al aplicar a la oferta. " + ex.Message;
            }
            return View("~/Views/Usuario/ConsultarSolicitante.cshtml", solicitante);
        }
    }
}