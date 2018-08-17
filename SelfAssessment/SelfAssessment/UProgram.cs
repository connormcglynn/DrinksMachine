using System;
namespace SelfAssessment
{
    public class UProgram
    {
        public string Name { get; set; }
        public Degree Degree { get; set; }

        public UProgram(string name)
        {
            Name = name;
        }
    }
}
