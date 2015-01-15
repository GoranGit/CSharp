using System;
namespace AgeAfter
{
    class Program
    {
        static void Main()
        {
            DateTime birthDay = (DateTime.Parse((string)Console.ReadLine()));

            TimeSpan years = DateTime.Now - birthDay;
            int days = years.Days;
            float yearsTillNow = (float)(days / 365.25);

            Console.WriteLine(yearsTillNow + 10);

        }
    }
}
