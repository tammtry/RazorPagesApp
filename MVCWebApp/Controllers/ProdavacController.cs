using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class ProdavacController : Controller
    {
        // GET: Prodavac
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutProdavac(Prodavac prodavac)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            ViewBag.korisnicko_ime = korisnici.AddProdavac(prodavac);
            ViewBag.ProdavacPodaci = korisnici.IscitajProdavca(ViewBag.korisnicko_ime);

            return View();
        }


        [HttpPost]
        public ActionResult SaveProdavacInfo(Prodavac p, string KorisnickoIme)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            Prodavac stariProdavac = new Prodavac();
            stariProdavac = korisnici.IscitajProdavca(KorisnickoIme);
            korisnici.IzmeniProdavca(p, stariProdavac);
            return View();
        }
    }
}