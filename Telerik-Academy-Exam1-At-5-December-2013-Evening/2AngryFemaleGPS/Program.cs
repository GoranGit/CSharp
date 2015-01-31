using System;
namespace _2AngryFemaleGPS
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long sumEven = 0;
            long sumOdd = 0;
            long digit;
            long rez = 0;
            string result;

            if (n < 0)
                n *= (-1);
            while(n!=0)
           {
               digit = n % 10;
               n /= 10;
               if (digit % 2 == 0)
                   sumEven += digit;
               else
                   sumOdd += digit;

           }
           if (sumEven > sumOdd)
           {
               result = "right";
               rez = sumEven;
           }
           else
               if (sumOdd > sumEven)
               {
                   result = "left";
                   rez = sumOdd;
               }
               else
               {
                   result = "straight";
                   rez = sumOdd;
               }
           Console.WriteLine("{0} {1}", result, rez);
        }
    }
}
