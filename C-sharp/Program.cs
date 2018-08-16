using System;

namespace Csharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine();
            myMachine._location = "Kitchen";
            myMachine._model = "DM1000";
            myMachine.MakeCappuccino();

            Console.WriteLine(myMachine._location);
        }
    }
    class DrinksMachine
    {
        public string _location;
        public string _make;
        public string _model;

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino has been made.");
        }

        public void MakeEspresso()
        {
            
        }
    }
}
