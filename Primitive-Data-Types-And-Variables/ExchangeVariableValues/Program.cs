using System;
namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " " + b);
        }
    }
}
