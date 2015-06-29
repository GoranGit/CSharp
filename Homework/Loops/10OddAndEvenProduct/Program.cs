using System;
namespace _10OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            string k = Console.ReadLine();

            string[] array = k.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
            
            for(int i = 0;i<array.Length;i++)
            {
                if (i % 2 == 0)
                    oddProduct *= int.Parse(array[i]);

                else
                    evenProduct *= int.Parse(array[i]);

            }

            Console.WriteLine("{0}", (oddProduct == evenProduct) ? ("yes \n product is:"+oddProduct ): ("no \n odd_product ="+oddProduct+" \n even_product = "+evenProduct));
            Main();
        }
    }
}
