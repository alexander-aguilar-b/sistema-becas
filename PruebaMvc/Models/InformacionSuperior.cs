namespace PruebaMvc.Models
{
    public class InformacionSuperior
    {
        public string id_Nombre_Institucion { get; set; }
        public string fecha_inicio { get; set; }
        public string fecha_fin { get; set; }
        public string fecha_graduacion { get; set; }
        public string nombre_programa { get; set; }
        public string semestre_programa { get; set; }
        public int creditos { get; set; }
        public string titulo_obtenido { get; set; }
        public bool registro_calificado { get; set; }
    }
}