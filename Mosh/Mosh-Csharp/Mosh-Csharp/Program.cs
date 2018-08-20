using System;

namespace MoshCsharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);

            Console.WriteLine(j);

        }
    }
}
