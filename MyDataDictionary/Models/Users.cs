using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class Users
    {
        public int UsersID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Flag { get; set; }



        /***
         * Foreign Key
         */
        public ICollection<Reports> Reports { get; set; }
        public ICollection<Letters> Letters { get; set; }
        public ICollection<Problems> Problems { get; set; }

    }
}