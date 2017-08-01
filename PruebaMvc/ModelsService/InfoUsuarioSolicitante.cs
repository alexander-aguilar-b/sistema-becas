using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class InfoUsuarioSolicitante
    {
        public string numero_documento { get; set; }
        public string apellidos { get; set; }
        public object direccion { get; set; }
        public object telefono { get; set; }
        public object estrato { get; set; }
        public long fecha_nacimiento { get; set; }
        public IdTipoDocumento id_tipo_documento { get; set; }
        public Sexo sexo { get; set; }
        public object id_tipo_poblacion { get; set; }
        public PaisNacimiento pais_nacimiento { get; set; }
        public object pais_residencia { get; set; }
        public object departamento_nacimiento { get; set; }
        public object departamento_residencia { get; set; }
        public object municipio_nacimiento { get; set; }
        public object municipio_residencia { get; set; }
        public object experiencia_laboral { get; set; }
        public object informacion_academica_basica { get; set; }
        public object informacion_academica_superior { get; set; }
        public object idioma_solicitante { get; set; }
    }
}