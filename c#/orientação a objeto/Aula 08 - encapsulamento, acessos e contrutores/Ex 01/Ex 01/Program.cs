using System;

namespace Ex_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a idade\n");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira o nome\n");
            string Nome = Console.ReadLine();

            Console.WriteLine("\nInsira o endereço\n");
            string endereço = Console.ReadLine();


            Pessoas PessoaTest = new Pessoas(idade, Nome, endereço);

            PessoaTest.FazAniversario();

            PessoaTest.ImprimaDados();

        }
    }
}
