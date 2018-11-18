using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class TipoUsuarioModel : ModeloBase
    {
        public enum CAMPOS
        {
            IdTipoUsuario = 0,
            NomTipoUsuario = 1
        }
        [DataMember]
        public int IdTipoUsuario { get; set; }
        [DataMember]
        public String NomTipoUsuario { get; set; }

        

        public TipoUsuarioModel(int idTipoUsuario, string nomTipoUsuario)
        {
            IdTipoUsuario = idTipoUsuario;
            NomTipoUsuario = nomTipoUsuario;
        }

        public TipoUsuarioModel()
        {
            IdTipoUsuario = 0;
            NomTipoUsuario = "";
        }
    }
}
