using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = string.Empty;
            List<string> currProducts = new List<string>();

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                currProducts = command.Split().ToList();

                if(currProducts[0] == "Urgent")
                {
                    UrgentProduct(products, currProducts);
                }
                else if(currProducts[0] == "Unnecessary")
                {
                    RemoveProduct(products, currProducts);
                }
                else if(currProducts[0] == "Correct")
                {
                    ChangeName(products, currProducts);
                }
                else if(currProducts[0] == "Rearrange")
                {
                    RearrangeList(products, currProducts);
                }
            }

            Console.WriteLine(string.Join(", ", products));
        }

        private static void ChangeName(List<string> products, List<string> currProducts)
        {
            

            for (int i = 0; i < products.Count; i++)
            {
                if (currProducts[1] == products[i])
                {
                    products.RemoveAt(i);
                    products.Insert(i, currProducts[2]);
                }
            }
        }

        private static void RearrangeList(List<string> products, List<string> currProducts)
        {
            string temp = string.Empty;

            for (int i = 0; i < products.Count; i++)
            {
                if (currProducts[1] == products[i])
                {
                    temp = currProducts[1];
                    products.RemoveAt(i);
                    products.Add(temp);
                }
            }
        }

        private static void RemoveProduct(List<string> products, List<string> currProducts)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (currProducts[1] == products[i])
                {
                    products.RemoveAt(i);
                }
            }
        }

        private static void UrgentProduct(List<string> products, List<string> currProducts)
        {
            bool isHere = false;

            for (int i = 0; i < products.Count; i++)
            {
                if (currProducts[1] == products[i])
                {
                    isHere = true;
                }
            }

            if (isHere == false)
            {
                products.Insert(0, currProducts[1]);
            }
        }
    }
}
