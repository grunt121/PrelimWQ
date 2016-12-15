﻿using System;
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
                A2_1 = questionnaire.A2_1.HasValue ? questionnaire.A2_1.Value : -88,
                A2_2 = questionnaire.A2_2.HasValue ? questionnaire.A2_2.Value : -88,
                A2_3a = questionnaire.A2_3a.HasValue ? questionnaire.A2_3a.Value : -88,
                A2_3b = questionnaire.A2_3b.HasValue ? questionnaire.A2_3b.Value : -88,
                A2_3c = questionnaire.A2_3c.HasValue ? questionnaire.A2_3c.Value : -88,
                A2_3d = questionnaire.A2_3d.HasValue ? questionnaire.A2_3d.Value : -88,
                A2_3e = questionnaire.A2_3e.HasValue ? questionnaire.A2_3e.Value : -88,
                A2_3f = questionnaire.A2_3f.HasValue ? questionnaire.A2_3f.Value : -88,
                A2_3g = questionnaire.A2_3g.HasValue ? questionnaire.A2_3g.Value : -88,
                A2_3h = questionnaire.A2_3h.HasValue ? questionnaire.A2_3h.Value : -88,
                A2_3i = questionnaire.A2_3i.HasValue ? questionnaire.A2_3i.Value : -88,
                A2_3j = questionnaire.A2_3j.HasValue ? questionnaire.A2_3j.Value : -88,
            };


          


            return View(viewModel);
            
        }

        [HttpPost]
        public ActionResult Page1Save(Page1ViewModel questionnaire, string SaveWork, string ProgressPage)
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
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page1", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page2", new { id = questionnaire.Id });
            }
        }

        

        //Page 2 Actions
        //Edit & View are combined into one
        public ActionResult Page2(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page2ViewModel
            {
                A2_4a = questionnaire.A2_4a.HasValue ? questionnaire.A2_4a.Value : -88,
                A2_4b = questionnaire.A2_4b.HasValue ? questionnaire.A2_4b.Value :-88,
                A2_4c = questionnaire.A2_4c.HasValue ? questionnaire.A2_4c.Value : -88,
                A2_4d = questionnaire.A2_4d.HasValue ? questionnaire.A2_4d.Value : -88,
                A2_4e = questionnaire.A2_4e.HasValue ? questionnaire.A2_4e.Value : -88,
                A2_4f = questionnaire.A2_4f.HasValue ? questionnaire.A2_4f.Value : -88,
                A2_4g = questionnaire.A2_4g.HasValue ? questionnaire.A2_4g.Value : -88,
                A2_4h = questionnaire.A2_4h.HasValue ? questionnaire.A2_4h.Value : -88,
                A2_4i = questionnaire.A2_4i.HasValue ? questionnaire.A2_4i.Value : -88,
                A2_4j = questionnaire.A2_4j.HasValue ? questionnaire.A2_4j.Value : -88,

            };


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Page2Save(Page2ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            questionnaireInDB.A2_4a = questionnaire.A2_4a;
            questionnaireInDB.A2_4b = questionnaire.A2_4b;
            questionnaireInDB.A2_4c = questionnaire.A2_4c;
            questionnaireInDB.A2_4d = questionnaire.A2_4d;
            questionnaireInDB.A2_4e = questionnaire.A2_4e;
            questionnaireInDB.A2_4f = questionnaire.A2_4f;
            questionnaireInDB.A2_4g = questionnaire.A2_4g;
            questionnaireInDB.A2_4h = questionnaire.A2_4h;
            questionnaireInDB.A2_4i = questionnaire.A2_4i;
            questionnaireInDB.A2_4j = questionnaire.A2_4j;
           
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page2", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page3", new { id = questionnaire.Id });
            }

           
        }


      

        //Page 3 Actions
        //Edit & View are combined into one
        public ActionResult Page3(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page3ViewModel
            {
                A2_5 = questionnaire.A2_5.HasValue ? questionnaire.A2_5.Value : -88,
                A2_6 = questionnaire.A2_6.HasValue ? questionnaire.A2_6.Value : -88,
                A2_7 = questionnaire.A2_7.HasValue ? questionnaire.A2_7.Value : -88,
                A2_8 = questionnaire.A2_8.HasValue ? questionnaire.A2_8.Value : -88,
                A2_9 = questionnaire.A2_9.HasValue ? questionnaire.A2_9.Value : -88,
                A2_10 = questionnaire.A2_10.HasValue ? questionnaire.A2_10.Value : -88,
                A2_11 = questionnaire.A2_11.HasValue ? questionnaire.A2_11.Value : -88,
                A2_12 = questionnaire.A2_12.HasValue ? questionnaire.A2_12.Value : -88,


            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page3Save(Page3ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            questionnaireInDB.A2_5 = questionnaire.A2_5;
            questionnaireInDB.A2_6 = questionnaire.A2_6;
            questionnaireInDB.A2_7 = questionnaire.A2_7;
            questionnaireInDB.A2_8 = questionnaire.A2_8;
            questionnaireInDB.A2_9 = questionnaire.A2_9;
            questionnaireInDB.A2_10 = questionnaire.A2_10;
            questionnaireInDB.A2_11 = questionnaire.A2_11;
            questionnaireInDB.A2_12 = questionnaire.A2_12;
            
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

           
            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page3", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page4", new { id = questionnaire.Id });
            }


        }

        


        //Page 4 Actions
        //Edit & View are combined into one
        public ActionResult Page4(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page4ViewModel
            {
                
                A2_13 = questionnaire.A2_13.HasValue ? questionnaire.A2_13.Value : -88,
                A2_14 = questionnaire.A2_14.HasValue ? questionnaire.A2_14.Value : -88,
                A2_15 = questionnaire.A2_15.HasValue ? questionnaire.A2_15.Value : -88,
                A2_16 = questionnaire.A2_16.HasValue ? questionnaire.A2_16.Value : -88,
                A2_17 = questionnaire.A2_17.HasValue ? questionnaire.A2_17.Value : -88,
                A2_18 = questionnaire.A2_18.HasValue ? questionnaire.A2_18.Value : -88,
                A2_19 = questionnaire.A2_19.HasValue ? questionnaire.A2_19.Value : -88,


            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page4Save(Page4ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            
            questionnaireInDB.A2_13 = questionnaire.A2_13;
            questionnaireInDB.A2_14 = questionnaire.A2_14;
            questionnaireInDB.A2_15 = questionnaire.A2_15;
            questionnaireInDB.A2_16 = questionnaire.A2_16;
            questionnaireInDB.A2_17 = questionnaire.A2_17;
            questionnaireInDB.A2_18 = questionnaire.A2_18;
            questionnaireInDB.A2_19 = questionnaire.A2_19;

            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page4", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page5", new { id = questionnaire.Id });
            }
        }

       

        //Page 5 Actions
        //Edit & View are combined into one
        public ActionResult Page5(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page5ViewModel
            {
                A3_1a = questionnaire.A3_1a.HasValue ? questionnaire.A3_1a.Value : -88,
                A3_1b = questionnaire.A3_1b.HasValue ? questionnaire.A3_1b.Value : -88,
                A3_1c = questionnaire.A3_1c.HasValue ? questionnaire.A3_1c.Value : -88,
                A3_1e = questionnaire.A3_1d.HasValue ? questionnaire.A3_1d.Value : -88,
                A3_2a = questionnaire.A3_2a.HasValue ? questionnaire.A3_2a.Value : -88,
                A3_2b = questionnaire.A3_2b.HasValue ? questionnaire.A3_2b.Value : -88,
                A3_2c = questionnaire.A3_2c.HasValue ? questionnaire.A3_2c.Value : -88,
                A3_2d = questionnaire.A3_2d.HasValue ? questionnaire.A3_2d.Value : -88,
                A3_2e = questionnaire.A3_2e.HasValue ? questionnaire.A3_2e.Value : -88,
                A3_2f = questionnaire.A3_2f.HasValue ? questionnaire.A3_2f.Value : -88,
                A3_2f_other = questionnaire.A3_2f_other,
                
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page5Save(Page5ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            questionnaireInDB.A3_1a = questionnaire.A3_1a;
            questionnaireInDB.A3_1b = questionnaire.A3_1b;
            questionnaireInDB.A3_1c = questionnaire.A3_1c;
            questionnaireInDB.A3_1d = questionnaire.A3_1d;
            questionnaireInDB.A3_2a = questionnaire.A3_2a;
            questionnaireInDB.A3_2b = questionnaire.A3_2b;
            questionnaireInDB.A3_2c = questionnaire.A3_2c;
            questionnaireInDB.A3_2d = questionnaire.A3_2d;
            questionnaireInDB.A3_2e = questionnaire.A3_2e;
            questionnaireInDB.A3_2f = questionnaire.A3_2f;
            questionnaireInDB.A3_2f_other = questionnaire.A3_2f_other;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page5", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page6", new { id = questionnaire.Id });
            }
        }

     

        //Page 6 Actions
        //Edit & View are combined into one
        public ActionResult Page6(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page6ViewModel
            {
                A4_1 = questionnaire.A4_1.HasValue ? questionnaire.A4_1.Value : -88,
                A4_2 = questionnaire.A4_2.HasValue ? questionnaire.A4_2.Value : -88,
                A4_3 = questionnaire.A4_3.HasValue ? questionnaire.A4_3.Value : -88,
                A4_4 = questionnaire.A4_4.HasValue ? questionnaire.A4_4.Value : -88,
                A4_5 = questionnaire.A4_5.HasValue ? questionnaire.A4_5.Value : -88,
                A4_6 = questionnaire.A4_6.HasValue ? questionnaire.A4_6.Value : -88,
                A4_7 = questionnaire.A4_7.HasValue ? questionnaire.A4_7.Value : -88,
                A4_8 = questionnaire.A4_8.HasValue ? questionnaire.A4_8.Value : -88,
                A4_9a = questionnaire.A4_9a.HasValue ? questionnaire.A4_9a.Value : -88,
                A4_9b = questionnaire.A4_9b.HasValue ? questionnaire.A4_9b.Value : -88,
                A4_9c = questionnaire.A4_9c.HasValue ? questionnaire.A4_9c.Value : -88,
                A4_9d = questionnaire.A4_9d.HasValue ? questionnaire.A4_9d.Value : -88,
                A4_10a = questionnaire.A4_10a.HasValue ? questionnaire.A4_10a.Value : -88,
                A4_10b = questionnaire.A4_10b.HasValue ? questionnaire.A4_10b.Value : -88,
                A4_10c = questionnaire.A4_10c.HasValue ? questionnaire.A4_10c.Value : -88,
                A4_10d = questionnaire.A4_10d.HasValue ? questionnaire.A4_10d.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page6Save(Page6ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            questionnaireInDB.A4_1 = questionnaire.A4_1;
            questionnaireInDB.A4_2 = questionnaire.A4_2;
            questionnaireInDB.A4_3 = questionnaire.A4_3;
            questionnaireInDB.A4_4 = questionnaire.A4_4;
            questionnaireInDB.A4_5 = questionnaire.A4_5;
            questionnaireInDB.A4_6 = questionnaire.A4_6;
            questionnaireInDB.A4_7 = questionnaire.A4_7;
            questionnaireInDB.A4_8 = questionnaire.A4_8;
            questionnaireInDB.A4_9a = questionnaire.A4_9a;
            questionnaireInDB.A4_9b = questionnaire.A4_9b;
            questionnaireInDB.A4_9c = questionnaire.A4_9c;
            questionnaireInDB.A4_9d = questionnaire.A4_9d;
            questionnaireInDB.A4_10a = questionnaire.A4_10a;
            questionnaireInDB.A4_10b = questionnaire.A4_10b;
            questionnaireInDB.A4_10c = questionnaire.A4_10c;
            questionnaireInDB.A4_10d = questionnaire.A4_10d;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page6", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page7", new { id = questionnaire.Id });
            }
        }

        [HttpPost]
    

        //Page 7 Actions
        //Edit & View are combined into one
        public ActionResult Page7(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page7ViewModel
            {
                A4_11a = questionnaire.A4_11a.HasValue ? questionnaire.A4_11a.Value : -88,
                A4_11b = questionnaire.A4_11b.HasValue ? questionnaire.A4_11b.Value : -88,
                A4_11c = questionnaire.A4_11c.HasValue ? questionnaire.A4_11c.Value : -88,
                A4_11d = questionnaire.A4_11d.HasValue ? questionnaire.A4_11d.Value : -88,
                A4_12a = questionnaire.A4_12a.HasValue ? questionnaire.A4_12a.Value : -88,
                A4_12b = questionnaire.A4_12b.HasValue ? questionnaire.A4_12b.Value : -88,
                A4_12c = questionnaire.A4_12c.HasValue ? questionnaire.A4_12c.Value : -88,
                A4_12d = questionnaire.A4_12d.HasValue ? questionnaire.A4_12d.Value : -88,
                A4_12e = questionnaire.A4_12e.HasValue ? questionnaire.A4_12e.Value : -88,
                A4_12f = questionnaire.A4_12f.HasValue ? questionnaire.A4_12f.Value : -88,
                A4_12g = questionnaire.A4_12g.HasValue ? questionnaire.A4_12g.Value : -88,


            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page7Save(Page7ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.A4_11a = questionnaire.A4_11a;
            questionnaireInDB.A4_11b = questionnaire.A4_11b;
            questionnaireInDB.A4_11c = questionnaire.A4_11c;
            questionnaireInDB.A4_11d = questionnaire.A4_11d;
            questionnaireInDB.A4_12a = questionnaire.A4_12a;
            questionnaireInDB.A4_12b = questionnaire.A4_12b;
            questionnaireInDB.A4_12c = questionnaire.A4_12c;
            questionnaireInDB.A4_12d = questionnaire.A4_12d;
            questionnaireInDB.A4_12e = questionnaire.A4_12e;
            questionnaireInDB.A4_12f = questionnaire.A4_12f;
            questionnaireInDB.A4_12g = questionnaire.A4_12g;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page7", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page8", new { id = questionnaire.Id });
            }
        }

      

        //Page 8 Actions
        //Edit & View are combined into one
        public ActionResult Page8(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page8ViewModel
            { 
                A5_1 = questionnaire.A5_1.HasValue ? questionnaire.A5_1.Value : -88,
                A5_2 = questionnaire.A5_2.HasValue ? questionnaire.A5_2.Value : -88,
                A5_3 = questionnaire.A5_3.HasValue ? questionnaire.A5_3.Value : -88,
                A5_4 = questionnaire.A5_4.HasValue ? questionnaire.A5_4.Value : -88,
                A5_5 = questionnaire.A5_5.HasValue ? questionnaire.A5_5.Value : -88,
                A5_6 = questionnaire.A5_6.HasValue ? questionnaire.A5_6.Value : -88,
                A5_7 = questionnaire.A5_7.HasValue ? questionnaire.A5_7.Value : -88,
                A5_8 = questionnaire.A5_8.HasValue ? questionnaire.A5_8.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page8Save(Page8ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.A5_1 = questionnaire.A5_1;
            questionnaireInDB.A5_2 = questionnaire.A5_2;
            questionnaireInDB.A5_3 = questionnaire.A5_3;
            questionnaireInDB.A5_4 = questionnaire.A5_4;
            questionnaireInDB.A5_5 = questionnaire.A5_5;
            questionnaireInDB.A5_6 = questionnaire.A5_6;
            questionnaireInDB.A5_7 = questionnaire.A5_7;
            questionnaireInDB.A5_8 = questionnaire.A5_8;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page8", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page9", new { id = questionnaire.Id });
            }
        }

       

        //Page 9 Actions
        //Edit & View are combined into one
        public ActionResult Page9(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page9ViewModel
            {
                A5_9 = questionnaire.A5_9.HasValue ? questionnaire.A5_9.Value : -88,
                A5_10 = questionnaire.A5_10.HasValue ? questionnaire.A5_10.Value : -88,
                A5_11 = questionnaire.A5_11.HasValue ? questionnaire.A5_11.Value : -88,
                A5_12 = questionnaire.A5_12.HasValue ? questionnaire.A5_12.Value : -88,
                A5_13 = questionnaire.A5_13.HasValue ? questionnaire.A5_13.Value : -88,
                A5_14 = questionnaire.A5_14.HasValue ? questionnaire.A5_14.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page9Save(Page9ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.A5_9 = questionnaire.A5_9;
            questionnaireInDB.A5_10 = questionnaire.A5_10;
            questionnaireInDB.A5_11 = questionnaire.A5_11;
            questionnaireInDB.A5_12 = questionnaire.A5_12;
            questionnaireInDB.A5_13 = questionnaire.A5_13;
            questionnaireInDB.A5_14 = questionnaire.A5_14;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page9", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page10", new { id = questionnaire.Id });
            }
        }

        

        //Page 10 Actions
        //Edit & View are combined into one
        public ActionResult Page10(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page10ViewModel
            {
                B1_stones = questionnaire.B1_stones.Value,
                B1_llbs = questionnaire.B1_llbs.Value,
                B1_kgs = questionnaire.B1_kgs.Value,
                B2_feet = questionnaire.B2_feet.Value,
                B2_inches = questionnaire.B2_inches.Value,
                B2_cms = questionnaire.B2_cms.Value,
                B3 = questionnaire.B3.HasValue ? questionnaire.B3.Value : -88,
                B4 = questionnaire.B4.HasValue ? questionnaire.B4.Value : -88,
                B5_a = questionnaire.B5_a.Value,
                B5_b = questionnaire.B5_b.Value,
                B5_c = questionnaire.B5_c.Value,
                B6 = questionnaire.B6.HasValue ? questionnaire.B6.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page10Save(Page10ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);


            questionnaireInDB.B1_stones = questionnaire.B1_stones;
            questionnaireInDB.B1_llbs = questionnaire.B1_llbs;
            questionnaireInDB.B1_kgs = questionnaire.B1_kgs;
            questionnaireInDB.B2_feet = questionnaire.B2_feet;
            questionnaireInDB.B2_inches = questionnaire.B2_inches;
            questionnaireInDB.B2_cms = questionnaire.B2_cms;
            questionnaireInDB.B3 = questionnaire.B3;
            questionnaireInDB.B4 = questionnaire.B4;
            questionnaireInDB.B5_a = questionnaire.B5_a;
            questionnaireInDB.B5_b = questionnaire.B5_b;
            questionnaireInDB.B5_c = questionnaire.B5_c;
            questionnaireInDB.B6 = questionnaire.B6;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page10", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page11", new { id = questionnaire.Id });
            }
        }

       

        //Page 11 Actions
        //Edit & View are combined into one
        public ActionResult Page11(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page11ViewModel
            {
                B7 = questionnaire.B7.HasValue ? questionnaire.B7.Value : -88,
                B_8a = questionnaire.B_8a.HasValue ? questionnaire.B_8a.Value : -88,
                B_8b = questionnaire.B_8b.HasValue ? questionnaire.B_8b.Value : -88,
                B_8c = questionnaire.B_8c.HasValue ? questionnaire.B_8c.Value : -88,
                B_8d = questionnaire.B_8d.HasValue ? questionnaire.B_8d.Value : -88,
                B_8e = questionnaire.B_8e.HasValue ? questionnaire.B_8e.Value : -88,
                B9 = questionnaire.B9.HasValue ? questionnaire.B9.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page11Save(Page11ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.B7 = questionnaire.B7;
            questionnaireInDB.B_8a = questionnaire.B_8a;
            questionnaireInDB.B_8b = questionnaire.B_8b;
            questionnaireInDB.B_8c = questionnaire.B_8c;
            questionnaireInDB.B_8d = questionnaire.B_8d;
            questionnaireInDB.B_8e = questionnaire.B_8e;
            questionnaireInDB.B9 = questionnaire.B9;
            
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page11", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page12", new { id = questionnaire.Id });
            }
        }

       

        //Page 12 Actions
        //Edit & View are combined into one
        public ActionResult Page12(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page12ViewModel
            {
                C1_DOB = questionnaire.C1_DOB.Value,
                C2= questionnaire.C2.HasValue ? questionnaire.C2.Value : -88,
                C3 = questionnaire.C3.HasValue ? questionnaire.C3.Value : -88,
                C3_other = questionnaire.C3_other,
                C4 = questionnaire.C4.Value,
                C5 = questionnaire.C5.HasValue ? questionnaire.C5.Value : -88,
                C6_a = questionnaire.C6_a.HasValue ? questionnaire.C6_a.Value : -88,
                C6_b = questionnaire.C6_b.HasValue ? questionnaire.C6_b.Value : -88,
                C6_c = questionnaire.C6_c.HasValue ? questionnaire.C6_c.Value : -88,
                C6_d = questionnaire.C6_d.HasValue ? questionnaire.C6_d.Value : -88,
                C6_e = questionnaire.C6_e.HasValue ? questionnaire.C6_e.Value : -88,
                C7 = questionnaire.C7.HasValue ? questionnaire.C7.Value : -88,


            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page12Save(Page12ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.C1_DOB = questionnaire.C1_DOB;
            questionnaireInDB.C2 = questionnaire.C2;
            questionnaireInDB.C3 = questionnaire.C3;
            questionnaireInDB.C3_other = questionnaire.C3_other;
            questionnaireInDB.C4 = questionnaire.C4;
            questionnaireInDB.C5 = questionnaire.C5;
            questionnaireInDB.C6_a = questionnaire.C6_a;
            questionnaireInDB.C6_b = questionnaire.C6_b;
            questionnaireInDB.C6_c = questionnaire.C6_c;
            questionnaireInDB.C6_d = questionnaire.C6_d;
            questionnaireInDB.C6_e = questionnaire.C6_e;
            questionnaireInDB.C7 = questionnaire.C7;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page12", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page13", new { id = questionnaire.Id });
            }
        }

        

        //Page 13 Actions
        //Edit & View are combined into one
        public ActionResult Page13(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page13ViewModel
            {
                C8 = questionnaire.C8.HasValue ? questionnaire.C8.Value : -88,
                C9 = questionnaire.C9.HasValue ? questionnaire.C9.Value : -88,
                C_10a = questionnaire.C_10a.HasValue ? questionnaire.C_10a.Value : -88,
                C_10b = questionnaire.C_10b.HasValue ? questionnaire.C_10b.Value : -88,
                C_10c = questionnaire.C_10c.HasValue ? questionnaire.C_10c.Value : -88,
                C_10d = questionnaire.C_10d.HasValue ? questionnaire.C_10d.Value : -88,
                C_10e = questionnaire.C_10e.HasValue ? questionnaire.C_10e.Value : -88,
                C_10f = questionnaire.C_10f.HasValue ? questionnaire.C_10f.Value : -88,
                C11 = questionnaire.C11.HasValue ? questionnaire.C11.Value : -88,

            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page13Save(Page13ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.C8 = questionnaire.C8;
            questionnaireInDB.C9 = questionnaire.C9;
            questionnaireInDB.C_10a = questionnaire.C_10a;
            questionnaireInDB.C_10b = questionnaire.C_10b;
            questionnaireInDB.C_10c = questionnaire.C_10c;
            questionnaireInDB.C_10d = questionnaire.C_10d;
            questionnaireInDB.C_10e = questionnaire.C_10e;
            questionnaireInDB.C_10f = questionnaire.C_10f;
            questionnaireInDB.C11 = questionnaire.C11;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page13", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page14", new { id = questionnaire.Id });
            }
        }

      

        //Page 14 Actions
        //Edit & View are combined into one
        public ActionResult Page14(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page14ViewModel
            {
                C12 = questionnaire.C12,
                C13 = questionnaire.C13,
                C14 = questionnaire.C14,
                C15 = questionnaire.C15,
                C16 = questionnaire.C16.HasValue ? questionnaire.C16.Value : -88,
                C17 = questionnaire.C17.HasValue ? questionnaire.C17.Value : -88,
                C18 = questionnaire.C18.HasValue ? questionnaire.C18.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page14Save(Page14ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);
            questionnaireInDB.C12 = questionnaire.C12;
            questionnaireInDB.C13 = questionnaire.C13;
            questionnaireInDB.C14 = questionnaire.C14;
            questionnaireInDB.C15 = questionnaire.C15;
            questionnaireInDB.C16 = questionnaire.C16;
            questionnaireInDB.C17 = questionnaire.C17;
            questionnaireInDB.C18 = questionnaire.C18;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page14", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page15", new { id = questionnaire.Id });
            }
        }

        

        //Page 15 Actions
        //Edit & View are combined into one
        public ActionResult Page15(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page15ViewModel
            {
                C19 = questionnaire.C19.HasValue ? questionnaire.C19.Value : -88,
                C20 = questionnaire.C20.HasValue ? questionnaire.C20.Value : -88,
                C21 = questionnaire.C20.HasValue ? questionnaire.C20.Value : -88,
                C22 = questionnaire.C20.HasValue ? questionnaire.C20.Value : -88,
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page15Save(Page15ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.C19 = questionnaire.C19;
            questionnaireInDB.C20 = questionnaire.C20;
            questionnaireInDB.C21 = questionnaire.C21;
            questionnaireInDB.C22 = questionnaire.C22;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page15", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page16", new { id = questionnaire.Id });
            }
        }



        //Page 16 Actions
        //Edit & View are combined into one
        public ActionResult Page16(int id)
        {
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == id);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page16ViewModel
            {

                ConsentToFutureStudies = questionnaire.ConsentToFutureStudies.Value,
                ConsentToHistoricStudies = questionnaire.ConsentToHistoricStudies.Value,
                ConsentToMRR = questionnaire.ConsentToMRR.Value,
                Title = questionnaire.Title,
                Forename = questionnaire.Forename,
                Surname = questionnaire.Surname,
                Address1 = questionnaire.Address1,
                Address2 = questionnaire.Address2,
                TownCity = questionnaire.TownCity,
                County = questionnaire.County,
                Postcode = questionnaire.Postcode,
                TelephoneNumber = questionnaire.TelephoneNumber,
                SurveySubmitted = questionnaire.SurveySubmitted.Value
            };


            return View(viewModel);

        }
        [HttpPost]
        public ActionResult Page16Save(Page16ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == questionnaire.Id);

            questionnaireInDB.ConsentToFutureStudies = questionnaire.ConsentToFutureStudies;
            questionnaireInDB.ConsentToHistoricStudies = questionnaire.ConsentToHistoricStudies;
            questionnaireInDB.ConsentToMRR = questionnaire.ConsentToMRR;
            questionnaireInDB.Title = questionnaire.Title;
            questionnaireInDB.Forename = questionnaire.Forename;
            questionnaireInDB.Surname = questionnaire.Surname;
            questionnaireInDB.Address1 = questionnaire.Address1;
            questionnaireInDB.Address2 = questionnaire.Address2;
            questionnaireInDB.TownCity = questionnaire.TownCity;
            questionnaireInDB.County = questionnaire.County;
            questionnaireInDB.Postcode = questionnaire.Postcode;
            questionnaireInDB.TelephoneNumber = questionnaire.TelephoneNumber;
            questionnaireInDB.SurveySubmitted = questionnaire.SurveySubmitted;
            TryUpdateModel(questionnaireInDB);
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page16", new { id = questionnaire.Id });
            }
            else
            {
                return RedirectToAction("Page16", new { id = questionnaire.Id }); //At the moment there is no progression page
            }
        }

    }
}