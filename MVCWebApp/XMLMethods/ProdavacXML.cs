using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class ProdavacXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Prodavci.xml");

        public void XmlSerialize(List<Prodavac> prodavci)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Prodavac>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, prodavci);
            }
        }

        public List<Prodavac> XmlDeserialize()
        {
            List<Prodavac> getProdavci = new List<Prodavac>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Prodavac>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getProdavci = (List<Prodavac>)obj;
                }
            }
            else
            {
                getProdavci = new List<Prodavac>();
            }

            return getProdavci;
        }
    }
}