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
        public DbSet<Letters> Letters { get; set; }
        public DbSet<Problems> Problems { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Severities> Severities { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}