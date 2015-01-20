//Creator: Jason R Hodges
//Description: This is a tip calculator that allows you to:
//  -Split a tip between multiple people
//  -Adjust the percent amount that you would like to tip
//  -Choose to either include tax and deductions in the tip calculation or exclude them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        public static int count = 0;

        public ActionResult Index(CalculatorModel calc)
        {
            if (calc.IncludeTax && calc.IncludeDeduct)
            {
                calc.CalcTotal1();
            }
            else if (calc.IncludeTax && !calc.IncludeDeduct)
            {
                calc.CalcTotal2();
            }
            else if (!calc.IncludeTax && calc.IncludeDeduct)
            {
                calc.CalcTotal3();
            }
            else if (!calc.IncludeTax && !calc.IncludeDeduct)
            {
                calc.CalcTotal4();
            }

            return View(calc);
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