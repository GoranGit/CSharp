using System;

namespace _14DecimalToBinaryNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            long n = long.Parse(Console.ReadLine());
            string binary = "";
            
            while(n!=0)
            {
                binary = (n % 2).ToString()+binary;
                n /= 2;


            }
            Console.WriteLine(binary);
            
        }
    }
}
