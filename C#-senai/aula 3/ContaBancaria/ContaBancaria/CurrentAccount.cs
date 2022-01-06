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

        public string Name1 { get => Name; set => Name = value; }
        public int NumberAccount1 { get => NumberAccount; set => NumberAccount = value; }
        public double Balance1 { get => Balance; set => Balance = value; }
        public double LimitWithDraw1 { get => LimitWithDraw; set => LimitWithDraw = value; }

        public void Deposit()
        {
            Console.Write("\nInput a value what do you want to deposit : $");
            Balance1 += double.Parse(Console.ReadLine());
            Console.WriteLine($"Deposit done, your new balance ${Balance1}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        public void WithDraw()
        {
            Console.Write("\nInput a value what do you want to WithDraw");
            double value = double.Parse(Console.ReadLine());


            try
            {

            }
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
                throw 
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
    }
}
