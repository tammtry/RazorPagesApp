using MVCWebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Manifestacija
    {
        private string naziv;
        private TipManifestacije tipManifestacije;
        private int brojMesta;
        private string datumIVremeOdrzavanja;
        private double cenaRegularKarte;
        private Status status;
        private MestoOdrzavanja mestoOdrzavanja;
        private string posterManifestacije;

        public string Naziv { get => naziv; set => naziv = value; }
        public TipManifestacije TipManifestacije { get => tipManifestacije; set => tipManifestacije = value; }
        public int BrojMesta { get => brojMesta; set => brojMesta = value; }
        public string DatumIVremeOdrzavanja { get => datumIVremeOdrzavanja; set => datumIVremeOdrzavanja = value; }
        public double CenaRegularKarte { get => cenaRegularKarte; set => cenaRegularKarte = value; }
        public Status Status { get => status; set => status = value; }
        public MestoOdrzavanja MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }
        public string PosterManifestacije { get => posterManifestacije; set => posterManifestacije = value; }

        public Manifestacija(string naz, TipManifestacije tipM, int brMesta, string datumVr, Status s, MestoOdrzavanja mo, string poster)
        {
            Naziv = naz;
            TipManifestacije = tipM;
            BrojMesta = brMesta;
            DatumIVremeOdrzavanja = datumVr;
            Status = s;
            MestoOdrzavanja = mo;
            PosterManifestacije = poster;
        }

        private Manifestacija()
        {

        }
    }
}