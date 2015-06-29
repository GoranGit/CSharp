using System;


namespace _3OnesAndZeros
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            n += 2147483648;
            string bits = Convert.ToString(n, 2);
            string sixteenBits = bits.Substring(16, 16);

            string[] ones = { ".#.", "##.", ".#.", ".#.", "###" };
            string[] zeros = { "###", "#.#", "#.#", "#.#", "###" };
            int j = 0;
            for(int i = 0 ; i<5;i++)
            {
                j=0;
            foreach(char c in sixteenBits)
            {

                if(c=='0')
                {
                    Console.Write("{0}{1}", (j == 0) ? "" : ".", zeros[i]);
                }
                else
                {
                    Console.Write("{0}{1}", (j == 0) ? "" : ".", ones[i]);
                }
                j++;
            }
            Console.WriteLine();
            }

        }
    }
}
