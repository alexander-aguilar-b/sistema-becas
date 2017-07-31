using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class OferenteS
    {
        public int id { get; set; }
        public string correoElectronico { get; set; }
        public object contrasena { get; set; }
        public string nombre { get; set; }
        public object idEstadoSistema { get; set; }
        public RolS rol { get; set; }
        public InfoUsuarioS infoUsuario { get; set; }
    }
}