using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.IsusModels.XmlSubModels.IsusUser
{
    [Serializable]
    public class IsusUserCardBodyItem
    {
        [XmlAttribute("I")]
        public string FirstName { get; set; }

        [XmlAttribute("F")]
        public string LastName { get; set; }

        [XmlAttribute("O")]
        public string MiddleName { get; set; }

        [XmlAttribute("Sex")]
        public int Gender { get; set; }

        [XmlAttribute("Birthdate")]
        public string BirthdateText { get; set; }

        [XmlIgnore]
        public DateTime Birthdate
        {
            get => DateTime.ParseExact(BirthdateText, "yyyyMMdd", CultureInfo.InvariantCulture);
            set => BirthdateText = value.ToString("yyyyMMdd");
        }

        [XmlAttribute("INN")]
        public string Inn { get; set; }

        [XmlAttribute("Strah")]
        public string Strah { get; set; }

        [XmlAttribute("Passport")]
        public string Passport { get; set; }

        [XmlAttribute("Info")]
        public string Info { get; set; }

        [XmlAttribute("Tel")]
        public string Tel { get; set; }

        [XmlAttribute("AddressReg")]
        public string AddressReg { get; set; }

        [XmlAttribute("AddressFact")]
        public string AddressFact { get; set; }

        [XmlAttribute("Contacts")]
        public string Contacts { get; set; }
    }
}
