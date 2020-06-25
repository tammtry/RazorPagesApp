using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class MestoOdrzavanja
    {
        private string ulica;
        private int broj;
        private string mesto;
        private int postanskiBroj;

        public string Ulica { get => ulica; set => ulica = value; }
        public int Broj { get => broj; set => broj = value; }
        public string Mesto { get => mesto; set => mesto = value; }
        public int PostanskiBroj { get => postanskiBroj; set => postanskiBroj = value; }

        public MestoOdrzavanja()
        {
            Ulica = "";
            Broj = -1;
            Mesto = "";
            PostanskiBroj = -1;
        }

        public MestoOdrzavanja(string u, int br, string m, int pb)
        {
            Ulica = u;
            Broj = br;
            Mesto = m;
            PostanskiBroj = pb;
        }
    }
}