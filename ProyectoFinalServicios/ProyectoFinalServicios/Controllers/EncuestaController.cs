using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogicaNegocios;
using System.Web.Http.Results;

namespace ProyectoFinalServicios.Controllers
{
    public class EncuestaController : ApiController
    {
        Encuesta_BL oEncuesta_BL = new Encuesta_BL();
        // GET api/Encuesta
        public IEnumerable<EncuestaModel> Get()
        {
            return oEncuesta_BL.Listar();
        }

        // GET api/Encuesta/id
        public IEnumerable<RespuestaModelo> Get(int id)
        {
            return oEncuesta_BL.ListarEncuestaCompleta(id);
        }
        // POST: api/Encuesta
        public void Post([FromBody]EncuestaModel encuesta)
        {
            oEncuesta_BL.RegistraEncuesta(encuesta); 
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
