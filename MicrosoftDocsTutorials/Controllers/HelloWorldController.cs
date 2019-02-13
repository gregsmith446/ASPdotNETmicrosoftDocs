using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MicrosoftDocsTutorials.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            // adds a Message and NumTimes value to the ViewData dictionary. 
            // The ViewData dictionary is a dynamic object, which means any type can be used
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

//summary
/*
 Data is taken from the URL and passed to the controller using the MVC model binder.
 The controller packages the data into a ViewData dictionary and passes that object to the view.
 The view then renders the data as HTML to the browser.
 */
