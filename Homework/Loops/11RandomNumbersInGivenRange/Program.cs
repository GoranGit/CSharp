using System;
namespace _11RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" n =");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" min =");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(" max =");
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();
            for(int i = 0; i<n ; i++)
            {
                Console.Write("{0}{1}", r.Next(min,max), " ");
            }


        }
    }
}
