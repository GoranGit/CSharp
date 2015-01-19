using System;
namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the weight on Eart : ");
            double weightEart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(17 * (weightEart / 100));

        }
    }
}
