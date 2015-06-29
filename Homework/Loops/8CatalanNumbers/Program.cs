using System;
using System.Numerics;
namespace _8CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            
            int n = int.Parse(Console.ReadLine());
           
            int p = 2*n;

           BigInteger factorialP = 1;
            BigInteger factorialN = 1;
            

            for (int i = 0; i <= p; i++)
            {

              
                if(i!=0)
                {

                    factorialP *= i;
                    if (n >= i)
                        factorialN *= i;
                  

                }

            }
            Console.WriteLine("{0}", factorialP / ((factorialN*(n+1))* factorialN));


       

        }
   

        
    }
}
