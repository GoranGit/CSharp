using System;
namespace _19SpiralMatrix2
{
    class Program
    {
        static void Main()
        {

           int m = int.Parse(Console.ReadLine());
            int n = m;
            int x = 0;
            int y = 0;
            int[ , ] matrix = new int[n,n];
            int count = n*n; // number of  elements
            int cnt = 1; // 
           
            while (cnt <=count)
            {

                if(n==1)
                {   matrix[x,y]=cnt;
                    cnt++;
                    break;
                }

                //top left to right
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x,y++] = cnt ;
                    cnt++;
                }

                //top right to down
                for (int i = 0; i < n - 1; i++)
                {
                   matrix[x++,y] = cnt;
                   cnt++;
                }

                //right bottom  to left
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x,y--] = cnt;
                    cnt++;
                }

                //left bottom to up
                for (int i = 0; i < n - 1; i++)
                {
                    matrix[x--,y] = cnt;
                    cnt++;
                }

                x++;
                y++;

                n -= 2; // cut the  rows and colums that are passed

            }

            for (int l = 0; l < m; l++) //Print the  matrix in the console
            {
                for (int k = 0; k < m; k++)
                    Console.Write(matrix[l, k]);
                Console.Write("\n");
            }
        
        }
    }
}
