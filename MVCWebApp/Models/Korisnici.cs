using MVCWebApp.XMLMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Korisnici
    {
        public KupacXML kupacXML = new KupacXML();
        public List<Kupac> listaKupaca { get; set; }

        public Korisnici()
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();
        }

        // ---> [KUPAC] METODE <--- //

        public void RegistrujKupca(Kupac kupac)
        {
            List<Kupac> listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            listaKupaca.Add(kupac);
            kupacXML.XmlSerialize(listaKupaca);

        }

        public bool kupacUsernameAlreadyExists(string korisnickoIme)
        {
            List<Kupac> listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            foreach (var item in listaKupaca)
            {
                if (item.KorisnickoIme == korisnickoIme)
                {
                    return true;
                }
                else
                {
                    //listaGostiju.Add(item);
                }
            }
            return false;
        }
    }
}