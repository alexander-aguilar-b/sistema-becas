using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class OferenteConsulta
    {
        public int id { get; set; }
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public IdEstadoSistema idEstadoSistema { get; set; }
        public Rol rol { get; set; }
        public InfoUsuario infoUsuario { get; set; }
    }
}