using System;
using System.Numerics;
namespace _3CardWars
{
    class Program
    {
        static void Main()
        {
            int[] points = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 0, 1, 11, 12, 13 };

            string cards = "2345678910AJQK";
            string card;

            BigInteger scoreFirstPlayer = 0;
            BigInteger scoreSecondPlayer = 0;
            bool firstPlayerHasX = false;
            bool secondPlayerHasX = false;
            int gamePointsFP = 0;
            int gamePointsSP = 0;

            int firstPlayerWins = 0;
            int secondPlayerWins = 0;


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int j = 3;
                firstPlayerHasX = false;
                secondPlayerHasX = false;
                gamePointsFP = 0;
                gamePointsSP = 0;

                while (j != 0)
                {
                    card = Console.ReadLine().ToUpper();
                    switch (card)
                    {
                        case "X":
                            {
                                firstPlayerHasX = true;
                                break;
                            }
                        case "Y":
                            {

                                scoreFirstPlayer -= 200;
                                break;
                            }
                        case "Z":
                            {

                                scoreFirstPlayer *= 2;
                                break;
                            }
                        default:
                            {
                                gamePointsFP += points[cards.IndexOf(card)];

                                break;
                            }
                    }
                    j--;

                }
                j = 3;
                while (j != 0)
                {
                    card = Console.ReadLine().ToUpper();
                    switch (card)
                    {
                        case "X":
                            {
                                secondPlayerHasX = true;
                                break;
                            }
                        case "Y":
                            {
                                scoreSecondPlayer -= 200;
                                break;
                            }
                        case "Z":
                            {
                                scoreSecondPlayer *= 2;
                                break;
                            }
                        default:
                            {
                                gamePointsSP += points[cards.IndexOf(card)];

                                break;
                            }
                    }
                    j--;

                }

                if (firstPlayerHasX && secondPlayerHasX)
                {
                    scoreFirstPlayer += 50;
                    scoreSecondPlayer += 50;
                    firstPlayerHasX = false;
                    secondPlayerHasX = false;
                }
                else
                    if (firstPlayerHasX)
                    {
                        firstPlayerWins++;
                        break;
                    }
                    else
                        if (secondPlayerHasX)
                        {
                            secondPlayerWins++;
                            break;
                        }
                        else
                            if (gamePointsFP > gamePointsSP)
                            {
                                scoreFirstPlayer += gamePointsFP;
                                firstPlayerWins++;

                            }
                            else
                                if (gamePointsSP > gamePointsFP)
                                {
                                    scoreSecondPlayer += gamePointsSP;
                                    secondPlayerWins++;

                                }


            }

            if (firstPlayerHasX)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
            }
            else
                if (secondPlayerHasX)
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
                else
                    if (scoreFirstPlayer > scoreSecondPlayer)
                    {
                        Console.WriteLine("First player wins!");
                        Console.WriteLine("Score: {0}", scoreFirstPlayer);
                        Console.WriteLine("Games won: {0}", firstPlayerWins);
                    }
                    else
                        if (scoreSecondPlayer > scoreFirstPlayer)
                        {
                            Console.WriteLine("Second player wins!");
                            Console.WriteLine("Score: {0}", scoreSecondPlayer);
                            Console.WriteLine("Games won: {0}", secondPlayerWins);

                        }
                        else
                            if (scoreFirstPlayer == scoreSecondPlayer)
                            {
                                Console.WriteLine("It's a tie!");
                                Console.WriteLine("Score: {0}", scoreFirstPlayer);
                            }

        }
    }
}
