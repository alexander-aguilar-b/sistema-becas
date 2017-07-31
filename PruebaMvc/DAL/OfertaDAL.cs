using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.DAL
{
    public class OfertaDAL
    {
        public List<OfertaModel> obtenerOfertaPorOferente(int id = 0)
        {
            List<OfertaModel> listaOferta = new List<OfertaModel>();
            using (PortalBecasEntities datacontext = new PortalBecasEntities())
            {
                List<spConsultarOfertaOferente_Result> listaOfertasResult = datacontext.spConsultarOfertaOferente(1).ToList();
                foreach(spConsultarOfertaOferente_Result ofertaResult in listaOfertasResult)
                {
                    OfertaModel oferta = new OfertaModel();
                    oferta = convierteAModelo(oferta, ofertaResult);

                    listaOferta.Add(oferta);
                }
            }
            return listaOferta;
        }

        public OfertaModel obtenerOferta(int idOferta = 0)
        {
            OfertaModel oferta = new OfertaModel();
            using (PortalBecasEntities datacontext = new PortalBecasEntities())
            {
                spConsultarOferta_Result ofertaResult = datacontext.spConsultarOferta(idOferta).FirstOrDefault();
                oferta = convierteAModelo(oferta, ofertaResult);
            }
            return oferta;
        }

        public void aplicarOferta(int pIdOferta, int pIdSolicitante)
        {
            try
            {
                using (PortalBecasEntities datacontext = new PortalBecasEntities())
                {
                    datacontext.spAplicarOferta(pIdOferta, pIdSolicitante);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        #region converite a modelo
        public OfertaModel convierteAModelo(OfertaModel oferta, spConsultarOfertaOferente_Result ofertaResult)
        {
            oferta.IdOferta = ofertaResult.IdOferta;
            oferta.IdOferente = ofertaResult.IdOferente;
            oferta.Nombre = ofertaResult.Nombre;
            oferta.Descripcion = ofertaResult.Descripcion;
            oferta.FechaInicio = ofertaResult.FechaInicio;
            oferta.FechaFin = ofertaResult.FechaFin;
            oferta.IdTipoOferta = ofertaResult.IdTipoOferta;
            oferta.Requisitos = ofertaResult.Requisitos;
            oferta.Condiciones = ofertaResult.Condiciones;
            oferta.InformacionAdicional = ofertaResult.InformacionAdicional;
            oferta.FechaCreacion = ofertaResult.FechaCreacion;
            oferta.IdEstadoSistema = ofertaResult.IdEstadoSistema;

            return oferta;
        }

        public OfertaModel convierteAModelo(OfertaModel oferta, spConsultarOferta_Result ofertaResult)
        {
            oferta.IdOferta = ofertaResult.IdOferta;
            oferta.IdOferente = ofertaResult.IdOferente;
            oferta.Nombre = ofertaResult.Nombre;
            oferta.Descripcion = ofertaResult.Descripcion;
            oferta.FechaInicio = ofertaResult.FechaInicio;
            oferta.FechaFin = ofertaResult.FechaFin;
            oferta.IdTipoOferta = ofertaResult.IdTipoOferta;
            oferta.Requisitos = ofertaResult.Requisitos;
            oferta.Condiciones = ofertaResult.Condiciones;
            oferta.InformacionAdicional = ofertaResult.InformacionAdicional;
            oferta.FechaCreacion = ofertaResult.FechaCreacion;
            oferta.IdEstadoSistema = ofertaResult.IdEstadoSistema;

            return oferta;
        }

#endregion convierte a modelo
    }
}