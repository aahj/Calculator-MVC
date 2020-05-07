using Calculator_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator_MVC.Controllers
{
    public class WebCalcController : Controller
    {
        // GET: WebCalc
        public ActionResult Index()
        {
            return View(new web_based_calc());
        }
        [HttpPost]
        public ActionResult Index(web_based_calc c,string calculate)
        {
            if (calculate == "add")
            {
                c.tot = c.input1 + c.input2;
            }
            else if (calculate == "sub")
            {
                c.tot = c.input1 - c.input2;
            }
            else if (calculate == "mul")
            {
                c.tot = c.input1 * c.input2;
            }
            else
            {
                c.tot = c.input1 / c.input2;
            }
            return View(c);
        }
    }
}