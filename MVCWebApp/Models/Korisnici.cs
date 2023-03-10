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

        public ProdavacXML prodavacXML = new ProdavacXML();
        public List<Prodavac> listaProdavaca { get; set; }

        public ManifestacijaXML manifestacijaXML = new ManifestacijaXML();
        public List<Manifestacija> listaManifestacija { get; set; }

        public KartaXML kartaXML = new KartaXML();
        public List<Karta> listaKarata { get; set; }

        public KomentarXML komentarXML = new KomentarXML();
        public List<Komentar> listaKomentara { get; set; }



        public Korisnici()
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            listaAdministratora = new List<Administrator>();
            listaAdministratora = administratorXML.XmlDeserialize();

            listaKorisnika = new List<Korisnik>();
            listaKorisnika = korisnikXML.XmlDeserialize();

            listaProdavaca = new List<Prodavac>();
            listaProdavaca = prodavacXML.XmlDeserialize();

            listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            listaKomentara = new List<Komentar>();
            listaKomentara = komentarXML.XmlDeserialize();

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

        public string AddKupac(Korisnik user)
        {
            if (SearchForKupac(user.KorisnickoIme, user.Lozinka))
            {
                if (!listaKupaca.Contains(user))
                {
                    this.listaKorisnika.Add(user);
                }
            }
            return user.KorisnickoIme;
        }

        public bool SearchForKupac(string korisnickoIme, string lozinka)
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            foreach (var item in listaKupaca)
            {
                if (item.KorisnickoIme == korisnickoIme && item.Lozinka == lozinka)
                {
                    return true;
                }
            }
            return false;
        }

        public Kupac IscitajKupca(string KorisnickoIme)
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            Kupac retKupac = new Kupac();
            List<Kupac> retVal = new List<Kupac>();

            foreach (var item in listaKupaca)
            {
                if (item.KorisnickoIme == KorisnickoIme)
                {
                    retKupac.KorisnickoIme = item.KorisnickoIme;
                    retKupac.Lozinka = item.Lozinka;
                    retKupac.Ime = item.Ime;
                    retKupac.Prezime = item.Prezime;

                    //retVal.Add(retAdmin);
                }
            }
            return retKupac;
        }

        public void IzmeniKupca(Kupac k, Kupac stariKupac)
        {
            listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            foreach (var item in listaKupaca)
            {
                if (item.KorisnickoIme.Contains(stariKupac.KorisnickoIme))
                {
                    item.KorisnickoIme = k.KorisnickoIme;
                    item.Lozinka = k.Lozinka;
                    item.Ime = k.Ime;
                    item.Prezime = k.Prezime;
                    item.Pol = k.Pol;
                    item.Uloga = k.Uloga;


                    kupacXML.XmlSerialize(listaKupaca);
                }
            }

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

        public void IzmeniAdministratora(Administrator a, Administrator stariAdmin)
        {
            listaAdministratora = new List<Administrator>();
            listaAdministratora = administratorXML.XmlDeserialize();

            foreach (var item in listaAdministratora)
            {
                if (item.KorisnickoIme.Contains(stariAdmin.KorisnickoIme))
                {
                    item.KorisnickoIme = a.KorisnickoIme;
                    item.Lozinka = a.Lozinka;
                    item.Ime = a.Ime;
                    item.Prezime = a.Prezime;
                    item.Pol = a.Pol;
                    item.Uloga = a.Uloga;
                    

                    administratorXML.XmlSerialize(listaAdministratora);
                }
            }

        }

        public List<Karta> IscitajListuKarataAdmin()
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            return listaKarata;
        }

        public List<Kupac> IscitajListuKupaca()
        {
            List<Kupac> listaKupaca = new List<Kupac>();
            listaKupaca = kupacXML.XmlDeserialize();

            return listaKupaca;
        }

        public List<Prodavac> IscitajListuProdavaca()
        {
            List<Prodavac> listaProdavaca = new List<Prodavac>();
            listaProdavaca = prodavacXML.XmlDeserialize();

            return listaProdavaca;
        }

        public Tuple<List<Kupac>, List<Prodavac>> IscitajListuKorisnika()
        {
            List<Kupac> listaKupaca = new List<Kupac>();
            listaKupaca = IscitajListuKupaca();

            List<Prodavac> listaProdavaca = new List<Prodavac>();
            listaProdavaca = IscitajListuProdavaca();

            Tuple<List<Kupac>, List<Prodavac>> retKorisnici = new Tuple<List<Kupac>, List<Prodavac>>(listaKupaca, listaProdavaca);
            return retKorisnici;
        }

        //------------------ [ADMINISTRATOR] sortiranje, filtriranje i pretraga ------------------ //

        

        public Tuple<List<Kupac>, List<Prodavac>> SearchUsersByName(string name)
        {
            List<Kupac> listaKupaca = IscitajListuKupaca();
            List<Prodavac> listaProdavaca = IscitajListuProdavaca();

            Tuple<List<Kupac>, List<Prodavac>> retUsers = new Tuple<List<Kupac>, List<Prodavac>>(listaKupaca, listaProdavaca);

            List<Kupac> retListaKupaca = new List<Kupac>();
            List<Prodavac> retListaProdavaca = new List<Prodavac>(); 

            List<Kupac> retKupac = new List<Kupac>();
            List<Prodavac> retProdavac = new List<Prodavac>();

            foreach (var item in retUsers.Item1)
            {
                if(item.Ime.ToLower().Equals(name.ToLower()))
                {
                    retListaKupaca.Add(item);
                }
            }

            foreach (var item2 in retUsers.Item2)
            {
                if (item2.Ime.ToLower().Equals(name.ToLower()))
                {
                    retListaProdavaca.Add(item2);
                }
            }

            Tuple<List<Kupac>, List<Prodavac>> retCurrent = new Tuple<List<Kupac>, List<Prodavac>>(retListaKupaca, retListaProdavaca);

            return retCurrent;
            
        }

        public Tuple<List<Kupac>, List<Prodavac>> SearchUsersBySurname(string surname)
        {
            List<Kupac> listaKupaca = IscitajListuKupaca();
            List<Prodavac> listaProdavaca = IscitajListuProdavaca();

            Tuple<List<Kupac>, List<Prodavac>> retUsers = new Tuple<List<Kupac>, List<Prodavac>>(listaKupaca, listaProdavaca);

            List<Kupac> retListaKupaca = new List<Kupac>();
            List<Prodavac> retListaProdavaca = new List<Prodavac>();

            List<Kupac> retKupac = new List<Kupac>();
            List<Prodavac> retProdavac = new List<Prodavac>();

            foreach (var item in retUsers.Item1)
            {
                if (item.Prezime.ToLower().Equals(surname.ToLower()))
                {
                    retListaKupaca.Add(item);
                }
            }

            foreach (var item2 in retUsers.Item2)
            {
                if (item2.Prezime.ToLower().Equals(surname.ToLower()))
                {
                    retListaProdavaca.Add(item2);
                }
            }

            Tuple<List<Kupac>, List<Prodavac>> retCurrent = new Tuple<List<Kupac>, List<Prodavac>>(retListaKupaca, retListaProdavaca);

            return retCurrent;

        }

        public Tuple<List<Kupac>, List<Prodavac>> SearchUsersByUsername(string username)
        {
            List<Kupac> listaKupaca = IscitajListuKupaca();
            List<Prodavac> listaProdavaca = IscitajListuProdavaca();

            Tuple<List<Kupac>, List<Prodavac>> retUsers = new Tuple<List<Kupac>, List<Prodavac>>(listaKupaca, listaProdavaca);

            List<Kupac> retListaKupaca = new List<Kupac>();
            List<Prodavac> retListaProdavaca = new List<Prodavac>();

            List<Kupac> retKupac = new List<Kupac>();
            List<Prodavac> retProdavac = new List<Prodavac>();

            foreach (var item in retUsers.Item1)
            {
                if (item.KorisnickoIme.ToLower().Equals(username.ToLower()))
                {
                    retListaKupaca.Add(item);
                }
            }

            foreach (var item2 in retUsers.Item2)
            {
                if (item2.KorisnickoIme.ToLower().Equals(username.ToLower()))
                {
                    retListaProdavaca.Add(item2);
                }
            }

            Tuple<List<Kupac>, List<Prodavac>> retCurrent = new Tuple<List<Kupac>, List<Prodavac>>(retListaKupaca, retListaProdavaca);

            return retCurrent;

        }

        public Tuple<List<Kupac>, List<Prodavac>> FilterUsersByRole(string type)
        {
            List<Kupac> listaKupaca = IscitajListuKupaca();
            List<Prodavac> listaProdavaca = IscitajListuProdavaca();

            Tuple<List<Kupac>, List<Prodavac>> retUsers = new Tuple<List<Kupac>, List<Prodavac>>(listaKupaca, listaProdavaca);

            List<Kupac> retListaKupaca = new List<Kupac>();
            List<Prodavac> retListaProdavaca = new List<Prodavac>();

            List<Kupac> retKupac = new List<Kupac>();
            List<Prodavac> retProdavac = new List<Prodavac>();

            foreach (var item in retUsers.Item1)
            {
                if (item.Uloga.ToString().Equals(type))
                {
                    retListaKupaca.Add(item);
                }
            }

            foreach (var item2 in retUsers.Item2)
            {
                if (item2.Uloga.ToString().Equals(type))
                {
                    retListaProdavaca.Add(item2);
                }
            }

            Tuple<List<Kupac>, List<Prodavac>> retCurrent = new Tuple<List<Kupac>, List<Prodavac>>(retListaKupaca, retListaProdavaca);

            return retCurrent;

        }
        



        // ---> [PRODAVAC] METODE <--- //

        public void DodajProdavcaUFajl(Prodavac prodavac)
        {
           
            listaProdavaca.Add(prodavac);
            prodavacXML.XmlSerialize(listaProdavaca);

        }

        public string AddProdavac(Korisnik user)
        {
            if (SearchForProdavac(user.KorisnickoIme, user.Lozinka))
            {
                if (!listaProdavaca.Contains(user))
                {
                    this.listaKorisnika.Add(user);
                }
            }
            return user.KorisnickoIme;
        }

        public bool SearchForProdavac(string korisnickoIme, string lozinka)
        {
            listaProdavaca = new List<Prodavac>();
            listaProdavaca = prodavacXML.XmlDeserialize();

            foreach (var item in listaProdavaca)
            {
                if (item.KorisnickoIme == korisnickoIme && item.Lozinka == lozinka)
                {
                    return true;
                }
            }
            return false;

        }

        public Prodavac IscitajProdavca(string KorisnickoIme)
        {
            listaProdavaca = new List<Prodavac>();
            listaProdavaca = prodavacXML.XmlDeserialize();

            Prodavac retProdavac = new Prodavac();
            List<Prodavac> retVal = new List<Prodavac>();

            foreach (var item in listaProdavaca)
            {
                if (item.KorisnickoIme == KorisnickoIme)
                {
                    retProdavac.KorisnickoIme = item.KorisnickoIme;
                    retProdavac.Lozinka = item.Lozinka;
                    retProdavac.Ime = item.Ime;
                    retProdavac.Prezime = item.Prezime;

                    //retVal.Add(retAdmin);
                }
            }
            return retProdavac;
        }

        public void IzmeniProdavca(Prodavac p, Prodavac stariProdavac)
        {
            listaProdavaca = new List<Prodavac>();
            listaProdavaca = prodavacXML.XmlDeserialize();

            foreach (var item in listaProdavaca)
            {
                if (item.KorisnickoIme.Contains(stariProdavac.KorisnickoIme))
                {
                    item.KorisnickoIme = p.KorisnickoIme;
                    item.Lozinka = p.Lozinka;
                    item.Ime = p.Ime;
                    item.Prezime = p.Prezime;
                    item.Pol = p.Pol;
                    item.Uloga = p.Uloga;


                    prodavacXML.XmlSerialize(listaProdavaca);
                }
            }

        }

        // ---> [MANIFESTACIJE] METODE <--- //

        public List<Manifestacija> AllManifHomePage()
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            var list = listaManifestacija.OrderBy(x => x.DatumIVremeOdrzavanja.Date).ToList();

            return list;
        }

        public List<Manifestacija> SearchManifByName(string name)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach(var item in listaManifestacija)
            {
                if(item.Naziv.ToLower().Equals(name.ToLower()))
                {
                    retManif.Add(item);
                    var list = retManif.OrderBy(x => x.DatumIVremeOdrzavanja.Date).ToList();
                    retManif = list;
                }
            }

            return retManif;
        }

        public List<Karta> AdminSearchTicketByManifName(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retManif = new List<Karta>();

            foreach (var item in listaKarata)
            {
                if (item.ManifestacijaZaKojuJeRezervisana.Naziv.ToLower().Equals(name.ToLower()))
                {
                    retManif.Add(item);

                }
            }

            return retManif;
        }


       

        public List<Manifestacija> SearchByManifCountry(string name)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if (item.Drzava.ToLower().Equals(name.ToLower()))
                {
                    retManif.Add(item);
                    var list = retManif.OrderBy(x => x.DatumIVremeOdrzavanja.Date).ToList();
                    retManif = list;
                }
            }

            return retManif;
        }

        public List<Manifestacija> SearchByManifPlace(string name)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if (item.Mesto.ToLower().Equals(name.ToLower()))
                {
                    retManif.Add(item);
                    var list = retManif.OrderBy(x => x.DatumIVremeOdrzavanja.Date).ToList();
                    retManif = list;
                }
            }

            return retManif;
        }

       

        public List<Manifestacija> MultipleSearch(string name, string place, string country, string priceF, string priceT)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if(item.Naziv.ToLower().Equals(name.ToLower()) && item.Mesto.ToLower().Equals(place.ToLower()) && item.Drzava.ToLower().Equals(country.ToLower()) && item.CenaRegularKarte >= Int32.Parse(priceF) && item.CenaRegularKarte <= Int32.Parse(priceT))
                {
                    retManif.Add(item);
                }
                else
                {

                }
            }

            return retManif;
        }

        public IEnumerable<Manifestacija> SortByManifPlace(string place)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            IEnumerable<Manifestacija> nova = null;

            if (place == "ASC")
            {
                nova = listaManifestacija.OrderBy(x => x.Mesto); 
            }
            else
            {
                nova = listaManifestacija.OrderByDescending(x => x.Mesto); 
            }

            return nova;
        }


        public IEnumerable<Manifestacija> SortByManifName(string name)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            IEnumerable<Manifestacija> nova = null;

            if (name == "ASC")
            {       
              nova = listaManifestacija.OrderBy(x=>x.Naziv); 
            }
            else 
            {
                nova = listaManifestacija.OrderByDescending(x => x.Naziv); 
            }
            
            return nova;
        }

        public IEnumerable<Manifestacija> SortByManifPrice(string price)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            IEnumerable<Manifestacija> nova = null;

            if (price == "ASC")
            {
                nova = listaManifestacija.OrderBy(x => x.CenaRegularKarte).ToList(); //cena
            }
            else
            {
                nova = listaManifestacija.OrderByDescending(x => x.CenaRegularKarte).ToList(); //cena
            }

            return nova;
        }

        public IEnumerable<Karta> AdminSortTicketByPrice(string price)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            IEnumerable<Karta> nova = null;

            if (price == "ASC")
            {
                nova = listaKarata.OrderBy(x => x.CenaKarte).ToList(); //cena
            }
            else
            {
                nova = listaKarata.OrderByDescending(x => x.CenaKarte).ToList(); //cena
            }

            return nova;
        }
        


        public void DodajManifestacijuUFajl(Manifestacija manif)
        {

            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            listaManifestacija.Add(manif);
            manifestacijaXML.XmlSerialize(listaManifestacija);
        }

        // -------> [PENDING MANIFESTACIJE] METODE <----------

 


        public List<Manifestacija> IscitajListuManifestacija()
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            return listaManifestacija;
        }


        // -------> [KOMENTAR] METODE <----------

        public void AddComment(string kupac, string manif, string tekst, int ocena, int id)
        {

        }




        /*public Manifestacija IscitajManifestaciju(string Naziv)
        {
            listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            Manifestacija retManif = new Manifestacija();
            List<Manifestacija> retVal = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if (item.Naziv == Naziv)
                {
                    retManif.Naziv = item.Naziv;
                    retManif.TipManifestacije = item.TipManifestacije;
                    retManif.BrojMesta = item.BrojMesta;
                    retManif.DatumIVremeOdrzavanja = item.DatumIVremeOdrzavanja;
                    retManif.CenaRegularKarte = item.CenaRegularKarte;
                    retManif.Status = item.Status;
                    retManif.PosterManifestacije = item.PosterManifestacije;

                    //retVal.Add(retAdmin);
                }
            }
            return retManif;
        }*/

        public Manifestacija IscitajStaruManifestaciju(string Id)
        {
            Manifestacija retVal = new Manifestacija();
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            foreach(var item in listaManifestacija)
            {
                if(item.Id == Int32.Parse(Id))
                {
                    retVal = item;
                }
            }
            return retVal;
        }

        public void IzmeniManifestaciju(Manifestacija m, Manifestacija staraManifestacija)
        {
            listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            foreach (var item in listaManifestacija)
            {
                if (item.Id.ToString() == staraManifestacija.Id.ToString())
                {
                    item.Naziv = m.Naziv;
                    item.TipManifestacije = m.TipManifestacije;
                    item.BrojMesta = m.BrojMesta;
                    item.DatumIVremeOdrzavanja = m.DatumIVremeOdrzavanja;
                    item.CenaRegularKarte = m.CenaRegularKarte;
                    item.Status = m.Status;
                    item.PosterManifestacije = m.PosterManifestacije;
                    item.Id = m.Id;

                    manifestacijaXML.XmlSerialize(listaManifestacija);
                    manifestacijaXML.XmlDeserialize();
                }
            }

        }

        public string AddManifestacija(Manifestacija manif)
        {
            if(SearchForManifestacija(manif.Naziv))
            {              
                    this.listaManifestacija.Add(manif);          
            }
            return manif.Naziv;
        }

        public bool SearchForManifestacija(string Naziv)
        {
            listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            foreach (var item in listaManifestacija)
            {
                if (item.Naziv == Naziv)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteManifestation(string Id)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retVal = new List<Manifestacija>();
            retVal = listaManifestacija;

            foreach (var item in listaManifestacija)
            {
                if (item.Id.ToString() == Id.ToString())
                {
                    retVal.Remove(item);
                    manifestacijaXML.XmlSerialize(retVal);
                }
            }
        }




        // ---> [KARTA] METODE <--- //

        public List<Karta> IscitajListuKarata(string KorisnickoIme) //kod domacina
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retVal = new List<Karta>();
            foreach (var item in listaKarata)
            {
                if (item.Kupac == KorisnickoIme)
                {
                    retVal.Add(item);
                }
            }

            return retVal;
        }

        public List<Karta> SearchTicketsByManifName(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retKarta = new List<Karta>();

            foreach (var item in listaKarata)
            {
                if (item.ManifestacijaZaKojuJeRezervisana.Naziv.ToLower().Equals(name.ToLower()))
                {
                    retKarta.Add(item);
                    //var list = retKarta.OrderBy(x => x.DatumIVremeOdrzavanja.Date).ToList();
                    //retManif = list;
                }
            }

            return retKarta;
        }

        public List<Karta> SearchTicketsByPrice(string from, string to)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retKarta = new List<Karta>();

            foreach(var item in listaKarata)
            {
                if(item.CenaKarte >= Int32.Parse(from) && item.CenaKarte <= Int32.Parse(to))
                {
                    retKarta.Add(item);
                }
                else
                {

                }
            }

            return retKarta;
        }

        public List<Manifestacija> SearchManifByPrice(string from, string to)
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if (item.CenaRegularKarte >= Int32.Parse(from) && item.CenaRegularKarte <= Int32.Parse(to))
                {
                    retManif.Add(item);
                }
                else
                {

                }
            }

            return retManif;
        }
        

        public List<Karta> AdminTicketsFilterByStatus(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retKarta = new List<Karta>();

            foreach(var item in listaKarata)
            {
                if(item.StatusKarte.ToString().Equals(name))
                {
                    retKarta.Add(item);
                }
            }

            return retKarta;
        }

        public List<Manifestacija> FilterByType(string type) //manif at home page
        {
            List<Manifestacija> listaManifestacija = new List<Manifestacija>();
            listaManifestacija = manifestacijaXML.XmlDeserialize();

            List<Manifestacija> retManif = new List<Manifestacija>();

            foreach (var item in listaManifestacija)
            {
                if (item.TipManifestacije.ToString().Equals(type))
                {
                    retManif.Add(item);
                }
            }

            return retManif;
        }

        public List<Karta> AdminTicketsFilterByType(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            List<Karta> retKarta = new List<Karta>();

            foreach (var item in listaKarata)
            {
                if (item.TipKarte.ToString().Equals(name))
                {
                    retKarta.Add(item);
                }
            }

            return retKarta;
        }


        public IEnumerable<Karta> SortTicketsByName(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            IEnumerable<Karta> nova = null;

            if (name == "ASC")
            {
                nova = listaKarata.OrderBy(x => x.ManifestacijaZaKojuJeRezervisana.Naziv); //cena
            }
            else
            {
                nova = listaKarata.OrderByDescending(x => x.ManifestacijaZaKojuJeRezervisana.Naziv); //cena
            }

            return nova;
        }

        public IEnumerable<Karta> SortTicketsByPrice(string name)
        {
            List<Karta> listaKarata = new List<Karta>();
            listaKarata = kartaXML.XmlDeserialize();

            IEnumerable<Karta> nova = null;

            if (name == "ASC")
            {
                nova = listaKarata.OrderBy(x => x.CenaKarte); //cena
            }
            else
            {
                nova = listaKarata.OrderByDescending(x => x.CenaKarte); //cena
            }

            return nova;
        }

        public void SaveCommentToFile(string id, string kupac, string text, int ocena)
        {
            Random rnd = new Random();
            Komentar k = new Komentar();

            k.Id = rnd.Next(10000, 10500);
            k.Kupac = kupac;
            k.Tekst = text;
            k.Ocena = ocena;

            komentarXML.XmlDeserialize();
            listaKomentara.Add(k);
            komentarXML.XmlSerialize(listaKomentara);

        }
    }
}