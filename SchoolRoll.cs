using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_PracticeSessions
{
    class SchoolRoll
    {
        private List<Student> _students = new List<Student>();

        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
