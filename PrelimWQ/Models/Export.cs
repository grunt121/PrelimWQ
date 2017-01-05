using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrelimWQ.Models
{
    public class Export
    {

        public int Id { get; set; }

        public int? StudyId { get; set; }

        public string OnlineIdLogin { get; set; }

        public string OnlineIdPassword { get; set; }

    }
}