using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            List<Person> persons = new List<Person>();

            while (true)
            {
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if(command[0] == "End")
                {
                    break;
                }

                
                string name = command[0];
                string id = command[1];
                int age = int.Parse((command[2].ToString()));

                Person currPpl = new Person(name, id, age);
                persons.Add(currPpl);
            }

            Console.WriteLine(string.Join(Environment.NewLine, persons.OrderBy(x => x.Age)));
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
