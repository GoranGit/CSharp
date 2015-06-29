using System;
namespace _3BatGoikoTower
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int w = 2*h;
            int j =1;
            int k=1;
            for(int i=0;i<h;i++)
            {
                if(i==j)
                {
                    Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (w / 2) - 1 - i), "/", new string('-', 2 * i), "\\");
                    k++;
                    j += k;
                }
                else{
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('.', (w / 2) - 1 - i), "/", new string('.', 2 * i), "\\");
                
                }
                }

        }
    }
}
