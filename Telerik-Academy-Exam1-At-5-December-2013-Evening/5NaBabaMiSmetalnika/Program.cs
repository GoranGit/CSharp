using System;

namespace _5NaBabaMiSmetalnika
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());

            string[] matrix = new string[8];

            uint pom = 0;
           for(int i=0;i<8;i++)
           {
               pom = uint.Parse(Console.ReadLine());
              // pom += 2147483648;

               string p  = Convert.ToString(pom, 2);
               p = p.PadLeft(32, '0');
              

               matrix[i] = p.Substring(p.Length - width,width);
                            

           }

            bool stop = false;
            long rezult = 0;
            int numOfEmptyColums = 0;
            bool emptyColum = true;
            int countEmptyColums = 0;

            while(!stop){
            string question = Console.ReadLine();
                if(question == "stop")
                {
                   
                    stop = true;
                    for(int i = 0; i<8;i++)
                    {
                       rezult +=  Convert.ToUInt32(matrix[i], 2);
                    }


                    for (int i = 0; i < width; i++)
                    {
                        emptyColum = true;
                        for (int j = 0; j < 8; j++)
                        {
                            if (matrix[j][i] == '1')
                                emptyColum = false; 

                        }
                        if (emptyColum)
                            countEmptyColums++;
                    }

                    Console.WriteLine(rezult * countEmptyColums);

                }
                else
                    if(question.Equals("reset"))
                    {
                        for(int i =0 ; i<8;i++)
                        {
                            int ones = matrix[i].Split('1').Length - 1;
                            string onesStr = new string('1', ones) + new string('0',width-ones);
                            matrix[i] = onesStr;

                        }



                    }
                    else
                    {
                        int row = int.Parse(Console.ReadLine());
                        int colum = int.Parse(Console.ReadLine());

                        if (colum < 0 )
                            colum = 0;
                        else if (colum > width - 1)
                           colum = width - 1;

                     

                        if (question.Equals("right"))
                        {
                            string subStr = matrix[row].Substring(colum, width - colum);
                            int ones = subStr.Split('1').Length - 1;
                            string onesStr = matrix[row].Substring(0,colum) + new string('0',(width-colum - ones)) +  new string('1', ones);
                            matrix[row] = onesStr;
                            
                        }else
                            if (question.Equals("left"))
                            {
                                string subStr = matrix[row].Substring(0,colum+1);
                                int ones = subStr.Split('1').Length - 1;
                                string onesStr = new string('1', ones) + new string('0',(colum +1 - ones))+ matrix[row].Substring(colum+1,width-colum - 1);
                                matrix[row] = onesStr;

                            }
                    }

            }


        }

      
    }
}
