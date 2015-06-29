using System;
namespace _4Cube3D
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 0;i<N;i++)
            {
                if (i == 0)
                    Console.WriteLine(new string(':', N));
                else
                    if(i == N-1)
                    {
                        Console.WriteLine("{0}{1}{2}", new string(':', N), new string('|', N - 2), ":");
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}{2}{0}", ":", new string(' ', N - 2), new string('|', i - 1));
                    }
            }
            for (int i = 0; i < N - 1; i++)
            {
                if (i == N - 2)
                {
                    Console.WriteLine(new string(' ', N - 1) + new string(':', N));

                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{3}{1}", new string(' ', i + 1), ":", new string('-', N - 2), new string('|', N - 2 - (i + 1)));
                }

            }
        }
    }
}
