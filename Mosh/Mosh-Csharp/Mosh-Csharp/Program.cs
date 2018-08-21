using System;

namespace MoshCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Connor";
            var lastName = "McGlynn";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "George", "Paul" };
            var formattedNames = string.Join(",", names);


            var text = @"Hi John
Look into the following paths
c:\folder1\foolder2
c:\folder3\folder4";

            Console.WriteLine(text);

        }
    }
}
