using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult Index()
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.AllManifHomePage();

            return View();
        }

        [HttpPost]
        public ActionResult SearchManifByName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.SearchManifByName(name);

            return View("Index");
        }

        [HttpPost]
        public ActionResult SearchByManifCountry(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.SearchByManifCountry(name);

            return View("Index");
        }

        [HttpPost]
        public ActionResult SearchByManifPlace(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.SearchByManifPlace(name);

            return View("Index");
        }

        [HttpPost]
        public ActionResult SortByManifName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.SortByManifName(name);

            return View("Index");
        }

        [HttpPost]
        public ActionResult SortByManifPrice(string price)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.SortByManifPrice(price);

            return View("Index");
        }

        [HttpPost]
        public ActionResult MultipleSearch(string name, string place, string country, string priceF, string priceT)   
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaManifestacija = korisnici.MultipleSearch(name, place, country, priceF, priceT);

            return View("Index");
        }



    }
}