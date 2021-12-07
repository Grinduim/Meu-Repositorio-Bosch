using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<NovaPergunta> lista = new List<NovaPergunta>();

            NovaPergunta p1 = new NovaPergunta("Qual a cor do mar ?", "azul", "É a mesma que a do ceu.");
            NovaPergunta p2 = new NovaPergunta("Qual a cor da laranja ?", "laranja", "A resposta está na pergunta");
            NovaPergunta p3 = new NovaPergunta("Qual a cor do sol ? ", "amarelo", "É parecido com a cor da girafa");

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);

            Random rnd = new Random();
            int num = rnd.Next(0, 3);

            string pergunta = lista[num].GetP();
            string resposta = lista[num].GetR();
            string dica = lista[num].GetDica();

            Console.WriteLine(pergunta);
            string aws = Console.ReadLine();
            aws = aws.ToLower();

            if(aws == resposta)
            {
                Console.WriteLine("\nParabens você acertou!");
            }
            else
            {
                Console.WriteLine("\nAqui vai uma dica em... Tente novamente");
                Console.WriteLine(dica);
                aws = Console.ReadLine();
                if (aws == resposta)
                {
                    Console.WriteLine("\nParabens você acertou!");
                }
                else
                {
                    Console.WriteLine("\nAaahhh, Infelizmente você errou :/ ");
                }
            }
        }
    }
}
