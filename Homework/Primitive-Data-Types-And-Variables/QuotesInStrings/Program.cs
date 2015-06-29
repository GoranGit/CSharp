using System;
namespace QuotesInStrings
{
    class Program
    {
        static void Main()
        {
            string a = @"The ""use"" of quotations causes difficulties.";
            string l = "The \"use\" of quotations causes difficulties.";

            Console.WriteLine(a + "     " + l);


        }
    }
}
