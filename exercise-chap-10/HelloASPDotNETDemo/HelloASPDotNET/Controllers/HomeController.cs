using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloASPDotNET.Models;

namespace HelloASPDotNET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            /*string html = "<form method='post' action='/hello/welcome'>" +
                "<input type='text' name='name'>" +
                "<select name='language' id='language'>" + 
                    "<option value='English'>English</option>" +
                    "<option value='Spanish'>Spanish</option>" +
                    "<option value='Italian'>Italian</option>" +
                    "<option value='German'>German</option>" +
                    "<option value='French'>French</option>" +
                    "</select>"+
                 "<input type='submit' value='Submit' />" +
                "</form>";

            return Content(html, "text/html");*/
            return View();
        }

        [HttpPost]
        [Route("/hello/welcome")]
        public IActionResult Welcome(string name="Tatyana", string language="Hello ")
        {
            return Content("<h1>" + language + name + "</h1>", "text/html");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
