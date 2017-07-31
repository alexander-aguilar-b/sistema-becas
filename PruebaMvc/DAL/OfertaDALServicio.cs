using Newtonsoft.Json;
using PruebaMvc.Models;
using PruebaMvc.ModelsService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace PruebaMvc.DAL
{
    public class OfertaDALServicio
    {

        public OferenteS obtenerOferente(String idOferente)
        {
            OferenteS oferente = new OferenteS();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/offerers/1"); //+ idOferente);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<OferenteS>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<OfertaS> obtenerListaOferta()
        {
            List<OfertaS> oferente = new List<OfertaS>();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/announcements/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<List<OfertaS>>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<OfertaS> obtenerOfertaOferente(String idOferente)
        {
            List<OfertaS> oferente = new List<OfertaS>();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/announcements/offerers/"+ idOferente);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<List<OfertaS>>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public OfertaS obtenerOfertaId(String idOferta)
        {
            OfertaS oferente = new OfertaS();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/announcements/"+ idOferta);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<OfertaS>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}