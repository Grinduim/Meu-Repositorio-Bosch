using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inisira o nome do arquivo codificado");
            string codificado = Console.ReadLine();
            codificado.ToUpper();
            string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVXYZ0123456789";
            List<char> decodificado = new List<char>();
            int count = 0;
            for(int aux =0; aux <codificado.Length; aux++)
            {
                for(int aux2 = 0; aux2 < Alphabet.Length; aux2++)
                {
                    if (Alphabet[aux2] == codificado[aux])
                    {
                        decodificado.Add(Alphabet[aux2]);
                        count = count + 1;
                        break;
                        
                    }
                    else
                    {
                        if (aux2 == 34)
                        {
                            count = 0;
                        }
                        continue;
                    }

                }
            }
            int posição = decodificado.Count() - count ;
            decodificado.Insert(posição, '.');

            Console.WriteLine("\n A palabra decodificada ficou da seguinte maneira:\n");
            for (int aux = 0; aux < decodificado.Count(); aux++)
            {
                Console.Write(decodificado[aux]);
            }
            
        }
    }
}
