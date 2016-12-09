using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{    public class GrondstofController : Controller
    {

        public ActionResult Index()
        {
            string datum = string.Format("{0:D}", DateTime.Now);
            ViewBag.Datum = datum;
            return View();
        }

        public ActionResult GrondstofToevoegen()
        {
            return View();
        }

        public ActionResult GrondstofOverzicht()
        {
            ViewBag.grondstof = Project.Models.GrondstofModel.getAll();
            return View();
        }

        public ActionResult GrondstofVerwijderen()
        {
            return View();
        }

    }
}