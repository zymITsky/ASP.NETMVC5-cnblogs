using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlarkInc.Models;

namespace SlarkInc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Simple s = new Simple();
            s.Name = "Slark";
            s.Email = "anyangmaxin@163.com";
            return View(s);
        }

        public ActionResult DefaultAction()
        {
           
            return View();
        }
    }
}