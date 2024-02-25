using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domPesho
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void PrintFamily()
        {
            members.Sort();
            foreach (var person in members)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
