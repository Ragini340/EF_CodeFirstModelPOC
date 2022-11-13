using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF_CodeFirstModelPOC.Models
{
    public class StudentContext : DbContext
    {
       public StudentContext() : base()
            {
            }
            public DbSet<Student> Students { get; set; }
        }
}