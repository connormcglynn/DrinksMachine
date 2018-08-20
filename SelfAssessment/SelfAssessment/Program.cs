using System;

namespace SelfAssessment
{
    class Program
    {
        static void Main()
        {
            // Students
            Student[] students =
            {
                new Student("Andrew", "Clark", 17),
                new Student("Claire", "Standish", 16),
                new Student("John", "Bender", 18)
            };

            // Teacher
            Teacher[] teachers =
            {
                new Teacher("Richard", "Vernon")
            };

            // Course
            Course course = new Course("Programming with C#")
            {
                // Add students to course
                Student = students,

                // Add teacher to course
                Teacher = teachers
            };

            // Degree
            Degree degree = new Degree("Bachelor")
            {
                // Add course to degree
                Course = course
            };

            // UProgram
            UProgram uprogram = new UProgram("Information Technology")
            {
                // Add degree to UProgram
                Degree = degree
            };

            // Write/print course/degree/student information
            Console.WriteLine($"The program is {uprogram.Name} and offers a {degree.Name} degree in the field of {course.Name}. There are currently {Student.numStudents} students enrolled.");
        }
    }
}

