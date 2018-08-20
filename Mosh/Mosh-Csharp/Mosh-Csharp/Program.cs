using System;
using MoshCsharp.Math;

namespace MoshCsharp
{

    class MainClass
    {
        static void Main(string[] args)
        {
            Person connor = new Person
            {
                FirstName = "Connor",
                LastName = "McGlynn"
            };
            connor.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(5, 44);

            Console.WriteLine(result);
        }
    }
}
