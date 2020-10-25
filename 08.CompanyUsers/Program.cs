using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> register = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if(command[0] == "End")
                {
                    break;
                }

                string companyName = command[0];
                string id = command[1];

                if (!register.ContainsKey(companyName))
                {
                    register[companyName] = new List<string>();
                    register[companyName].Add(id);
                }
                else
                {
                    if(!register[companyName].Any(x => x == id))
                    {
                        register[companyName].Add(id);
                    }
                }
            }

            register = register.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in register)
            {
                Console.WriteLine($"{kvp.Key}");

                List<string> allMembers = kvp.Value.ToList();
                for (int i = 0; i < allMembers.Count; i++)
                {
                    Console.WriteLine($"-- {allMembers[i]}");
                }
            }
        }
    }
}
