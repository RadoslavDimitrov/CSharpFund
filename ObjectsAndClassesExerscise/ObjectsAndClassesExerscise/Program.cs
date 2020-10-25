using System;
using System.Linq;

namespace ObjectsAndClassesExerscise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Random rand = new Random();

            

            var phrases = new string[]{ "Excellent product.", "Such a great product."
                , "I always use that product.", "Best product of its category.", "Exceptional product."
                , "I can’t live without this product." };

            var events = new string[] { "Now I feel good.", "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied.", "I feel great!" };

            var authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < n; i++)
            {
                AdvertisementMessage message = new AdvertisementMessage(phrases[rand.Next(0, phrases.Length)],
                    events[rand.Next(0, events.Length)], authors[rand.Next(0, authors.Length)],
                    cities[rand.Next(0, cities.Length)]);

                Console.WriteLine(message.ToString());
            }
        }

    }

    public class AdvertisementMessage
    {
        public string Phrases { get; set; }

        public string Events { get; set; }

        public string Authors { get; set; }

        public string Cities { get; set; }

        public AdvertisementMessage(string phrases, string events, string authors, string cities)
        {
            this.Phrases = phrases;
            this.Events = events;
            this.Authors = authors;
            this.Cities = cities;
        }

        public override string ToString()
        {
            return $"{Phrases} {Events} {Authors} – {Cities}.";
        }
    }
}
