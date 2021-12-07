using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("insira a data no formato DD/MM/AAAA");
            string InputData = Console.ReadLine();

            var atual = DateTime.Now;

            var Date = atual.Date.ToString("dd/MM/yyyy");

            TimeSpan DiasDiferentes = Convert.ToDateTime(InputData) - Convert.ToDateTime(atual);

            int totalhoras = DiasDiferentes.Days * 24;

            if(totalhoras < 0)
            {
                totalhoras = totalhoras * (-1);
            }

            Console.WriteLine($"o dia de hoje com a data inserida tem uam diferença de {totalhoras} horas");

        }
    }
}
