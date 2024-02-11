using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task_2.Models;

namespace task_2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Index(Student S)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Contact");
            }
            return View(S);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}