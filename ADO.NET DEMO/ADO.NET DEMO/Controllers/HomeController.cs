using MessageBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO.NET_DEMO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            const string YourAccessKey = "AquLAl0e6sUIG90jTbHnqCaqW"; // your access key here
            Client client = Client.CreateDefault(YourAccessKey);
            const long Msisdn = +918461914451; // your phone number here

            MessageBird.Objects.Message message = client.SendMessage("Priyanshu", "Hi There!", new[] { Msisdn });

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}