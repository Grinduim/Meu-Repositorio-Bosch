using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancaria;

namespace ContaBancaria
{
    class CurrentAccount
    {
        private string Name;
        private int NumberAccount;
        private double Balance;
        private double LimitWithDraw;

        // gets e seets
        public string Name1 { get => Name; set => Name = value; }
        public int NumberAccount1 { get => NumberAccount; set => NumberAccount = value; }
        public double Balance1 { get => Balance; set => Balance = value; }
        public double LimitWithDraw1 { get => LimitWithDraw; set => LimitWithDraw = value; }

         static public void InvalidInt()
        {// function of modulation 
             Console.WriteLine("Please, correctly insert the fields");
             Console.WriteLine("Press any key to continue");
             Console.ReadKey();
             Console.Clear();
        }

        public void Deposit()
        {
            try
            {
                Console.Write("\nInput a value what do you want to deposit : $");
                Balance1 += double.Parse(Console.ReadLine());
                Console.WriteLine($"Deposit done, your new balance ${Balance1}");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            catch (FormatException)
            {
               InvalidInt();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void WithDraw()
        { // function fro withdraw
            try
            {
                 Console.Write("\nInput a value what do you want to WithDraw");
                 double value = double.Parse(Console.ReadLine());


                //condition
                if (LimitWithDraw >= value && Balance1-value >= 0 && value > 0 )
                {
                    Balance1 -= value;
                    Console.WriteLine($"\nWithDraw Complete, your new balance ${Balance1}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(Balance1 - value >= 0)
                {
                    Console.WriteLine("\nYou are unable to make this action, your balance it will be 0");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear(); 
                }
                else if(value > LimitWithDraw1)
                {
                    Console.WriteLine($"\nSorry, you are unable to make this action the amount you want with draw is more bigger than your Limit Of WithDraw -> ${LimitWithDraw1}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"\nSorry, you cannot complete this withdraw, please check all informations\nAttencion your Limit for WithDraw in {LimitWithDraw1}");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (FormatException)
            {
                   InvalidInt();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

        public void ShowData()
        {// show datas
            Console.WriteLine("\tDatas fo your account");
            Console.WriteLine($"\nNumber: {NumberAccount1}");
            Console.WriteLine($"Balance: {Balance1}");
            Console.WriteLine($"Limit of With Draw: {LimitWithDraw1}");
            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public void ChangeLimit()
        { // change limits
            try
            {
                Console.Write("\nWhat is your new balance? $");
                double NewBalance = double.Parse(Console.ReadLine());

                Console.WriteLine($"\n your new limit is Limit of With Draw: {LimitWithDraw1}");

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            catch (FormatException)
            {
                InvalidInt();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
