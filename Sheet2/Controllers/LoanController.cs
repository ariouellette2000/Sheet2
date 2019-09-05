using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class LoanController : Controller
    {
        private double loopCount;
        private double total;

        [HttpGet]
        // GET: Loan
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index (double years, double investment, double rate)
        {
            ViewData["years"] = years;
            ViewData["investment"] = investment;
            ViewData["rate"] = rate;

            total = investment;
            for (loopCount = 0; loopCount < years; loopCount++) {
                total = (total * (rate / 100))+total;
                
            }
           

            ViewData["totalAmount"] = Convert.ToDecimal(total).ToString("C"); 
             
            return View();
        }
    }
}