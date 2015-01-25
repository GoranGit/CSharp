using System;
namespace _13BinaryToDecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            string binary = Console.ReadLine();
            int len = binary.Length;
            long dec = 0;
            int bit;
            foreach(char k in binary)
            {
                bit =int.Parse(k.ToString());
                if (bit == 0 && len == 1)
                    continue;

                dec += (long)Math.Pow(bit*2, (len - 1));
                len--;

            }
            Console.WriteLine(dec);
           
            Main();//recursive call for easy testing
 
        }
    }
}
