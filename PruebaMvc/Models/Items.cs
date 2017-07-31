using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Items
    {
        PortalBecasEntities dataContext = new PortalBecasEntities();

        public List<Item> lstItems { get; set; }

        public Items()
        {
        }

        public Items(string cc)
        {
            lstItems = GetItems(cc);
        }

        public List<Item> GetItems(string cc)
        {
            List<Item> varlstItems = new List<Item>();

            List<spObtenerFormularioTemporal_Result> lst = dataContext.spObtenerFormularioTemporal(cc).ToList();

            foreach (spObtenerFormularioTemporal_Result item in lst)
            {
                Item it = new Item { Id = item.IdItem, Cedula = cc, Descripcion = item.Item, IdTipoControl = item.IdTipoControl };

                it.lstRespuestas = obtenerRespuestas(it.Id);

                varlstItems.Add(it);
            }
            return varlstItems;
        }

        public List<Respuesta> obtenerRespuestas(int idItem)
        {
            List<Respuesta> lstRespuesta = new List<Respuesta>();

            List<spObtenerRespuestaItem_Result> lst = dataContext.spObtenerRespuestaItem(idItem).ToList();

            foreach (spObtenerRespuestaItem_Result item in lst)
            {
                Respuesta respuesta = new Respuesta();
                respuesta.respuesta= item.Respuesta;

                lstRespuesta.Add(respuesta);
            }
            return lstRespuesta;
        }
    }

}