using System;
namespace _4Eggcelent
{
    class Program
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int height = 2 * n;
            int width = (3 * n) + 1;
            int top = n - 1;
            int bottom = top;
            string cracks = "@.";
            string cracks2 = ".@";
            int half = (height - 4) / 2;

            string rezult1 = "";
            string rezult2 = "";
            Console.WriteLine("{0}{1}{0}", new string('.', (width - top) / 2), new string('*', top));
            drawHalf(half, width, top, "up");
            
            for(int i=0;i<((width-5)/2);i++)
            {   rezult1+=cracks;
                rezult2+=cracks2;
            }
            Console.WriteLine("{0}{1}{2}", ".*", rezult1, "@*.");
            Console.WriteLine("{0}{1}{2}", ".*", rezult2, ".*.");

            drawHalf(half, width, top, "down");
            Console.WriteLine("{0}{1}{0}", new string('.', (width - bottom) / 2), new string('*', bottom));



        }

        static void drawHalf(int half, int width, int top, string upDown)
        {
            int p = 0;
            if (upDown.Equals("up"))
                for (int i = 1; i <= half; i++)
                {
                    bool k = false;

                    if (i == 1)
                        p = top + 2;
                    else
                        p += 4;

                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        (k = ((((width - top) / 2) - (i + i)) <= 1)) ?
                        "." :
                        new string('.', ((width - top) / 2) - (i + i)),
                        "*",
                        (k) ?
                        new string('.', (width - 4)) :
                        new string('.', p));

                }
            else
            {
                p = width - 4;
                for (int i = half; i >= 1; i--)
                {
                    bool k = false;
                   
                    if (i == 1)
                        p = top + 2;
                    else    
                        p -= 4;

                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        (k = ((((width - top) / 2) - (i + i)) <= 1)) ?
                        "." :
                        new string('.', ((width - top) / 2) - (i + i)),
                        "*",
                        (k) ?
                        new string('.', (width - 4)) :
                        new string('.', p));
                    if (k)
                        p += 4;
                }


            }
        }
    }
}
