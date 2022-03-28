using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class BeginFormController : Controller
    {
        // GET: BeginForm
        public ActionResult BeginForm()
        {
            return View();
        }

        //Sayfa içerisindeki formda bir html elemnet veya js tarafından form submit edldiğinde post işlemi ise bu metoda düşsün
        [HttpPost]
        public ActionResult BeginForm(int? id)
        {
            return View();
        }
    }
}