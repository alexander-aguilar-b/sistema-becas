using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;


namespace PruebaMvc.Controllers
{
    public class GestionarFormularioController : Controller
    {
        private String cedula = "1023";
        private int MULTI_SELECCION = 7;
        private int DOCUMENTO_ADJUNTO = 8;

        String connString = ConfigurationManager.ConnectionStrings["PortalBecas"].ConnectionString;

        // GET: Home
        [Authorize(Roles = "Administrador,Solicitante")]
        public ActionResult Formulario()
        {
            Items lista = new Items(cedula);

            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand testCMD = new SqlCommand("spCrearFormularioSolicitante", conn);
                testCMD.CommandType = CommandType.StoredProcedure;

                testCMD.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = cedula;
                testCMD.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al gestionar el formulario" + ex.Message;
            }

            return View(lista);
        }

        [Authorize(Roles = "Administrador,Solicitante")]
        public ActionResult Guardar(Items items, HttpPostedFileBase file)
        {

            //Documento adjunto

            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand testCMD = new SqlCommand("spCalificarItems", conn);
                testCMD.CommandType = CommandType.StoredProcedure;

                string path = "";

                if (file != null)
                {
                    if (file.ContentLength > 0)
                    {
                        string fileName = Path.GetFileName(file.FileName);
                        path = Path.Combine(Server.MapPath("~/Documents"), fileName);
                        file.SaveAs(path);
                    }
                }

                foreach (Item item in items.lstItems)
                {

                    if (item.IdTipoControl == MULTI_SELECCION)
                        item.valor = obtenerSeleccionMultiple(item);

                    if (item.IdTipoControl == DOCUMENTO_ADJUNTO)
                        item.valor = path;

                    testCMD.Parameters.Clear();
                    testCMD.Parameters.Add("@Cedula", SqlDbType.VarChar, 20).Value = item.Cedula;
                    testCMD.Parameters.Add("@IdItem", SqlDbType.Int).Value = item.Id;
                    testCMD.Parameters.Add("@Valor", SqlDbType.VarChar, 100).Value = item.valor == null? "" : item.valor;
                    testCMD.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al gestionar el formulario" + ex.Message;
            }

            return View();
        }

        private String obtenerSeleccionMultiple(Item item)
        {
            String valor = "";
            foreach (Respuesta respuesta in item.lstRespuestas)
            {
                valor = respuesta.seleccion ? valor + "," + respuesta.respuesta : valor;
            }

            return valor.TrimStart(',');
        }

    }
}