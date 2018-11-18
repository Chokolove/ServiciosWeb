using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [DataContract]
    public class UsuarioModelo : ModeloBase
    {
        public enum CAMPOS
        {
            IdUsuario=0,
            Login=1,
            Pass=2,
            NomUsu=3,
            Empresa=4,
            FchaCreacion=5,
            TipoUsuario =6,
            Estado =7
        }

        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public String Login { get; set; }
        [DataMember]
        public String Pass { get; set; }
        [DataMember]
        public String NomUsu { get; set; }
        [DataMember]
        public EmpresaModelo Empresa { get; set; }
        [DataMember]
        public String FchaCreacion { get; set; }
        [DataMember]
        public TipoUsuarioModel TipoUsuario { get; set; }
        [DataMember]
        public TipoEstadoModelo TipoEstado { get; set; }

        public UsuarioModelo(int idUsuario, string login, string pass, string nomUsu, EmpresaModelo empresa, string fchaCreacion, TipoUsuarioModel tipoUsuario, TipoEstadoModelo tipoEstado)
        {
            IdUsuario = idUsuario;
            Login = login;
            Pass = pass;
            NomUsu = nomUsu;
            Empresa = empresa;
            FchaCreacion = fchaCreacion;
            TipoUsuario = tipoUsuario;
            TipoEstado = tipoEstado;
        }

        public UsuarioModelo()
        {
            IdUsuario = 0;
            Login = "";
            Pass = "";
            NomUsu = "";
            Empresa = new EmpresaModelo();
            FchaCreacion = "";
            TipoUsuario = new TipoUsuarioModel();
            TipoEstado = new TipoEstadoModelo();
        }
    }
}
