using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyDataDictionary.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("DDMS") { }
        public DbSet<Status> Status { get; set; }
        public DbSet<Problems> Problems { get; set; }
    }
}