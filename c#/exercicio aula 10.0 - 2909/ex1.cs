using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1____ver_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o primeiro lado do triangulo");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o segundo lado do triangulo");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o terceiro lado do triangulo");
            int C = int.Parse(Console.ReadLine());

            if (A < (B + C) && B < (C + A) && C < (A + B))
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("\nos dados informados formam triangulo equilátero");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("\nOs dados informados formam um triangulo isóceles");
                }
                else
                {
                    Console.WriteLine("\nOs dados informados formam um triangulo escaleno");
                }
            }
            else
            {
                Console.WriteLine("\nOs dados informados não formam um triangulo\n");
            }
        }
    }
}