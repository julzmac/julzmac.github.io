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
    public class HomeController : Controller
    {





        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View("Index");

        }

        public ActionResult Resume()
        {
            ViewBag.Title = "Resume";
            return View("Resume");


        }

        public ActionResult Contact()
        {
            ViewBag.Title = ("Contact");
        


            return View("Contact");

        }

        


        public ActionResult Projects()
        {
            ViewBag.Title = ("Projects");


            return View("Projects");

        }

        

    }



    }
