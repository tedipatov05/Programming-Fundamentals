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

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTittle)
        {
            Title=newTittle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            Article article = new Article(input[0],input[1],input[2]); 
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] vs = command.Split(": "); 
                if(vs[0]== "Edit")
                {
                    article.Edit(vs[1]);
                }
                else if(vs[0]=="ChangeAuthor")
                {
                    article.ChangeAuthor(vs[1]);
                }
                else if(vs[0]=="Rename")
                {
                    article.Rename(vs[1]);
                }
            }
            Console.WriteLine(article.ToString()); 
        }
    }
}
