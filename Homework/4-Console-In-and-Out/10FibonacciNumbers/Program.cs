using System;
namespace _10FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            int pre = 0;
            int l = 0;

            char p = ',';
            for (int i = 0; i < n; i++)
            {

                if (i >= 2)
                {
                    l = pre + k;

                    pre = k;
                    k = l;

                }
                if (i == 0)
                {
                    l = 0;
                }
                if (i == 1)
                {
                    l = 1;
                }

                if (i == n - 1)
                    p = ' ';

                Console.Write("{0}{1} ", l, p);
            }
        }
    }
}
