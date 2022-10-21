using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Article
    {
        public Article(string tittle, string content, string author)
        {
            Title = tittle;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

       
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for(int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
                Article article = new Article(input[0], input[1], input[2]);
                listOfArticles.Add(article);

            }
            string splitter = Console.ReadLine();
            if(splitter == "title")
            {
               listOfArticles = listOfArticles.OrderBy(obj => obj.Title).ToList();
            }
            else if(splitter =="content")
            {
                listOfArticles = listOfArticles.OrderBy(obj => obj.Content).ToList();
            }
            else if(splitter == "author")
            {
                listOfArticles = listOfArticles.OrderBy(obj => obj.Author).ToList();
            }
            for(int i = 0; i < listOfArticles.Count; i++)
            {
                Console.WriteLine(listOfArticles[i].ToString());
            }
           
        }
    }
}
