using System;
using System.Numerics;
namespace _6CalculateNFacDivKFac
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            
                for (int i = 0; i <= n; i++)
                {
                    if (i == 0)
                    {
                        factorialN = 1;
                        factorialK = 1;
                    }
                    else
                    {
                        factorialN *= i;
                        if (k >= i)
                            factorialK *= i;
                    }

            }
            Console.WriteLine("{0}", factorialN / factorialK);

        }

    }
}

