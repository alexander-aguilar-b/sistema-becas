using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class Solicitante : Usuario
    {
        public int id_tipo_documento { get; set; }
        public String documento { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String correo_electronico { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String sexo { get; set; }
        public int estrato { get; set; }
        public int id_tipo_poblacion { get; set; }
        public String fecha_nacimiento { get; set; }


        public int id_pais_nacimiento { get; set; }
        public int id_depatamento_nacimiento { get; set; }
        public int id_ciudad_nacimiento { get; set; }

        public int id_pais_residencia { get; set; }
        public int id_depatamento_residencia { get; set; }
        public int id_ciudad_residencia { get; set; }

        public List<InformacionAcademica> informacion_academica { get; set; }
        public List<InformacionSuperior> informacion_academica_superior { get; set; }
        public List<ExperienciaLaboral> experiencia_laboral { get; set; }

        public List<NivelIdioma> nivel_idioma { get; set; }

        public int id_estado_sistema { get; set; }
    }
}