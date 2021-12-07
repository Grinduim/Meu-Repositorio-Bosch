using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06_vogais_função
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira uma palavra");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();

            int x = vogais(palavra);
            Console.WriteLine("Se tem {0} vogais nessa  palavra",x);

        }
        static int vogais(string palavra)
        {
            int ax = 0;

            for( int aux = 0; aux < palavra.Length; aux ++)
            {

                
                if (palavra[aux] == 'a' || palavra[aux] == 'e' || palavra[aux] == 'i' || palavra[aux] == 'o' ||
                    palavra[aux] == 'u')
                {
                    ax++;
                }
            }
            return ax;
        }
    }
}
