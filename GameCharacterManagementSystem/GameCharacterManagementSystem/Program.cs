using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacterManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("     GAME CHARACTER MANAGEMENT");
            Console.WriteLine("======================================");

            Console.Write("Enter Warrior name: ");
            string warriorName = Console.ReadLine();

            Console.Write("Enter Mage name: ");
            string mageName = Console.ReadLine();

            Warrior warrior = new Warrior(warriorName, 150, 5, 80);
            Mage mage = new Mage(mageName, 100, 4, 120);

            Console.WriteLine();
            Console.WriteLine("Characters created successfully!");

            char choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("======================================");
                Console.WriteLine("                MENU");
                Console.WriteLine("======================================");

                Console.WriteLine("1 - Show Warrior");
                Console.WriteLine("2 - Show Mage");
                Console.WriteLine("3 - Warrior Attack");
                Console.WriteLine("4 - Mage Cast Spell");
                Console.WriteLine("5 - Show Character Powers");
                Console.WriteLine("6 - Exit");

                Console.WriteLine("======================================");

                Console.Write("Enter your choice: ");
                choice = char.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case '1':

                        warrior.ShowWarriorInfo();

                        break;

                    case '2':

                        mage.ShowMageInfo();

                        break;

                    case '3':

                        warrior.Attack();
                        warrior.Attack(mage.Name);

                        break;

                    case '4':

                        mage.CastSpell();

                        break;

                    case '5':

                        Console.WriteLine(warrior.Name +
                                          " Power: " + warrior.GetPower());

                        Console.WriteLine(mage.Name +
                                          " Power: " + mage.GetPower());

                        break;

                    case '6':

                        Console.WriteLine("Thank you for playing!");
                        break;

                    default:

                        Console.WriteLine("Invalid choice!");

                        break;
                }

            } while (choice != '6');

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("        GAME CLOSED SUCCESSFULLY");
            Console.WriteLine("======================================");
        }
    }



class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public Character(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void ShowInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Character: " + Name);
            Console.WriteLine("Health: " + Health);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("--------------------------------");
        }

        public void Attack()
        {
            Console.WriteLine(Name + " attacks!");
        }

        public void Attack(string enemy)
        {
            Console.WriteLine(Name + " attacks " + enemy + "!");
        }

        public int GetPower()
        {
            return Level * 10;
        }
    }

    class Warrior : Character
    {
        public int Armor { get; set; }

        public Warrior(string name, int health, int level, int armor)
            : base(name, health, level)
        {
            Armor = armor;
        }

        public void ShowWarriorInfo()
        {
            ShowInfo();
            Console.WriteLine("Armor: " + Armor);
            Console.WriteLine("Power: " + GetPower());
        }

        public void Defend()
        {
            Console.WriteLine(Name + " is defending!");
        }
    }

    class Mage : Character
    {
        public int Mana { get; set; }

        public Mage(string name, int health, int level, int mana)
            : base(name, health, level)
        {
            Mana = mana;
        }

        public void ShowMageInfo()
        {
            ShowInfo();
            Console.WriteLine("Mana: " + Mana);
            Console.WriteLine("Power: " + GetPower());
        }

        public void CastSpell()
        {
            Console.WriteLine(Name + " casts a powerful spell!");
        }
    }

  
}
