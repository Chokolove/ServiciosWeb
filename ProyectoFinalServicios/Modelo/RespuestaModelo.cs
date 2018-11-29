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
        [DataMember]
        public int contRespuesta { get; set; }

        public RespuestaModelo(int idRespuesta, PreguntaModelo pregunta, string descRespuesta, int contRespuesta)
        {
            this.idRespuesta = idRespuesta;
            this.pregunta = pregunta;
            this.descRespuesta = descRespuesta;
            this.contRespuesta = contRespuesta;
        }

        public RespuestaModelo()
        {
            this.idRespuesta = 0;
            this.pregunta = new PreguntaModelo();
            this.descRespuesta = "";
            this.contRespuesta = 0;
        }
    }
}
