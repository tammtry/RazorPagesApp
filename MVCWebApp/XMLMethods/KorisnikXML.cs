using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MVCWebApp.XMLMethods
{
    public class KorisnikXML
    {
        private readonly string path = System.Web.HttpContext.Current.Server.MapPath("~/Models/Xml/Korisnici.xml");

        public void XmlSerialize(List<Korisnik> korisnici)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Korisnik>));

            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, korisnici);
            }
        }

        public List<Korisnik> XmlDeserialize()
        {
            List<Korisnik> getKorisnici = new List<Korisnik>();

            if (File.Exists(path))
            {
                XmlSerializer xmlDeserializer = new XmlSerializer(typeof(List<Korisnik>));
                using (TextReader reader = new StreamReader(path))
                {
                    object obj = xmlDeserializer.Deserialize(reader);
                    getKorisnici = (List<Korisnik>)obj;
                }
            }
            else
            {
                getKorisnici = new List<Korisnik>();
            }

            return getKorisnici;
        }
    }
}