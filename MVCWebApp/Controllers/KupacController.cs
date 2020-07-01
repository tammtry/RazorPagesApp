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
        public ActionResult AllManifestations()
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.IscitajListuManifestacija();
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

        [HttpPost]
        public ActionResult SearchTicketsByManifName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.SearchTicketsByManifName(name);

            return View("KupacTickets");
        }

        [HttpPost]
        public ActionResult SearchTicketsByPrice(string from, string to)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.SearchTicketsByPrice(from, to);

            return View("KupacTickets");
        }

        [HttpPost]
        public ActionResult SortTicketsByName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.SortTicketsByName(name);

            return View("KupacTickets");
        }

        [HttpPost]
        public ActionResult SortTicketsByPrice(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.SortTicketsByPrice(name);

            return View("KupacTickets");
        }

        [HttpPost]
        public ActionResult AddComment(string id)
        {

            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.Id = id; //preko id-a/ nemam polje za kupca unutar manifestacije (suludo jer je nije kupio i rezervisao)

            return View();
        }

        [HttpPost]
        public ActionResult SaveCommentToFile(string id, string kupac, string text, string ocena)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            korisnici.SaveCommentToFile(id, kupac, text, Int32.Parse(ocena));

            return View("AddComment");
        }
    }
}