using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutAdministrator(Administrator administrator)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            ViewBag.korisnicko_ime = korisnici.AddAdmin(administrator);
            ViewBag.AdminPodaci = korisnici.IscitajKupca(ViewBag.korisnicko_ime);

            return View();
        }

        [HttpPost]
        public ActionResult SaveAdminInfo(Administrator a, string KorisnickoIme)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            Administrator stariAdministrator = new Administrator();
            stariAdministrator = korisnici.IscitajAdministratora(KorisnickoIme);
            korisnici.IzmeniAdministratora(a, stariAdministrator);
            return View();
        }

        [HttpPost]
        public ActionResult AddProdavac(Prodavac prodavac)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            korisnici.DodajProdavcaUFajl(prodavac);
            korisnici.AddProdavac(prodavac);

            return View();
        }
    }
}