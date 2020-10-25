using System;

namespace _1_GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 read name
            // тип, име и стойност
            string name = Console.ReadLine();

            // 2. "Hello, <name>!"
            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("!");
        }
    }
}
