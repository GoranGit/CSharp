using System;
namespace _1ExchangeIfGreater
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            if (a < b)
                Console.WriteLine(a + " " + b);
            else
                Console.WriteLine(b + " " + a);

        }
    }
}
