using System;
using System.Numerics;
namespace _3Maslan
{
    class Program
    {
        static void Main()
        {
            string n = Console.ReadLine();
            long[] sums = new long[1000000];
           BigInteger product = 1;
            int transformations = 0;
            int pointer = 0;
            bool tenTransformations = false;
            while (n.Length > 1)
            {
                while (n.Length > 0)
                {
                    n = n.Remove(n.Length - 1);
                    if (n.Length != 0) // ignore the  calculation if no digts;
                    {
                        sums[pointer] = calcOddSum(n);
                        pointer++;
                    }
                }

                for (int i = 0; i < pointer; i++)
                {
                    if (sums[i] == 0)
                        continue;
                    else
                        product *= (ulong)sums[i];

                }

                for (int i = 0; i < 30; i++)
                    sums[i] = 0;

                    pointer = 0;

                transformations++;
                n = product.ToString();
                product = 1;


                if (transformations == 10)
                {
                    tenTransformations = true;

                    break;
                }




            }
            if (!tenTransformations)
                Console.WriteLine(transformations);


            if (n.Length > 0)
                Console.WriteLine(n);

        }

        static int calcOddSum(string n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += int.Parse(n[i].ToString());

                }
            }
            return sum;
        }
    }
}
