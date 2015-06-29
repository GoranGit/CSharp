using System;
using System.Globalization;
using System.Threading;

    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            float a = float.Parse(Console.ReadLine());
            float p = float.Parse(Console.ReadLine());

            float inMachine = n1 * 0.05f + n2 * 0.10f + n3 * 0.20f + n4 * 0.50f + n5 * 1.0f;


         	Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;      

            if(a>=p && (a-p)<=inMachine)
            {

                Console.WriteLine("Yes {0:0.00}", inMachine - (a - p));
            }
            else
                if(p>a)
                {
                    Console.WriteLine("More {0:0.00}", p - a);
                }
                else
                   if (a>p && (a-p)> inMachine)
            {
                Console.WriteLine("No {0:0.00}", a - p - inMachine);

            }


        }
    }

