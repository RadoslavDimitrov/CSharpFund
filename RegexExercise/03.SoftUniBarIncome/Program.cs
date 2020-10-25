using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //customer, product, count and a price:

            //%Customer%<\w>|int|realnum$

            //pattern - (?<name>%[A-Z][a-z]+%)<(?<product>[A-Za-z]+)>\|(?<count>\d+)\|(?<price>\d+(\.*\d+))\$

            string command = Console.ReadLine();

            //string pattern = @"%(?<name>[A-Z][a-z]+)%<(?<product>[A-Za-z]+)>\|(?<count>\d+)\|(?<price>\d+(\.*\d+))\$";
            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

            double sum = 0;

            while (true)
            {
                if(command == "end of shift")
                {
                    break;
                }

                MatchCollection ppl = Regex.Matches(command, pattern, RegexOptions.IgnoreCase);

                if(Regex.IsMatch(command, pattern, RegexOptions.IgnoreCase))
                {
                    var name = ppl[0].Groups[2].ToString();
                    var product = ppl[0].Groups[3].ToString();
                    int count = int.Parse(ppl[0].Groups[4].ToString());
                    double price = double.Parse(ppl[0].Groups[5].ToString());

                    sum += count * price;

                    Console.WriteLine($"{name}: {product} - {(count * price):F2}");
                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
