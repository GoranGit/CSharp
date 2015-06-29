using System;
namespace _3MinMaxSumAndAverageOfNNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 0;
            bool minmax = false;
            int max = 0;
           

            float avg = 0;
            int sum = 0;
            int pom = 0;
            for (int i = 1; i <= n; i++)
            {
                pom = int.Parse(Console.ReadLine());

                if (!(minmax))
                {
                    min = pom;
                    max = pom;
                    minmax = true;
                   
                }
                if (pom > max)
                    max = pom;
                if (pom < min)
                    min = pom;

                sum += pom;

            }

            avg = (float)sum / n;


            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg);
        }
    }
}
