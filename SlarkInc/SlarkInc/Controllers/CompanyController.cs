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
        public ViewResult Index(string sortOrder)
        {
            ViewBag.FirstNameSortParm = string.IsNullOrWhiteSpace(sortOrder) ? "first_desc" : "";
            ViewBag.LastNameSortParm = sortOrder == "last" ? "last_desc" : "last";
            var workers = from w in db.Workers
                select w;
            switch (sortOrder)
            {
                case "first_desc":
                    workers = workers.OrderByDescending(w => w.FirstName);
                    break;
                case "last_desc":
                    workers = workers.OrderByDescending(w => w.LastName);
                    break;
                case "last":
                    workers = workers.OrderBy(w => w.LastName);
                    break;
                default:
                    workers = workers.OrderBy(w => w.FirstName);
                    break;
            }
            
            return View(workers.ToList());
        }
    }
}