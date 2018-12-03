using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class Usuario_EmpresaModel
    {
        [DataMember]
        public int idUsuarioEmpresa { get; set; }
        [DataMember]
        public EmpresaModelo empresa { get; set; }
        [DataMember]
        public UsuarioModelo usuario { get; set; }

        public Usuario_EmpresaModel(int idUsuarioEmpresa, EmpresaModelo empresa, UsuarioModelo usuario)
        {
            this.idUsuarioEmpresa = idUsuarioEmpresa;
            this.empresa = empresa;
            this.usuario = usuario;
        }

        public Usuario_EmpresaModel()
        {
            this.idUsuarioEmpresa = 0;
            this.empresa = new EmpresaModelo();
            this.usuario = new UsuarioModelo();
        }
    }
}
