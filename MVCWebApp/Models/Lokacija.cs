using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class Lokacija
    {
        private string geografskaDuzina;
        private string geografskaSirina;
        private MestoOdrzavanja mestoOdrzavanja;

        public string GeografskaDuzina { get => geografskaDuzina; set => geografskaDuzina = value; }
        public string GeografskaSirina { get => geografskaSirina; set => geografskaSirina = value; }
        public MestoOdrzavanja MestoOdrzavanja { get => mestoOdrzavanja; set => mestoOdrzavanja = value; }

        public Lokacija(string gd, string gs, MestoOdrzavanja mo)
        {
            GeografskaDuzina = gd;
            GeografskaSirina = gs;
            MestoOdrzavanja = mo;
        }
    }
}