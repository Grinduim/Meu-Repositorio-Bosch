using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClasseAluno
    {
        string nome;
        string matricula;
        string curso;
        int periodo;
        int idade;
        Disciplinasmat NomeDisciplina;

        public ClasseAluno(string nome, string matricula, string curso, int periodo, int idade, Disciplinasmat NomeDisciplina)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.periodo = periodo;
            this.idade = idade;
            this.NomeDisciplina = NomeDisciplina;

        }

        public void Dados()
        {
            Console.Write($"\n {nome}, idade {idade}, matricula: {matricula}, curso {curso}, periodo {periodo},\ndisciplina {NomeDisciplina.GetNomeDisciplina()}, horaio {NomeDisciplina.GetHorario()}," +
                $"\ncredito: {NomeDisciplina.GetCredito()}");
            
            
        }
    }
}
