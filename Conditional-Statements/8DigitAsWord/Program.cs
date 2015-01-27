using System;
namespace _8DigitAsWord
{
    class Program
    {
        static void Main()
        {
            int n;
               if( !int.TryParse(Console.ReadLine().ToString(),out n))
              
            {
                Console.WriteLine("not a digit");
                return;
            }
           
            string digit = "";

            switch(n)
            {
                case 0:
                    {
                        digit = "zero";
                        break;
                    }
                case 1:
                    {
                        digit = "one";
                        break;
                    }
                case 2:
                    {
                        digit = "two";
                        break;
                    }
                case 3:
                    {
                        digit = "three";
                        break;
                    }
                case 4:
                    {
                        digit = "four";
                        break;
                    }
                case 5:
                    {
                        digit = "five";
                        break;
                    }
                case 6:
                    {
                        digit = "six";
                        break;
                    }
                case 7:
                    {
                        digit = "seven";
                        break;
                    }
                case 8:
                    {
                        digit = "eight";
                        break;
                    }
                case 9:
                    {
                        digit ="nine";
                        break;
                    }
                default:
                    {
                        digit = "not a digit";
                        break;
                    }

            }
            Console.WriteLine(digit);
        }
    }
}
