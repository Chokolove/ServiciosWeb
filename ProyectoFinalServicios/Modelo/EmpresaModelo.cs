using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class EmpresaModelo : ModeloBase
    {
        public enum CAMPOS
        {
            IdEmpresa =0,
            NomEmpresa =1,
            TipoEmpresa=2,
            FechaCreacion=3,
            Estado=4
        }
        [DataMember]
        public int IdEmpresa { get; set; }
        [DataMember]
        public String NomEmpresa { get; set; }
        [DataMember]
        public TipoEmpresaModel TipoEmpresa { get; set; }
        [DataMember]
        public String FechaCreacion { get; set; }
        [DataMember]
        public TipoEstadoModelo TipoEstado { get; set; }

        public EmpresaModelo(int idEmpresa, string nomEmpresa, TipoEmpresaModel tipoEmpresa, string fchaCreacion, TipoEstadoModelo tipoEstado)
        {
            IdEmpresa = idEmpresa;
            NomEmpresa = nomEmpresa;
            TipoEmpresa = tipoEmpresa;
            FechaCreacion = fchaCreacion;
            TipoEstado = tipoEstado;
        }

        public EmpresaModelo()
        {
            IdEmpresa = 0;
            NomEmpresa = "";
            TipoEmpresa = new TipoEmpresaModel();
            FechaCreacion = "";
            TipoEstado = new TipoEstadoModelo();
        }
    }
}
