using System;


namespace C_Sharp_PracticeSessions
{
    class Student : IComparable<Student>
    {

        public string Name { get; set; }
        public int GradLevel { get; set; }


        public int CompareTo(Student that)
        {

            int result = this.Name.CompareTo(that.Name);

            if (result == 0)
            {
                result = this.GradLevel.CompareTo(that.GradLevel);

            }

            return result;
        }

    }
}
