using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("======================================");
            Console.WriteLine("          LUCKY NUMBER GAME");
            Console.WriteLine("======================================");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            char playAgain;

            do
            {
                Random random = new Random();

                int luckyNumber = random.Next(1, 101);

                int[] guesses = new int[7];

                int guessCount = 0;
                bool guessedCorrectly = false;

                float score = 100.0f;
                decimal prize = 0.00m;

                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Game Rules:");
                Console.WriteLine("I have chosen a number between 1 and 100.");
                Console.WriteLine("You have 7 attempts.");
                Console.WriteLine("--------------------------------------");

                while (guessCount < 7 && guessedCorrectly == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("Remaining attempts: " + (7 - guessCount));
                    Console.Write("Enter your guess: ");

                    int guess = int.Parse(Console.ReadLine());

                    bool alreadyGuessed = false;

                    for (int i = 0; i < guessCount; i++)
                    {
                        if (guesses[i] == guess)
                        {
                            alreadyGuessed = true;
                        }
                    }

                    if (alreadyGuessed == true)
                    {
                        Console.WriteLine("You have already guessed this number!");
                    }
                    else
                    {
                        guesses[guessCount] = guess;
                        guessCount = guessCount + 1;

                        if (guess == luckyNumber)
                        {
                            guessedCorrectly = true;

                            if (guessCount == 1)
                            {
                                score = 100.0f;
                                prize = 500.00m;
                            }
                            else if (guessCount == 2)
                            {
                                score = 90.0f;
                                prize = 400.00m;
                            }
                            else if (guessCount == 3)
                            {
                                score = 80.0f;
                                prize = 300.00m;
                            }
                            else if (guessCount == 4)
                            {
                                score = 70.0f;
                                prize = 250.00m;
                            }
                            else if (guessCount == 5)
                            {
                                score = 60.0f;
                                prize = 200.00m;
                            }
                            else if (guessCount == 6)
                            {
                                score = 50.0f;
                                prize = 150.00m;
                            }
                            else
                            {
                                score = 40.0f;
                                prize = 100.00m;
                            }

                            Console.WriteLine();
                            Console.WriteLine("**************************************");
                            Console.WriteLine("CONGRATULATIONS " + name + "!");
                            Console.WriteLine("You guessed the lucky number!");
                            Console.WriteLine("**************************************");
                        }
                        else if (guess < luckyNumber)
                        {
                            Console.WriteLine("Try a higher number!");

                            score = score - 10.0f;
                        }
                        else
                        {
                            Console.WriteLine("Try a lower number!");

                            score = score - 10.0f;
                        }
                    }
                }

                if (guessedCorrectly == false)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have used all your attempts!");
                    Console.WriteLine("The lucky number was: " + luckyNumber);

                    score = 0.0f;
                    prize = 0.00m;
                }

                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine("             GAME RESULT");
                Console.WriteLine("======================================");

                Console.WriteLine("Player: " + name);
                Console.WriteLine("Lucky Number: " + luckyNumber);

                Console.WriteLine();
                Console.WriteLine("Your Guesses:");

                for (int i = 0; i < guessCount; i++)
                {
                    Console.WriteLine((i + 1) + ". Guess: " + guesses[i]);
                }

                Console.WriteLine();
                Console.WriteLine("Total Guesses: " + guessCount);
                Console.WriteLine("Score: " + score);
                Console.WriteLine("Prize: " + prize.ToString("F2") + " TL");

                Console.WriteLine("======================================");

                Console.WriteLine();
                Console.Write("Do you want to play again? (Y/N): ");
                playAgain = char.Parse(Console.ReadLine().ToUpper());

            } while (playAgain == 'Y');

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("Thank you, " + name + "!");
            Console.WriteLine("Thank you for playing!");
            Console.WriteLine("See you next time!");
            Console.WriteLine("======================================");
        }
    }
}
