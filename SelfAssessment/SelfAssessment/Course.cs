using System;
namespace SelfAssessment
{
    public class Course
    {
        
        public Student[] students = new Student[3];

        public Course(string name)
        {
            Name = name;
        }

        public Course(Student[] students, Teacher[] teachers, string name)
        {
            Student = students;
            Teacher = teachers;
            Name = name;
        }

        public Student[] Student { get; set; }
        public Teacher[] Teacher { get; set; }
        public string Name { get; set; }
    }
}
