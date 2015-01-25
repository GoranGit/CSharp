using System;
namespace _1NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {

                Console.Write(i + " ");
            }
        }
    }
}
