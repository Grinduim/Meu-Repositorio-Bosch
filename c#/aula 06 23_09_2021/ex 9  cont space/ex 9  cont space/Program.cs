using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9__cont_space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a palavra");
            string palavra = Console.ReadLine();
            Console.WriteLine(ContSpace(palavra));
        }

        static int ContSpace(string frase)
        {
            int cont = 0;
            for(int aux =0; aux < frase.Length; aux++)
            {
                if(frase[aux] == ' ')
                {
                    cont++;
                }

            }
            return cont;
        }
    }
}
