using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Administrador : Usuario
    {
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String Cargo { get; set; }
        public String IdSede { get; set; }
    }
}