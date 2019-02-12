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

        // GET: /HelloWorld/

        public string Index()
        {
            return "this is the default action.";
        }

        // GET: /HelloWorld/Welcome

        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}