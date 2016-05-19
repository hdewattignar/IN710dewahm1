using firstMVC.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstMVC.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome

        public Holiday CurrentHoliday {get;set;}
        

        public ActionResult Index()
        {
            Holiday christmas = new Holiday("christmas", new DateTime(DateTime.Now.Year, 12, 25), "http://weknowyourdreamz.com/images/christmas/christmas-02.jpg");
            Holiday easter = new Holiday("easter", new DateTime(DateTime.Now.Year, 04, 16), "https://cdn4.dogonews.com/images/31b4e5eb-8ad9-40aa-9fb4-a84b897aaec1/happy-easter.jpg");
            Holiday halloween = new Holiday("halloween", new DateTime(DateTime.Now.Year, 10, 31), "https://rap4-radioafricagroup.netdna-ssl.com/wp-content/uploads/2015/10/halloween-696x492.jpg");

            Holiday[] holidays = new Holiday[] { christmas, easter, halloween };
            Random rnd = new Random();
            CurrentHoliday = holidays[rnd.Next(3)];
            return View(CurrentHoliday);
        }


        
    }
}