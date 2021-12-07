using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace teste
{
    class Program
    {
        static int CondContinuar()
        {

            Console.WriteLine("\ndeseja continuar ? " +
                "\n[1] para sim" +
                "\n[2] para não");
            int op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }


        static void Main(string[] args)
        {
            TextInfo myTI = new CultureInfo("pt-BR", false).TextInfo; // função de TitleCase

            Console.WriteLine("\n nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\n idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\n matricula:");
            string matricula = Console.ReadLine();

            Console.WriteLine("\n curso: ");
            string curso = Console.ReadLine();

            Console.WriteLine("\n periodo:");
            int periodo = int.Parse(Console.ReadLine());

            Console.WriteLine("\n disciplina:");
            string disciplina = Console.ReadLine();

            Console.WriteLine("\n horario:");
            string horario = Console.ReadLine();

            Console.WriteLine("\n Creditos:");
            string creditos = Console.ReadLine();

            Disciplinasmat disciplinas = new Disciplinasmat(disciplina, horario, creditos);

            ClasseAluno alunotest = new ClasseAluno(nome,matricula,curso,periodo,idade,disciplinas);

            alunotest.Dados();

          
        }

    }
}