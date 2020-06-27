using MVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registracija(Kupac korisnik)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            if (korisnici.kupacUsernameAlreadyExists(korisnik.KorisnickoIme))
            {
                return View("Error");
            }
            else
            {

                Session["korisnici"] = korisnici;
                korisnici.RegistrujKupca(korisnik); //ako ne postoji registruj ga (u fajl)
                return View("Index");
            }

        }
    }
}