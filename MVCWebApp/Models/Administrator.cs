using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Administrator : Korisnik
    {
        public Administrator()
        {
            KorisnickoIme = "";
            Lozinka = "";
            Ime = "";
            Prezime = "";
            Pol = Enums.Pol.MUSKO;
            DatumRodjenja = "";
            Uloga = Enums.Uloga.ADMINISTRATOR;
            //SveKarteBezObziraNaStatus = new List<Karta>();
            //BrojBodova = 0;
            //Manifestacije = new List<Manifestacija>();
            TipKorisnika = new TipKorisnika(); //da li je ovo uopste potrebno kod administratora?!
        }
    }
}