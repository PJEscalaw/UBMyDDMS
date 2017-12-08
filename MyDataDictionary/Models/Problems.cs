using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Problems
    {
        public int ProblemID { get; set; }
        public string ProblemName { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string Severity { get; set; }
        public DateTime DateResolved { get; set; }
        public string StatusID { get; set; }
        public int Flag { get; set; }

    }
}