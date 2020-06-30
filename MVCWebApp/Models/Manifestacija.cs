﻿using MVCWebApp.Models.Enums;
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
        private double cenaRegularKarte;
        private Status status;
        private MestoOdrzavanja mestoOdrzavanja;
        private string posterManifestacije;

        public string Naziv { get => naziv; set => naziv = value; }
        public TipManifestacije TipManifestacije { get => tipManifestacije; set => tipManifestacije = value; }
        public int BrojMesta { get => brojMesta; set => brojMesta = value; }
        public DateTime DatumIVremeOdrzavanja { get => datumIVremeOdrzavanja; set => datumIVremeOdrzavanja = value; }
        public double CenaRegularKarte { get => cenaRegularKarte; set => cenaRegularKarte = value; }
        public Status Status { get => status; set => status = value; }      
        public string PosterManifestacije { get => posterManifestacije; set => posterManifestacije = value; }
        public MestoOdrzavanja MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }
     

        //dodatno polje
        private string drzava;
        public string Drzava { get => drzava; set => drzava = value; }

        public Manifestacija(string naz, TipManifestacije tipM, int brMesta, DateTime datumVr, Status s, MestoOdrzavanja mo, string poster, string drz)
        {
            Naziv = naz;
            TipManifestacije = tipM;
            BrojMesta = brMesta;
            DatumIVremeOdrzavanja = DateTime.Parse("02:00:00 PM");
            Status = s;
            MestoOdrzavanja = mo;
            PosterManifestacije = poster;
            Drzava = drz;
            
        }

        private Manifestacija()
        {

        }
    }
}