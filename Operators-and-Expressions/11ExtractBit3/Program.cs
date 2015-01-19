using System;
using System.Collections;
namespace _11ExtractBit3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number n = ");
            BitArray n = new BitArray( new int[]{int.Parse(Console.ReadLine())});



            if (n[2])
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
           
           
        }
    }
}
