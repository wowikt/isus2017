using System;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser
{
    [Serializable]
    public class IsusUserCardBody
    {
        [XmlElement("bodyitem")]
        public IsusUserCardBodyItem Item { get; set; }
    }
}
