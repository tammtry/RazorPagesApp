using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class KartaXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Karte.xml");

        public void XmlSerialize(List<Karta> karte)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Karta>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, karte);
            }
        }

        public List<Karta> XmlDeserialize()
        {
            List<Karta> getKarte = new List<Karta>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Karta>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getKarte = (List<Karta>)obj;
                }
            }
            else
            {
                getKarte = new List<Karta>();
            }

            return getKarte;
        }
    }
}