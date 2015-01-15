using System;
namespace PrintNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(1);
            for (int i = 2; i < 4; i++) 
                Console.WriteLine(Math.Pow(10, i) + 1); 
        }
    }
}
