using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class ApothekerController : Controller
    {
       public ActionResult Index()
        {
            string datum = string.Format("{0:D}", DateTime.Now);
            ViewBag.Datum = datum;
            return View();
        }

        public ActionResult EAVUitlezen()
        {
            return View();
        }

        /*public ActionResult EAVWijzigen()
        {
            return View();
        }*/

        /*public ActionResult ConflictVerwijderen()
        {
            return View();
        }*/
    }
}