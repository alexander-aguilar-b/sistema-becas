using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class SolicitanteCrear
    {
		[Required(ErrorMessage = "El nombre de usuario es requerido")]
		[Display(Name = "Usuario")]
		public string nombreUsuario { get; set; }

		[Required(ErrorMessage = "El correo electrónico es requerido")]
		[Display(Name = "Correo Electrónico")]
		[RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "El correo electrónico no tiene el formato adecuado")]
		public string correoElectronico { get; set; }

		[Required(ErrorMessage = "La contraseña es requerida")]
		[Display(Name = "Contraseña")]
		public string contrasena { get; set; }

		[Required(ErrorMessage = "La confirmación de contraseña es requerida")]
		[Compare("contrasena", ErrorMessage = "Las contraseñas no coinciden")]
		[Display(Name = "Confirmar Contraseña")]
		public string confirmarContrasena { get; set; }

		[Required(ErrorMessage = "El nombre es requerido")]
		[Display(Name = "Nombre")]
		public string nombre { get; set; }

		[Required(ErrorMessage = "El número de documento es requerido")]
		[Display(Name = "Documento")]
		public string numero_documento { get; set; }

		[Required(ErrorMessage = "Los apellidos son requeridos")]
		[Display(Name = "Apellidos")]
		public string apellidos { get; set; }

		
		[Range(1, int.MaxValue, ErrorMessage = "El tipo de documento es requerido")]
		[Display(Name = "Tipo de Documento")]
		public int id_tipo_documento { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El género es requerido")]
		[Display(Name = "Género")]
		public int sexo { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El tipo de población es requerido")]
		[Display(Name = "Tipo de Población")]
		public int id_tipo_poblacion { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El pais de nacimiento es requerido")]
		[Display(Name = "Pais de Nacimiento")]
		public int pais_nacimiento { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "El pais de residencia es requerido")]
		[Display(Name = "Pais de Residencia")]
		public int pais_residencia { get; set; }
    }
}