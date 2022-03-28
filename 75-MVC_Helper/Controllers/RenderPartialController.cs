using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class RenderPartialController : Controller
    {
        // GET: RenderPartial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RenderPartial()
        {
            return View();
        }
    }
}