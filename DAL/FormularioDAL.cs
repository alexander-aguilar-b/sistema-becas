using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormularioDAL
    {
        String connString = ConfigurationManager.ConnectionStrings["PortalBecas"].ConnectionString;

        public void GuardarFormulario(String cedula, Items items)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand procedure = new SqlCommand("spInsertarItemFormularioTemporal", conn);
                procedure.CommandType = CommandType.StoredProcedure;

                foreach (Item item in items.lstItems)
                {
                    String opciones = obtenerRespuestas(item.lstRespuestas);
                    procedure.Parameters.Clear();
                    procedure.Parameters.Add("@CedulaUsuario", SqlDbType.VarChar, 20).Value = cedula;
                    procedure.Parameters.Add("@Item", SqlDbType.VarChar, 500).Value = item.Descripcion;
                    procedure.Parameters.Add("@IdTipoControl", SqlDbType.Int).Value = Convert.ToInt16(item.IdTipoControl);
                    procedure.Parameters.Add("@Respuestas", SqlDbType.VarChar, 100).Value = opciones;

                    procedure.ExecuteNonQuery();
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                throw ex;
                //ViewBag.Message = "Hubo un error al gestionar el formulario" + ex.Message;
            }

        }

        private String obtenerRespuestas(List<Respuesta> respuestas)
        {
            String opciones = "";
            if (respuestas != null)
            {
                foreach (Respuesta respuesta in respuestas)
                {
                    opciones += respuesta.respuesta + "|";
                }
            }

            return opciones.TrimEnd('|');
        }
    }
}
