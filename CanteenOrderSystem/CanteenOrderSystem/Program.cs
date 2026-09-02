using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CanteenOrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("======================================");
            Console.WriteLine("       CANTEEN ORDER SYSTEM");
            Console.WriteLine("======================================");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            double total = 0;
            int orderItems = 0;

            string choice = "";

            while (choice != "0")
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("                MENU");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1 - Toast          : 75.50 TL");
                Console.WriteLine("2 - Hamburger      : 120.00 TL");
                Console.WriteLine("3 - Ayran          : 25.00 TL");
                Console.WriteLine("4 - Cola           : 35.00 TL");
                Console.WriteLine("5 - French Fries   : 50.00 TL");
                Console.WriteLine("0 - Finish Order");
                Console.WriteLine("--------------------------------------");

                Console.Write("Enter product number: ");
                choice = Console.ReadLine();

                double price = 0;
                string product = "";

                switch (choice)
                {
                    case "1":
                        product = "Toast";
                        price = 75.50;
                        break;

                    case "2":
                        product = "Hamburger";
                        price = 120.00;
                        break;

                    case "3":
                        product = "Ayran";
                        price = 25.00;
                        break;

                    case "4":
                        product = "Cola";
                        price = 35.00;
                        break;

                    case "5":
                        product = "French Fries";
                        price = 50.00;
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Invalid product number!");
                        Console.WriteLine("Please choose a valid option.");
                        continue;
                }

                if (choice == "0")
                {
                    break;
                }

                Console.Write("How many " + product + " would you like? ");
                int quantity = int.Parse(Console.ReadLine());

                if (quantity <= 0)
                {
                    Console.WriteLine("Quantity cannot be zero or negative!");
                    Console.WriteLine("The order was not added.");
                }
                else
                {
                    double itemTotal = price * quantity;
                    total = total + itemTotal;
                    orderItems = orderItems + 1;

                    Console.WriteLine();
                    Console.WriteLine("Your order has been added, " + name + ".");
                    Console.WriteLine("Product: " + product);
                    Console.WriteLine("Quantity: " + quantity);
                    Console.WriteLine("Item Total: " + itemTotal.ToString("F2") + " TL");
                    Console.WriteLine("Current Total: " + total.ToString("F2") + " TL");
                }
            }

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("                BILL");
            Console.WriteLine("======================================");

            Console.WriteLine("Subtotal: " + total.ToString("F2") + " TL");

            double discountRate = 0;

            if (total > 500)
            {
                discountRate = 0.10;
            }
            else if (total > 250)
            {
                discountRate = 0.05;
            }
            else
            {
                discountRate = 0;
            }

            double discountAmount = total * discountRate;
            double finalTotal = total - discountAmount;

            Console.WriteLine("Discount Amount: " + discountAmount.ToString("F2") + " TL");
            Console.WriteLine("Final Amount: " + finalTotal.ToString("F2") + " TL");

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("Thank you, " + name + "!");
            Console.WriteLine("Number of order items: " + orderItems);
            Console.WriteLine("We hope to see you again.");
            Console.WriteLine("======================================");



        }
    }
}
