using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Letters
    {
        public int LettersID { get; set; }
        public string Name { get; set; }
        public string Navigation { get; set; }
        public string FieldName { get; set; }
        public string Path { get; set; }    
        public DateTime DateCreated { get; set; }
        public int Flag { get; set; }


        public int UsersID { get; set; }
        public Users Users { get; set; }
    }
}