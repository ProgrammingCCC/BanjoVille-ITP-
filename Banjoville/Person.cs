using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banjoville
{
    class Person
    {
        public string Name;
        string Age;
        string Description;
        bool isDrunk;

        public Person(string passedInName)
        {
            Name = passedInName;
        }
        public Person(string passedInName,string passedInAge,string passedInDescription, bool passedInIsDrunk)
        {
            Name = passedInName;
            Age = passedInAge;
            Description = passedInDescription;
            isDrunk = passedInIsDrunk;
        }

        public void About()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Description);
        }

        public void Talk()
        {

        }

        public void PutToSleep()
        {

        }

        public void RunAway()
        {

        }
    }
}
