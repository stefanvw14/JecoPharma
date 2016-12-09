using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers // wijzigen bij invoegen Bit Bucket
{
    public class ConflictController : Controller
    {
        public ActionResult Index()
        {
            string datum = string.Format("{0:D}", DateTime.Now);
            ViewBag.Datum = datum;

            ViewBag.conflicten = Project.Models.ConflictModel.getAll(); // wijzigen bij invoegen in Bit Bucket
            return View();

        }

        public ActionResult ConflictToevoegen()
        {


            return View();
        }

        public ActionResult ConflictOverzicht()
        {
            ViewBag.conflicten = JecoPharma.Models.ConflictModel.getAll();
            return View();
        }

        public ActionResult ConflictVerwijderen()
        {
            return View();
        }

    }
}