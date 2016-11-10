using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banjoville
{
    class Location
    {
        string Name;
        string Description;
        int Population;

        string[] Items;
        string[] Adjective = { "Amazing", "Awesome", "Super", "Spectacular", "Astonishing", "Daring", "Brave", "Courageous", "Phenomenal", "Magical", "Glorious"};
        string[] FirstName = { "Alejandro", "Jared", "Hector", "Casey", "Justin", "Alex", "Eric", "Austin", "Venus", "Ricardo", "Jeremy", "Lawrence", "David", "Marilu", "Colin", "Nick" };

        Random RandomIndexNumber = new Random();

        Person strangerOne;
        Person strangerTwo;

        public Location(string passedInName, string passedInDescription, int passedInPopulation)
        {
            Name = passedInName;
            Description = passedInDescription;
            Population = passedInPopulation;
            Items = fillItems();
            PopulateTown();
        }
        private string GetName()
        {
            int index = 0;
            string name = "";

            index = RandomIndexNumber.Next(Adjective.Length);
            name = Adjective[index];

            index = RandomIndexNumber.Next(FirstName.Length);
            name = name + " " + FirstName[index];

            return name;
        }
        private void PopulateTown()
        {
           

            if (Name == "Folk Town")
            {
                strangerOne = new Person(GetName());
                strangerTwo = new Person(GetName());
            }
            if (Name == "Puzzle Park")
            {
                strangerOne = new Person(GetName());
                strangerTwo = new Person(GetName());
            }
            if (Name == "Toothless Street")
            {
                strangerOne = new Person("Wealthy Dentist");
                strangerTwo = new Person("Golden-Tooth Gary");
            }
        }

        private string[] fillItems()
        {
            string[] filledItems = new string[3];

            if(Name == "Folk Town")
            {
                filledItems[0] = "Old People";
                filledItems[1] = "TumbleWeeds";
                filledItems[2] = "Rocking Chairs";
            }
            if (Name == "Puzzle Park")
            {
                filledItems[0] = "A single maze";
                filledItems[1] = "3 Jigsaw puzzles";
                filledItems[2] = "some bushes";
            }
            if (Name == "Toothless Street")
            {
                filledItems[0] = "Teeth";
                filledItems[1] = "Blue Grass";
                filledItems[2] = "A dentist office";
            }

            return filledItems;
        }


        public void About()
        {
            Console.Clear();
            Console.WriteLine(Name);
            Console.WriteLine(Description);
            Console.WriteLine("Population: " + Population);
            Console.WriteLine("We have the following exports");

            foreach (string item in Items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("You have a chance to meet the follow people in " + Name);
            Console.WriteLine(strangerOne.Name);
            Console.WriteLine(strangerTwo.Name);


            //for(int x = 0; x < Items.Length; x++)
            //{
            //    Console.WriteLine(Items[x]);
            //}

            //Console.WriteLine(Items[0]);
            //Console.WriteLine(Items[1]);
            //Console.WriteLine(Items[2]);


        }
    }
}
