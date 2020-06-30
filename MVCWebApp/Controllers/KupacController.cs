using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class KupacController : Controller
    {
        // GET: Kupac
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutKupac(Kupac kupac)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            ViewBag.korisnicko_ime = korisnici.AddKupac(kupac);
            ViewBag.KupacPodaci = korisnici.IscitajKupca(ViewBag.korisnicko_ime);

            return View();
        }

        [HttpPost]
        public ActionResult KupacTickets(string KorisnickoIme)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.IscitajListuKarata(KorisnickoIme);
            
            return View();
        }


        [HttpPost]
        public ActionResult SaveKupacInfo(Kupac k, string KorisnickoIme)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            Kupac stariKupac = new Kupac();
            stariKupac = korisnici.IscitajKupca(KorisnickoIme);
            korisnici.IzmeniKupca(k, stariKupac);
            return View();
        }
    }
}