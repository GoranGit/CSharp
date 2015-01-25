using System;
namespace _5CalculateNXN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double sum = 0;

            for(int i=0;i<=n;i++)
            {
                if (i == 0)
                    sum += (float)factorial(i);
                else
                sum += (float)factorial(i) / Math.Pow(x,i);

                

            }
            Console.WriteLine("{0:F5}",sum);
        }

        static int factorial(int n) // recursion for  factorial,  this solution is not optimal becouse for big n it alocate to much memory and can causes to many "context switch" for CPU  if we have  multithreading.
        
        {
            if(n==0)
                return 1;
            return factorial(n - 1) * n;
        }
    }
}
