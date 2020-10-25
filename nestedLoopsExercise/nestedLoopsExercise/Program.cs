using System;

namespace nestedLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isDone = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    counter++;
                    Console.Write(counter + " ");
                    if (counter >= n)
                    {
                        isDone = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (isDone)
                {
                    break;
                }
                
            }
        }
    }
}
