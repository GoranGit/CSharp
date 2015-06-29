using System;
using System.Collections.Generic;
namespace _5NeuronMapping
{
    class Program
    {
        static void Main()
        {
            uint n = 0;
            string row;
            string temp;
            string[] p ;
  
            int countZerows = 0;

            int position = 0;
            for (int i = 0; uint.TryParse(Console.ReadLine(), out n);i++ )
            {
                string[] cleanedSpace = new string[32];

                row = Convert.ToString(n, 2).PadLeft(32, '0');

                p = row.Split('1');

                position = 0;
                countZerows = 0;

                for(int j=0;j<p.Length;j++)
                {
                    if (j == 0 && p[j].Equals(""))
                    {
                        cleanedSpace[countZerows] = p[j];
                        countZerows++;     
                    }else
                        if(p[j]=="" && (j!=p.Length-1) )
                        {
                            if(countZerows<2)
                            position++;
                            continue;
                        }
                        else
                            if(p[j]== "" && (j==p.Length-1))
                            {
                                cleanedSpace[countZerows] = p[j];
                                countZerows++;
                            }else                       
                                {

                                    if (countZerows == 0)
                                        position = p[j].Length;

                                    if (countZerows == 1)
                                        position++;

                                    cleanedSpace[countZerows] = p[j];
                                    countZerows++;
                                }
                }

                if (cleanedSpace[2]!=null)
                {
                    temp = cleanedSpace[1];
                   temp =  temp.Replace('0', '1');
                   temp = temp.PadLeft(position+temp.Length, '0');
                   temp = temp.PadRight(32, '0');

                }
                else
                {
                    temp = new string('0', 32);
                }





                Console.WriteLine(Convert.ToUInt32(temp, 2));


            }
        }
    }
}
