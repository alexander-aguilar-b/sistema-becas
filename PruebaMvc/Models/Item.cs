using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Item
    {
        public string Cedula { get; set; }
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int? IdTipoControl { get; set; }

        public string valor { get; set; }
        public bool activo { get; set; }

        public List<Respuesta> lstRespuestas { get; set; }
    }
}