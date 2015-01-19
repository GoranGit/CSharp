using System;
using System.Collections;
namespace _16BitExchangeAdvanced
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number n = ");
            uint n = 0;

            try // because 33333333333 is out of range I handle that error
            {
                n = checked(uint.Parse(Console.ReadLine()));
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("overflow catched please  enter a number from 0 to 4294967295(uint maxVal) ");
                Main();
                return;
            }
          
            Console.Write("Enter a numper p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter a number q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter a number k = ");
            int k = int.Parse(Console.ReadLine());

            bool overlap = false;
            bool outOfRange = false;

            int min = p;
            int max = q;

            if (q < p)
            {
                min = q;
                max = p;
            }

            if ((min + k - 1) >= max)
            {
                overlap = true;
            }

            if (max + k - 1 > 31)
                outOfRange = true;


            if (!outOfRange && !overlap)
            {
                BitArray temp = new BitArray(new int[] { (int)n });
                bool hlp = false;

                for (int i = 0; i <= k - 1; i++)
                {
                    hlp = temp[p + i];
                    temp[p + i] = temp[q + i];
                    temp[q + i] = hlp;
                }

                int[] array = new int[1];
                temp.CopyTo(array, 0);
                Console.WriteLine((uint)array[0]);
            }
            else
                if (overlap)
                {
                    Console.WriteLine("overlapping");
                }
                else
                    Console.WriteLine("out of range");


        }
    }
}
