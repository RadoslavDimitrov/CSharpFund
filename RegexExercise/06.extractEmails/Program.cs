using System;
using System.Text.RegularExpressions;

namespace _06.extractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@\#+[A-Z][A-Za-z0-9][A-Za-z0-9][A-Za-z0-9][A-Za-z0-9][A-Za-z0-9]+\@\#+";

            string digidPattern = @"[\d*]";

            int n = int.Parse(Console.ReadLine());
            

            string text = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
                MatchCollection digids = Regex.Matches(text, digidPattern, RegexOptions.IgnoreCase);

                string productGroup = string.Empty;

               

                for (int k = 0; k < digids.Count; k++)
                {
                    productGroup += digids[k].ToString();
                }

                Console.WriteLine($"Product group: {productGroup}");

                foreach (Match item in matches)
                {
                    Console.WriteLine(item.Value);
                }

                productGroup = string.Empty;
                text = Console.ReadLine();
            }

            
        }
    }
}
