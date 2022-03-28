using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class DropDownController : Controller
    {
        List<Sehir> sehirler = new List<Sehir>();
        public DropDownController()
        {
            sehirler.Add(new Sehir() { Id=1,SehirAdi="Ankara"});
            sehirler.Add(new Sehir() { Id=2,SehirAdi="Bursa"});
            sehirler.Add(new Sehir() { Id=3,SehirAdi="İstanbul"});
        }

        // GET: DropDown
        public ActionResult Index()
        {
            

            return View();
        }
        public ActionResult DropDownList()
        {
            //viewbag nesnesi dynamic bir nesnedir
            ViewBag.SehirId = new SelectList(sehirler, "Id", "SehirAdi");
            return View();
        }

        public ActionResult DropDownListFor()
        {
            //viewbag nesnesi dynamic bir nesnedir
            Sehir sehir = new Sehir();
            sehir.Id = 2;
            sehir.SehirAdi = "Ankara";

            return View(sehir);
        }
    }
}