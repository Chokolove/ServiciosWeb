using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class EncuestaModel : ModeloBase
    {
        public enum CAMPOS
        {
            IdEncuesta=0,
            Usuario=1,
            NomEncuesta=2,
            ContRespuestas=3,
            FchaCreacion=4,
            Estado=5
        }

        [DataMember]
        public int IdEncuesta { get; set; }
        [DataMember]
        public UsuarioModelo Usuario { get; set; }
        [DataMember]
        public String NomEncuesta { get; set; }
        [DataMember]
        public int ContRespuestas { get; set; }
        [DataMember]
        public String FchaCreacion { get; set; }
        [DataMember]
        public TipoEstadoModelo TipoEstado { get; set; }

        public EncuestaModel(int idEncuesta, UsuarioModelo usuario, string nomEncuesta, int contRespuestas, string fchaCreacion, TipoEstadoModelo tipoEstado)
        {
            IdEncuesta = idEncuesta;
            Usuario = usuario;
            NomEncuesta = nomEncuesta;
            ContRespuestas = contRespuestas;
            FchaCreacion = fchaCreacion;
            TipoEstado = tipoEstado;
        }

        public EncuestaModel()
        {
            IdEncuesta = 0;
            Usuario = new UsuarioModelo();
            NomEncuesta = "";
            ContRespuestas = 0;
            FchaCreacion = "";
            TipoEstado = new TipoEstadoModelo();
        }
    }
}
