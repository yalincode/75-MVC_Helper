using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class AntiforgeryTokenController : Controller
    {
        // GET: AntiforgeryToken
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AntiforgeryToken()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AntiforgeryToken(string name)
        {
            return View();
        }
    }
}