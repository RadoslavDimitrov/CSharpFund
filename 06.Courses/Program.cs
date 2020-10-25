using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

             

            while (true)
            {
                var command = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToList();

                if(command[0] == "end")
                {
                    break;
                }

                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                    
                }
                
                courses[courseName].Add(studentName);
                
            }

            courses = courses.OrderByDescending(x => x.Value.Count).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                var orderMembers = item.Value.OrderBy(x => x).ToList();
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {orderMembers[i]}");
                }
                
                
            }
        }
    }
}
