using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PractacalTaskPart3.Task2
{
    class List
    {
        public static void Menu()
        {
            var Persons = new List<Person>
            {
                new Person{Name = "Andrey", Age = 12, PhoneNumbers = new string[] { "0502342310"} },
                new Person{Name = "Jailey", Age = 24, PhoneNumbers = new string[] { "0507571766", "0969257435"} },
                new Person{Name = "Yuriy", Age = 18, PhoneNumbers = new string[] { "0505362075"} },
                new Person{Name = "Wall-E", Age = 85, PhoneNumbers = new string[] { "0601899857", "0976386292"} },
            };

            var PersonsNew = new List<Person>
            {
                new Person{Name = "Lisa", Age = 47, PhoneNumbers = new string[] { "0509238417"} },
                new Person{Name = "Robert", Age = 33, PhoneNumbers = new string[] { "0502679356", "0961093674"} },
            };

            Persons.AddRange(PersonsNew);

            for (int i = 0; i < Persons.Count; i++)
            {
                Console.Write("PhoneNumber: ");
                foreach (var item in Persons[i].PhoneNumbers)
                {
                    Console.Write(item + "; ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
            Program.Main();
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
