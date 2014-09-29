using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactMeForm());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactMeForm contact)
        {
            Models.ContactMeEntities db = new Models.ContactMeEntities();
            db.ContactMeForms.Add(contact);
            //save changes
            db.SaveChanges();
            //kick user back to list
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
