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

        static public void InvalidInt()
        { // function to  send a message error
             Console.WriteLine("Please, correctly insert the fields");
             Console.WriteLine("Press any key to continue");
             Console.ReadKey();
             Console.Clear();
        }


        static public CurrentAccount CreatAccount()
        {
            CurrentAccount account = new CurrentAccount();

            while (true)
            {
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
                    return account;
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
        }

        static public ReseachAccount(CurrentAccount[] Accounts){
        {
                foreach(CurrentAccount account in Accounts)
                {
                    if( account.NumberAccount1 == 30)
                    {
                        Console.WriteLine("Teste 1 completo");
                        return Accounts;
                    }
                }

        }

        static public int Menu()
        { // menu funcition
            while (true)
            {// while in case of error
                try
                {
                    Console.WriteLine("\nChose a option:" +
                    "\n[1] - Creat Account" +
                    "\n[2] - Deposit" +
                    "\n[3] - WithDraw" + 
                    "\n[4] - Transfer"+
                    "\n[5] - Exit");
                    int opc = int.Parse(Console.ReadLine());

                    if(opc >= 1 || opc <= 3)
                    {
                        return opc;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease, select a option between 1 and 3");
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
                   Console.WriteLine("Erro:" + e.Message);
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }

        static void Main(string[] args)
        {
            List<CurrentAccount>  Accounts = new List<CurrentAccount>();

            
           
            while (true)
            { // make the menu infinite
                int menu = Menu();

                switch (menu)
                {
                    case 1:
                        Accounts.add(CreatAccount());
                        break;

                    case 2:
                        {
                            CurrentAccount account = ReseachAccount();
                            account.Deposit();
                            break;
                        }
                    case 3:
                        {
                            account.WithDraw();
                            break;
                        }
                   case 4:
                       account.Transfer();
                       break;

                    case 5:
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
