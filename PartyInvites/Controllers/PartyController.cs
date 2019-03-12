using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class PartyController : Controller
    {
        PartyDbContext db = new PartyDbContext();
        // GET: Party
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponse model)
        {
            if (ModelState.IsValid)
            {
                var count= db.GuestResponses.Count();
                model.ID = count + 1;
                db.GuestResponses.Add(model);
                db.SaveChanges();
                return View("Thanks", model);
            }
            else
            {
                return View();
            }
        }
    }
}