using System;
namespace _3Sheets
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 2047;
            string[] s = { "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10"};
            string result = Convert.ToString(n ^ p, 2).PadLeft(11,'0');
            for (int i = 0; i < result.Length; i++)
                if (result[i] == '1')
                    Console.WriteLine(s[i]);

        }
    }
}
