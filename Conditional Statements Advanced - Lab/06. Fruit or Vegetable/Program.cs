using System;

namespace _06._Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            //⦁	Плодовете "fruit" имат следните възможни стойности:  banana, apple, kiwi, cherry, lemon и grapes
            // ⦁	Зеленчуците "vegetable" имат следните възможни стойности:  tomato, cucumber, pepper и carrot

            string input = Console.ReadLine();

            bool isFruit = (input == "banana") || (input == "apple") || (input == "kiwi") || (input == "cherry") || (input == "lemon") || (input == "grapes");
            bool isVegetable = (input == "tomato") || (input == "cucumber") || (input == "pepper") || (input == "carrot");
            
            if (isFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (isVegetable)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            
        }
    }
}
