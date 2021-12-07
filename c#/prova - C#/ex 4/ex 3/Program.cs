using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual valor você quer sacar ?  RS$");
            int valor = int.Parse(Console.ReadLine());

            if(valor >= 10 && valor <= 600)
            {
                int n100 = valor / 100;
                valor = valor - (100 * n100);
                Console.WriteLine(n100);

                int n50 = valor / 50;
                valor = valor - (50 * n50);

                int n20 =  valor / 20;
                valor = valor - (20 * n20);

                int n10 = valor / 10;
                valor = valor - (10 * n10);

                int n5 = valor / 5;
                valor = valor - (5 * n5);

                int n1 = valor / 1;
                valor = valor - (1* n1);

                Console.WriteLine($"\n Sacando..." +
                    $"\n {n100} notas/nota de 100 reais" +
                    $"\n {n50} notas/nota de 50 reais" +
                    $"\n {n20} notas/nota de 20 reais" +
                    $"\n {n10} notas/nota de 10 reais" +
                    $"\n {n1} notas/nota de 1 real");
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }

        }
    }
}
