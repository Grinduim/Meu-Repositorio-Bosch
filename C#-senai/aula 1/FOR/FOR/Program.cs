using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um programa que receba um numero natural e imprime todos os nmeros pares de 0 até o numero inserido.


            int num;

            Console.WriteLine("Insira um numero");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Todos os numeros pares começando do 0 até  {num} que é o numero inserido");
            for(int i = 0; i < num+1; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
