using System;
namespace StringsAndObjects
{
    class Program
    {
        static void Main()
        {
            string k = "Hello";
            string p = "World";
            object l = k + p;
            string o = (string)l;
            Console.WriteLine(o + " " + l);

        }
    }
}
