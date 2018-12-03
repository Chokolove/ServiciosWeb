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
using System.Web.Http.Results;

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
        // GET api/Encuesta
        public IEnumerable<EncuestaModel> Get()
        {
            return bl.Listar();
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
        // POST: api/Encuesta
        public void Post([FromBody]EncuestaModel encuesta)
        {
            bl.RegistraEncuesta(encuesta); 
        }

        // PUT: api/Encuesta/id
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Encuesta/id
        public void Delete(int id)
        {
        }
    }
}
