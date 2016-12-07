using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PrelimWQ.Models;
using PrelimWQ.ViewModels;

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

        public ActionResult New()
        {

            var viewModel = new Page1ViewModel
            {

            };
            return View("Page1", viewModel);

        }

        public ActionResult Page2()
        {
            return View();
        }

        public ActionResult Page3()
        {
            return View();
        }

        public ActionResult Page4()
        {
            return View();
        }

        public ActionResult Page5()
        {
            return View();
        }

        public ActionResult Page6()
        {
            return View();
        }

        public ActionResult Page7()
        {
            return View();
        }

        public ActionResult Page8()
        {
            return View();
        }
        
        public ActionResult Page9()
        {
            return View();
        }

        public ActionResult Page10()
        {
            return View();
        }

        public ActionResult Page11()
        {
            return View();
        }
        public ActionResult Page12()
        {
            return View();
        }
        public ActionResult Page13()
        {
            return View();
        }

        public ActionResult Page14()
        {
            return View();
        }

        public ActionResult Page15()
        {
            return View();
        }

        public ActionResult Page16()
        {
            return View();
        }
    }
}