using System;
namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            double r = float.Parse(Console.ReadLine());
            double p = 2 * r * Math.PI;
            double a = r * r * Math.PI;
            Console.WriteLine("Perimeter p ={0:0.00} \n Area a = {1:0.00}", p, a);
        }
    }
}
