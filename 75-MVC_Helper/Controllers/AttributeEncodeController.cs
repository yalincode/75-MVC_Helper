using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class AttributeEncodeController : Controller
    {
        // GET: AttributeEncode
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AttributeEncode()
        {
            Personal personal=new Personal();
            personal.NameAndSurname = "Şefik Şerefoğlu";
            return View(personal);
        }
    }
}