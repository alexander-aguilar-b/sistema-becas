using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class OfertaS
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public object fechaInicio { get; set; }
        public object fechaFin { get; set; }
        public string requisitos { get; set; }
        public string condiciones { get; set; }
        public string informacionAdicional { get; set; }
        public object fechaCreacion { get; set; }
        public object tipoOferta { get; set; }
        public object estadoSistema { get; set; }
        public int idOferente { get; set; }
    }
}