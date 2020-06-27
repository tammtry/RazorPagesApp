using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class KupacXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Kupci.xml");

        public void XmlSerialize(List<Kupac> kupci)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Kupac>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, kupci);
            }
        }

        public List<Kupac> XmlDeserialize()
        {
            List<Kupac> getKupci = new List<Kupac>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Kupac>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getKupci = (List<Kupac>)obj;
                }
            }
            else
            {
                getKupci = new List<Kupac>();
            }

            return getKupci;
        }
    }
}
