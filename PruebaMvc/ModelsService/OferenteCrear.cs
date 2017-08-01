using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class OferenteCrear
    {
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string nit { get; set; }
        public string descripcion { get; set; }
        public int tipoEntidad { get; set; }
        public int pais { get; set; }
    }
}