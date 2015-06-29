using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
namespace _12FallingRocks
{
    class Program
    {
        static void Main()
        {
            char[] dwarf = {'(','0',')'};
            char[] rocks = new char[] { '^', '^', '^', '@', '@', '@', '@', '*', '*', '*', '*', '*', '&', '+', '%', '$', '$', '$', '#', '#', '#', '!','!','!','!','!','!','!', '.',';',';',';',';', '-' };

            Point startDwarf = new Point(10,20);
            char[ , ] console = new char[20, 20];
            int score = 0;


            console[startDwarf.Y-1, startDwarf.X - 1] = dwarf[0];
            console[startDwarf.Y-1, startDwarf.X] = dwarf[1];
            console[startDwarf.Y-1, startDwarf.X + 1] = dwarf[2];

            bool congestion = false;

            while(!congestion)
            {
                
                

                console = moveDown(console,rocks);




                ConsoleKeyInfo k = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                Console.Clear();

                if (k.Key == ConsoleKey.LeftArrow && (startDwarf.X - 1 > 0))
                    startDwarf.X--;
                else
                    if (k.Key == ConsoleKey.RightArrow && (startDwarf.X + 3 < 20))
                        startDwarf.X++;
                char p = console[startDwarf.Y-1,startDwarf.X];
                char l = console[startDwarf.Y-1,startDwarf.X+1];
                char o = console[startDwarf.Y-1,startDwarf.X + 2];
                if( (p== ' '||p=='\0') && (l == ' '||l=='\0')&& (o == ' '||o=='\0'))
                { console[startDwarf.Y-1,startDwarf.X] = dwarf[0];
                  console[startDwarf.Y-1,startDwarf.X+1] = dwarf[1];
                  console[startDwarf.Y-1,startDwarf.X+2] = dwarf[2];
                  score++;

                   for(int i =0;i<20;i++)
                       for(int j=0;j<20;j++)
                       {
                           Console.Write("{0}{1}",console[i,j],(j==0 && i!=0)?"\n":"");
                       }
                }
                else
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine("Your Score is {0}", score);
                        congestion = true;
                }

                Thread.Sleep(150);
                   




            }

        
        }
        
        static char[ , ] moveDown(char[ , ] m , char[] rocks)
        {
            char[,] rez = new char[20, 20];

            int rockNum = new Random().Next(2, 10);
        int[] cordinates = new int[rockNum];
        for(int i=0;i<rockNum;i++)
        {
            cordinates[i] = new Random().Next(0, 20);
        }
            

          

            for(int i =0;i<20;i++)
            {
                for(int j = 0;j<20;j++)
                {
                    if(i==0 && (new List<int> (cordinates).Contains(j)))
                    {
                        rez[i, j] = rocks[new Random().Next(0, rocks.Length - 1)];

                    }
                    else
                        if (i == 0)
                        {
                            rez[i, j] = ' ';
                        }
                        else
                        {
                            rez[i, j] = m[i - 1, j];
                        }

                }
            }

            return rez;
        }


    }
}
