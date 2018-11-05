using System;


namespace C_Sharp_PracticeSessions
{
    class Student : IComparable<Student>
    {

        public string Name { get; set; }
        public int GradeLevel { get; set; }


        public int CompareTo(Student that)
        {

            int result = this.Name.CompareTo(that.Name);

            if (result == 0)
            {
                result = this.GradeLevel.CompareTo(that.GradeLevel);

            }

            return result;
        }

        /// <summary>
        ///  Trying to not add the same student
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            // we will check against the name and grade value
            // IF we were rutrning the students from a db. it would have a unique ID already            

            return Name.GetHashCode() + GradeLevel.GetHashCode();
        }

        public override bool Equals(object obj)
        {

            // casting to make sure whats being passed in is a Student Object, 
            // returns null if it does not work.
            Student that = obj as Student;

            if (that == null)
            {
                return false;
            }

            // then it is a Student Object
            return this.Name == that.Name && this.GradeLevel == that.GradeLevel;
        }

    }
}
