using System;
namespace _6QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            double x1 = ((-1)*b - Math.Sqrt((b * b ) -4*(a * c))) / (2 * a);
            double x2 = ((-1)*b + Math.Sqrt((b * b )-4*( a * c)))/ (2 * a);
            Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);

        }
    }
}
