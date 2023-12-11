using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Task1
{
    class UniversityDBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
   
}
