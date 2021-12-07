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
            while (true)
            {
                Console.WriteLine("\nInsira um numero ");
                double num = double.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine($"\nO numero digitado é positivo, Você inseriu o numero {num}");
                    double A = num;
                }
                else if (num < 0)
                {
                    Console.WriteLine($"\nO numero digitado é negativo, você inseriu o numero {num}");
                    double B = num;
                }
                else
                {
                    Console.WriteLine($"\nO numero digitado foi 0.{num} ");
                }
            }

        }
    }
}