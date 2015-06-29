using System;


    class Program
    {
        static void Main()
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r = 0;
            long result = 0;

            switch(b)
            {
                case 2:
                    {
                        r = a % c;
                        break;
                    }
                case 4:
                    {
                        r = a + c;
                        break;
                    }
                case 8:
                    {
                        r = a * c;
                        break;
                    }
                default: break;
            }

            if (r % 4 == 0)
            {
                result = r / 4;
            }
            else
                result = r % 4;

            Console.WriteLine(result);
            Console.WriteLine(r);
        }
    }

