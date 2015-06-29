using System;
namespace _10PointInsideACircleOutsideOfARectangle
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter coordinate x =");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coordinate y =");
            double y = Convert.ToDouble(Console.ReadLine());
            bool inCircle = false;
            bool inRec = false;


            if (1.5>= Math.Sqrt(Math.Pow(1-x,2) + Math.Pow(1-y,2))) // d(distance)  = sqrt(pow(x2-x1,2) + pow(y2-y1,2)). in thi case x2 and y2 are 0 and pow(-x,2)==pow(x,2)
                inCircle = true;

            if ((x>= -1)&&(x<=5) && (y>=-1)&&(y<=1))
            {
                inRec = true;
            }

            if(inCircle && !inRec)
            {
                Console.WriteLine("yes");
            }else
                Console.WriteLine("no");
           
        }


        }
    }

