using System;
namespace _4PrintADeckOf52Cards
{
    class Program
    {
        static void Main()
        {
            string[] deck = { "of spades,", "of clubs,", "of hearts,", "of diamonds \n" };

            for (int i = 2; i <= 14; i++)
            {
                for(int k = 0;k<4;k++)
                {
                    switch(i)
                    {
                        case 11:
                            {
                                Console.Write("J {0} ", deck[k]);
                                break;
                            }
                        case 12:
                            {
                                Console.Write("Q {0} ", deck[k]);
                                break;
                            }
                        case 13:
                            {
                                Console.Write("K {0} ", deck[k]);
                                break;
                            }
                        case 14:
                            {
                                Console.Write("A {0} ", deck[k]);
                                break;
                            }
                        default:
                            {
                                Console.Write("{0} {1} ", i, deck[k]);
                                break;
                            }
                    }
                }


            }

        }
    }
}
