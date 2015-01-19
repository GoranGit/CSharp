using System;
namespace _7PointInACircle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter coordinate x =");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y =");
            double y = Convert.ToDouble(Console.ReadLine());

            if (2>= Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2))) // d(distance)  = sqrt(pow(x2-x1,2) + pow(y2-y1,2)). in thi case x2 and y2 are 0 and pow(-x,2)==pow(x,2)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
