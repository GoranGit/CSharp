using System;
namespace Problem1
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            decimal P = decimal.Parse(Console.ReadLine());


            decimal realms = (decimal)(N * S) / 400;

            int integerRealms = (int)realms;
            decimal rest = realms - integerRealms;


            Console.WriteLine("{0:F3}", ((decimal) (integerRealms * P) + (rest * P)));


        }
    }
}
