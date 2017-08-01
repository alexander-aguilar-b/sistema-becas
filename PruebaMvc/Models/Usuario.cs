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
		[Display(Name ="Nombre Usuario")]
        public String NombreUsuario { get; set; }
        public String CorreoElectronico { get; set; }
		[Required(ErrorMessage =  "La clave es requerida")]
		[Display(Name = "Contraseña")]
		public String Clave { get; set; }
        public String ConfirmarClave { get; set; }
        public String Rol { get; set; }
    }
}