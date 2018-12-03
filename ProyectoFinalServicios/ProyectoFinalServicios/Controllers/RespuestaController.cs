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
    public class RespuestaController : ApiController
    {
        Encuesta_BL oEncuesta_BL = new Encuesta_BL();
        // GET: api/Respuesta
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Respuesta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Respuesta
        public void Post([FromBody]List<RespuestaModelo> lstRespuesta)
        {
            oEncuesta_BL.RegistrarRespuesta(lstRespuesta);
        }

        // PUT: api/Respuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Respuesta/5
        public void Delete(int id)
        {
        }
    }
}
