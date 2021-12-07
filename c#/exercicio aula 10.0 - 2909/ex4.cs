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


            Console.WriteLine("Bem Vindo ao Vetorzes 3300");
            int tam;
            int count = 0;
            while (true)
            {
                Console.WriteLine("\n Qual o tamanho dos vetores ? o tamanho maximo permitido é 50");
                tam = int.Parse(Console.ReadLine());

                if( tam >0 && tam < 51)
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
            double[] V2 = new double[tam];
            // vetor 2

            for(int aux = 0; aux <tam; aux++)
            {
                Console.WriteLine($"\nInsira o {aux + 1}º valor do primeiro vetor");
                V1[aux] = double.Parse(Console.ReadLine());

                Console.WriteLine($"\nInsira o {aux + 1}º valor do segundo vetor");
                V2[aux] = double.Parse(Console.ReadLine());
            }

            for(int aux = 0; aux<tam; aux++)
            {
                if (V1[aux] == V2[aux])
                {
                    count++;
                    continue;
                }
            }

            if(count > 0)
            {
                Console.WriteLine($"\n Os dois vetores possuem o mesmo valor na mesma posição {count} vezes");
            }
            else
            {
                Console.WriteLine($"\n  Nenhum valor se repitiu na mesma posição");
            }
           

            Console.WriteLine("\n");






        }
    }
}