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
            int tam = 0;
            //  determina tamanho do vetor
            while (true)
            {
                Console.WriteLine("\n Qual o tamanho dos vetores ? o tamanho maximo permitido é 50");
                tam = int.Parse(Console.ReadLine());

                if (tam > 0 && tam < 51)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n O numero inserido em relação ao tamanho do vetor é invalido, por favor tente novamente.");
                    continue;
                }

            }

            double[] V1 = new double[tam];
            // vetor 1

            // preencher vetor
            for (int aux = 0; aux < tam; aux++)
            {
                Console.WriteLine($"\nInsira o {aux + 1}º valor do primeiro vetor");
                V1[aux] = double.Parse(Console.ReadLine());

            }

            bool w2 = true;

            while(w2 == true)
            {

                Console.WriteLine("\n1 - Listar Vetor" +
"\n2 - Exibir apenas os números pares do vetor" +
"\n3 - Exibir apenas os números ímpares do vetor" +
"\n4 - Exibir a quantidade de números pares existem nas posições ímpares do vetor" +
"\n5 - Exibir a quantidade de números ímpares existem nas posições pares do vetor" +
"\n6 - Sair");
                int Op = int.Parse(Console.ReadLine());

                switch (Op)
                {

                    case 1:
                        Console.WriteLine("\n");
                        for (int aux = 0; aux < V1.Length; aux++)
                        {
                            
                            Console.WriteLine($"{V1[aux]}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n");
                        for (int aux = 0; aux < V1.Length; aux++)
                        {
                            if (V1[aux] % 2 == 0)
                            {
                                
                                Console.WriteLine($"{V1[aux]}");
                            }

                        }
                        break;
                    case 3:
                        Console.WriteLine("\n");
                        for (int aux = 0; aux < V1.Length; aux++)
                        {
                            if (V1[aux] % 2 != 0)
                            {
                                
                                Console.WriteLine($"{V1[aux]}");
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n");
                        for (int aux = 0; aux < V1.Length; aux++)
                        {
                            if (aux % 2 == 0)
                            {
                                if (V1[aux] % 2 == 0)
                                {
                                    
                                    Console.WriteLine($"{V1[aux]}");
                                }
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n");
                        for (int aux = 0; aux < V1.Length; aux++)
                        {
                            if (aux % 2 != 0)
                            {
                                if (V1[aux] % 2 != 0)
                                {
                                   
                                    Console.WriteLine($"{V1[aux]}");
                                }
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("\n");
                        Console.WriteLine("\n Encerrando problema");
                        Console.WriteLine("\n");
                        w2 = false;
                        break;
                }
            }

            
        }


    }
}