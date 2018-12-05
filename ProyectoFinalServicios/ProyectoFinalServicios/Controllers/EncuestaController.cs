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
        Pregunta_BL pbl = new Pregunta_BL();

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
                status = 1,
                message = "ok",
                data = lst
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        /*JSON*/
        public JsonResult GetTypeQuestion()
        {
            List<TipoPreguntaModelo> lst = pbl.ListarTipos();
            var obj = new
            {
                status = 1,
                message = "ok",
                data = lst
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        // POST: JSON
        public JsonResult UpdateQuiz([FromBody]EncuestaModel encuesta, List<PreguntaModelo> lstPreg, List<RespuestaModelo> lstResp)
        {
            EncuestaModel oEncuesta = new EncuestaModel();
            String idEncuesta = encuesta.NomEncuesta;
            var obj = new
            {
                status = 1,
                message = "ok",
                data = idEncuesta
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
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
