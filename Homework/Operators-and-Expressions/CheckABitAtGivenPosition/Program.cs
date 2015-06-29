using System;
namespace CheckABitAtGivenPosition
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position p = ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(((n >> p) & 1) == 1);
        }
    }
}
