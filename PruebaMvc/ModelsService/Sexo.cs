using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaMvc.ModelsService
{
    public class Sexo
    {
        public int id_genero { get; set; }
        public object abreviatura { get; set; }
        public string descripcion { get; set; }
    }
}