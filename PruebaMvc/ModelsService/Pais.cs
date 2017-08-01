using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class Pais
    {
        public int id_pais { get; set; }
        public object abreviatura { get; set; }
        public object nombre { get; set; }
        public object nacionalidad { get; set; }
    }
}