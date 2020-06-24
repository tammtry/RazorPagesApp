using MVCWebApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp.Models
{
    public class TipKorisnika
    {
        private ImeTipa imeTipa;
        private double popust;
        private double trazeniBrojBodova; //uslov za odredjen tip korisnika

        public ImeTipa ImeTipa { get => imeTipa; set => imeTipa = value; }
        public double Popust { get => popust; set => popust = value; }
        public double TrazeniBrojBodova { get => trazeniBrojBodova; set => trazeniBrojBodova = value; }
    }
}