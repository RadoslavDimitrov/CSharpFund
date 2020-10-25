using System;

namespace _5_ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. name
            //2. project
            //3. 1 project = 3 hours
            //The architect ... will need .... to complete ... project/s.

            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;

            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projects} project/s.");

        }
    }
}
