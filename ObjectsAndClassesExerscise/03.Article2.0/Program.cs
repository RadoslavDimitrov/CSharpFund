using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Article2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> allArticles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                var currArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Article thisArticle = new Article(currArticle[0], currArticle[1], currArticle[2]);
                allArticles.Add(thisArticle);

            }

            string command = Console.ReadLine();

            if(command == "title")
            {
                Console.WriteLine(string.Join(Environment.NewLine, allArticles.OrderBy(x => x.Title)));
            }
            else if(command == "content")
            {
                Console.WriteLine(string.Join(Environment.NewLine, allArticles.OrderBy(x => x.Content)));
            }
            else if(command == "author")
            {
                Console.WriteLine(string.Join(Environment.NewLine, allArticles.OrderBy(x => x.Author)));
            }
        }
    }

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
