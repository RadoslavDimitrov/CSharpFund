using System;
using System.Text;

namespace _05.BigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            num1 = num1.TrimStart(new char[] {'0'});

            int num2 = int.Parse(Console.ReadLine());

            int rest = 0;

            char[] numAsChar = num1.ToCharArray();

            string result = "";

            int temp = 0;
            int tempResult = 0;
            int tempNumber = 0;

            if(num2 == 0 || num1 == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = numAsChar.Length - 1; i >= 0; i--)
            {
                tempNumber = int.Parse(numAsChar[i].ToString());
                if(rest > 0)
                {
                    temp =  tempNumber * num2 + rest;
                }
                else
                {
                    temp = tempNumber * num2;
                }

                if(i == 0)
                {
                    result = result.Insert(0, temp.ToString());
                    break;
                }
                
                tempResult = temp % 10;
                //result.Insert(0, tempResult.ToString());
                result = result.Insert(0, tempResult.ToString());
                rest = temp / 10;
            }

            Console.WriteLine(result);
            
        }
    }
}
