using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlarkInc.DAL;
using SlarkInc.Models;

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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Worker work)
        {
            if (ModelState.IsValid)
            {
                db.Workers.Add(work);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}