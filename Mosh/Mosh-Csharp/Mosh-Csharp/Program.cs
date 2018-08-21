using System;

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
            var random = new Random();
            const int pwLength = 10;

            var buffer = new char[pwLength];
            for (var i = 0; i < pwLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);

            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9:" + index);

            // Clear() set array item to 0
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);
            
            // Sort() 
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
