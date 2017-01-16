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
    [Authorize]
    public class QuestionnairesController : Controller
    {

        #region DBContext
        //Setting DB Context
        private ApplicationDbContext _context;
        private PrelimMailEntities PrelimContext;
       
        public QuestionnairesController()
        {
            _context = new ApplicationDbContext();
            PrelimContext = new PrelimMailEntities();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            PrelimContext.Dispose();
        }
        #endregion



        // GET: Questionnaire
        public ActionResult Index()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");


            return View();
        }


        #region Page1
        //Page 1 Actions
        //Edit & View are combined into one
        public ActionResult Page1()
        {
            if (isSurveyCompleted() || isThereAY1()) 
                return RedirectToAction("SurveyCompleted");


            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid );
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
        [ValidateAntiForgeryToken]
        public ActionResult Page1Save(Page1ViewModel questionnaire, string SaveWork, string ProgressPage)
        {

            int qid = questionnaireIDFromLogin();
            int sid = studyIDFromLogin();


            var hasResponsesInDB = PrelimContext.MailParticipants.Where(x => x.StudyId == sid).Any(x => x.MailResponses.Count > 0);
            if (hasResponsesInDB == false)
            {
                var electronicResponse = PrelimContext.MailParticipants.Where(x => x.StudyId == sid).First();
                PrelimContext.MailResponses.Add(new MailRespons()
                {
                    ParticipantId = electronicResponse.ParticipantId,
                    ResponseTypeId = 2,
                    Signature = true,
                    Dated = true,
                    DateResponseLogged = DateTime.Now,
                    CreationDate = DateTime.Now,
                    UpdatedBy = "WebSurvey",
                });
                PrelimContext.SaveChanges();

            }


            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
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
            questionnaireInDB.A_1a = setMobility(Request.QueryString["MOBILITY"]);
            questionnaireInDB.A_1b = setSelfCare(Request.QueryString["SELFCARE"]);
            questionnaireInDB.A_1c = setUsualActivities(Request.QueryString["USUALACTIVITIES"]);
            questionnaireInDB.A1_d = setPainDiscomfort(Request.QueryString["PAINDISCOMFORT"]);
            questionnaireInDB.A1_e = setAnxietyDepression(Request.QueryString["ANXIETYDEPRESSION"]);
            questionnaireInDB.A_1_health = setHealthScore(Request.QueryString["VAS"]);
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();

            if (string.IsNullOrWhiteSpace(ProgressPage))
            {
                return RedirectToAction("Page1");
            }
            else
            {
                return RedirectToAction("Page2");
            }
        }

        #endregion


        #region Page2
       
        public ActionResult Page2()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page2ViewModel
            {
                A2_4a = questionnaire.A2_4a.HasValue ? questionnaire.A2_4a.Value : -88,
                A2_4b = questionnaire.A2_4b.HasValue ? questionnaire.A2_4b.Value : -88,
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
        [ValidateAntiForgeryToken]
        public ActionResult Page2Save(Page2ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
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

            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();

            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page1");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page2");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page3");
            }

            return View();

        }


        #endregion


        #region Page3
        //Page 3 Actions
        //Edit & View are combined into one
        public ActionResult Page3()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page3Save(Page3ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
            questionnaireInDB.A2_5 = questionnaire.A2_5;
            questionnaireInDB.A2_6 = questionnaire.A2_6;
            questionnaireInDB.A2_7 = questionnaire.A2_7;
            questionnaireInDB.A2_8 = questionnaire.A2_8;
            questionnaireInDB.A2_9 = questionnaire.A2_9;
            questionnaireInDB.A2_10 = questionnaire.A2_10;
            questionnaireInDB.A2_11 = questionnaire.A2_11;
            questionnaireInDB.A2_12 = questionnaire.A2_12;

            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();

            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page2");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page3");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page4");
            }

            return View();


        }

        #endregion


        #region Page4

        //Page 4 Actions
        //Edit & View are combined into one
        public ActionResult Page4()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page4Save(Page4ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {


            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.A2_13 = questionnaire.A2_13;
            questionnaireInDB.A2_14 = questionnaire.A2_14;
            questionnaireInDB.A2_15 = questionnaire.A2_15;
            questionnaireInDB.A2_16 = questionnaire.A2_16;
            questionnaireInDB.A2_17 = questionnaire.A2_17;
            questionnaireInDB.A2_18 = questionnaire.A2_18;
            questionnaireInDB.A2_19 = questionnaire.A2_19;

            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page3");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page4");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page5");
            }

            return View();
        }
        #endregion


        #region Page5
        //Page 5 Actions
        //Edit & View are combined into one
        public ActionResult Page5()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page5ViewModel
            {
                A3_1a = questionnaire.A3_1a.HasValue ? questionnaire.A3_1a.Value : -88,
                A3_1b = questionnaire.A3_1b.HasValue ? questionnaire.A3_1b.Value : -88,
                A3_1c = questionnaire.A3_1c.HasValue ? questionnaire.A3_1c.Value : -88,
                A3_1d = questionnaire.A3_1d.HasValue ? questionnaire.A3_1d.Value : -88,
                A3_1e = questionnaire.A3_1e.HasValue ? questionnaire.A3_1e.Value : -88,
                A3_2a = questionnaire.A3_2a.HasValue ? questionnaire.A3_2a.Value : -88,
                A3_2b = questionnaire.A3_2b.HasValue ? questionnaire.A3_2b.Value : -88,
                A3_2c = questionnaire.A3_2c.HasValue ? questionnaire.A3_2c.Value : -88,
                A3_2d = questionnaire.A3_2d.HasValue ? questionnaire.A3_2d.Value : -88,
                A3_2e = questionnaire.A3_2e.HasValue ? questionnaire.A3_2e.Value : -88,
                A3_2f = questionnaire.A3_2f.HasValue ? questionnaire.A3_2f.Value : -88,
                A3_2f_other = questionnaire.A3_2f_other,

            };

            if ((questionnaire.A3_2f == 1) && string.IsNullOrEmpty(questionnaire.A3_2f_other))
            {
                ModelState.AddModelError("A3_2f_other", "Please provide details");

            }
            return View(viewModel);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Page5Save(Page5ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
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
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            //Checking for missing data because of selection
            if ((questionnaire.A3_2f == 1) && string.IsNullOrEmpty(questionnaire.A3_2f_other))
            {
                return RedirectToAction("Page5");

            }


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page4");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page5");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page6");
            }

            return View();
        }

        #endregion


        #region Page6
        //Page 6 Actions
        //Edit & View are combined into one
        public ActionResult Page6()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page6Save(Page6ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
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
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page5");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page6");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page7");
            }

            return View();
        }
        #endregion


        #region Page7
        //Page 7 Actions
        //Edit & View are combined into one
        public ActionResult Page7()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page7Save(Page7ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {
            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

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
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();



            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page6");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page7");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page8");
            }

            return View();
        }
        #endregion


        #region Page8
        //Page 8 Actions
        //Edit & View are combined into one
        public ActionResult Page8()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page8Save(Page8ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {
            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.A5_1 = questionnaire.A5_1;
            questionnaireInDB.A5_2 = questionnaire.A5_2;
            questionnaireInDB.A5_3 = questionnaire.A5_3;
            questionnaireInDB.A5_4 = questionnaire.A5_4;
            questionnaireInDB.A5_5 = questionnaire.A5_5;
            questionnaireInDB.A5_6 = questionnaire.A5_6;
            questionnaireInDB.A5_7 = questionnaire.A5_7;
            questionnaireInDB.A5_8 = questionnaire.A5_8;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page7");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page8");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page9");
            }

            return View();
        }

        #endregion


        #region Page9
        //Page 9 Actions
        //Edit & View are combined into one
        public ActionResult Page9()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page9Save(Page9ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.A5_9 = questionnaire.A5_9;
            questionnaireInDB.A5_10 = questionnaire.A5_10;
            questionnaireInDB.A5_11 = questionnaire.A5_11;
            questionnaireInDB.A5_12 = questionnaire.A5_12;
            questionnaireInDB.A5_13 = questionnaire.A5_13;
            questionnaireInDB.A5_14 = questionnaire.A5_14;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page8");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page9");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page10");
            }

            return View();
        }

        #endregion


        #region Page10
        //Page 10 Actions
        //Edit & View are combined into one
        public ActionResult Page10()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page10ViewModel
            {
               
                B1_stones = questionnaire.B1_stones.HasValue ? questionnaire.B1_stones.Value : 0,
                B1_llbs = questionnaire.B1_llbs.HasValue ? questionnaire.B1_llbs.Value : 0,
                B1_kgs = questionnaire.B1_kgs.HasValue ? questionnaire.B1_kgs.Value : 0,
                B2_feet = questionnaire.B2_feet.HasValue ? questionnaire.B2_feet.Value : 0,
                B2_inches = questionnaire.B2_inches.HasValue ? questionnaire.B2_inches.Value : 0,
                B2_cms = questionnaire.B2_cms.HasValue ? questionnaire.B2_cms.Value : 0,
                B3 = questionnaire.B3.HasValue ? questionnaire.B3.Value : -88,
                B4 = questionnaire.B4.HasValue ? questionnaire.B4.Value : -88,
                B5_a = questionnaire.B5_a.HasValue ? questionnaire.B5_a.Value : 0,
                B5_b = questionnaire.B5_b.HasValue ? questionnaire.B5_b.Value : 0,
                B5_c = questionnaire.B5_c.HasValue ? questionnaire.B5_c.Value : 0,
                B6 = questionnaire.B6.HasValue ? questionnaire.B6.Value : -88,
            };


            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Page10Save(Page10ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);


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
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page9");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page10");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page11");
            }

            return View();
        }
        #endregion


        #region Page11

        //Page 11 Actions
        //Edit & View are combined into one
        public ActionResult Page11()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page11Save(Page11ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.B7 = questionnaire.B7;
            questionnaireInDB.B_8a = questionnaire.B_8a;
            questionnaireInDB.B_8b = questionnaire.B_8b;
            questionnaireInDB.B_8c = questionnaire.B_8c;
            questionnaireInDB.B_8d = questionnaire.B_8d;
            questionnaireInDB.B_8e = questionnaire.B_8e;
            questionnaireInDB.B9 = questionnaire.B9;

            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();

            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page10");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page11");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page12");
            }

            return View();
        }

        #endregion


        #region Page12
        //Page 12 Actions
        //Edit & View are combined into one
        public ActionResult Page12()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page12ViewModel
            {
                C1_DOB = questionnaire.C1_DOB.HasValue ? questionnaire.C1_DOB.Value : DateTime.Parse("01/01/1901"),
                C2 = questionnaire.C2.HasValue ? questionnaire.C2.Value : -88,
                C3 = questionnaire.C3.HasValue ? questionnaire.C3.Value : -88,
                C3_other = questionnaire.C3_other,
                C4 = questionnaire.C4.HasValue ? questionnaire.C4.Value : 0,
                C5 = questionnaire.C5.HasValue ? questionnaire.C5.Value : -88,
                C6_a = questionnaire.C6_a.HasValue ? questionnaire.C6_a.Value : false,
                C6_b = questionnaire.C6_b.HasValue ? questionnaire.C6_b.Value : false,
                C6_c = questionnaire.C6_c.HasValue ? questionnaire.C6_c.Value : false,
                C6_d = questionnaire.C6_d.HasValue ? questionnaire.C6_d.Value : false,
                C6_e = questionnaire.C6_e.HasValue ? questionnaire.C6_e.Value : false,
                C7 = questionnaire.C7.HasValue ? questionnaire.C7.Value : -88,


            };

            if ((questionnaire.C3 == 9) && string.IsNullOrEmpty(questionnaire.C3_other))
            {
                ModelState.AddModelError("C3_other", "Please provide details");

            }


            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Page12Save(Page12ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

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
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();

            //Checking for missing data because of selection
            if ((questionnaire.C3 == 9) && string.IsNullOrEmpty(questionnaire.C3_other))
            {
                return RedirectToAction("Page12");

            }


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page11");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page12");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page13");
            }

            return View();
        }


        #endregion

        #region Page13
        //Page 13 Actions
        //Edit & View are combined into one
        public ActionResult Page13()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page13Save(Page13ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.C8 = questionnaire.C8;
            questionnaireInDB.C9 = questionnaire.C9;
            questionnaireInDB.C_10a = questionnaire.C_10a;
            questionnaireInDB.C_10b = questionnaire.C_10b;
            questionnaireInDB.C_10c = questionnaire.C_10c;
            questionnaireInDB.C_10d = questionnaire.C_10d;
            questionnaireInDB.C_10e = questionnaire.C_10e;
            questionnaireInDB.C_10f = questionnaire.C_10f;
            questionnaireInDB.C11 = questionnaire.C11;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page12");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page13");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page14");
            }

            return View();
        }

        #endregion


        #region Page14
        //Page 14 Actions
        //Edit & View are combined into one
        public ActionResult Page14()
        {
            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
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
        [ValidateAntiForgeryToken]
        public ActionResult Page14Save(Page14ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage, string SkipTo16)
        {
            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
            questionnaireInDB.C12 = questionnaire.C12;
            questionnaireInDB.C13 = questionnaire.C13;
            questionnaireInDB.C14 = questionnaire.C14;
            questionnaireInDB.C15 = questionnaire.C15;
            questionnaireInDB.C16 = questionnaire.C16;
            questionnaireInDB.C17 = questionnaire.C17;
            questionnaireInDB.C18 = questionnaire.C18;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page13");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page14");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page15");
            }

            if (!string.IsNullOrWhiteSpace(SkipTo16))
            {
                return RedirectToAction("Page16");

            }

            return View();
        }

        #endregion


        #region Page15
        //Page 15 Actions
        //Edit & View are combined into one
        public ActionResult Page15()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            var viewModel = new Page15ViewModel
            {
                C19 = questionnaire.C19.HasValue ? questionnaire.C19.Value : 0,
                C20 = questionnaire.C20.HasValue ? questionnaire.C20.Value : 0,
                C21 = questionnaire.C20.HasValue ? questionnaire.C20.Value : 0,
                C22 = questionnaire.C20.HasValue ? questionnaire.C20.Value : 0,
            };


            return View(viewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Page15Save(Page15ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage)
        {

            int qid = questionnaireIDFromLogin();
            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);

            questionnaireInDB.C19 = questionnaire.C19;
            questionnaireInDB.C20 = questionnaire.C20;
            questionnaireInDB.C21 = questionnaire.C21;
            questionnaireInDB.C22 = questionnaire.C22;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
                return RedirectToAction("Page14");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page15");

            }

            if ((string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(SaveWork)) && (!string.IsNullOrWhiteSpace(ProgressPage)))
            {
                return RedirectToAction("Page16");
            }

            return View();
        } 
        #endregion


        #region Page 16
        //Page 16 Actions
        //Edit & View are combined into one
        public ActionResult Page16()
        {

            if (isSurveyCompleted() || isThereAY1())
                return RedirectToAction("SurveyCompleted");

            int qid = questionnaireIDFromLogin();
            var questionnaire = _context.Questionnaires.SingleOrDefault(q => q.Id == qid);
            if (questionnaire == null)
                return HttpNotFound();

            int sid = studyIDFromLogin();           
            var patientAddress = PrelimContext.MailParticipants.SingleOrDefault(x => x.StudyId == sid);


            Page16ViewModel viewModel = new Page16ViewModel();
               

            if (TempData["tempQuestion"] != null)
            {
                viewModel = TempData["tempQuestion"] as Page16ViewModel;
                ModelState.AddModelError("Title", "Please provide your Title");

                if (viewModel.ConsentToMRR == 1 || viewModel.ConsentToFutureStudies == 1 || viewModel.ConsentToHistoricStudies == 1)
                {

                    if (viewModel.Title == "0" || string.IsNullOrWhiteSpace(viewModel.Title))
                    {

                        ModelState.AddModelError("Title", "Please provide your Title");

                    }

                    if (viewModel.Forename == "0" || string.IsNullOrWhiteSpace(viewModel.Forename))
                    {

                        ModelState.AddModelError("Forename", "Please provide your Forename");
                    }

                    if (viewModel.Surname == "0" || string.IsNullOrWhiteSpace(viewModel.Surname))
                    {
                        ModelState.AddModelError("Surname", "Please provide your Surname");
                    }

                    if (viewModel.Address1 == "0" || string.IsNullOrWhiteSpace(viewModel.Address1))
                    {
                        ModelState.AddModelError("Address1", "Please provide the first of your address");
                    }

                    if (viewModel.TownCity == "0" || string.IsNullOrWhiteSpace(viewModel.TownCity))
                    {
                        ModelState.AddModelError("TownCity", "Please provide your Town or City");
                    }

                    if (viewModel.County == "0" || string.IsNullOrWhiteSpace(viewModel.County))
                    {
                        ModelState.AddModelError("County", "Please provide your County");
                    }

                    if (viewModel.Postcode == "0" || string.IsNullOrWhiteSpace(viewModel.Postcode))
                    {
                        ModelState.AddModelError("Postcode", "Please provide your Postcode");
                    }

                }


            }
             else
            {
                 viewModel = new Page16ViewModel
                {
                    ConsentToMRR = 0,
                    ConsentToFutureStudies = 0,
                    ConsentToHistoricStudies = 0,
                    Title = patientAddress.Title,
                    Forename = patientAddress.Forename,
                    Surname = patientAddress.Surname,
                    Address1 = patientAddress.AddressLine1,
                    Address2 = patientAddress.AddressLine2,
                    TownCity = patientAddress.TownCity,
                    County = patientAddress.County,
                    Postcode = patientAddress.Postcode,
                    TelephoneNumber = patientAddress.TelNumber,
                    SurveySubmitted =  false
                };
            }


            return View(viewModel);
           
            

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Page16Save(Page16ViewModel questionnaire, string SaveWork, string ProgressPage, string PreviousPage, string SubmitSurvey)
        {

            if (questionnaire.ConsentToMRR == 1 || questionnaire.ConsentToFutureStudies == 1 || questionnaire.ConsentToHistoricStudies == 1)
            {

                if (questionnaire.Title == "0" || string.IsNullOrWhiteSpace(questionnaire.Title))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");

                }

                if (questionnaire.Forename == "0" || string.IsNullOrWhiteSpace(questionnaire.Forename))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

                if (questionnaire.Surname == "0" || string.IsNullOrWhiteSpace(questionnaire.Surname))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

                if (questionnaire.Address1 == "0" || string.IsNullOrWhiteSpace(questionnaire.Address1))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

                if (questionnaire.TownCity == "0" || string.IsNullOrWhiteSpace(questionnaire.TownCity))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

                if (questionnaire.County == "0" || string.IsNullOrWhiteSpace(questionnaire.County))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

                if (questionnaire.Postcode == "0" || string.IsNullOrWhiteSpace(questionnaire.Postcode))
                {
                    TempData["tempQuestion"] = questionnaire;
                    return RedirectToAction("Page16");
                }

            }

            int qid = questionnaireIDFromLogin();
            int sid = studyIDFromLogin();

            var questionnaireInDB = _context.Questionnaires.Single(m => m.Id == qid);
            questionnaireInDB.SurveySubmitted = false;
            _context.Entry(questionnaireInDB).State = EntityState.Modified;
            _context.SaveChanges();


            //Updating the PatientDetails Table
            var updatedPatientAddress = PrelimContext.MailParticipants.Where(x => x.StudyId == sid).First();
            updatedPatientAddress.Title = string.IsNullOrWhiteSpace(questionnaire.Title) ? "0" : questionnaire.Title;
            updatedPatientAddress.Forename = string.IsNullOrWhiteSpace(questionnaire.Forename) ? "0" : questionnaire.Forename;
            updatedPatientAddress.Surname = string.IsNullOrWhiteSpace(questionnaire.Surname) ? "0" : questionnaire.Surname;
            updatedPatientAddress.AddressLine1 = string.IsNullOrWhiteSpace(questionnaire.Address1) ? "0" : questionnaire.Address1;
            updatedPatientAddress.AddressLine2 = string.IsNullOrWhiteSpace(questionnaire.Address2) ? "0" : questionnaire.Address2;
            updatedPatientAddress.TownCity = string.IsNullOrWhiteSpace(questionnaire.TownCity) ? "0" : questionnaire.TownCity;
            updatedPatientAddress.County = string.IsNullOrWhiteSpace(questionnaire.County) ? "0" : questionnaire.County;
            updatedPatientAddress.Postcode = string.IsNullOrWhiteSpace(questionnaire.Postcode) ? "0" : questionnaire.Postcode;
            updatedPatientAddress.TelNumber = string.IsNullOrWhiteSpace(questionnaire.TelephoneNumber) ? "0" : questionnaire.TelephoneNumber;
            PrelimContext.Entry(updatedPatientAddress).State = EntityState.Modified;
            PrelimContext.SaveChanges();

            //Checking Name & Address is Set

            if ((!string.IsNullOrWhiteSpace(PreviousPage)) && (string.IsNullOrWhiteSpace(ProgressPage)) && (string.IsNullOrWhiteSpace(SaveWork)))
            {
               
                return RedirectToAction("Page15");
            }

            if ((string.IsNullOrWhiteSpace(ProgressPage)) && (!string.IsNullOrWhiteSpace(SaveWork)) && (string.IsNullOrWhiteSpace(PreviousPage)))
            {
                return RedirectToAction("Page16");

            }

            if (!string.IsNullOrWhiteSpace(SubmitSurvey))
            {
                //CreatingY1Response
                var hasY1InDB = PrelimContext.MailResponses.Where(x => x.ParticipantId == sid & x.ResponseTypeId == 1).Any();
                if (hasY1InDB == false)
                {
                    var Y1Response = PrelimContext.MailParticipants.Where(x => x.StudyId == sid).First();
                    PrelimContext.MailResponses.Add(new MailRespons()
                    {
                        ParticipantId = Y1Response.ParticipantId,
                        ResponseTypeId = 1,
                        Signature = true,
                        Dated = true,
                        DateResponseLogged = DateTime.Now,
                        CreationDate = DateTime.Now,
                        UpdatedBy = "WebSurvey",
                    });
                    PrelimContext.SaveChanges();

                }

                //SelectY1 for Participant ID
                var selectedMailResponse = this.PrelimContext.MailResponses
                                          .Where(n => n.ParticipantId == sid || n.ResponseTypeId == 1)
                                          .OrderByDescending(t => t.CreationDate)
                                          .FirstOrDefault();


                //Create MailResponse & Set Consents
                var hasResponsesForConsent = PrelimContext.MailResponseConsents.Where(x => x.ResponseId == selectedMailResponse.ResponseId).Any();
                if (hasResponsesForConsent == false)
                {
                    var createConsentMRR = PrelimContext.MailResponseConsents.Where(x => x.ResponseId == selectedMailResponse.ResponseId).Any();
                    PrelimContext.MailResponseConsents.Add(new MailResponseConsent()
                    {

                        ResponseId = selectedMailResponse.ResponseId,
                        ConsentId = 1,
                        Selected = questionnaire.ConsentToMRR
                    });
                    PrelimContext.SaveChanges();

                    var createConsentHistoric = PrelimContext.MailResponseConsents.Where(x => x.ResponseId == selectedMailResponse.ResponseId).Any();
                    PrelimContext.MailResponseConsents.Add(new MailResponseConsent()
                    {

                        ResponseId = selectedMailResponse.ResponseId,
                        ConsentId = 2,
                        Selected = questionnaire.ConsentToHistoricStudies
                    });
                    PrelimContext.SaveChanges();

                    var createConsentFuture = PrelimContext.MailResponseConsents.Where(x => x.ResponseId == selectedMailResponse.ResponseId).Any();
                    PrelimContext.MailResponseConsents.Add(new MailResponseConsent()
                    {

                        ResponseId = selectedMailResponse.ResponseId,
                        ConsentId = 3,
                        Selected = questionnaire.ConsentToFutureStudies
                    });
                    PrelimContext.SaveChanges();

                    //Mark Survey As Submitted
                    questionnaireInDB.SurveySubmitted = true;
                    _context.Entry(questionnaireInDB).State = EntityState.Modified;
                    _context.SaveChanges();

                    return RedirectToAction("Thanks");
                }
            }

            return View();
        }

        #endregion


        public ActionResult SurveyCompleted()
        {
            return View();
        }


        public ActionResult Thanks()
        {
            return View();
        }


        #region Helpers
        private bool isSurveyCompleted()
        {

            var userRecord = _context.Export.Where(x => x.OnlineIdLogin == User.Identity.Name).FirstOrDefault();
            var questionnaire = _context.Questionnaires.Where(x => x.StudyID == userRecord.StudyId).FirstOrDefault();

            //var hasY1InDB = PrelimContext.MailResponses.Where(x => x.ParticipantId == userRecord.StudyId || x.ResponseTypeId == 1).Any();

            if (questionnaire != null)
            {
             if (questionnaire.SurveySubmitted  != true)
                        {
                            return false;
                        } else
                {
                    return true;
                }
            }  return false;
        }

        private int questionnaireIDFromLogin()
        {
            var userRecordExport = _context.Export.Where(x => x.OnlineIdLogin == User.Identity.Name).FirstOrDefault();
            var questionnaire = _context.Questionnaires.Where(x => x.StudyID == userRecordExport.StudyId).FirstOrDefault();
            if (questionnaire.Id !=0)
            {
                return questionnaire.Id;
            }
            return 0;

        }

        private int studyIDFromLogin()
        {
            var userRecordExport = _context.Export.Where(x => x.OnlineIdLogin == User.Identity.Name).FirstOrDefault();
            
            if (userRecordExport.StudyId  != 0)
            {
                return userRecordExport.StudyId.Value;
            }
            return 0;

        }

        private int participantIDFromStudyID(int onlineID)
        {
            var userParticipantID = PrelimContext.MailParticipants.Where(x => x.StudyId == onlineID).FirstOrDefault();
            if (userParticipantID != null)
            {
                return userParticipantID.ParticipantId;
            }
            return 0;

        }

        private bool isThereAY1()
        {
            int studyID = studyIDFromLogin();
            //int intPassedOnlineID = Int32.Parse(User.Identity.Name);
            int participantID = participantIDFromStudyID(studyID);

            var hasY1InDB = PrelimContext.MailResponses.Where(x => x.ParticipantId == participantID & x.ResponseTypeId == 1).Any();
            if (hasY1InDB != true)
            {
                return false;
            }

            return true;
        }

        private int setMobility(string mobility)
        {
            if(!string.IsNullOrEmpty(mobility))
            {
                switch (mobility)
                {
                    case "I_HAVE_NO_PROBLEMS_IN_WALKING_AB":
                        return 1;
                    case "I_HAVE_SLIGHT_PROBLEMS_IN_WALKIN":
                        return 2;
                    case "I_HAVE_MODERATE_PROBLEMS_IN_WALK":
                        return 3;
                    case "I_HAVE_SEVERE_PROBLEMS_IN_WALKIN":
                        return 4;
                    case "I_AM_UNABLE_TO_WALK_ABOUT":
                        return 5;
                    default:
                        return 0;
                }
            } else
            {
                return -88;
            }
        }

        private int setSelfCare(string selfcareScore)
        {
            if (!string.IsNullOrEmpty(selfcareScore))
            {
                switch (selfcareScore)
                {
                    case "I_HAVE_NO_PROBLEMS_WASHING_OR_DRES":
                        return 1;
                    case "I_HAVE_SLIGHT_PROBLEMS_WASHING_OR":
                        return 2;
                    case "I_HAVE_MODERATE_PROBLEMS_WASHING":
                        return 3;
                    case "I_HAVE_SEVERE_PROBLEMS_WASHING_OR":
                        return 4;
                    case "I_HAVE_UNABLE_TO_WASH_OR_DRESSI":
                        return 5;
                    default:
                        return 0;
                }
            }
            else
            {
                return -88;
            }
        }

        private int setUsualActivities(string usualscore)
        {
            if (!string.IsNullOrEmpty(usualscore))
            {
                switch (usualscore)
                {
                    case "I_HAVE_NO_PROBLEMS_DOING_MY_USUA":
                        return 1;
                    case "I_HAVE_SLIGHT_PROBLEMS_DOING_MY_":
                        return 2;
                    case "I_HAVE_MODERATE_PROBLEMS_DOING_M":
                        return 3;
                    case "I_HAVE_SEVERE_PROBLEMS_DOING_MY_":
                        return 4;
                    case "I_AM_UNABLE_TO_DO_MY_USUAL_ACTIV":
                        return 5;
                    default:
                        return 0;
                }
            }
            else
            {
                return -88;
            }
        }

        private int setPainDiscomfort(string painscore)
        {
            if (!string.IsNullOrEmpty(painscore))
            {
                switch (painscore)
                {
                    case "I_HAVE_NO_PAIN_OR_DISCOMFORT":
                        return 1;
                    case "I_HAVE_SLIGHT_PAIN_OR_DISCOMFORT":
                        return 2;
                    case "I_HAVE_MODERATE_PAIN_OR_DISCOMFO":
                        return 3;
                    case "I_HAVE_SEVERE_PAIN_OR_DISCOMFORT":
                        return 4;
                    case "I_HAVE_EXTREME_PAIN_OR_DISCOMFOR":
                        return 5;
                    default:
                        return 0;
                }
            }
            else
            {
                return -88;
            }
        }

        private int setAnxietyDepression(string anxietyscore)
        {
            if (!string.IsNullOrEmpty(anxietyscore))
            {
                switch (anxietyscore)
                {
                    case "I_AM_NOT_ANXIOUS_OR_DEPRESSED":
                        return 1;
                    case "I_AM_SLIGHTLY_ANXIOUS_OR_DEPRESS":
                        return 2;
                    case "I_AM_MODERATELY_ANXIOUS_OR_DEPRE":
                        return 3;
                    case "I_AM_SEVERELY_ANXIOUS_OR_DEPRESS":
                        return 4;
                    case "I_AM_EXTREMELY_ANXIOUS_OR_DEPRES":
                        return 5;
                    default:
                        return 0;
                }
            }
            else
            {
                return -88;
            }
        }

        private int setHealthScore(string healthscore)
        {
            if (!string.IsNullOrEmpty(healthscore))
            {
                int convertHealthScore;
                bool result = Int32.TryParse(healthscore, out convertHealthScore);
                if (result)
                {

                    return convertHealthScore;
                }
                else
                {
                    return -88;
                }
            }
            else
            {
                return -88;
            }
        }
        #endregion

    }

   
}