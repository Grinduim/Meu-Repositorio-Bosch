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

                Console.WriteLine("\nO que você deseja verificar ? " +
                    "\n 1 - para verificar se um dos numeros é multiplo do outro" +
                    "\n 2 - para verificar se os dois numeros são pares" +
                    "\n 3 - para verificar se a média é maior ou igual a 7" +
                    "\n 4 - para sair ");
                int Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        if (num1 % num2 == 0)
                        {
                            Console.WriteLine($"\nO {num1} é multiplo de  {num2}");
                            break;
                        }
                        else if( num2 % num1 == 0)
                        {
                            Console.WriteLine($"\nO {num2} é multiplo de  {num1}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n{num1} e {num2} não são multiplos");
                            break;
                        }

                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("\nAmbos os numeros são pares");
                            break;
                        }
                        else if (num1 % 2 == 0)
                        {
                            Console.WriteLine($"\nApenas o {num1} é par");
                            break;
                        }
                        else if (num2 % 2 == 0)
                        {
                            Console.WriteLine($"\nApenas o {num2} é impar");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nNenhum dos numeros inseridos são pares");
                            break;
                        }

                    case 3:
                        int média = (num1 + num2) / 2;
                        if(média >= 7)
                        {
                            Console.WriteLine($"\nA média dos dois numeros é maior que 7, a média é:{média}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\n A média inserida é menor que 7, a média é:{média}");
                            break;
                        }

                    case 4:
                        w1 = false;
                        Console.WriteLine("\nEncerrando programa....");
                        break;

                    default:
                        Console.WriteLine("\nO numero inserido é invalido, por favor tente novamente");
                        break;

                }





            }


        }
    }
}