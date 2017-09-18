using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser
{
    [Serializable]
    [XmlRoot("doc")]
    public class IsusUserCard
    {
        [XmlElement("body")]
        public IsusUserCardBody Body { get; set; }

        [XmlArray("history")]
        [XmlArrayItem(ElementName ="historyitem")]
        public IsusUserCardHistoryItem[] History { get; set; }
    }
}
