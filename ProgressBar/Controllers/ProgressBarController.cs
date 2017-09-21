using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgressBar.Controllers
{
    public class ProgressBarController : Controller
    {
        // GET: ProgressBar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Button
        public JsonResult Randomized()
        {
            Random rnd = new Random();
            Session["zahl"] = rnd.Next(1, 101);
            return Json(Session["zahl"], JsonRequestBehavior.AllowGet);
        }
        public JsonResult Plus(int pbcurrentvalue)
        {
            pbcurrentvalue ++;
            //Session["zahl"]= Convert.ToInt32(Session["zahl"])+5;
            //return Json(Session["zahl"], JsonRequestBehavior.AllowGet);
            return Json(pbcurrentvalue, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Minus(int pbcurrentvalue)
        {
            pbcurrentvalue--;
            //Session["zahl"] = Convert.ToInt32(Session["zahl"]) - 5;
            //return Json(Session["zahl"], JsonRequestBehavior.AllowGet);
            return Json(pbcurrentvalue, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Mute()
        {
            //pbcurrentvalue = 0;
            Session["zahl"] = 0;
                //Convert.ToInt32(Session["zahl"]) - Convert.ToInt32(Session["zahl"]);
            return Json(Session["zahl"], JsonRequestBehavior.AllowGet);
            //return Json(pbcurrentvalue, JsonRequestBehavior.AllowGet);
        }
    }
}