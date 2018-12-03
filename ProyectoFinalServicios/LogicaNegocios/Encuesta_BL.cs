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
        public List<RespuestaModelo> ListarEncuestaCompleta(int id)
        {
            try
            {
                return oEncuesta_SD.ListarEncuestaCompleta(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String RegistraEncuesta(EncuestaModel encuesta)
        {
            try
            {
                return oEncuesta_SD.RegistraEncuesta(encuesta);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public List<String> RegistraPreguntas(List<PreguntaModelo> lstPreguntas)
        {
            try
            {
                return oEncuesta_SD.RegistraPreguntas(lstPreguntas);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public String RegistrarRespuesta(List<RespuestaModelo> lstRepuesta)
        {
            try
            {
                return oEncuesta_SD.RegistraRespuestas(lstRepuesta);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
