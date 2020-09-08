using System;
using Enum2.Entities;

namespace Enum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!!");
            Post p1 = new Post(DateTime.Parse("08/09/2020, 14:51:43"), "Travelling to England",
                "I'm going to visit this wonderful country", 12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}