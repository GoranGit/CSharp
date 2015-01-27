using System;
namespace _11NumbersInIntervalDividableByGivenNumber
{
    class Program
    {
        static void Main()
        {
            int p = 0;
            int j = 0;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int[] k = new int[end]; 
            for(int i = start;i<=end;i++)
            {
                if (i % 5 == 0)
                {
                    k[j] = i;
                    j++;
                }
                
            }

            Console.Write("p = {0}   Coments:",j);

            for (int i = 0; i < j; i++)
                Console.Write("{0}, ", k[i]);
        }
    }
}
