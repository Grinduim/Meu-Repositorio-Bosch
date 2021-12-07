using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PR = new List<string>();
            List<string> SP = new List<string>();
            List<string> SC = new List<string>();

            Console.Write("Quantos endereços você quer inserir ? ");
            int qtd = int.Parse(Console.ReadLine());

            for(int X = 0; X < qtd; X++)
            {
                Console.Write("\nInsira a Rua:");
                string rua = Console.ReadLine();

                Console.Write("\nNumero:");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("\nCidade:");
                string cidade = Console.ReadLine();

                Console.Write("\nEstado:");
                string uf = Console.ReadLine();
                uf = uf.ToUpper();

                string completo = $"{rua},{numero} - {cidade}/{uf}";

                if (uf == "PR")
                {
                    PR.Add(completo);
                }
                else if (uf == "SP")
                {
                    SP.Add(completo);
                }
                else
                {
                    SC.Add(completo);
                }
            }

            Console.Write("\n Todos os dados foram inserido:");
            Console.WriteLine("listando todos os endereços");

            Console.WriteLine("\n");
            for(int aux = 0; aux < PR.Count; aux++)
            {
                Console.WriteLine($"{PR[aux]}");
            }

            for (int aux = 0; aux < SP.Count; aux++)
            {
                Console.WriteLine($"{SP[aux]}");
            }

            for (int aux = 0; aux < SC.Count; aux++)
            {
                Console.WriteLine($"{SC[aux]}");
            }

        }
    }
}
