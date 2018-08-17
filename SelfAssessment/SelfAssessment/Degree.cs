using System;
namespace SelfAssessment
{
    public class Degree
    {
        public string Name { get; set; }
        public Course Course { get; set; }

        public Degree(string name)
        {
            Name = name;
        }
    }
}
