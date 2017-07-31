using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class FormularioRespuesta
    {
        PortalBecasEntities dataContext = new PortalBecasEntities();

        public List<Item> lstItems { get; set; }

        public FormularioRespuesta(string cc)
        {
            lstItems = GetItems(cc);
        }

        public List<Item> GetItems(string cc)
        {
            List<Item> varlstItems = new List<Item>();

            List<spConsultarFormulario_Result> lst = dataContext.spConsultarFormulario(cc).ToList();

            foreach (spConsultarFormulario_Result item in lst)
            {
                Item it = new Item {Cedula = cc, Descripcion = item.Item, valor= item.Valor };

                varlstItems.Add(it);
            }
            return varlstItems;
        }
    }
}