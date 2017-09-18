using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser
{
    [Serializable]
    public class IsusUserCardHistory
    {
        [XmlElement("historyitem")]
        public IsusUserCardBody[] Body { get; set; }
    }
}
