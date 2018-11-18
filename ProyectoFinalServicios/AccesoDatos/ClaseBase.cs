using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace AccesoDatos
{
    public class ClaseBase
    {
        public String CadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["ocn"].ConnectionString;
        }
    }
}
