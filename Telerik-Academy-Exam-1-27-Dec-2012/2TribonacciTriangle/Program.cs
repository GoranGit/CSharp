using System;
namespace _2TribonacciTriangle
{
    class Program
    {
        static void Main()
        {
            Int64 a = Int64.Parse(Console.ReadLine());
            Int64 b = Int64.Parse(Console.ReadLine());
            Int64 c = Int64.Parse(Console.ReadLine());
            int l=int.Parse(Console.ReadLine());

            string rez = "";

            Int64 result = 0;
            for(int i=0;i<l;i++)
            {
                for(int j=0;j<i+1;j++)
                {
                    if(i==0 )
                    {
                        Console.WriteLine(a);

                    }else
                        if(i==1 )
                        {
                            Console.WriteLine(b + " " + c);
                            j++;
                        }
                        else
                        {
                            result = a + b + c;
                            rez += result + " ";
                            a = b;
                            b = c;
                            c = result;

                        }
                }
                if(!rez.Equals(""))
                {
                    Console.WriteLine(rez.Trim(' '));
                }
                rez = "";
            }
        }
    }
}
