using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class ManifestacijaXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Manifestacije.xml");

        public void XmlSerialize(List<Manifestacija> manifestacije)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Manifestacija>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, manifestacije);
            }
        }

        public List<Manifestacija> XmlDeserialize()
        {
            List<Manifestacija> getManifestacije = new List<Manifestacija>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Manifestacija>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getManifestacije = (List<Manifestacija>)obj;
                }
            }
            else
            {
                getManifestacije = new List<Manifestacija>();
            }

            return getManifestacije;
        }
    }
}