using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a palavra ");
            string palavra = Console.ReadLine();
            palavra = palavra.ToLower();
            int x = ContConsoante(palavra);
            Console.WriteLine(x);
        }
        static int ContConsoante(string palavra)
        {
            string consoante = "aeiou";
            int cont = palavra.Length;
            for (int aux = 0; aux < palavra.Length; aux++)
            {
                for ( int aux2 = 0; aux2< consoante.Length; aux2++)
                {
                    if( palavra[aux] != consoante[aux2])
                    {
                        
                    }
                    else
                    {
                        cont--;
                    }
                }
            }
            return cont;
        }
    }
}
