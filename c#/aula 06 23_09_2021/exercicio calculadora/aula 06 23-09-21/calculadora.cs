using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_06_23_09_21
{
    class calculadora
    {
        static void Main(string[] args)
        {
            // exercicio calculadora 
            while (true)
            {
                Console.WriteLine("Insira um valor");
                float n1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Insira outro valor");
                float n2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Escolhar 1 operação" +
                    "\n -" +
                    "\n +" +
                    "\n *" +
                    "\n /");
                string aws = Console.ReadLine();

                float x;

                switch (aws)
                {
                    case "-":
                        x = Subtração(n1, n2);

                        break;

                    case "+":
                        x = Soma(n1, n2);
                        break;

                    case "*":
                        x = Multi(n1, n2);
                        break;

                    case "/":
                        x = Divisao(n1, n2);
                        break;
                }
            }

            
        }

        static float Soma(float x, float y)
        {
            float soma = x + y;
            Console.WriteLine($"A soma entre {x} e {y} é {soma}");
            return soma;
        }

        static float Subtração(float x, float y)
        {
            float sub = x - y;
            Console.WriteLine($"A subtração entre {x} e {y} é {sub}");
            return sub;
        }

        static float Multi (float x, float y)
        {
            float multi = x * y;
            Console.WriteLine($"A multriplicação entre {x} e {y} é {multi}");
            return multi;
        }

        static float Divisao (float x, float y)
        {
            float diviz = x / y;
            Console.WriteLine($"A divisão entre {x} e {y} é {diviz}");
            return diviz;
        }
    }

}
