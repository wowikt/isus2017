using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IsusCoreFullNet2017Spa.Infrastructure
{
    public class XmlSerializationProvider
    {
        public static string Serialize<T>(T obj) where T : class
        {
            if (obj == null)
            {
                return null;
            }

            var serializer = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            using (var sw = new StringWriter())
            {
                using (var xtw = new XmlTextWriter(sw))
                {
                    serializer.Serialize(xtw, obj, ns);
                }

                return sw.ToString();
            }
        }

        public static T Deserialize<T>(string data) where T : class
        {
            if (data == null)
            {
                return null;
            }

            var serializer = new XmlSerializer(typeof(T));
            using (var sr = new StringReader(data))
            {
                using (var xtr = new XmlTextReader(sr))
                {
                    return serializer.Deserialize(xtr) as T;
                }
            }
        }
    }
}
