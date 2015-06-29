using System;
namespace _17CalculateGCD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a integer number a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a integer number b =");
            int b = int.Parse(Console.ReadLine());
            int pom = 0;
            int rez = 0;

            if (a > b)
            {
                pom = b;
                b = a;
                a = pom;
            }

            while (b != 0)
            {

                rez = a % b;

                a = b;
                if (rez == 0)
                {
                    rez = b;
                    b= 0;  
                }
                else
                {
                    b = rez;
                }



            }

            Console.WriteLine("GCD = {0}", rez);
        }
    }
}
