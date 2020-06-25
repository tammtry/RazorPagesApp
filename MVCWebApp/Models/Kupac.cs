using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Kupac : Korisnik
    {
        public Kupac()
        {
            KorisnickoIme = "";
            Lozinka = "";
            Ime = "";
            Prezime = "";
            Pol = Enums.Pol.MUSKO;
            DatumRodjenja = "";
            Uloga = Enums.Uloga.KUPAC;
            SveKarteBezObziraNaStatus = new List<Karta>();
            BrojBodova = 0;
            TipKorisnika = new TipKorisnika();

        }
    }
}