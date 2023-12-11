using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public int YearsOfExperience { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public List<Course> Courses { get; set; }
    }
}
