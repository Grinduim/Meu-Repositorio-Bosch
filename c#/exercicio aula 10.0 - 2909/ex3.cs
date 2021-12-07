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
            Console.WriteLine("Bem vindo ao Verificador 3000");

            bool w1 = true;

            while (w1 == true)
            {
                Console.WriteLine("\ninsira o primeiro numero");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\ninsira o segundo numero");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nO que voc� deseja verificar ? " +
                    "\n 1 - para verificar se um dos numeros � multiplo do outro" +
                    "\n 2 - para verificar se os dois numeros s�o pares" +
                    "\n 3 - para verificar se a m�dia � maior ou igual a 7" +
                    "\n 4 - para sair ");
                int Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        if (num1 % num2 == 0)
                        {
                            Console.WriteLine($"\nO {num1} � multiplo de  {num2}");
                            break;
                        }
                        else if( num2 % num1 == 0)
                        {
                            Console.WriteLine($"\nO {num2} � multiplo de  {num1}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n{num1} e {num2} n�o s�o multiplos");
                            break;
                        }

                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("\nAmbos os numeros s�o pares");
                            break;
                        }
                        else if (num1 % 2 == 0)
                        {
                            Console.WriteLine($"\nApenas o {num1} � par");
                            break;
                        }
                        else if (num2 % 2 == 0)
                        {
                            Console.WriteLine($"\nApenas o {num2} � impar");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nNenhum dos numeros inseridos s�o pares");
                            break;
                        }

                    case 3:
                        int m�dia = (num1 + num2) / 2;
                        if(m�dia >= 7)
                        {
                            Console.WriteLine($"\nA m�dia dos dois numeros � maior que 7, a m�dia �:{m�dia}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n A m�dia inserida � menor que 7, a m�dia �:{m�dia}");
                            break;
                        }

                    case 4:
                        w1 = false;
                        Console.WriteLine("\nEncerrando programa....");
                        break;

                    default:
                        Console.WriteLine("\nO numero inserido � invalido, por favor tente novamente");
                        break;

                }





            }


        }
    }
}