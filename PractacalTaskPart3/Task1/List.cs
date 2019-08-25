using System;
using System.Collections.Generic;

namespace PractacalTaskPart3.Task1
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

            for (int i = 0; i < Persons.Capacity; i++)
            {
                Console.WriteLine("Name: " + Persons[i].Name + "  Age: " + Persons[i].Age);
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
