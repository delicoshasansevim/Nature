using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;


namespace WebApplication3.Controllers
{

    //[Authorize]
    public class HomeController : Controller
    {

        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewData["message"] = 123;
            return View();
        }


      
        [HttpGet]
        public ActionResult email_send()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult email_send(Person person1)
        {
            PersonDBEntities db = new PersonDBEntities();

  if (ModelState.IsValid)
   { 
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage("delicos@freenet.de", "delicos@web.de");

            //mail.From = new System.Net.Mail.MailAddress("delicos@freenet.de");
            //mail.To.Add("delicos@web.de");
            mail.Subject = "you have message from " + person1.Name;
            mail.Body = person1.EmailMessage;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            
            smtp.Host = "mx.freenet.de";
            smtp.Port = 587;
            smtp.EnableSsl = true;
          
            smtp.Credentials = new System.Net.NetworkCredential("delicos@freenet.de", "arpej34");

            try {
                smtp.Send(mail);

                    ViewBag.message = "Your email has been sent successfully";
               
            }
            catch (Exception)
            {
                Response.Write("it failed to connect");
            }

            
   }                   
            return View("email_send");
        }

        [AllowAnonymous]
        public ActionResult Mammals()
        {

            return View();
        }

        [AllowAnonymous]
        public ActionResult vertebrates()
        {


            return View();
        }


        [AllowAnonymous]
        public ActionResult reptilians()
        {


            return View();
        }


        [AllowAnonymous]
        public ActionResult worldwonders()
        {
            

            return View();
        }

        [Authorize]
        public ActionResult world_history()
        {

            
            return View();
        }


        public ActionResult pollution()
        {


            return View();
        }


        public ActionResult scroll_to()
        {


            return View();
        }



        public ActionResult counter1()
        {
            Session["myCounter"] = 1123;

            return View();
        }


        public ActionResult loginSuccess()
        {


            return View();
        }


    }
}