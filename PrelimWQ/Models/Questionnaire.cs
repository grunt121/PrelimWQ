using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrelimWQ.Models
{
    public class Questionnaire
    {
        public int Id { get; set; }
        public int? A_1a { get; set; }
        public int? A_1b { get; set; }
        public int? A_1c { get; set; }
        public int? A1_d { get; set; }
        public int? A1_e { get; set; }
        public int? A_1_health { get; set; }
        public int? A2_1 { get; set; }
        public int? A2_2 { get; set; }
        public int? A2_3a { get; set; }
        public int? A2_3b { get; set; }
        public int? A2_3c { get; set; }
        public int? A2_3d { get; set; }
        public int? A2_3e { get; set; }
        public int? A2_3f { get; set; }
        public int? A2_3g { get; set; }
        public int? A2_3h { get; set; }
        public int? A2_3i { get; set; }
        public int? A2_3j { get; set; }
        public int? A2_4a { get; set; }
        public int? A2_4b { get; set; }
        public int? A2_4c { get; set; }
        public int? A2_4d { get; set; }
        public int? A2_4e { get; set; }
        public int? A2_4f { get; set; }
        public int? A2_4g { get; set; }
        public int? A2_4h { get; set; }
        public int? A2_4i { get; set; }
        public int? A2_4j { get; set; }
        public int? A2_5 { get; set; }
        public int? A2_6 { get; set; }
        public int? A2_7 { get; set; }
        public int? A2_8 { get; set; }
        public int? A2_9 { get; set; }
        public int? A2_10 { get; set; }
        public int? A2_11 { get; set; }
        public int? A2_12 { get; set; }
        public int? A2_13 { get; set; }
        public int? A2_14 { get; set; }
        public int? A2_15 { get; set; }
        public int? A2_16 { get; set; }
        public int? A2_17 { get; set; }
        public int? A2_18 { get; set; }
        public int? A2_19 { get; set; }
        public int? A3_1a { get; set; }
        public int? A3_1b { get; set; }
        public int? A3_1c { get; set; }
        public int? A3_1d { get; set; }
        public int? A3_1e { get; set; }
        public int? A3_2a { get; set; }
        public int? A3_2b { get; set; }
        public int? A3_2c { get; set; }
        public int? A3_2d { get; set; }
        public int? A3_2e { get; set; }
        public int? A3_2f { get; set; }
        public string A3_2f_other { get; set; }
        public int? A4_1 { get; set; }
        public int? A4_2 { get; set; }
        public int? A4_3 { get; set; }
        public int? A4_4 { get; set; }
        public int? A4_5 { get; set; }
        public int? A4_6 { get; set; }
        public int? A4_7 { get; set; }
        public int? A4_8 { get; set; }
        public int? A4_9a { get; set; }
        public int? A4_9b { get; set; }
        public int? A4_9c { get; set; }
        public int? A4_9d { get; set; }
        public int? A4_10a { get; set; }
        public int? A4_10b { get; set; }
        public int? A4_10c { get; set; }
        public int? A4_10d { get; set; }
        public int? A4_11a { get; set; }
        public int? A4_11b { get; set; }
        public int? A4_11c { get; set; }
        public int? A4_11d { get; set; }
        public int? A4_12a { get; set; }
        public int? A4_12b { get; set; }
        public int? A4_12c { get; set; }
        public int? A4_12d { get; set; }
        public int? A4_12e { get; set; }
        public int? A4_12f { get; set; }
        public int? A4_12g { get; set; }
        public int? A5_1 { get; set; }
        public int? A5_2 { get; set; }
        public int? A5_3 { get; set; }
        public int? A5_4 { get; set; }
        public int? A5_5 { get; set; }
        public int? A5_6 { get; set; }
        public int? A5_7 { get; set; }
        public int? A5_8 { get; set; }
        public int? A5_9 { get; set; }
        public int? A5_10 { get; set; }
        public int? A5_11 { get; set; }
        public int? A5_12 { get; set; }
        public int? A5_13 { get; set; }
        public int? A5_14 { get; set; }
        public decimal? B1_stones { get; set; }
        public decimal? B1_llbs { get; set; }
        public decimal? B1_kgs{ get; set; }
        public decimal? B2_feet { get; set; }
        public decimal? B2_inches { get; set; }
        public decimal? B2_cms { get; set; }
        public int? B3 { get; set; }
        public int? B4 { get; set; }
        public decimal? B5_a { get; set; }
        public decimal? B5_b{ get; set; }
        public decimal? B5_c { get; set; }
        public int? B6 { get; set; }
        public int? B7 { get; set; }
        public int? B_8a { get; set; }
        public int? B_8b { get; set; }
        public int? B_8c { get; set; }
        public int? B_8d { get; set; }
        public int? B_8e { get; set; }
        public int? B9 { get; set; }
        public DateTime? C1_DOB { get; set; }
        public int? C2 { get; set; }
        public int? C3 { get; set; }
        public string C3_other { get; set; }
        public int? C4 { get; set; }
        public int? C5 { get; set; }
        public bool? C6_a { get; set; }
        public bool? C6_b { get; set; }

        public bool? C6_c { get; set; }
        public bool? C6_d { get; set; }
        public bool? C6_e { get; set; }
        public int? C7 { get; set; }
        public int? C8 { get; set; }
        public int? C9 { get; set; }
        public int? C_10a { get; set; }
        public int? C_10b { get; set; }
        public int? C_10c { get; set; }
        public int? C_10d { get; set; }
        public int? C_10e { get; set; }
        public int? C_10f { get; set; }
        public int? C11 { get; set; }
        public string C12 { get; set; }
        public string C13 { get; set; }
        public string C14 { get; set; }
        public string C15 { get; set; }
        public int? C16 { get; set; }
        public int? C17 { get; set; }
        public int? C18 { get; set; }
        public int? C19 { get; set; }
        public int? C20 { get; set; }
        public int? C21 { get; set; }
        public int? C22 { get; set; }
       
        public int? ConsentToMRR { get; set; }
       
        public int? ConsentToHistoricStudies { get; set; }
       
        public int? ConsentToFutureStudies { get; set; }
        public DateTime? DateOfSubmission { get; set; }
        public string Title { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TownCity { get; set; }
        public string County { get; set; }
        public string Postcode { get; set; }
        public string TelephoneNumber { get; set; }
        public bool? SurveySubmitted { get; set; }
        public int StudyID { get; set; }
        public DateTime? SurveyStarted { get; set; }



    }
}