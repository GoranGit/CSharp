using System;
using System.Globalization;
namespace _10BeerTime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)");
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "hh:mm tt", CultureInfo.InvariantCulture);

            string designiter = time.ToString("tt", CultureInfo.InvariantCulture).ToUpper();

            if (((time.Hour >= 13) && (designiter.Equals("PM") && (time.Hour <= 23))) ||
                ((time.Hour >= 0) && (time.Hour <= 3) && (designiter.Equals("AM"))))
            {
                Console.WriteLine("beer time");

            }
            else
                Console.WriteLine("non-beer time");
           


        }
    }
}
