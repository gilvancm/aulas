using System;
using Aula121ap.Entities;

namespace Aula121ap
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I´m Going to visit this wonderful coutry!",
                12
                );

            p1.Comments.Add(c1);
            p1.Comments.Add(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.Comments.Add(c3);
            p2.Comments.Add(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
           

        }
    }
}
