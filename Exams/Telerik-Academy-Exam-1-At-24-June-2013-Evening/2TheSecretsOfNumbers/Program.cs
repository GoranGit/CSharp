using System;

namespace _2TheSecretsOfNumbers
{
    class Program
    {
        static void Main()
        {
            string N = Console.ReadLine().Trim('-');
            char[] k = N.ToCharArray();
            Array.Reverse(k);
            string n = new string(k);

            long sum = 0;

               for(int i=0;i<n.Length;i++)
               {
                   int p =int.Parse(n[i].ToString());
                   if (i % 2 == 0)
                   {
                       sum += (p * (i + 1) * (i + 1));
                   }
                   else
                       sum += (p * p * (i + 1));
               }

               int length = 0;
            if((length = (int)(sum%10) ) == 0)
            {
                Console.WriteLine(sum);
                Console.WriteLine("{0} has no secret alpha-sequence", N);
            }else
            {
                long R = ((sum % 26)+1 + 64);
               int j=0;
               string result = "";
                for(int i =0;i<length;i++)
                {

                    if (R + j == 91)
                    {
                        R = 65;
                        j = 0;
                    }
                   result+=((char)(R + j));
                   j++;

                }
                Console.WriteLine(sum);
                Console.WriteLine(result);
            }
           
        }
    }
}
