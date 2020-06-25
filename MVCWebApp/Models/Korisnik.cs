using MVCWebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Korisnik
    {
        private string korisnickoIme;
        private string lozinka;
        private string ime;
        private string prezime;
        private string datumRodjenja; //probaj preko odredjenog formata "21.12.1997." 
        private Pol pol;
        private Uloga uloga;
        private List<Karta> sveKarteBezObziraNaStatus; //ako je korisnik KUPAC
        private List<Manifestacija> manifestacije; //ako je korisnik PRODAVAC
        private double brojBodova;  //sakupljeni bodovi ako je korisnik KUPAC
        private TipKorisnika tipKorisnika;


        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public Pol Pol { get => pol; set => pol = value; }
        public Uloga Uloga { get => uloga; set => uloga = value; }
        public List<Karta> SveKarteBezObziraNaStatus { get => sveKarteBezObziraNaStatus; set => sveKarteBezObziraNaStatus = value; }
        public List<Manifestacija> Manifestacije { get => manifestacije; set => manifestacije = value; }
        public double BrojBodova { get => brojBodova; set => brojBodova = value; }
        public TipKorisnika TipKorisnika { get => tipKorisnika; set => tipKorisnika = value; }
    }
}