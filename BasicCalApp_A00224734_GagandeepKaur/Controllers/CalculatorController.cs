using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicCalApp_A00224734_GagandeepKaur.Models;

namespace BasicCalApp_A00224734_GagandeepKaur.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator calculator, string operate)
        {
            calculator.result = 0;
            switch (operate)
            {
                case "add":
                    calculator.result = calculator.value1 + calculator.value2;
                    break;
                case "subtract":
                    calculator.result = calculator.value1 - calculator.value2;
                    break;
                case "multiply":
                    calculator.result = calculator.value1 * calculator.value2;
                    break;
                case "divide":
                    if (calculator.value2 == 0)
                    {
                        calculator.error = "You divided a value by zero. Enter another value.";
                    }
                    else
                    {
                        calculator.result = calculator.value1 / calculator.value2;
                    }
                    break;
                default:
                    break;
            }
            return View(calculator);
        }
    }
}