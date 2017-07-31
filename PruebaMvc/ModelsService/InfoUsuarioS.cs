using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class InfoUsuarioS
    {
        public string nit { get; set; }
        public string descripcion { get; set; }
        public object fechaCreacion { get; set; }
        public object tipoEntidad { get; set; }
        public object pais { get; set; }
    }
}