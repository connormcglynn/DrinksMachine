using System;

namespace SelfAssessment
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int age;

        public static int numStudents;

        public static int GetStudents { get => numStudents; }

        public Student(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.age = age;
            numStudents++;
        }
    }
}
