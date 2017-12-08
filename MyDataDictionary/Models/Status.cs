using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Status
    {
        public int StatusID { get; set; }
        public string Name { get; set; }
        public int Flag { get; set; }

        public ICollection<Problems> Problems { get; set; }
    }
}