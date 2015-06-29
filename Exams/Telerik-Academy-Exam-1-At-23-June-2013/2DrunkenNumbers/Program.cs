using System;
namespace _2DrunkenNumbers
{
    class Program
    {
        static void Main()
        {
            ulong sumM = 0;
            ulong sumV = 0;

            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string round = Console.ReadLine().TrimStart(new char[]{'0','-'});
                string MitkoRBeers = ((round.Length) % 2 == 0) ? round.Substring(0, round.Length / 2) : round.Substring(0, (round.Length / 2) + 1);
                string VlatkoRBeers = ((round.Length) % 2 == 0) ? round.Substring(round.Length / 2, round.Length / 2) : round.Substring(round.Length / 2 , (round.Length / 2) + 1);
                sumM += findSum(MitkoRBeers);
                sumV += findSum(VlatkoRBeers);
            }
            if (sumM > sumV)
                Console.WriteLine("M {0}", sumM - sumV);
            else
                if (sumV > sumM)

                    Console.WriteLine("V {0}", sumV-sumM);
                else
                    Console.WriteLine("No {0}", sumM + sumV);
        }

        static ulong findSum( string s)
        {
            ulong sum = 0;
            int digit;
            foreach(char k in s)
            {
           
                if(int.TryParse(k.ToString(),out digit))
                {
                    sum += (ulong)digit;
                }
            }
            return sum;
        }
    }
}
