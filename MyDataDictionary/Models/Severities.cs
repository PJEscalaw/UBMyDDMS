using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Severities
    {
        public int SeveritiesID { get; set; }
        public string Name { get; set; }
        public int Flag { get; set; }

        /***
         * Foreign Key
         */
        public ICollection<Problems> Problems { get; set; }
    }
}