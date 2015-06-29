using System;
namespace _5TheBiggestOf3Numbers
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float max = a;

            if (max < b)
                max = b;
            if (max < c)
                max = c;

            Console.WriteLine(max);

            

        }
    }
}
