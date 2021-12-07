using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1 = 0;
            int vitoria = 0;
            int num = 0;

            while (w1 == 0)
            {
                do
                {
                    Console.WriteLine($"\nInsira um numero:");
                    num = int.Parse(Console.ReadLine());
                    if (num > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" numero invalido tente novamente");
                        continue;
                    }
                } while (true);


                Console.WriteLine("Você quer impar ou par ? ");
                string opc = Console.ReadLine();
                opc = opc.ToUpper();

                Random rnd = new Random();
                int robo = rnd.Next(1, 3);
                Console.WriteLine(robo); // apenas para registras a joga do pc. 

                int sum = num + robo;
                if ((sum) % 2 == 0)
                {
                    if (opc == "PAR")
                    {
                        Console.WriteLine("Você ganhou ! ");
                        vitoria++;
                        continue;
                    }
                    else if (opc == "IMPAR")
                    {
                        Console.WriteLine("Você perdeu! ");
                        Console.WriteLine("Você ganhou {0} vezes", vitoria);
                        break;
                    }
                }
                else if (sum % 2 != 0)
                {
                    if (opc == "IMPAR")
                    {
                        Console.WriteLine("Você ganhou ! ");
                        vitoria++;
                        continue;
                    }
                    else if (opc == "PAR")
                    {
                        Console.WriteLine("Você perdeu! ");
                        Console.WriteLine("Você ganhou {0} vezes", vitoria);
                        break;
                    }

                }
            }
        }
    }
}
