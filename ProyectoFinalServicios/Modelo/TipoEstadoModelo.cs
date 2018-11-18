using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class TipoEstadoModelo : ModeloBase
    {
        public enum CAMPOS
        {
            IdTipoEstado = 0,
            NomTipoEstado = 1
        }

        [DataMember]
        public int IdTipoEstado { get; set; }
        [DataMember]
        public String NomTipoEstado { get; set; }

        public TipoEstadoModelo(int idTipoEstado, string nomTipoEstado)
        {
            IdTipoEstado = idTipoEstado;
            NomTipoEstado = nomTipoEstado;
        }

        public TipoEstadoModelo()
        {
            IdTipoEstado = 0;
            NomTipoEstado = "";
        }
    }
}
