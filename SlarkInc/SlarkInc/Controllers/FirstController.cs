using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlarkInc.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Number = 8;
            ViewBag.Message = "This is index Page";
            ViewBag.Slarks = new List<string> { "Slark1", "Slark2", "Slark3" };
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

      /*  // GET: First
        public string Index()
        {
            return "<h1>This is index page</h1>";
        }

        public string Index2(string id)
        {
            return "This is first controller index page.<br/> Your Id is " + id;
        }

        public string Another()
        {
            return "This is first controller another page";
        }*/
    }
}