using System;

namespace _9SumOfnNumbers
{
    class Program
    {
        static void Main()
        {
            float sum = 0;
            int n = int.Parse(Console.ReadLine());
            float k = 0;
            for(int i=0;i<n;i++)
            {
                k = float.Parse(Console.ReadLine());
                sum += k;
            }
            Console.WriteLine(sum);

        }
    }
}
