using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            int Hour = DateTime.Now.Hour;

            ViewBag.Greeting = Hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ActionResult Index2()
        {
            //return Content("Hello Class");
            return HttpNotFound();
        }

        
    }
}