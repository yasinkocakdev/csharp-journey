using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("****************************************");
            Console.WriteLine("*       CINEMA TICKET BOOKING          *");
            Console.WriteLine("****************************************");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            byte choice;
            byte ticketCount = 0;
            bool programRunning = true;

            double ticketPrice = 150.00;
            double totalPrice = 0;

            DateTime bookingTime = DateTime.Now;

            // 0 = Empty
            // 1 = Reserved
            int[,] seats = new int[5, 6];

            while (programRunning == true)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("                 MENU");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1 - Show Seats");
                Console.WriteLine("2 - Book a Seat");
                Console.WriteLine("3 - Show Booking Information");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("----------------------------------------");

                Console.Write("Enter your choice: ");
                choice = byte.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.WriteLine();
                        Console.WriteLine("              SEAT MAP");
                        Console.WriteLine();

                        for (int row = 0; row < 5; row++)
                        {
                            for (int column = 0; column < 6; column++)
                            {
                                if (seats[row, column] == 0)
                                {
                                    Console.Write("[O] ");
                                }
                                else
                                {
                                    Console.Write("[X] ");
                                }
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.WriteLine("O = Available");
                        Console.WriteLine("X = Reserved");

                        break;

                    case 2:

                        Console.WriteLine();
                        Console.WriteLine("Available Seats:");

                        for (int row = 0; row < 5; row++)
                        {
                            for (int column = 0; column < 6; column++)
                            {
                                if (seats[row, column] == 0)
                                {
                                    Console.Write("(" + (row + 1) + "," + (column + 1) + ") ");
                                }
                            }

                            Console.WriteLine();
                        }

                        Console.WriteLine();
                        Console.Write("Enter row number (1-5): ");
                        int selectedRow = int.Parse(Console.ReadLine());

                        Console.Write("Enter seat number (1-6): ");
                        int selectedColumn = int.Parse(Console.ReadLine());

                        if (selectedRow >= 1 && selectedRow <= 5 &&
                            selectedColumn >= 1 && selectedColumn <= 6)
                        {
                            if (seats[selectedRow - 1, selectedColumn - 1] == 0)
                            {
                                seats[selectedRow - 1, selectedColumn - 1] = 1;

                                ticketCount = (byte)(ticketCount + 1);

                                double currentPrice = ticketPrice;

                                if (ticketCount > 3)
                                {
                                    currentPrice = ticketPrice * 0.90;
                                }

                                totalPrice = totalPrice + currentPrice;

                                Console.WriteLine();
                                Console.WriteLine("Seat successfully reserved!");
                                Console.WriteLine("Seat: Row " + selectedRow +
                                                  ", Seat " + selectedColumn);

                                Console.WriteLine("Ticket Price: " +
                                                  currentPrice.ToString("F2") + " TL");
                            }
                            else
                            {
                                Console.WriteLine("This seat is already reserved!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid seat number!");
                        }

                        break;

                    case 3:

                        Console.WriteLine();
                        Console.WriteLine("========================================");
                        Console.WriteLine("          BOOKING INFORMATION");
                        Console.WriteLine("========================================");

                        Console.WriteLine("Customer: " + name);
                        Console.WriteLine("Ticket Count: " + ticketCount);
                        Console.WriteLine("Ticket Price: " + ticketPrice.ToString("F2") + " TL");

                        if (ticketCount > 3)
                        {
                            Console.WriteLine("Discount: 10%");
                        }
                        else
                        {
                            Console.WriteLine("Discount: 0%");
                        }

                        Console.WriteLine("Total Price: " +
                                          totalPrice.ToString("F2") + " TL");

                        Console.WriteLine("Booking Time: " +
                                          bookingTime.ToString("dd.MM.yyyy HH:mm"));

                        // Math konusu
                        double roundedPrice = Math.Round(totalPrice, 2);

                        Console.WriteLine("Rounded Total: " +
                                          roundedPrice.ToString("F2") + " TL");

                        Console.WriteLine();
                        Console.WriteLine("************* THANK YOU *************");
                        Console.WriteLine("*   Enjoy your movie, " + name + "!   *");
                        Console.WriteLine("*************************************");

                        break;

                    case 4:

                        programRunning = false;

                        Console.WriteLine();
                        Console.WriteLine("****************************************");
                        Console.WriteLine("*        THANK YOU FOR VISITING!       *");
                        Console.WriteLine("****************************************");
                        Console.WriteLine("Goodbye, " + name + "!");

                        break;

                    default:

                        Console.WriteLine();
                        Console.WriteLine("Invalid choice!");
                        Console.WriteLine("Please select an option between 1 and 4.");

                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Program closed.");
        }
    }
}
