using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class InfoUsuario
    {
        public string nit { get; set; }
        public string descripcion { get; set; }
        public long fecha_creacion { get; set; }
        public Nullable<int> id_tipo_entidad { get; set; }
        public Nullable<int> pais { get; set; }
    }
}