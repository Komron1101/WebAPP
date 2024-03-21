using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Task_1()
        {
            return View();
        }

        public ActionResult Task_2()
        {
            return View();
        }

        public ActionResult Task_3(double x = 0.12)
        {
            double sinPart = Math.Sin(Math.Pow(x, 3) + 0.0025);
            double logSinPart = Math.Log(sinPart);
            double powLogSinPart = Math.Pow(logSinPart, 3.0 / 2.0);
            double lastPowLogSinPart = powLogSinPart + 0.8 * Math.Pow(10, -3);

            ViewBag.sinPart = sinPart;
            ViewBag.logSinPart = logSinPart;
            ViewBag.powLogSinPart = powLogSinPart;
            ViewBag.lastPowLogSinPart = lastPowLogSinPart;

            double result = Math.Pow(Math.Log(Math.Sin(Math.Pow(x, 3) + 0.0025)), 3.0 / 2.0) + 0.8 * Math.Pow(10, -3);
            ViewBag.result = result;
            return View();
        }

        public ActionResult Task_4()
        {
            double kg = 1000;

            double sum_1 = 200 * 2.5 / kg;
            double sum_2 = 1000 * 1.2 / kg;
            double sum_3 = 500 * 1 / kg;
            double sum_4 = 500 * 7.5 / kg;
            double sum_5 = 360 * 4 / kg;

            ViewBag.sum_1 = sum_1;
            ViewBag.sum_2 = sum_2;
            ViewBag.sum_3 = sum_3;
            ViewBag.sum_4 = sum_4;
            ViewBag.sum_5 = sum_5;
            return View();
        }
    }
}