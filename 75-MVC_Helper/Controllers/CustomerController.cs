﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _75_MVC_Helper.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(int? id)
        {
            return View();
        }
    }
}