using System;
using System.Collections.Generic;

namespace MoshCsharp
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Program
    {
        static void Main(string[] args) 
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now.ToString("yyyy MMMMM dd HH:mm"));


            var timeSpan = new TimeSpan(1, 2, 3);

            Console.WriteLine(TimeSpan.FromHours(1));

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(5);
            var duration = end - start;

            Console.WriteLine(duration);


        }
    }
}
