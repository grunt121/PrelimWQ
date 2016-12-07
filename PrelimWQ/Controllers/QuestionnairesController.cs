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

    public class QuestionnairesController : Controller
    {

        //Setting DB Context
        private ApplicationDbContext _context;
        public QuestionnairesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Questionnaire
        public ActionResult Index()
        {
            return View();
        }


        //Page 1 Actions
        //Edit & View are combined into one
        public ActionResult Page1(int id)  
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page1ViewModel
            {
                A2_1 = questionnaire.A2_1.Value,
                A2_2 = questionnaire.A2_2.Value,
                A2_3a = questionnaire.A2_3a.Value,
                A2_3b = questionnaire.A2_3b.Value,
                A2_3c = questionnaire.A2_3c.Value,
                A2_3d = questionnaire.A2_3d.Value,
                A2_3e = questionnaire.A2_3e.Value,
                A2_3f = questionnaire.A2_3f.Value,
                A2_3g = questionnaire.A2_3g.Value,
                A2_3h = questionnaire.A2_3h.Value,
                A2_3i = questionnaire.A2_3i.Value,
                A2_3j = questionnaire.A2_3j.Value,
            };
            
        
            return View(viewModel);
            
        }

        [HttpPost]
        public ActionResult Page1Save(Questionnaire questionnaire)
        {

            if (questionnaire.Id == 0)
                _context.Questionnaires.Add(questionnaire);
            else

            {
                var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
                questionnaireInDB.A2_1 = questionnaire.A2_1;
                questionnaireInDB.A2_2 = questionnaire.A2_2;
                questionnaireInDB.A2_3a = questionnaire.A2_3a;
                questionnaireInDB.A2_3b = questionnaire.A2_3b;
                questionnaireInDB.A2_3c = questionnaire.A2_3c;
                questionnaireInDB.A2_3d = questionnaire.A2_3d;
                questionnaireInDB.A2_3e = questionnaire.A2_3e;
                questionnaireInDB.A2_3f = questionnaire.A2_3f;
                questionnaireInDB.A2_3g = questionnaire.A2_3g;
                questionnaireInDB.A2_3h = questionnaire.A2_3h;
                questionnaireInDB.A2_3i = questionnaire.A2_3i;
                questionnaireInDB.A2_3j = questionnaire.A2_3j;
                TryUpdateModel(questionnaireInDB);
            
            }

            _context.SaveChanges();

            return RedirectToAction("Page1", new { id = questionnaire.Id });
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