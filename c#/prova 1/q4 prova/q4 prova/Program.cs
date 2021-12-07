using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4_prova
{
    class Program
    {
        static public void NumPerfeito(int numero)
        {
            int resultado = 0;
            List<int> numeros = new List<int>();
            for(int aux = 1; aux < numero; aux++)
            {
                if(numero % aux == 0)
                {
                    numeros.Add(aux);
                }
                else
                {
                    continue;
                }
            }
            for(int aux = 0; aux < numeros.Count();aux++)
            {
                resultado = resultado + numeros[aux];
            }
            
            if(resultado == numero)
            {
                Console.WriteLine($" O  numero {numero} é um numero perfeito");
            }
            else
            {
                Console.WriteLine($" O  numero {numero} não  é um numero perfeito");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero inteiro");
            int num = int.Parse(Console.ReadLine());

            NumPerfeito(num);
        }
    }
}
