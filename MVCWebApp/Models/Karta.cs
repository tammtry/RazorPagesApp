using MVCWebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Karta
    {
        private string idKarte;
        private Manifestacija manifestacijaZaKojuJeRezervisana;
        private DateTime datumIVremeManifestacije;
        private string cenaKarte;
        private string kupac;
        private StatusKarte statusKarte;
        private TipKarte tipKarte;

        public string IdKarte { get => idKarte; set => idKarte = value; }
        public Manifestacija ManifestacijaZaKojuJeRezervisana { get => manifestacijaZaKojuJeRezervisana; set => manifestacijaZaKojuJeRezervisana = value; }
        public DateTime DatumIVremeManifestacije { get => datumIVremeManifestacije; set => datumIVremeManifestacije = value; }
        public string CenaKarte { get => cenaKarte; set => cenaKarte = value; }
        public string Kupac { get => kupac; set => kupac = value; }
        public StatusKarte StatusKarte { get => statusKarte; set => statusKarte = value; }
        public TipKarte TipKarte { get => tipKarte; set => tipKarte = value; }

        public Karta(string id, Manifestacija manif, DateTime datum, string cena, string kup, StatusKarte statusK, TipKarte tipK)
        {
            IdKarte = id;
            ManifestacijaZaKojuJeRezervisana = manif;
            DatumIVremeManifestacije = datum;
            CenaKarte = cena;
            Kupac = kup;
            StatusKarte = statusK;
            TipKarte = tipK;
        }

        private Karta()
        {
            IdKarte = "";
            ManifestacijaZaKojuJeRezervisana = null; 
            DatumIVremeManifestacije = DateTime.Now;
            CenaKarte = "244,00 dinara";
            Kupac = "Tamara";
            StatusKarte = StatusKarte.REZERVISANA;
            TipKarte = TipKarte.FANPIT;

        }
    }
}