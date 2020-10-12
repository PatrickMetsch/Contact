using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Contact.Areas.Help.Controllers
{

    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            string page;
            if(id == 1)
            {
                page = "Page1";
            } else if(id ==2)
            {
                page = "Page2";
            } else
            {
                page = "Page3";
            }
            return View(page);
        }
    }
}