using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogicaNegocios;

namespace ProyectoFinalServicios.Controllers
{
    public class EncuestaController : ApiController
    {
        public IEnumerable<EncuestaModel> Get()
        {
            return new Encuesta_BL().Listar();
        }
    }
}
