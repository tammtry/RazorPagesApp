using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Prodavac : Korisnik
    {
        public Prodavac()
        {
            KorisnickoIme = "";
            Lozinka = "";
            Ime = "";
            Prezime = "";
            Pol = Enums.Pol.MUSKO;
            DatumRodjenja = "";
            Uloga = Enums.Uloga.PRODAVAC;
            //SveKarteBezObziraNaStatus = new List<Karta>();
            //BrojBodova = 0;
            Manifestacije = new List<Manifestacija>();
            TipKorisnika = new TipKorisnika();
        }
    }
}