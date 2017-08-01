using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class SolicitanteCrear
    {
        public string correoElectronico { get; set; }
        public string contrasena { get; set; }
        public string nombre { get; set; }
        public string numero_documento { get; set; }
        public string apellidos { get; set; }
        public int id_tipo_documento { get; set; }
        public int sexo { get; set; }
        public int id_tipo_poblacion { get; set; }
        public int pais_nacimiento { get; set; }
        public int pais_residencia { get; set; }
    }
}