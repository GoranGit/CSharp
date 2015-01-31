using System;
namespace _1PeaceOfCake
{
    class Program
    {
        static void Main()
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong d = ulong.Parse(Console.ReadLine());

            ulong f = 0;
            ulong g = 0;

            decimal rez = ((f =((d * a) + (b * c))) / (decimal)(g=(b * d)));
            ulong k= 0;
            if(( k=(ulong)rez)!= 0)
            {
                Console.WriteLine(k);
                Console.WriteLine(f + "/" + g);

            }else
            {
                Console.WriteLine("{0:F22}", rez);
                Console.WriteLine(f + "/" + g);
            }
        }
    }
}
