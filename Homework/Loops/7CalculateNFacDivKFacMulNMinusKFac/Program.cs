using System;
using System.Numerics;
namespace _7CalculateNFacDivKFacMulNMinusKFac
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int p = n - k;

           BigInteger factorialP = 1;
            BigInteger factorialN = 1;
           BigInteger factorialK = 1;

            for (int i = 0; i <= n; i++)
            {
              
                if(i!=0)
                {

                    factorialN *= i;
                    if (k >= i)
                        factorialK *= i;
                    if (p >= i)
                        factorialP *= i;

                }

            }
            Console.WriteLine("{0}", factorialN / (factorialK*factorialP));

        }
    }
}
