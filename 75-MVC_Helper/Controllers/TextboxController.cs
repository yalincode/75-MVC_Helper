using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class TextboxController : Controller
    {
        // GET: Textbox
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Textbox()
        {
            Personal personal = new Personal();
            personal.Id = 1;
            personal.NameAndSurname = "Yalın Sonat";
            personal.Email = "yukselyal";
            personal.Phone = "468465116";

            return View(personal);
        }
        public ActionResult TextboxFor()
        {
            Personal personal = new Personal();
            personal.Id = 1;
            personal.NameAndSurname = "Yalın Sonat";
            personal.Email = "yukselyal";
            personal.Phone = "468465116";
            personal.BirthDate = new DateTime(1990,01,01);
            return View(personal);
        }
    }
}