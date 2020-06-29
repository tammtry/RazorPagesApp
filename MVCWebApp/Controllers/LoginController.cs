using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Korisnik k)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }         

            if (korisnici.SearchForAdministrator(k.KorisnickoIme, k.Lozinka))
            {
                ViewBag.korisnicko_ime = korisnici.AddAdmin(k);

                return View("AdminLogin");
            }

            else if(korisnici.SearchForKupac(k.KorisnickoIme, k.Lozinka))
            {
                ViewBag.korisnicko_ime = korisnici.AddKupac(k);

                return View("KupacLogin");
            }

            else if(korisnici.SearchForProdavac(k.KorisnickoIme, k.Lozinka))
            {
                ViewBag.korisnicko_ime = korisnici.AddProdavac(k);

                return View("ProdavacLogin");
            }

            else
            {
                return View("Error");
            }
        }
    }
}