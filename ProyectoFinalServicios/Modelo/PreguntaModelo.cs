using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
    public class PreguntaModelo
    {
        [DataMember]
        public int idPregunta { get; set; }
        [DataMember]
        public EncuestaModel encuesta { get; set; }
        [DataMember]
        public String descPregunta { get; set; }
        [DataMember]
        public TipoPreguntaModelo tipoPregunta { get; set; }

        public PreguntaModelo(int idPregunta, EncuestaModel encuesta, string descPregunta, TipoPreguntaModelo tipoPregunta)
        {
            this.idPregunta = idPregunta;
            this.encuesta = encuesta;
            this.descPregunta = descPregunta;
            this.tipoPregunta = tipoPregunta;
        }

        public PreguntaModelo()
        {
            this.idPregunta = 0;
            this.encuesta = new EncuestaModel();
            this.descPregunta = "";
            this.tipoPregunta = new TipoPreguntaModelo();
        }
    }
}
