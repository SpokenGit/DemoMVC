using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoApp.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext():base("CNN_DEMO") { }

        public DbSet<Job> Jobs { get; set; }
    }
}