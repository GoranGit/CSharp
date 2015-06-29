using System;
namespace _9Trapezoids
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter base a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter base b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter heigth h =");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine((a + b) / 2 * h);

        }
    }
}
