using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class KomentarXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Komentari.xml");

        public void XmlSerialize(List<Komentar> komentari)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Komentar>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, komentari);
            }
        }

        public List<Komentar> XmlDeserialize()
        {
            List<Komentar> getKomentari = new List<Komentar>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Komentar>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getKomentari = (List<Komentar>)obj;
                }
            }
            else
            {
                getKomentari = new List<Komentar>();
            }

            return getKomentari;
        }
    }
}