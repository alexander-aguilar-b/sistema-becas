using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.Models
{
    public class OfertaModel
    {
        public int IdOferta { get; set; }
        public Nullable<int> IdOferente { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<int> IdTipoOferta { get; set; }
        public string Requisitos { get; set; }
        public string Condiciones { get; set; }
        public string InformacionAdicional { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> IdEstadoSistema { get; set; }

    }
}