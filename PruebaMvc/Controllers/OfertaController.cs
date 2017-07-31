using PruebaMvc.DAL;
using PruebaMvc.ModelsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Controllers
{
    public class OfertaController : Controller
    {
        OfertaDALServicio ofertaDALServicio = new OfertaDALServicio();

        #region Experimento

        public ActionResult Index()
        {
            List<OfertaS> oferta = new List<OfertaS>();

            return View("~/Views/Oferta/ConsultarOferta.cshtml", oferta.AsEnumerable());
        }

        public ActionResult ConsultarOfertaId(int idOferta)
        {
            OfertaS oferta = new OfertaS();

            try
            {
                oferta = ofertaDALServicio.obtenerOfertaId(idOferta.ToString());
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Hubo un error al consultar el oferente. " + ex.Message;
            }
            return View("~/Views/Oferta/oferta.cshtml", oferta);
        }

        public ActionResult ConsultarTodasOferta(string tipoControl, string valor)
        {
            List<OfertaS> oferta = new List<OfertaS>();

            try
            {
                switch(tipoControl)
                {
                    case "1":
                        oferta = ofertaDALServicio.obtenerOfertaOferente(valor);
                        break;
                    case "2":
                        oferta = ofertaDALServicio.obtenerListaOferta();
                        break;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al consultar el oferente. " + ex.Message;
            }
            return View("~/Views/Oferta/ConsultarOferta.cshtml", oferta.AsEnumerable());
        }


        public ActionResult AplicarOferta(int idOferta, int idSolicitante)
        {
            string resultado = "";
            try
            {
                resultado = ofertaDALServicio.aplicarOfertaId(idOferta.ToString(), idSolicitante.ToString());
                ViewBag.Message = resultado;// "Ha aplicado a la oferta correctamente.";
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Hubo un error al aplicar a la oferta. " + ex.Message;
            }
            return View("~/Views/Oferta/oferta.cshtml");
        }

        #endregion Experimento




    }
}