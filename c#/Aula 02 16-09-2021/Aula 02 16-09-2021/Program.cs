using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// tipo[] NomeDaMAtriz;
//tipo[] NomeDaMAtriz = new int[]{1, 2, 3}
// int[] matriz = new[] - delimitou o tamanho da sting
// se matriz é uni dimencional porem pode ter mais de uma linha
// declaração 
// int [,] matriz = { {},{} }
//
// laço for(int i = 0 ; i <3, i ++)
//for(TIPO INICIALIZADOS; CONDIÇÃO; ITERADOR){}
// matriz.Length


namespace Aula_02_16_09_2021
{
    class Program
    {
        static void Main(string[] args)
        {

            // aula
            /*
            int[] matriz = { 10, 9, 24, 6 };
            for (int i = 0; i< matriz.Length; i++)
            {
                Console.WriteLine(matriz[i]);
            }*/

            // exercicio 1
            int[] matriz = new int[10];
            int maior = 0;
            int menor = 0;
            for (int aux = 0; aux < matriz.Length; aux++)
            {
                Console.WriteLine(" Insira o {0}º valor inteiro: ", (aux + 1));
                int num = int.Parse(Console.ReadLine());
                matriz[aux] = num;
                if (aux == 0)
                {
                    maior = num;
                    menor = num;
                }
                else if (aux > 0 && num > maior)
                {
                    maior = num;
                }
                else if (aux > 0 && num < menor)
                {
                    menor = num;
                }

            }
            Console.WriteLine(" o maior é {0} e menor é {1}", maior, menor);
        }
    }
}
