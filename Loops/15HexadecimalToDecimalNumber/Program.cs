using System;
namespace _15HexadecimalToDecimalNumber
{
    class Program
    {
        static void Main()
        {
            string hex = Console.ReadLine();
            char[] charArray = hex.ToCharArray();
            Array.Reverse(charArray);
            long dec = 0;
            for(int i =0;i<charArray.Length;i++)
            {
               switch(charArray[i])
               {
                   case 'A':
                       {
                           dec += (long)(10 * Math.Pow(16, i));
                           break;
                       }
                   case 'B':
                       {
                           dec += (long)(11 * Math.Pow(16, i));
                           break;
                       }
                   case 'C':
                       {
                           dec += (long)(12 * Math.Pow(16, i));
                           break;
                       }
                   case 'D':
                       {
                           dec += (long)(13 * Math.Pow(16, i));
                           break;
                       }
                   case 'E':
                       {
                           dec += (long)(14 * Math.Pow(16, i));
                           break;
                       }
                   case 'F':
                       {
                           dec += (long)(15 * Math.Pow(16, i));
                           break;
                       }
                   default:
                       {
                           dec += (long)(int.Parse(charArray[i].ToString()) * Math.Pow(16, i));
                           break;
                       }
               }
            }

            Console.WriteLine(dec);
            Main();

        }
    }
}
