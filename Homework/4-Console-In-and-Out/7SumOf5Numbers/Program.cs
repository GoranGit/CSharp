using System;
namespace _7SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            string h = Console.ReadLine();
            string[] k = h.Split(' ');
            float num = 0;
            float sum = 0;

            foreach(string l in k)
            {
                float.TryParse(l, out num);
                sum += num;
            }
            Console.WriteLine("Sum of the numbers is : {0}", sum);
        }

    }
}