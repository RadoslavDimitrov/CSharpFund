using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int cooker = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine()); // for one day
            int waffle = int.Parse(Console.ReadLine()); // for one day
            int pancake = int.Parse(Console.ReadLine()); // for one day

            double cakeSum = cake * 45.00;
            double waffleSum = waffle * 5.80;
            double pancakeSum = pancake * 3.20;

            double sumForOneDay = (cakeSum + waffleSum + pancakeSum) * cooker;
            double wholeSum = sumForOneDay * day;

            double percent = 1 * 1.0 / 8;
            double forCharity = wholeSum - percent * wholeSum;

            Console.WriteLine($"{forCharity:F2}");





        }
    }
}
