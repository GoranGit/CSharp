using System;

namespace _2EncodingSum
{
    class Program
    {
        static void Main()
        {
          decimal M = decimal.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            decimal result = 0m;

            for(int i = 0 ; i< text.Length;i++)
            {
                if (text[i] == '@')
                    break;
                if(char.IsDigit(text[i]))
                {
                    int k = int.Parse(text[i].ToString());
                    result *= k;
                    
                }
                else
                    if(char.IsLetter(text[i]))
                    {
                        int k = (int)(text[i].ToString().ToUpper())[0];
                        int rez = k - 65;
                        result += rez;
    

                    }
                    else
                    {
                        result %= M;
 
                    }
            }
            Console.WriteLine(result);

        }
    }
}
