using _75_MVC_Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class RawController : Controller
    {
        // GET: Raw
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Raw()
        {
            Tasarim tasarim=new Tasarim();
            tasarim.Sayfa = "<div style='background-color:red;width:100px;height:100px;border:1px solid red;></div>'";
            //sayfaya basarken sayfada html model olarak değerlendirilir.
            return View(tasarim);
        }
    }
}