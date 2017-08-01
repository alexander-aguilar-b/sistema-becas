using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PruebaMvc.ModelsService
{
    public class OferenteCrear
    {
		[Required(ErrorMessage ="El nombre de usuario es requerido")]
		[Display(Name ="Usuario")]
		public string nombreUsuario { get; set; }

		[Required(ErrorMessage = "El correo electrónico es requerido")]
		[Display(Name = "Correo Electrónico")]
		[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "El correo electrónico no tiene el formato adecuado")]
		public string correoElectronico { get; set; }

		[Required(ErrorMessage = "La contraseña es requerida")]
		[Display(Name = "Contraseña")]
		public string contrasena { get; set; }

		[Required(ErrorMessage = "El nombre es requerido")]
		[Display(Name = "Nombre")]
		public string nombre { get; set; }

		[Required(ErrorMessage = "El NIT es requerido")]
		[Display(Name = "NIT")]
		public string nit { get; set; }

        public string descripcion { get; set; }

		[Required(ErrorMessage = "El tipo de entidad es requerido")]
		[Range(1, int.MaxValue, ErrorMessage = "El tipo de entidad es requerido")]
		[Display(Name = "Tipo Entidad")]
		public int tipoEntidad { get; set; }

		[Required(ErrorMessage = "El pais es requerido")]
		[Range(1, int.MaxValue, ErrorMessage = "El pais es requerido")]
		[Display(Name = "Pais")]
		public int pais { get; set; }

		[Required(ErrorMessage = "La confirmación de contraseña es requerida")]
		[Compare("contrasena", ErrorMessage ="Las contraseñas no coinciden")]
		[Display(Name = "Confirmar Contraseña")]
		public string confirmarContrasena { get; set; }
	}
}