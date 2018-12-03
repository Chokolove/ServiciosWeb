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
            FechaCreacion=5,
            TipoUsuario =6,
            Estado =7,
            Token=8,
            App_secret=9
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
        public String FechaCreacion { get; set; }
        [DataMember]
        public TipoUsuarioModel TipoUsuario { get; set; }
        [DataMember]
        public TipoEstadoModelo TipoEstado { get; set; }
        [DataMember]
        public String Token { get; set; }
        [DataMember]
        public String App_secret { get; set; }

        public UsuarioModelo(int idUsuario, string login, string pass, string nomUsu, EmpresaModelo empresa, string fechaCreacion, TipoUsuarioModel tipoUsuario, TipoEstadoModelo tipoEstado, string token, string app_secret)
        {
            IdUsuario = idUsuario;
            Login = login;
            Pass = pass;
            NomUsu = nomUsu;
            Empresa = empresa;
            FechaCreacion = fechaCreacion;
            TipoUsuario = tipoUsuario;
            TipoEstado = tipoEstado;
            Token = token;
            App_secret = app_secret;
        }

        public UsuarioModelo()
        {
            IdUsuario = 0;
            Login = "";
            Pass = "";
            NomUsu = "";
            Empresa = new EmpresaModelo();
            FechaCreacion = "";
            TipoUsuario = new TipoUsuarioModel();
            TipoEstado = new TipoEstadoModelo();
            Token = "";
            App_secret = "";
        }
    }
}
