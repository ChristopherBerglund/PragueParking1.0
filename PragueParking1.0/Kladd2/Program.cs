using System;

namespace Kladd2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(250);
            Console.WriteLine(rand.Next(50));

            var now = DateTime.Today;
            Console.WriteLine(now);
            var later = now.AddDays(10);
            Console.WriteLine(later);


        }
    }
}
