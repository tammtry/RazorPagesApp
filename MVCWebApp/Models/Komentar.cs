using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Komentar
    {
        private string kupac;
        private string manifestacija;
        private string tekst;
        private int ocena;

        private int counter = 0;
        private int id;

        public string Kupac { get => kupac; set => kupac = value; }
        public string Manifestacija { get => manifestacija; set => manifestacija = value; }
        public string Tekst { get => tekst; set => tekst = value; }
        public int Ocena { get => ocena; set => ocena = value; }
        public int Id { get => id; set => id = value; }

        public Komentar(string k, string m, string t, int o)
        {
            Kupac = k;
            Manifestacija = m;
            Tekst = t;
            Ocena = o;
            Id = id;
        }

        public Komentar()
        {
          
        }
    }
}