using LcdDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LcdDisplay.Web.Controllers
{
    public class HomeController : Controller
    {
        private string displayType = "html";

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProcessInput(String input)
        {
            List<String> inputs = input.Split('\n').ToList();
            return Json(Json(DisplayManager.ProcessInputs(inputs, displayType), JsonRequestBehavior.AllowGet));
        }

    }
}
