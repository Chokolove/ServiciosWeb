using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Modelo
{
    [DataContract]
    public class ModeloBase
    {
        [DataMember]
        public int CodigoError { get; set; }
        [DataMember]
        public String MensajeError { get; set; }
        [DataMember]
        public Boolean Eliminado { get; set; }

    }
}
