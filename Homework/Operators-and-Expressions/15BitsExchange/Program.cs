using System;
using System.Collections;
namespace _15BitsExchange
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number n = ");
            uint n = uint.Parse(Console.ReadLine());

            BitArray temp = new BitArray(new int[] { (int)n });
            bool tempThree = temp[3];
            bool tempFour = temp[4];
            bool tempFive = temp[5];
            temp[3] = temp[24];
            temp[4] = temp[25];
            temp[5] = temp[26];
            temp[24] = tempThree;
            temp[25] = tempFour;
            temp[26] = tempFive;

            int[] array = new int[1];
            temp.CopyTo(array, 0);
            Console.WriteLine((uint)array[0]);
            

        }
    }
}
