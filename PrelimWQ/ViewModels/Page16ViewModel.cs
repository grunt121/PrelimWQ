using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrelimWQ.Models;

namespace PrelimWQ.ViewModels
{
    public class Page16ViewModel
    {

        public int Id { get; set; }
        public int ConsentToMRR { get; set; }
        public int ConsentToHistoricStudies { get; set; }
        public int ConsentToFutureStudies { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string TelephoneNumber { get; set; }
        public bool SurveySubmitted { get; set; }






    }
}