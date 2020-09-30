using FizzBuzz_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace FizzBuzz_App.Controllers
{
    public class FizzbuzzerController : Controller
    {
        // GET: Fizzbuzzer
        public ActionResult Index()
        {
            return View(new fizzbuzzer());
        }

        [HttpPost]
        public ActionResult Index(fizzbuzzer f)
          {
            // create temp answer
            String answer = "";

            // check if numbers are the same
            if (f.CheckSame() == true)
            {
                answer += "These numbers are the same.";
            }

            // check if numbers exceed boundaries
            else if (f.CheckBoundaries() == true)
            {
                answer += "Please enter whole numbers between 1 and 100.";
            }

            // check if reodering is needed
            else if (f.CheckOrder() == true)
            {
                f.Reorder();
                answer += f.FizzBuzz();

            }

            // check that correction was made and execute code
            else if (f.CheckOrder() == false)
            {
                answer += f.FizzBuzz();
            }

            // check if a non-whole number is entered
            else
            {
                answer += "Please enter a whole number.";
            }

            f.Result = answer;
            return View(f);

        }


    }
}