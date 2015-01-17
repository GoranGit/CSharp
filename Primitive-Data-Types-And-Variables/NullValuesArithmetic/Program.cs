using System;
namespace NullValuesArithmetic
{
    class Program
    {
        static void Main()
        {
            int? k = null;
            double? p = null;
            Console.WriteLine(k + p);

            Console.WriteLine( new String('-',50));

            k += 10;
            p += 10.9;
            Console.WriteLine(k + " " + p);
        }

    }
}
