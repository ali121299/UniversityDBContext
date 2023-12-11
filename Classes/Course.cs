using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
