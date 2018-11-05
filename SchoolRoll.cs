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

        // But what if they had an array and wanted to pass that in
        // Then they would have to convert to a list

            // but we only need to add those into a list, we can change this to an IEnumerable.

        /// <summary>
        /// There is a method named AddStudents that takes a list of students and
        /// then adds all of the new students to the list of students already in the school.
        /// </summary>
        /// <param name="students"> Pass as a List Type</param>
        public void AddStudents(IEnumerable<Student> students)
        {
            _students.AddRange(students);
        }
    }
}
