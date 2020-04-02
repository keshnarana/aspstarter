using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspstarter.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
     public IActionResult Index()
        {
            return View();

        }

        public IActionResult Welcome(string name, int numTimes = 10)
        {
            //https://localhost:44371/HelloWorld/Welcome?name=Rick&numTimes=2
            //  return HtmlEncoder.Default.Encode($"Hello {name}, Num : {ID}");
            ViewData["message"] = "hello" + name;
            ViewData["Num"] = numTimes;
            return View();
        }
    }
}
