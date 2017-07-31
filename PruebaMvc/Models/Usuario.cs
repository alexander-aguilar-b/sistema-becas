using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PruebaMvc.Models
{
	public class Usuario
	{
		public int IdUsuario { get; set; }
		[Required(ErrorMessage = "El nombre de usuario es requerido")]
        public String NombreUsuario { get; set; }
        public String CorreoElectronico { get; set; }
		[Required(ErrorMessage =  "La clave es requerida")]
		public String Clave { get; set; }
        public String ConfirmarClave { get; set; }
        public String Rol { get; set; }
    }
}