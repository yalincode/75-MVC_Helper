using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class HelpController : Controller
    {
        // GET: Help
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _PartialAction()
        {
            return PartialView();
        }
        public PartialViewResult _PartialRouteValue(int id)
        {
            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir() { Id = 1, SehirAdi = "Ankara"},
                new Sehir() { Id = 2, SehirAdi = "Bursa"},
                new Sehir() { Id = 3, SehirAdi = "İstanbul"}
            };

            Sehir sehir = sehirler.FirstOrDefault(T => T.Id == id);
            return PartialView(sehir);
        }
    }
}