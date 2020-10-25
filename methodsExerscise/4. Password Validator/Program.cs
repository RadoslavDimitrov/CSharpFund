using System;

namespace _4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwond = Console.ReadLine();

            bool longEnought = IsLongEnought(passwond);
            bool isRight = IsRightDigits(passwond);
            bool twoDigits = IsHavingTwoDigits(passwond);

            if(passwond.Length < 1)
            {
                longEnought = false;
                isRight = false;
                twoDigits = false;

            }

            if(longEnought && isRight && twoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (longEnought == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (isRight == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (twoDigits == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
            
        }

        private static bool IsHavingTwoDigits(string passwond)
        {
            int counter = 0;
            for (int i = 0; i < passwond.Length; i++)
            {
                if(passwond[i] >= 48 && passwond[i] <= 57)
                {
                    counter++;
                }
            }

            if(counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsRightDigits(string passwond)
        {
            //48 - 57
            //65 - 90
            //97 - 122
            int counter = 0;
            for (int i = 0; i < passwond.Length; i++)
            {
                char currChar = passwond[i];
                if(currChar > 47 && currChar < 58 || currChar > 64 && currChar < 91 || currChar > 96 && currChar < 123)
                {
                    counter++;
                }
                
            }

            if(counter == passwond.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsLongEnought(string passwond)
        {
            if(passwond.Length >= 6 && passwond.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
