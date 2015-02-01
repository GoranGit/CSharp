using System;
namespace _1NextDate
{
    class Program
    {
        static void Main()
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime k = new DateTime(year, month, day);
            k=k.AddDays(1);
            Console.WriteLine("{0}.{1}.{2}", k.Day, k.Month, k.Year);

        }
    }
}
