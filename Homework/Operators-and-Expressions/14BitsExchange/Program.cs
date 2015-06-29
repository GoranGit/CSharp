using System;
using System.Collections;
namespace _14BitsExchange
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a position p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter a bit value v = ");
            int v = int.Parse(Console.ReadLine());
            BitArray temp = new BitArray(new int[] { n });

            if (v == 1)

                temp[p] = true;
            else
                temp[p] = false;

            int[] array = new int[1];
            temp.CopyTo(array, 0);


            Console.WriteLine(array[0]);




        }
    }
}
