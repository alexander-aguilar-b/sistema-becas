using Newtonsoft.Json;
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
        #region Experimento
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
                    oferente = JsonConvert.DeserializeObject<List<ModelsService.OfertaS>>(streamReader.ReadToEnd());
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
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/announcements/offerers/" + idOferente);
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
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/announcements/" + idOferta);
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

        public string aplicarOfertaId(String idOferta, String idSolicitante)
        {

            string resultado = "";

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/application/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"idSolicitante\":" + idSolicitante + ",\"idConvocatoria\":"+ idOferta + "}";
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    resultado = streamReader.ReadToEnd();
                }

                return resultado;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion Experimento

        #region Prototipo

        public OferenteConsulta obtenerOferente(String idOferente)
        {
            OferenteConsulta oferente = new OferenteConsulta();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/offerers/" + idOferente); //+ idOferente);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<OferenteConsulta>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SolicitanteConsulta obtenerSolicitante(String idSolicitante)
        {
            SolicitanteConsulta solicitante = new SolicitanteConsulta();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/applicant/" + idSolicitante); //+ idOferente);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    solicitante = JsonConvert.DeserializeObject<SolicitanteConsulta>(streamReader.ReadToEnd());
                }

                return solicitante;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public OferenteConsulta crearOferente(OferenteCrear oferente)
        {
            string resultado = "";
            OferenteConsulta oferenteNuevo = new OferenteConsulta();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/offerers/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"correoElectronico\":\"" + oferente.correoElectronico +
                        "\",\"contrasena\":\"" + oferente.contrasena + 
                        "\",\"nit\":\"" + oferente.nit + "\",\"nombre\":\"" + oferente.nombre +
                        "\",\"descripcion\":\""+ oferente.descripcion+ "\",\"tipoEntidad\":" + oferente.tipoEntidad.ToString() +
                        ", \"pais\":" + oferente.pais.ToString() + "}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    oferenteNuevo = JsonConvert.DeserializeObject<OferenteConsulta>(streamReader.ReadToEnd());
                }

                return oferenteNuevo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SolicitanteConsulta crearSolicitante(SolicitanteCrear solicitante)
        {
            string resultado = "";
            SolicitanteConsulta solicitanteNuevo = new SolicitanteConsulta();

            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/applicant/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = "{\"correoElectronico\":\"" + solicitante.correoElectronico +
                        "\",\"contrasena\":\"" + solicitante.contrasena +
                        "\",\"nombre\":\"" + solicitante.nombre +
                        "\",\"numero_documento\":\"" + solicitante.numero_documento +
                        "\",\"apellidos\":\"" + solicitante.apellidos +
                        "\",\"id_tipo_documento\":" + solicitante.id_tipo_documento.ToString() +
                        ",\"sexo\":" + solicitante.sexo.ToString() +
                        ", \"id_tipo_poblacion\":" + solicitante.id_tipo_poblacion.ToString() +
                        ",\"pais_nacimiento\":" + solicitante.pais_nacimiento.ToString() +
                        ",\"pais_residencia\":" + solicitante.pais_residencia.ToString() + "}";

                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    solicitanteNuevo = JsonConvert.DeserializeObject<SolicitanteConsulta>(streamReader.ReadToEnd());
                }

                return solicitanteNuevo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /*
        public OferenteCrear crearOferente(OferenteCrear oferente)
        {
            
            OferenteConsulta oferente = new OferenteConsulta();

            try
            {
                PainEpisodeResult painEpisode = new PainEpisodeResult();

                try
                {
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8089/episodioscontrol/pains/mongoepisode/getEpisodeId");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    httpWebRequest.Headers.Add("checkSum", "3862045038");
                    httpWebRequest.Headers.Add("Authorization", "Basic YWRyaWFuYTpDb2xvbWJpYTEu");

                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        string json = "{\"episodeId\":\"" + episodeId + "\"}";
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }

                    PainEpisodeResult routes_list = new PainEpisodeResult();
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        painEpisode = JsonConvert.DeserializeObject<PainEpisodeResult>(streamReader.ReadToEnd());
                    }

                    return painEpisode;
                }
                catch (Exception ex)
                {
                    return null;
                }
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:8080/portal-becas/spring/offerers/1"); //+ idOferente);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    //String respuesta = streamReader.ReadToEnd();
                    oferente = JsonConvert.DeserializeObject<OferenteConsulta>(streamReader.ReadToEnd());
                }

                return oferente;
            }
            catch (Exception ex)
            {
                return null;
            }
        }*/



        #endregion prototipo

    }
}