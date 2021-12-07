using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impar_par__1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor");
            int n1 = int.Parse(Console.ReadLine());
            int x = imppar(n1);
            Console.WriteLine(x);
        }

        static int imppar(int n1)
        {
            if (n1 % 2 == 0)
            {
                return -1;
            }
            else
                return 1;
        }
    }
}

      
