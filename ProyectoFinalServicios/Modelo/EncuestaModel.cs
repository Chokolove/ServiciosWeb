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
            FechaCreacion = 3,
            Estado=4
        }

        [DataMember]
        public int IdEncuesta { get; set; }
        [DataMember]
        public UsuarioModelo Usuario { get; set; }
        [DataMember]
        public String NomEncuesta { get; set; }
        [DataMember]
        public String FechaCreacion { get; set; }
        [DataMember]
        public TipoEstadoModelo TipoEstado { get; set; }
        [DataMember]
        public int cantPreg { get; set; }

        public EncuestaModel(int idEncuesta, UsuarioModelo usuario, string nomEncuesta, int contRespuestas, string fechaCreacion, TipoEstadoModelo tipoEstado)
        {
            IdEncuesta = idEncuesta;
            Usuario = usuario;
            NomEncuesta = nomEncuesta;
            FechaCreacion = fechaCreacion;
            TipoEstado = tipoEstado;
        }

        public EncuestaModel()
        {
            IdEncuesta = 0;
            Usuario = new UsuarioModelo();
            NomEncuesta = "";
            FechaCreacion = "";
            TipoEstado = new TipoEstadoModelo();
        }
    }
}
