using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text;

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

        //[HttpPost]
        //public ActionResult Index(Models.ContactMeForm contact)
        //{
        //    Models.ContactMeEntities db = new Models.ContactMeEntities();
        //    db.ContactMeForms.Add(contact);
        //    //save changes
        //    db.SaveChanges();
        //    //kick user back to list
        //    return RedirectToAction("ThankYou", "Contact");
        //}

        //New contact form post to send me an email
        [HttpPost]
        public ActionResult Index(Models.ContactMeForm contact)
        {
            //Step 1: Add using System.Net.Mail 
            //Step 2. Create a new message
            MailMessage message = new MailMessage("theRobots@seedpaths.com", "kpbarry7@gmail.com");

            //Step 3. Set the subject
            message.Subject = "Pls respond to " + contact.FirstName + " " + contact.LastName;

            //Step 4. Build the body w/ a string builder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("Name: " + contact.FirstName + " " + contact.LastName);

            sb.AppendLine("My number is: " + contact.ContactNumber);
            sb.AppendLine("Message: " + contact.Comment);
            //Step 5. Set body = sb.ToString()
            message.Body = sb.ToString();

            //Step 6. SMTP Client
            SmtpClient client = new SmtpClient("mail.dustinkraft.com", 587);
            client.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //Step 7. Send the message
            client.Send(message);
            //Done, kick the user to the ThankYou page
            return PartialView("ThankYou");
        }
    }
}
