using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8
{
    class Program
    {
        public static string Reverter(string palavra)
        {
            char[] vetorChar = palavra.ToCharArray();
            Array.Reverse(vetorChar);
            string invertida = new String(vetorChar);
            return invertida;
        }

        static void Main(string[] args)
        {

            string palavra;
            Console.Write("Insira a quantidade de palavras que você quer inserir: ");
            int tam = int.Parse(Console.ReadLine());

            string[] vetor = new string[tam];

            for (int aux = 0; aux < tam; aux++)
            {
                Console.Write($"\n insira a {aux + 1}º palavra:");
                palavra = Console.ReadLine();
                palavra = palavra.ToUpper();
                vetor[aux] = palavra;
            }

            for (int aux2 = 0; aux2 < vetor.Length; aux2++)
            {

                string invertida = Reverter(vetor[aux2]);

                /*while (invertida.Contains(' '))
                {
                    int idx = invertida.IndexOf(' ');
                    invertida.Remove(idx);
                }

                while (vetor[aux2].Contains(' '))
                {
                    int idx = vetor[aux2].IndexOf(' ');
                    vetor[aux2].Remove(idx);
                }*/

                if (vetor[aux2] == invertida)
                {
                    Console.WriteLine($"\nA palavra '{vetor[aux2]}' é  um palindromo");
                }
                else
                {
                    Console.WriteLine($"\nA palavra '{vetor[aux2]}' não é  um palindromo");
                }
            }
        }
    }
}
