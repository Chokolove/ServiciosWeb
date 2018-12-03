using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogicaNegocios;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace ProyectoFinalServicios.Controllers
{
    public class EncuestaController : Controller
    {
        Encuesta_BL bl = new Encuesta_BL();

        public ActionResult Lista()
        {
            ViewBag.Title = "Listador Encuesta";
            return View();
        }
        public ActionResult Crear()
        {
            ViewBag.Title = "Crear Encuesta";
            return View();
        }
        public ActionResult Editar(int id)
        {
            ViewBag.Title = "Editar Encuesta";
            return View();
        }


        /*JSON*/
        public JsonResult GetAll(){
            List<EncuestaModel> lst = bl.Listar();
            var obj = new
            {
                data = lst
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}
