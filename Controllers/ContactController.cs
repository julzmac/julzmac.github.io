using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using PortfolioJM.Models;
using System.Threading;
using System.Text;
using System.Data;
using System.Web.Mvc.Html;
using System.Threading.Tasks;
using System.Net;

namespace PortfolioJM.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            return View("Contact");
            
        }

        [HttpPost]
        public ViewResult Contact(PortfolioJM.Models.ContactModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add("liljul27@gmail.com");
                mail.From = new MailAddress(_objModelMail.Email);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Message;
                mail.Body = "<b> Sender Name : </b>" + _objModelMail.Name + "<br/>"
                + "<b> Email address : </b>" + _objModelMail.Email + "<br/>"
                + "<b> Message  : </b>" + _objModelMail.Message + "<br/>";
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("liljul27@gmail.com", "goodanswer27"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Contact", _objModelMail);
            }
            else
            {
                return View();
            }
        }
    }
}