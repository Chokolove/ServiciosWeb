using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class TipoEmpresaModel : ModeloBase
    {
        public enum CAMPOS
        {
            IdTipoEmpresa = 0,
            NomTipoEmpresa = 1
        }
        [DataMember]
        public int IdTipoEmpresa { get; set; }
        [DataMember]
        public String NomTipoEmpresa { get; set; }

        public TipoEmpresaModel(int idTipoEmpresa, string nomTipoEmpresa)
        {
            IdTipoEmpresa = idTipoEmpresa;
            NomTipoEmpresa = nomTipoEmpresa;
        }

        public TipoEmpresaModel()
        {
            IdTipoEmpresa = 0;
            NomTipoEmpresa = "";
        }
    }
}
