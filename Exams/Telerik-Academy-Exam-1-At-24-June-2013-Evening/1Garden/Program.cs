using System;

namespace _1Garden
{
    class Program
    {
        static void Main()
        {
            int totalArea = 0;
            double[] cost = {0.5,0.4,0.25,0.6,0.3,0.4};
            int beansCount = 0;
            decimal seedsCost = 0;
            for(int i = 0 ; i<5;i++)
            {
                seedsCost += (decimal)int.Parse(Console.ReadLine()) * (decimal)cost[i];
                totalArea += int.Parse(Console.ReadLine());
               
            }


            beansCount = int.Parse(Console.ReadLine());
            seedsCost += beansCount * (decimal)cost[5];
            Console.WriteLine("Total costs: {0:F2}", seedsCost);
            if(250 > totalArea)
            {
               
                totalArea = (250 - totalArea);               
                Console.WriteLine("Beans area: {0}", totalArea);
            }else
                if(totalArea==250)
                {
                  
                    Console.WriteLine("No area for beans");

                }
                else
                {
                  
                    Console.WriteLine("Insufficient area");
                }
        }
    }
}
