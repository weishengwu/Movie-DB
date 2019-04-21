using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }
        /*
        public string Index()
        {
            return "This is my default action...";
        }
        */

        //
        // GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            //return "This is the Welcome action method...";
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

        

        
    }
}