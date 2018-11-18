using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Encuesta_BL
    {
        private Encuesta_SD oEncuesta_SD = new Encuesta_SD();
        public List<EncuestaModel> Listar()
        {
            try
            {
                return oEncuesta_SD.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
