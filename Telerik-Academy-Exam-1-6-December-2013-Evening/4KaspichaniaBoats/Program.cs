using System;
namespace _4KaspichaniaBoats
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            double height = 6 + ((n - 3) / 2) * 3;
            double width = n*2+1;

            double sailsHeight = (2f / 3) * height;
            double baseHeight = (1f / 3) * height;
            int str1 = (int)width/2;

            // print sails 
            Console.WriteLine("{0}{1}{0}", new string('.', str1), "*");
            for(int i =0;i<sailsHeight-2;i++)
            {
                str1--;
                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', str1), '*', new string('.', i));
            }
            Console.WriteLine("{0}", new string('*', (int)width));

            // print base
            int j = 1;
            for(j=1;j<= baseHeight -1;j++)
            {

                Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new string('.', j), '*', new string('.', (int)((width - (2*j) -3))/2));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', j), new string('*', (int)n));
        }
    }
}
