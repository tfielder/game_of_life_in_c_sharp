using System;

namespace game_of_life_in_c_sharp
{
    class MainClass
    {
        public static void PrintMenu()
        { 
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("1 - Start a new game");
            Console.WriteLine("2 - Exit the game");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Game of Life in C#!");
            Console.WriteLine("The game of life was originally developed by John Conway in 1970.");
            Console.WriteLine("Type the m key to see the menu at anytime.");

            var userOption = "0";

            while (userOption != "2")
            {
                PrintMenu();
                userOption = Console.ReadLine();
            }

            //Console.WriteLine("How big would you like the gameboard to be? Choose a number between 3 and 25.");
            //do
            //{
            //    var testInteger = Console.ReadLine();
            //    //TryParse, testInteger
            //    if (testInteger < 2) || (testInteger > 25)
            //    {
            //        Console.WriteLine("Try a number between 3 and 25.");
            //    }
            //} while (testInteger < 2 || testInteger > 25);
        }
    }
}
