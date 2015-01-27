using System;
using System.Linq;
namespace _2BonusScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a score: ");
            int score = int.Parse(Console.ReadLine());

            if (Enumerable.Range(1, 3).Contains(score))
                Console.WriteLine(score * 10);
            else
                if (Enumerable.Range(4, 6).Contains(score))
                    Console.WriteLine(score * 100);
                else
                    if (Enumerable.Range(7, 9).Contains(score))
                        Console.WriteLine(score * 1000);
                    else
                        Console.WriteLine("invalid score");
        }
    }
}
