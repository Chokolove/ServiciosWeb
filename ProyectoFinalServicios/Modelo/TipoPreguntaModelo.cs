using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
    public class TipoPreguntaModelo
    {
        [DataMember]
        public int idTipoPregunta { get; set; }
        [DataMember]
        public String nomTipoPregunta { get; set; }

        public TipoPreguntaModelo(int idTipoPregunta, string nomTipoPregunta)
        {
            this.idTipoPregunta = idTipoPregunta;
            this.nomTipoPregunta = nomTipoPregunta;
        }
        public TipoPreguntaModelo()
        {
            this.idTipoPregunta = 0;
            this.nomTipoPregunta = "";
        }
    }
}
