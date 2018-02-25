using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetDemo.DAL
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

     
        
    }
}