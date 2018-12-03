using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
    public class RespuestaModelo
    {
        [DataMember]
        public int idRespuesta { get; set; }
        [DataMember]
        public PreguntaModelo pregunta { get; set; }
        [DataMember]
        public String  descRespuesta { get; set; }

        public RespuestaModelo(int idRespuesta, PreguntaModelo pregunta, string descRespuesta)
        {
            this.idRespuesta = idRespuesta;
            this.pregunta = pregunta;
            this.descRespuesta = descRespuesta;
        }

        public RespuestaModelo()
        {
            this.idRespuesta = 0;
            this.pregunta = new PreguntaModelo();
            this.descRespuesta = "";
        }
    }
}
