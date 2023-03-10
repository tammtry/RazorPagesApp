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
            ViewBag.AdminPodaci = korisnici.IscitajAdministratora(ViewBag.korisnicko_ime);

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

        [HttpPost]
        public ActionResult AllUsers()
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            //ViewBag.listaKupaca = korisnici.IscitajListuKupaca();
            // ViewBag.listaProdavaca = korisnici.IscitajListuProdavaca();
            ViewBag.listaKorisnika = korisnici.IscitajListuKorisnika();
            return View();
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

            return View("AdminAllTickets");
        }

        [HttpPost]
        public ActionResult AdminSearchTicketByManifName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.AdminSearchTicketByManifName(name);

            return View("AdminAllTickets");
        }

        [HttpPost]
        public ActionResult AdminSortTicketByPrice(string price)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.AdminSortTicketByPrice(price);

            return View("AdminAllTickets");
        }
        

        [HttpPost]
        public ActionResult AdminTicketsFilterByStatus(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.AdminTicketsFilterByStatus(name);

            return View("AdminAllTickets");
        }

        [HttpPost]
        public ActionResult AdminTicketsFilterByType(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKarata = korisnici.AdminTicketsFilterByType(name);

            return View("AdminAllTickets");
        }

        
        [HttpPost]
        public ActionResult AdminAllTickets()
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            //ViewBag.listaKupaca = korisnici.IscitajListuKupaca();
            // ViewBag.listaProdavaca = korisnici.IscitajListuProdavaca();
            ViewBag.listaKarata = korisnici.IscitajListuKarataAdmin();
            return View();
        }


        [HttpPost]
        public ActionResult SearchUsersByName(string name)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKorisnika = korisnici.SearchUsersByName(name);

            return View("SearchBySomething");
        }

        [HttpPost]
        public ActionResult SearchUsersBySurname(string surname)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKorisnika = korisnici.SearchUsersBySurname(surname);

            return View("SearchBySomething");
        }

        [HttpPost]
        public ActionResult FilterUsersByRole(string type)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKorisnika = korisnici.FilterUsersByRole(type);

            return View("SearchBySomething");
        }

        [HttpPost]
        public ActionResult SearchUsersByUsername(string username)
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }

            ViewBag.listaKorisnika = korisnici.SearchUsersByUsername(username);

            return View("SearchBySomething");
        }

        [HttpPost]
        public ActionResult AdminPendingManifestations() //kod administratora
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
        public ActionResult SavePendingManifestationStatus(Manifestacija m, string Id) //radi kod prodavca
        {
            Korisnici korisnici = (Korisnici)Session["korisnici"];

            if (korisnici == null)
            {
                korisnici = new Korisnici();
                Session["korisnici"] = korisnici;
            }
            //pozovi izmenu

            Manifestacija staraManifestacija = new Manifestacija();
            staraManifestacija = korisnici.IscitajStaruManifestaciju(Id);
            korisnici.IzmeniManifestaciju(m, staraManifestacija);
          
            return View();
        }



    }
}