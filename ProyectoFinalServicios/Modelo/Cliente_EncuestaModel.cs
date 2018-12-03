using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class Cliente_EncuestaModel
    {
        [DataMember]
        public int idClienteEncuesta { get; set; }
        [DataMember]
        public EncuestaModel encuesta { get; set; }
        [DataMember]
        public String  UserAgent { get; set; }
        [DataMember]
        public String  FechaCreacion { get; set; }

        public Cliente_EncuestaModel(int idClienteEncuesta, EncuestaModel encuesta, string userAgent, string fechaCreacion)
        {
            this.idClienteEncuesta = idClienteEncuesta;
            this.encuesta = encuesta;
            UserAgent = userAgent;
            FechaCreacion = fechaCreacion;
        }

        public Cliente_EncuestaModel()
        {
            this.idClienteEncuesta = 0;
            this.encuesta = new EncuestaModel();
            UserAgent = "";
            FechaCreacion = "";
        }
    }
}
