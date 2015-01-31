using System;
namespace _4FireInTheMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int h1 = n / 2;
            int h2 = n / 4;
           
            int h4 = n / 2;

            for(int i=0;i<h1;i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', ((n / 2) - 1) - i), "#", new string('.', i * 2));
            }

            for(int i = 0;i<h2;i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), "#", new string('.', (n - 2) - (2 * i)));

            }

            Console.WriteLine(new string('-', n));

            for(int i=0;i<h4;i++)
            {
                Console.WriteLine("{0}{1}{2}{0}",new string('.',i),new string('\\',(n/2)-i),new string('/',(n/2)-i));
            }


        }
    }
}
