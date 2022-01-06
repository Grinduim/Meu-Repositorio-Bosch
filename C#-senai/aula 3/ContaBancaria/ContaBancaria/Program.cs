using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancaria;

namespace ContaBancaria
{
    class Program
    {

        static public int Menu()
        {
            Console.WriteLine("\nChose a option:" +
                "\n[1] - Deposit" +
                "\n[2] - WithDraw" +
                "\n[3] - Exit");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();

            Console.Write("Input your number of account: ");
            account.NumberAccount1 = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            account.Name1 = Console.ReadLine();

            Console.Write("Begin Balance: $");
            account.Balance1 = double.Parse(Console.ReadLine());

            Console.Write("Limit of With Draw: $");
            account.LimitWithDraw1 = double.Parse(Console.ReadLine());

            while (true)
            {
                int menu = Menu();

                switch (menu)
                {
                    case 1:
                        {
                            account.Deposit();
                            break;
                        }
                    case 2:
                        {
                            account.WithDraw();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nLeaving the program");
                            System.Environment.Exit(0);
                            break;
                        }
                }
            }

        }
    }
}
