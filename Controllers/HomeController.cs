using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Contact.Models;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("About");
        }

        public IActionResult Contact()
        {
            ContactInfo info = new ContactInfo("481.516.2342", "pat@mysite.com", "facebook.com/mysite");
            return View("Contact", info);
        }
    }
}
