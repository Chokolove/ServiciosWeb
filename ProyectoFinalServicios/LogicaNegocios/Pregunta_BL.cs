using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using AccesoDatos;

namespace LogicaNegocios
{
    public class Pregunta_BL
    {
        private Pregunta_SD oPregunta = new Pregunta_SD();
        public List<TipoPreguntaModelo> ListarTipos()
        {
            try
            {
                return oPregunta.ListarTipos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

    }
}
