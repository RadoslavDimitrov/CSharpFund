using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string regex = @">>([A-Za-z\s]+)<<(\d+(.\d+)?)!(\d+)";

            

            List<string> products = new List<string>();
            double sum = 0;
            //double price = 0;
            //int quantity = 0;
             
            while (input != "Purchase")
            {
                Match collection = Regex.Match(input, regex ,RegexOptions.IgnoreCase);
                if (collection.Success)
                {
                    var name = collection.Groups[1].Value;
                    var price = double.Parse(collection.Groups[2].Value);
                    var quantity = int.Parse(collection.Groups[4].Value);
                    products.Add(name);
                    //price = double.Parse(collection.Groups[2].ToString());
                    //quantity = int.Parse(collection.Groups[3].ToString());
                    //products.Add(collection.Groups[1].ToString());
                    sum += price * quantity;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if(products.Count > 0)
            {
                Console.WriteLine($"{ string.Join(Environment.NewLine, products)}");
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
