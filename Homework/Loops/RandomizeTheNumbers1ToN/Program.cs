using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int m = n;
            List<int> a = new List<int>();
            Random k = new Random();
            int element = new int();

            for(int i = 0;i< n ;i++)
            {
                a.Add(i+1);
            }

            for(int i = 0; i < m;i++)
            {
                element = k.Next(0, n - 1);
                Console.Write("{0} ", a[element]);
                a.RemoveAt(element);
                n--;
            }
            


        }
    }

