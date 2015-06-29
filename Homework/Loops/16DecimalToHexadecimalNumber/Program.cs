using System;
using System.Collections.Generic;
namespace _16DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            long n = long.Parse(Console.ReadLine());
            int k = 0;
            string c = "";
            string rezult = "";
            while(n!=0)
            {
                k =(int) (n % 16);

                switch(k)
                {
                    case 10:
                        {
                            c = "A";
                            break;
                        }
                    case 11:
                        {
                            c = "B";
                            break;
                        }

                    case 12 :
                        {
                            c = "C";
                            break;
                        }
                    case 13:
                        {
                            c = "D";
                            break;
                        }
                    case 14:
                        {
                            c = "E";
                            break;
                        }
                    case 15:
                        {
                            c = "F";
                            break;
                        }
                    default:
                        {
                            c = k.ToString();
                            break;

                        }
                       
                }

                rezult += c;
        
                n /= 16;
               
            }

            char[] charArray = rezult.ToCharArray();
            Array.Reverse( charArray );
  
            
            Console.Write(new string( charArray ));

        }
    }
}
