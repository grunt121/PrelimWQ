using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrelimWQ.Controllers
{
    public class QuestionnaireController : Controller
    {
        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Page1()
        {
            return View();
        }
       
    }
}