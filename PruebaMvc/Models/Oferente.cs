using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Oferente : Usuario
    {
        public String nit { get; set; }
        [Required(ErrorMessage = "Material cost is required")]
        public String nombre { get; set; }
        public String descripcion { get; set; }
        public int id_tipo_entidad { get; set; }
        public int id_pais { get; set; }
        public int id_estado_oferente { get; set; }
    }
}