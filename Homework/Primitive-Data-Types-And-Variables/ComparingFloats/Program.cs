using System;
namespace ComparingFloats
{
    class Program
    {
        static void Main()
        {
            float eps = 0.000001f;
            float a = 5.00000001f;
            float b = 5.00000005f;

            Console.WriteLine(eps+" "+ a + " " + b);
            Console.WriteLine(a == b);

            if (Math.Abs(a - b) < eps)
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
        }
    }
}
