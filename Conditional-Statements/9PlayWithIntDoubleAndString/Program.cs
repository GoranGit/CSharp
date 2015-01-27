using System;
namespace _9PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int \n 2 --> double \n 3 --> string");
            int selection = int.Parse(Console.ReadLine());

           switch(selection)

            {
                case 1:
                    {
                        Console.Write("Please enter a int:");
                        Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                        break;
                    }
               case 2:
                    {
                        Console.Write("Please enter a double:");
                        Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                        break;

                    }
               case 3:
                    {
                        Console.Write("Please enter a string:");
                        Console.WriteLine((Console.ReadLine()) + "*");
                        break;
                    }
               default:
                    {
                        Console.WriteLine("Please enter a string, int or double!");
                        Main();// recursive call 
                        break;
                    }

            }
        }
    }
}
