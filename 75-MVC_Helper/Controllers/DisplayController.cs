using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Display
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            Personal personal=new Personal();
            personal.NameAndSurname = "Yalın Sonat";
            return View(personal);
        }
        public ActionResult DisplayFor()
        {
            Personal personal = new Personal();
            personal.NameAndSurname = "Yalın Sonat";
            return View(personal);
        }
    }
}