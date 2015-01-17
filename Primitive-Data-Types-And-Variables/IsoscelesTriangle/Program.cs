using System;
namespace IsoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type a number of rows: ");
            int n = int.Parse(Console.ReadLine());
            int j =1;
            int m=0;

            string s1, s2;
            for(int i=n;i>1;i--)
            {
                s1 = new String(' ', i - 1);
                s2 = new String(' ', j);
                if (i == n)
                {
                    Console.WriteLine(s1 + (char)169 + s1);                 
                }
                else
                {
                    Console.WriteLine(s1 + (char)169 + s2 + (char)169 + s1);
                    m++;
                    j = (2*m) + 1;             
                }
            }
            s1 = new String((char)169, (n * 2) - 1);
            Console.WriteLine(s1);
        }
    }
}
