using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Etapa
    {
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public String fechaInicio { get; set; }
        public String fechaFin { get; set; }
        public int cantidadCupos { get; set; }
    }
}   