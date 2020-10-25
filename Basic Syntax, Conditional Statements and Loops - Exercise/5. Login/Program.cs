using System;
using System.Data;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            //dokato ne stane userName naobratno - parola

            string password = "";
            int counter = 0;

            for (int i = userName.Length - 1 ; i >= 0; i--)
            {
                password = password + (userName[i]);
            }
            string command = Console.ReadLine();
            while (command != password)
            {
                counter++;
                if(counter > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                command = Console.ReadLine();
            }

            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
