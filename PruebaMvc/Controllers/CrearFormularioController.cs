using PruebaMvc.DAL;
using PruebaMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PruebaMvc.Controllers
{
    public class CrearFormularioController : Controller
    {
        private String cedula = "1023";
        FormularioDAL formularioDAL = new FormularioDAL();
        String connString = ConfigurationManager.ConnectionStrings["PortalBecas"].ConnectionString;

        [Authorize(Roles = "Administrador,Oferente")]
        public ActionResult CrearFormulario()
        {
            Items lista = new Items(cedula);

            return View(lista);
        }

        [Authorize(Roles = "Administrador,Oferente")]
        [MultipleButton(Name = "action", Argument = "AgregarItem")]
        public ActionResult AgregarItem(String cedula, String nombreItem, String tipoControl, String tipoDelimitador, String opciones, Items items)
        {
            Items listaItems = new Items();
            try
            {
                Item item = new Item();
                item.Descripcion = nombreItem;
                item.IdTipoControl = Convert.ToInt16(tipoControl);
                if (opciones.Trim() != "")
                {
                    List<Respuesta> listaRespuestas = new List<Respuesta>();
                    String[] respuestas = opciones.Split(Convert.ToChar(tipoDelimitador));

                    foreach (String respuesta in respuestas)
                    {
                        Respuesta respuestaItem = new Respuesta { respuesta = respuesta };
                        listaRespuestas.Add(respuestaItem);
                    }

                    item.lstRespuestas = listaRespuestas;
                }

                List<Item> lista = new List<Item>();
                if (items.lstItems != null)
                {
                    lista = items.lstItems;
                }
                lista.Add(item);
                listaItems.lstItems = lista;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al gestionar el formulario" + ex.Message;
            }

            return View("~/Views/CrearFormulario/CrearFormulario.cshtml", listaItems);
        }

        [Authorize(Roles = "Administrador,Oferente")]
        [MultipleButton(Name = "action", Argument = "GuardarFormulario")]
        public ActionResult GuardarFormulario(String cedula, Items items)
        {
            try
            {
                formularioDAL.crearFormulario(cedula, items);
                ViewBag.Message = "El formulario fue creado correctamente";
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Hubo un error al crear el formulario. " + ex.Message;
            }

            return View("~/Views/CrearFormulario/CrearFormulario.cshtml");
        }

        [Authorize(Roles = "Administrador,Oferente")]
        [MultipleButton(Name = "action", Argument = "BorrarFormulario")]
        public ActionResult BorrarFormulario(Items items)
        {
            try
            {
                formularioDAL.borrarFormulario(cedula);
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Hubo un error al gestionar el formulario" + ex.Message;
            }

            return View("~/Views/CrearFormulario/CrearFormulario.cshtml");
        }
    }

}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
public class MultipleButtonAttribute : ActionNameSelectorAttribute
{
    public string Name { get; set; }
    public string Argument { get; set; }

    public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
    {
        var isValidName = false;
        var keyValue = string.Format("{0}:{1}", Name, Argument);
        var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

        if (value != null)
        {
            controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
            isValidName = true;
        }

        return isValidName;
    }
}


