using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banjoville
{
    class Game
    {
        Location myLocation;
        Random randoCalrissian = new Random();

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO BANJOVILLE");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Where would you like to visit today?");
            Console.WriteLine("A) Folk Town");
            Console.WriteLine("B) Puzzle Park");
            Console.WriteLine("C) Toothless Street");
            string choice = Console.ReadLine();

            if(choice.ToUpper() == "A")
            {
                int pop = randoCalrissian.Next(1, 950);
                myLocation = new Location("Folk Town","Full of tumble weeds...",pop);
                myLocation.About();
            }
            else if (choice.ToUpper() == "B")
            {
                myLocation = new Location("Puzzle Park", "Want to play a game?", 2);
                myLocation.About();
            }
            else if (choice.ToUpper() == "C")
            {
                myLocation = new Location("Toothless Street", "DO NOT GO HERE", 20000000);
                myLocation.About();
            }
            else
            {
                Run();
            }

            Console.ReadLine();
            //Console.ReadKey();
        }
    }
}
