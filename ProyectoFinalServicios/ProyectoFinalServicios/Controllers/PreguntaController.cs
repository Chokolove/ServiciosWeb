using LogicaNegocios;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoFinalServicios.Controllers
{
    public class PreguntaController : ApiController
    {
        Encuesta_BL oEncuesta_BL = new Encuesta_BL();
        // GET: api/Pregunta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pregunta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pregunta
        public void Post([FromBody]List<PreguntaModelo> lstPregunta)
        {
            oEncuesta_BL.RegistraPreguntas(lstPregunta);
        }

        // PUT: api/Pregunta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pregunta/5
        public void Delete(int id)
        {
        }
    }
}
