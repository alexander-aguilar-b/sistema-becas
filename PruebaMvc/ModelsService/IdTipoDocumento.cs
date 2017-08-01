using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class IdTipoDocumento
    {
        public int id_tipo_documento { get; set; }
        public string abreviacion { get; set; }
        public string descripcion { get; set; }
    }
}