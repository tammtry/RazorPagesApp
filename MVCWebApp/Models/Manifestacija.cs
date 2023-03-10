using MVCWebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Manifestacija
    {
        private string naziv;
        private TipManifestacije tipManifestacije;
        private int brojMesta;
        private DateTime datumIVremeOdrzavanja;
        private int cenaRegularKarte;
        private Status status;
        //private MestoOdrzavanja mestoOdrzavanja;
        private string posterManifestacije;
        private int id;
        private string mesto;

        public string Naziv { get => naziv; set => naziv = value; }
        public TipManifestacije TipManifestacije { get => tipManifestacije; set => tipManifestacije = value; }
        public int BrojMesta { get => brojMesta; set => brojMesta = value; }
        public DateTime DatumIVremeOdrzavanja { get => datumIVremeOdrzavanja; set => datumIVremeOdrzavanja = value; }
        public int CenaRegularKarte { get => cenaRegularKarte; set => cenaRegularKarte = value; }
        public Status Status { get => status; set => status = value; }      
        public string PosterManifestacije { get => posterManifestacije; set => posterManifestacije = value; }
        //public MestoOdrzavanja MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }

     

        //dodatno polje
        private string drzava;
        public string Drzava { get => drzava; set => drzava = value; }
        public int Id { get => id; set => id = value; }
        public string Mesto { get => mesto; set => mesto = value; }

        public Manifestacija(string naz, TipManifestacije tipM, int brMesta, DateTime datumVr, string mest, Status s, string poster, string drz, int cen, int i)
        {
            Naziv = naz;
            TipManifestacije = tipM;
            BrojMesta = brMesta;
            DatumIVremeOdrzavanja = datumVr;
            Status = s;
            Mesto = mesto;
            PosterManifestacije = poster;
            Drzava = drz;
            CenaRegularKarte = cen;
            Id = i;
        }

        public Manifestacija()
        {
            Naziv = "";
            TipManifestacije = TipManifestacije.FESTIVAL;
            BrojMesta = 11;
            Mesto = "";
            DatumIVremeOdrzavanja = DateTime.Now;
            CenaRegularKarte = 111;
            Status = 0;
            PosterManifestacije = "";
            Drzava = "";
            Id = 0;
        }
    }
}