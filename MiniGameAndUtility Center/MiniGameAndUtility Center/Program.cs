using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MiniGameAndUtility_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("==========================================");
            Console.WriteLine("       MINI GAME & UTILITY CENTER");
            Console.WriteLine("==========================================");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Random random = new Random();

            char choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("==========================================");
                Console.WriteLine("                  MENU");
                Console.WriteLine("==========================================");
                Console.WriteLine("1 - Quiz Game");
                Console.WriteLine("2 - Math Menu");
                Console.WriteLine("3 - Number Guessing Game");
                Console.WriteLine("4 - Music Player");
                Console.WriteLine("5 - Random League");
                Console.WriteLine("6 - Food Order");
                Console.WriteLine("7 - Save Note");
                Console.WriteLine("8 - Stack Demo");
                Console.WriteLine("9 - Exit");
                Console.WriteLine("==========================================");

                Console.Write("Enter your choice: ");
                choice = char.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case '1':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("                QUIZ GAME");
                        Console.WriteLine("==========================================");

                        int score = 0;

                        Console.WriteLine("Question 1:");
                        Console.WriteLine("What is the capital of France?");
                        Console.WriteLine("A - London");
                        Console.WriteLine("B - Paris");
                        Console.WriteLine("C - Rome");
                        Console.WriteLine("D - Berlin");

                        Console.Write("Your answer: ");
                        char answer1 = char.Parse(Console.ReadLine().ToUpper());

                        if (answer1 == 'B')
                        {
                            Console.WriteLine("Correct!");
                            score = score + 10;
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Question 2:");
                        Console.WriteLine("Which language are we using?");
                        Console.WriteLine("A - C#");
                        Console.WriteLine("B - Python");
                        Console.WriteLine("C - Java");
                        Console.WriteLine("D - HTML");

                        Console.Write("Your answer: ");
                        char answer2 = char.Parse(Console.ReadLine().ToUpper());

                        if (answer2 == 'A')
                        {
                            Console.WriteLine("Correct!");
                            score = score + 10;
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Your Score: " + score);

                        break;


                    case '2':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("                MATH MENU");
                        Console.WriteLine("==========================================");

                        Console.Write("Enter first number: ");
                        double number1 = double.Parse(Console.ReadLine());

                        Console.Write("Enter second number: ");
                        double number2 = double.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("1 - Addition");
                        Console.WriteLine("2 - Subtraction");
                        Console.WriteLine("3 - Multiplication");
                        Console.WriteLine("4 - Division");

                        Console.Write("Choose operation: ");
                        int mathChoice = int.Parse(Console.ReadLine());

                        double result = 0;

                        switch (mathChoice)
                        {
                            case 1:
                                result = number1 + number2;
                                break;

                            case 2:
                                result = number1 - number2;
                                break;

                            case 3:
                                result = number1 * number2;
                                break;

                            case 4:

                                if (number2 != 0)
                                {
                                    result = number1 / number2;
                                }
                                else
                                {
                                    Console.WriteLine("Cannot divide by zero!");
                                }

                                break;

                            default:
                                Console.WriteLine("Invalid operation!");
                                break;
                        }

                        Console.WriteLine("Result: " + result);

                        break;


                    case '3':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("          NUMBER GUESSING GAME");
                        Console.WriteLine("==========================================");

                        int luckyNumber = random.Next(1, 101);
                        int attempts = 0;
                        bool correct = false;

                        while (attempts < 7 && correct == false)
                        {
                            Console.Write("Enter your guess: ");
                            int guess = int.Parse(Console.ReadLine());

                            attempts++;

                            if (guess == luckyNumber)
                            {
                                Console.WriteLine("Congratulations! You guessed it!");
                                correct = true;
                            }
                            else if (guess < luckyNumber)
                            {
                                Console.WriteLine("Try a higher number!");
                            }
                            else
                            {
                                Console.WriteLine("Try a lower number!");
                            }
                        }

                        if (correct == false)
                        {
                            Console.WriteLine("You lost!");
                            Console.WriteLine("The number was: " + luckyNumber);
                        }

                        Console.WriteLine("Attempts: " + attempts);

                        break;


                    case '4':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("               MUSIC PLAYER");
                        Console.WriteLine("==========================================");

                        string[] songs =
                        {
                "Blinding Lights",
                "Believer",
                "Shape of You",
                "Counting Stars",
                "Perfect"
            };

                        Console.WriteLine("Your Playlist:");

                        for (int i = 0; i < songs.Length; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + songs[i]);
                        }

                        Console.Write("Choose a song: ");
                        int songChoice = int.Parse(Console.ReadLine());

                        if (songChoice >= 1 && songChoice <= songs.Length)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Now playing: " + songs[songChoice - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid song!");
                        }

                        break;


                    case '5':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("              RANDOM LEAGUE");
                        Console.WriteLine("==========================================");

                        string[] teams =
                        {
                "Lions",
                "Tigers",
                "Eagles",
                "Wolves"
            };

                        Console.WriteLine("Random Matches:");

                        for (int i = 0; i < teams.Length; i++)
                        {
                            int opponent = random.Next(0, teams.Length);

                            if (opponent != i)
                            {
                                Console.WriteLine(
                                    teams[i] + " vs " + teams[opponent]);
                            }
                        }

                        break;


                    case '6':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("                FOOD ORDER");
                        Console.WriteLine("==========================================");

                        string[] foods =
                        {
                "Burger",
                "Pizza",
                "Fries",
                "Chicken",
                "Cola"
            };

                        double[] prices =
                        {
                150.00,
                180.00,
                70.00,
                140.00,
                40.00
            };

                        for (int i = 0; i < foods.Length; i++)
                        {
                            Console.WriteLine(
                                (i + 1) + " - " +
                                foods[i] + " : " +
                                prices[i].ToString("F2") + " TL");
                        }

                        Console.Write("Choose a food: ");
                        int foodChoice = int.Parse(Console.ReadLine());

                        if (foodChoice >= 1 && foodChoice <= foods.Length)
                        {
                            Console.Write("Enter quantity: ");
                            int quantity = int.Parse(Console.ReadLine());

                            double foodTotal =
                                prices[foodChoice - 1] * quantity;

                            Console.WriteLine();
                            Console.WriteLine(
                                "Food: " + foods[foodChoice - 1]);

                            Console.WriteLine(
                                "Quantity: " + quantity);

                            Console.WriteLine(
                                "Total: " +
                                foodTotal.ToString("F2") + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Invalid food choice!");
                        }

                        break;


                    case '7':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("                 SAVE NOTE");
                        Console.WriteLine("==========================================");

                        Console.Write("Enter your note: ");
                        string note = Console.ReadLine();

                        string fileName = "MyNote.txt";

                        File.WriteAllText(fileName, note);

                        Console.WriteLine();
                        Console.WriteLine("Your note has been saved!");
                        Console.WriteLine("File: " + fileName);

                        break;


                    case '8':

                        Console.WriteLine("==========================================");
                        Console.WriteLine("                STACK DEMO");
                        Console.WriteLine("==========================================");

                        Stack<string> actions = new Stack<string>();

                        actions.Push("Open Game");
                        actions.Push("Start Match");
                        actions.Push("Buy Food");
                        actions.Push("Play Music");

                        Console.WriteLine("Stack items:");

                        foreach (string action in actions)
                        {
                            Console.WriteLine(action);
                        }

                        Console.WriteLine();
                        Console.WriteLine("Last action: " + actions.Peek());

                        Console.WriteLine(
                            "Removed action: " + actions.Pop());

                        Console.WriteLine();
                        Console.WriteLine("Remaining actions:");

                        foreach (string action in actions)
                        {
                            Console.WriteLine(action);
                        }

                        break;


                    case '9':

                        Console.WriteLine();
                        Console.WriteLine("==========================================");
                        Console.WriteLine("Thank you, " + name + "!");
                        Console.WriteLine("See you next time!");
                        Console.WriteLine("==========================================");

                        break;


                    default:

                        Console.WriteLine("Invalid choice!");

                        break;
                }

            } while (choice != '9');

            Console.WriteLine();
            Console.WriteLine("Program closed.");
        }
    }
}
