using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InvoiceDesk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page hi new ";

            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.Title = "Home Page hi new ";

            return View();
        }
    }
}
