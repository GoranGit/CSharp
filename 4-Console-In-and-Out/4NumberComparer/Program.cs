using System;
namespace _4NumberComparer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers 'a' and 'b' :");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine((a > b) ? a : b);
        }
    }
}
