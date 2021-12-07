using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10_num_primos_func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(primos(x));
        }

        static bool primos(int num)
        {
            int conta = 0;
            bool validacao = false;
            for (int aux = 1; aux < num +1; aux++)
            {
                if(num % aux == 0)
                {
                    conta++;
                    Console.WriteLine(aux);
                }
            }
            if (conta == 2)
            {
                validacao = true;
            }
            else
            {
                validacao = false;
            }
            return validacao;

        }
    }
}
