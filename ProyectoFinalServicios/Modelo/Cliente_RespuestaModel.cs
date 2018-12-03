using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Modelo
{
    [DataContract]
    public class Cliente_RespuestaModel
    {
        [DataMember]
        public int idClienteRespuesta { get; set; }
        [DataMember]
        public Cliente_EncuestaModel clienteEncuesta { get; set; }
        [DataMember]
        public PreguntaModelo pregunta { get; set; }
        [DataMember]
        public String string_value { get; set; }
        [DataMember]
        public int int_value { get; set; }
        [DataMember]
        public double double_value { get; set; }
        [DataMember]
        public String fechaCreacion { get; set; }

        public Cliente_RespuestaModel(int idClienteRespuesta, Cliente_EncuestaModel clienteEncuesta, PreguntaModelo pregunta, string string_value, int int_value, double double_value, string fechaCreacion)
        {
            this.idClienteRespuesta = idClienteRespuesta;
            this.clienteEncuesta = clienteEncuesta;
            this.pregunta = pregunta;
            this.string_value = string_value;
            this.int_value = int_value;
            this.double_value = double_value;
            this.fechaCreacion = fechaCreacion;
        }

        public Cliente_RespuestaModel()
        {
            this.idClienteRespuesta = 0;
            this.clienteEncuesta = new Cliente_EncuestaModel();
            this.pregunta = new PreguntaModelo();
            this.string_value = "";
            this.int_value = 0;
            this.double_value = 0;
            this.fechaCreacion = "";
        }
    }
}
