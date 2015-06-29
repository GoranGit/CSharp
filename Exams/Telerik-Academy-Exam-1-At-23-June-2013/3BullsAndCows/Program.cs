    using System;
    namespace _3BullsAndCows
    {
        class Program
        {
            static void Main()
            {
                int secret = int.Parse(Console.ReadLine());
                if (secret < 0)
                    secret *= (-1);
           
                char[] secretDigits = Convert.ToString(secret).ToCharArray();

                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if(b>4 || c>4)
                {
                    Console.WriteLine("No");
                    return;
                }
            
                bool[] secretArray = { false, false, false, false };
                bool[] guessArray = { false, false, false, false };
                int numBuls = 0;
                int numCows = 0;
                char[] guessNum = new char[4];

                string result = "";

                for(int i=1111;i<=9999;i++)
                {


                        guessNum = Convert.ToString(i).ToCharArray();
                    if(new string(guessNum).Contains("0"))
                        continue;

                    numCows = 0;
                    numBuls = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        for(int k=0;k<4;k++)
                        {
                            if ((guessNum[k] == secretDigits[k]) && !secretArray[k] && !guessArray[k])
                            {
                                numBuls++;
                                secretArray[k] = true;
                                guessArray[k] = true;

                           
                            }
                    
          
                                if((guessNum[j] == secretDigits[k]) && !secretArray[k] && !guessArray[j] && (k!=j))
                                {
                                    numCows++;
                                    secretArray[k] = true;
                                    guessArray[j] = true;
                                }


                        }

                    }

                    if(b==numBuls && c==numCows)
                    {
                        result += i.ToString() + " ";
                   
                    }

                    for (int p = 0; p < 4; p++)
                    {
                        secretArray[p] = false;
                        guessArray[p] = false;
                    }

                }

                if(  result.Trim(' ')=="")
                {
                    Console.WriteLine("No");
                }
                else
                Console.WriteLine(result.Trim(' '));
           
          
            }
        }
    }
