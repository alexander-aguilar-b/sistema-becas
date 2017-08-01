using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class PaisNacimiento
    {
        public int id_pais { get; set; }
        public string abreviatura { get; set; }
        public string nombre { get; set; }
        public string nacionalidad { get; set; }
    }
}