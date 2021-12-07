using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassePessoas[] matriz = new ClassePessoas[10];
            int pos = 0;
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nO que você deseja fazer? " +
                    "\n [1] - Inserir um nome" +
                    "\n [2] - Listar todos os nomes e alturas");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        if(count < 10)
                        {
                            Console.Write("\nInsira o nome: ");
                            string nome = Console.ReadLine();

                            Console.Write("\n Insira a data de nascimento, no formato DD/MM/AAAA ");
                            string nasc = Console.ReadLine();

                            Console.Write("\nInsira a altura em centimetros ");
                            float altura = float.Parse(Console.ReadLine());

                            ClassePessoas pessoa = new ClassePessoas(nome, altura, nasc);

                            matriz[pos] = pessoa;
                            pos++;

                            count++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nLamento, você ja inseriu o maximo de dados possiveis");
                            break;
                        }

                    case 2:
                        for(int aux = 0; aux < count; aux++)
                        {
                            Console.WriteLine($" \n {matriz[aux].GetNome()}, {matriz[aux].GetAltura():0}cm ");
                        }
                        break;
                }
            }
        }
    }
}
