using System;
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            uint counter = 0;
            uint sum = 0;
            uint digit = 0;

            char[] array = input.ToCharArray();
            for(int i=0;i<array.Length;i++)
            {
                if(i%2 ==1 && uint.TryParse(array[i].ToString(),out digit))
                {
                    sum += digit;
                    counter++;
                }
            }
            Console.Write("{0} {1}", counter, sum);

        }
    }

