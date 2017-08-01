using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class InfoUsuario
    {
        public string nit { get; set; }
        public string descripcion { get; set; }
        public long fechaCreacion { get; set; }
        public TipoEntidad tipoEntidad { get; set; }
        public Pais pais { get; set; }
    }
}