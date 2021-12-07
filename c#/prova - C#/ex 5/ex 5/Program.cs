using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>();
            List<decimal> valor = new List<decimal>();
            decimal total = 0;

            do
            {

                Console.Write("insira o nome do produto: ");
                string produto = Console.ReadLine();

                if (string.IsNullOrEmpty(produto) == false)
                {

                    Console.Write("Insira o valor do produto: R$");
                    decimal preço = decimal.Parse(Console.ReadLine());
                    Console.Write("\n");

                    total = total + preço;

                    produtos.Add(produto);
                    valor.Add(preço);
                    continue;
                }
                else
                {
                    Console.WriteLine("Encerrando programa.");
                    Task.Delay(1500).Wait();
                    Console.Clear();
                    break;
                }

            } while (true);

            for (int aux = 0;  aux < produtos.Count; aux++)
            {
                Console.WriteLine($"{aux + 1}º {produtos[aux]} | R${valor[aux]:0.00}");
            }
            Console.WriteLine($"\n Total: R${total:0.00}");
        }
    }
}
