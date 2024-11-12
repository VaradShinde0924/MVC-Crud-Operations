using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCrud.Models
{
    public class studDbcontext:DbContext
    {
        public studDbcontext():base("cs")
        {
            
        }
        public DbSet<Student> students { get; set; }
    }
}