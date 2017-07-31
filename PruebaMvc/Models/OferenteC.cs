using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class OferenteC
    {
        public int id { get; set; }
        public string correoElectronico { get; set; }
        public Nullable<int> contrasena { get; set; }
        public string nombre { get; set; }
        public Nullable<int> idEstadoSistema { get; set; }
        public Rol rol { get; set; }
        public InfoUsuario infoUsuario { get; set; }
    }
}