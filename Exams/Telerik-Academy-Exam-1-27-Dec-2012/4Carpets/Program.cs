using System;
namespace _4Carpets
{
    class Program
    {
        static void Main()
        {
           
            string left = "/";
            string right = "\\";
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for( i=0 ; i<n/2;i++)
            {
                
                Console.WriteLine("{0}{1}{2}{0}", new string('.', (n / 2 - 1 - i)), left, right);
                
                if(i%2==0){
                    left+=" ";
                    right = " "+ right;

                }
                else
                {
                    left+="/";
                    right="\\" + right;
                }
                
                
            }

            if (i % 2 == 0)
            {
                right = right.TrimStart('\\').TrimStart(' ') + " ";
                left = " " + left.TrimEnd('/').TrimEnd(' ');
            }

            else
            {
                right = right.TrimStart(' ');
                left = left.TrimEnd(' ');
            }
            for (i=(n/2)-1; i >=0; i--)
            {

                Console.WriteLine("{0}{1}{2}{0}", new string('.', ((n / 2 - 1) - i)), right, left);

                if (i % 2 == 1)
                {
                    left = left.TrimStart(' ');
                    right = right.TrimEnd(' ');

                }
                else
                {
                    left = left.TrimStart('/');
                    right = right.TrimEnd('\\');
                }


            }
           
        }
    }
}
