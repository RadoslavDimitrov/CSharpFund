using System;

namespace _3._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)ppl / capacity);

            Console.WriteLine(courses);
        }
    }
}
