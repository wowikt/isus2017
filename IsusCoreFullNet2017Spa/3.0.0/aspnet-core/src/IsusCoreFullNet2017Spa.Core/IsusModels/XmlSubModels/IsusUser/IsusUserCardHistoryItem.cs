using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser
{
    [Serializable]
    public class IsusUserCardHistoryItem
    {
        [XmlAttribute("attr")]
        public string Attr { get; set; }

        [XmlAttribute("date")]
        public string DateText { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get => DateTime.ParseExact(DateText, "yyyyMMdd", CultureInfo.InvariantCulture);
            set => DateText = value.ToString("yyyyMMdd");
        }

        [XmlAttribute("value")]
        public string Value { get; set; }
    }
}
