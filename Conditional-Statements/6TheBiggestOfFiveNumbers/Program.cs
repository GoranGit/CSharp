using System;
namespace _6TheBiggestOfFiveNumbers
{
    class Program
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            float max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            if (max < d)
                max = d;
            if (max < e)
                max = e;
            Console.WriteLine(max);
        }
    }
}
