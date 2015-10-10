using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlarkInc.DAL;

namespace SlarkInc.Controllers
{
    public class CompanyController : Controller
    {
        private CompanyContext db=new CompanyContext();

        // GET: Company
        public ViewResult Index()
        {
            return View(db.Workers.ToList());
        }
    }
}