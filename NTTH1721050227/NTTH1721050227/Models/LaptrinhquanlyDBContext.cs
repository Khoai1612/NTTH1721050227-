using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTTH1721050227.Models
{
    public class LaptrinhquanlyDBContext : DbContext
    {
        public LaptrinhquanlyDBContext() : base("LaptrinhquanlyDBContext")
        {
        }

        public DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<NTTH1721050227.Models.Person> People { get; set; }
    }
}