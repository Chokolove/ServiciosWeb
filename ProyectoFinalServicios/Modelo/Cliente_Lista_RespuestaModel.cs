using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
    public class Cliente_Lista_RespuestaModel
    {
        [DataMember]
        public int idClienteListaRespuesta { get; set; }
        [DataMember]
        public Cliente_EncuestaModel clienteEncuesta { get; set; }
        [DataMember]
        public PreguntaModelo pregunta { get; set; }
        [DataMember]
        public RespuestaModelo respuesta { get; set; }
        [DataMember]
        public String fechaCreacion { get; set; }

        public Cliente_Lista_RespuestaModel(int idClienteListaRespuesta, Cliente_EncuestaModel clienteEncuesta, PreguntaModelo pregunta, RespuestaModelo respuesta, string fechaCreacion)
        {
            this.idClienteListaRespuesta = idClienteListaRespuesta;
            this.clienteEncuesta = clienteEncuesta;
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.fechaCreacion = fechaCreacion;
        }

        public Cliente_Lista_RespuestaModel()
        {
            this.idClienteListaRespuesta = 0;
            this.clienteEncuesta = new Cliente_EncuestaModel();
            this.pregunta = new PreguntaModelo();
            this.respuesta = new RespuestaModelo();
            this.fechaCreacion = "";
        }
    }
}
