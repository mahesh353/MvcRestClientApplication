using BasicMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}