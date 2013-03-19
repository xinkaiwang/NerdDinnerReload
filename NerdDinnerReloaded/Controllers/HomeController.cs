using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NerdDinnerReloaded.DAL;
using NerdDinnerReloaded.Models;

namespace NerdDinnerReloaded.Controllers
{
    public class HomeController : Controller
    {
        private NerdDinners dbContext = new NerdDinners();

        public ActionResult Index()
        {
            var dinners = from d in dbContext.Dinners
                          where d.EventDate > DateTime.UtcNow
                          select d;

            return View(dinners.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                dbContext.Dinners.Add(dinner);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(dinner);
        }
    }
}
