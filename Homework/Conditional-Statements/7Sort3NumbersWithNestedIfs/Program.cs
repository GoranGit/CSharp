using System;
namespace _7Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else

                    if (c > a)
                        Console.WriteLine(c + " " + a + " " + b);
                    else
                        Console.WriteLine(a + " " + c + " " + b);
            }
            else
                if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                    if (c > b)
                        Console.WriteLine(c + " " + b + " " + a);
                    else
                        Console.WriteLine(b + " " + c + " " + a);

        }
    }
}
