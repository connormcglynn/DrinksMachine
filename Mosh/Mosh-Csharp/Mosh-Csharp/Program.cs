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
            //bool isGoldCustomer = true;

            ////float price;
            ////if (isGoldCustomer)
            ////{
            ////    price = 19.95f;
            ////}
            ////else
            ////{
            ////    price = 29.95f;
            ////}

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            // CASE

            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's autumn and a beautiful season.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's summer, time for the beach!");
                    break;

                default:
                    Console.WriteLine("I have no clue what season it is!");
                    break;
                    
            }

        }
    }
}
