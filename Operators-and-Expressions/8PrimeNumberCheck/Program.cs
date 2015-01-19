using System;
namespace _8PrimeNumberCheck
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number n :");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine(false);
                return;
            }


            bool flag =true;
            for (int i = 2; i < (int)Math.Sqrt(n); i++) // to check if some number n is prime  it's enough to check if that number  is not divisible with numbers 2,3,4... sqrt(n)
            {
                if (n % i == 0)
                {
                   
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag);
        }
    }
}
