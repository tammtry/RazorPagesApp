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

        public AdministratorXML administratorXML = new AdministratorXML();
        public List<Administrator> listaAdministratora { get; set; }

        public KorisnikXML korisnikXML = new KorisnikXML();
        public List<Korisnik> listaKorisnika { get; set; }

        public Korisnici()
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            listaAdministratora = new List<Administrator>();
            listaAdministratora = administratorXML.XmlDeserialize();

            listaKorisnika = new List<Korisnik>();
            listaKorisnika = korisnikXML.XmlDeserialize();
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

        // ---> [ADMINISTRATOR] METODE <--- //

        public bool SearchForAdministrator(string korisnickoIme, string lozinka)
        {
            listaAdministratora = new List<Administrator>();
            listaAdministratora = administratorXML.XmlDeserialize();

            foreach (var item in listaAdministratora)
            {
                if (item.KorisnickoIme == korisnickoIme && item.Lozinka == lozinka)
                {
                    return true;
                }
            }
            return false;
        }

        public string AddAdmin(Korisnik user) 
        {
            if (SearchForAdministrator(user.KorisnickoIme, user.Lozinka))
            {
                if (!listaAdministratora.Contains(user))
                {
                    this.listaKorisnika.Add(user);
                }
            }
            return user.KorisnickoIme;
        }

        public Administrator IscitajAdministratora(string KorisnickoIme)
        {
            listaAdministratora = new List<Administrator>();
            listaAdministratora = administratorXML.XmlDeserialize();

            Administrator retAdmin = new Administrator();
            List<Administrator> retVal = new List<Administrator>();

            foreach (var item in listaAdministratora)
            {
                if (item.KorisnickoIme == KorisnickoIme)
                {
                    retAdmin.KorisnickoIme = item.KorisnickoIme;
                    retAdmin.Lozinka = item.Lozinka;
                    retAdmin.Ime = item.Ime;
                    retAdmin.Prezime = item.Prezime;
                    
                    //retVal.Add(retAdmin);
                }
            }
            return retAdmin;
        }

    }
}