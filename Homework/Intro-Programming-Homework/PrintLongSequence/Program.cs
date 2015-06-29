using System;
namespace PrintLongSequence
{
    class Program
    {
        static void Main()
        {
            int b;
            int maxSeqEl = 1000;
            for (int i = 2; i <= maxSeqEl + 1; i++)
            {
                b = i;
                if (b % 2 == 1)
                    b = i * (-1);
                Console.Write(b);
                if (i != maxSeqEl + 1)
                {
                    Console.Write(",");
                }

            }
        }
    }
}
