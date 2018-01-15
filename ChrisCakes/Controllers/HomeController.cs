using ChrisCakes.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ChrisCakes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.ShowCarousel = true;
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        [HttpPost]
        public ActionResult About(FormCollection formCollection)
        {
            StringBuilder s = new StringBuilder();
            foreach (string key in Request.Form.Keys)
            {
                s.AppendLine(key + ": " + Request.Form[key] +"<br>" + Environment.NewLine);
            }
            string formData = s.ToString();
            ViewBag.Message = true;
            Gmailer mailer = new Gmailer();
            mailer.GmailUsername = WebConfigurationManager.AppSettings["GoogClientID"];
            mailer.GmailPassword = WebConfigurationManager.AppSettings["GoogClientSecret"];


            mailer.ToEmail = WebConfigurationManager.AppSettings["ChrisCakesEmail"];
            mailer.Subject = "Chris Cakes Contact Form";
            mailer.Body = formData;
            mailer.IsHtml = true;
            mailer.Send();

            return View();
        }
        public ActionResult BreakfastALaCarte()
        {
            return View();
        }
        public ActionResult BreakfastMenus()
        {
            return View();
        }
        public ActionResult DayOfEventInformation()
        {
            return View();
        }
        public ActionResult Fundraising()
        {
            return View();
        }
        public ActionResult HowToBook()
        {
            return View();
        }
        public ActionResult HowToRunASuccessfulFundraiser()
        {
            return View();
        }
        public ActionResult InvoicePayment()
        {
            return View();
        }
        public ActionResult LunchAndDinner()
        {
            return View();
        }
        public ActionResult MenusNMore()
        {
            return View();
        }
        public ActionResult MenusNMoreALaCarte()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult YourGroup()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}