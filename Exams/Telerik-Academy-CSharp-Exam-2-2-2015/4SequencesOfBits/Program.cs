using System;

namespace _4SequencesOfBits
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            uint p = 0;
            
            int maxZero = 0;
            int maxOne = 0;
           string rezString = "";

            for(int i = 0;i<n;i++)
            {
                p = uint.Parse(Console.ReadLine());
                string l = Convert.ToString(p, 2).PadLeft(30,'0');
                rezString +=l; 
                   
            }

            maxOne = countZerowsOnes(rezString, '1');
            maxZero = countZerowsOnes(rezString, '0');
            Console.WriteLine(maxZero);
            Console.WriteLine(maxOne);
            
           


        }

        static int countZerowsOnes(string p, char oneOrZero)
        {
            int count = 0;
         
            
            string[] subs = p.Split(oneOrZero);

            for(int i = 0;i<subs.Length;i++)
            {
                if(subs[i].Length>count)
                    count = subs[i].Length;
                
            }
            return count;

        }
    }
}
