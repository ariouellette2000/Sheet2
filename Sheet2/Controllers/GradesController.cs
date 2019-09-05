using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet2.Controllers
{
    public class GradesController : Controller
    {

        private  int counter =3;
        [HttpGet]
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection myForm)
        {
            ViewBag.test1 = double.Parse(myForm["test1"]);
            ViewBag.test2 = double.Parse(myForm["test2"]);
            ViewBag.test3 = double.Parse(myForm["test3"]);

            ViewBag.average = (ViewBag.test1 + ViewBag.test2+ ViewBag.test3)/3;
            if (ViewBag.average >= 90)
            {
                ViewBag.letter = 'A';
            }
            else if (ViewBag.average >= 80 && ViewBag.average <= 89)
            {
                ViewBag.letter = 'B';
            }
            else if (ViewBag.average >= 70 && ViewBag.average <= 79)
            {
                ViewBag.letter = 'C';
            }
            else if (ViewBag.average >= 60 && ViewBag.average <= 69)
            {
                ViewBag.letter = 'D';
            }
            else if (ViewBag.average >= 0 && ViewBag.average <= 59)
            {
                ViewBag.letter = 'E';
            }

            ViewBag.average = String.Format("{0:0.00}", ((ViewBag.test1 + ViewBag.test2 + ViewBag.test3) / 3));
            return View();
        }
       //ATTEMPTS FOR THE BONUS
       //public void Button_Add_Click(object add,EventArgs e)
       // {
       //     counter++;
       //     TextBox tb = new TextBox();
       //     tb.ID = "test" + counter;
       //     tb.Text = "New text";

       //     LiteralControl lineBreak = new LiteralControl("<br/>");
       //     PlaceHolder1.Controls.Add(tb);
       //     PlaceHolder1.Controls.Add(lineBreak);
       //     controlIdList.Add(tb.ID);
       //     ViewState["controlIdList"] = controlIdList;

       // }

    }
}