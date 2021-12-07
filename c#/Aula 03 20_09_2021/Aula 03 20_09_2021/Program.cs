using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03_20_09_2021
{
    class Program
    {
        static void Main(string[] args)
         
        {
            // Laços While
            // while (n < 5);{
            //pode se usar com mais de 2 argumento 
            // }

            // exercicio 2

            {
                /*int a = 0;
                int soma = 0;
                int ante = 0;
                while (a < 1)
                {
                    Console.WriteLine("insira um valor inteiro: ");
                    int nume = int.Parse(Console.ReadLine());
                    soma += nume;
                    if (ante == nume)
                    {
                        Console.WriteLine(" O programa chegou ao fim ");
                        Console.WriteLine(" A soma dos valores digitados é {0}", soma);
                        a += 1;
                    }
                    else
                    {
                        ante = nume;
                    }
                }*/
            }


            // Exercicio 3
            {
/*Console.WriteLine("Quantos calculos você realizará? ");
                int tam = int.Parse(Console.ReadLine());
                float[] resultados = new float[tam];
                int i = 0;
                while (i < tam)
                {
                    Console.WriteLine(" Insira o primeiro numero :");
                    float num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo numero:");
                    float num2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Selecione uma das opçãoes abaixo" +
                        "\n / para divisão" +
                        "\n * para multiplicação" +
                        "\n+ para soma" +
                        "\n-  subtração");
                    string opc = Console.ReadLine();
                    float result = 0;

                    if (opc == "/")
                    {
                        result = num1 / num2;
                    }
                    else if (opc == "*")
                    {
                        result = num1 * num2;
                    }
                    else if (opc == "+")
                    {
                        result = num1 + num2;
                    }
                    else if (opc == "-")
                    {
                        result = num1 - num2;
                    }
                    resultados[i] = result;
                    i++;
                }
                for (int aux = 0; aux < tam ; aux++)
                {
                    Console.WriteLine("{0}",resultados[aux]);
                }*/
            }
            // Exercicio 4
         
            {
              /*  Console.WriteLine("Quantos numeros você quer inserir ? ");
                int tam = int.Parse(Console.ReadLine());
                int aux = 1;
                int neg = 0;
                int posi = 0;
                while (aux <= tam)
                {
                    Console.WriteLine(" insira o numero ");
                    int num = int.Parse(Console.ReadLine());

                    if (num < 0)
                    {
                        neg++;
                    }
                    else if( num > 0)
                    {
                        posi++;
                    }
                    aux++;
                }
                Console.WriteLine("Você digitou {0} e deles {1} são positivos e {2} negativos",tam,posi,neg);*/
            }

            //Exercicio 5
            { 
                int[] senhas = { 1224, 1569, 1589, 8476, 7856 };
                int b = 0;
                bool correta = false;

                while (true)
                {
                    Console.WriteLine("Insira a sua senha: ");
                    int s2 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < senhas.Length; i++)
                    {
                        if (s2 == senhas[i])
                        {
                            Console.WriteLine("Bem vindo!");
                            correta = true;
                        }
                    }

                    if ( correta == false)
                    {
                        Console.WriteLine("Senha Incorreta, por favor tente novamente");
                    }
                    else
                    {
                        Console.WriteLine("Encerrando programa...");
                        break;
                    }
                }
                
            }

            //Exercicio 6
            {
                Console.WriteLine("Insira um numero para fatorar");
                int num = int.Parse(Console.ReadLine());
                int result = num;

                if(num != 0)
                {
                    for (int i = 1; i < num; i++)
                    {
                        result *= i;

                    }
                    Console.WriteLine("O resultado é ......\n ...{0}...", result);
                }
                else
                {
                    Console.WriteLine("O resultado é ......\n ...1...");
                }

                

            }

        }
    }
}
