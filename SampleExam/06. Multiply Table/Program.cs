using System;

namespace _06._Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string num2 = Convert.ToString(num[2]);
            string num1 = Convert.ToString(num[1]);
            string num0 = Convert.ToString(num[0]);
            int numThree = int.Parse(num2);
            int numTwo = int.Parse(num1);
            int numOne = int.Parse(num0);
            
            for (int i = 1; i <= numThree; i++)
            {
                for (int j = 1; j <= numTwo; j++)
                {
                    for (int k = 1; k <= numOne; k++)
                    {

                        
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
