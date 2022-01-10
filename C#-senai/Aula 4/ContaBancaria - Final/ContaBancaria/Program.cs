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

        static public void InvalidInt()// function to show a message error
        {
             Console.WriteLine("Please, correctly insert the fields");
             Console.WriteLine("Press any key to continue");
             Console.ReadKey();
             Console.Clear();
        }



        static public int Menu()
        { // menu
            while (true)
            { // while to make infinity menu in case of error
                try
                {
                    Console.WriteLine("\nChose a option:" +
                    "\n[1] - Deposit" +
                    "\n[2] - WithDraw" +
                    "\n[3] - Show data of account" +
                    "\n[4] - Change a limit of WithDraw" +
                    "\n[5] - Exit" +
                    "\nPlease select a option");
                    int opc = int.Parse(Console.ReadLine());

                    if(opc >= 1 || opc <= 5)
                    {
                        return opc;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease, select a option between 1 and 5");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    
                }
                 catch (FormatException)
                {
                    InvalidInt();
                    continue;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            
        }

        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();

            while (true)
            {// while to make infinity menu in case of error
                try
                {
                     Console.Write("Input your number of account: ");
                    account.NumberAccount1 = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    account.Name1 = Console.ReadLine();

                    Console.Write("Begin Balance: $");
                    account.Balance1 = double.Parse(Console.ReadLine());

                    Console.Write("Limit of With Draw: $");
                    account.LimitWithDraw1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\n\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                 catch (FormatException)
                {
                    InvalidInt();
                    continue;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
               
            }
           
            while (true)
            {// while to make infinity menu
                int menu = Menu();

                switch (menu)
                {
                    case 1: // deposit switch
                        {
                            account.Deposit();
                            break;
                        }
                    case 2: // withDraw Switch
                        {
                            account.WithDraw();
                            break;
                        }

                    case 3: // show data switch
                        {
                            account.ShowData();
                            break;
                        }
                    case 4: // change limit switch
                        {
                            account.ChangeLimit();
                            break;
                        }
                    case 5: // exit switch
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