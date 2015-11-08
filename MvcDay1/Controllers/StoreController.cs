using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcDay1.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public int Index(int x1, int x2)
        {
            return x1 + x2;
        }
        [Authorize]
        public ActionResult MyName()
        {
            ViewData["Name1"] = "Abanoub Nageh";
            ViewBag.Name = "Samy Reda";
            return View();
        }

        public ActionResult MyWebsite()
        {
            return RedirectPermanent("http://www.facebook.com");
        }

        public ActionResult ToAnotherAction()
        {
            return RedirectToAction("MyName");
        }

        public ActionResult OpenFile()
        {
            return File("~/Scripts/jquery-1.7.1.js","javascript");
        }

        public ActionResult ReturnJson()
        {
            object fullName = new {FName = "Abanoub", LName = "nageh"};
            return Json(fullName, JsonRequestBehavior.AllowGet);
        }
    }
}
