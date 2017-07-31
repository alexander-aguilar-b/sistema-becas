using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public String CorreoElectronico { get; set; }
        public String Clave { get; set; }
        public String ConfirmarClave { get; set; }
        public String Rol { get; set; }
    }
}