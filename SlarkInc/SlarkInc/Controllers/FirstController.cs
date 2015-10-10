using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlarkInc.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
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
        }
    }
}