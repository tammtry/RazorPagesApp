using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class AdministratorXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Administratori.xml");

        public void XmlSerialize(List<Administrator> administratori)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Administrator>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, administratori);
            }
        }

        public List<Administrator> XmlDeserialize()
        {
            List<Administrator> getAdministratori = new List<Administrator>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Administrator>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getAdministratori = (List<Administrator>)obj;
                }
            }
            else
            {
                getAdministratori = new List<Administrator>();
            }

            return getAdministratori;
        }
    }
}