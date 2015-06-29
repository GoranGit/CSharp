using System;
using System.Linq;

namespace _3CheckForAPlayCard
{
    class Program
    {
        static void Main()
        {
            string[] cards = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };
          
            Console.WriteLine("Enter a card");
            string card = Console.ReadLine().ToUpper();
            if (cards.Contains(card))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
