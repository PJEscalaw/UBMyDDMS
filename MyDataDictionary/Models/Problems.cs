using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Problems
    {
        public int ProblemsID { get; set; }
        public string ProblemName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Severity { get; set; }
        public DateTime DateResolved { get; set; }
        public int Flag { get; set; }


        public int UsersID { get; set; }
        public Users Users { get; set; }

        public int SeveritiesID { get; set; }
        public Severities Severities { get; set; }

        //Foreign Key
        public int StatusID { get; set; }
        public Status Status { get; set; }
     

    }
}