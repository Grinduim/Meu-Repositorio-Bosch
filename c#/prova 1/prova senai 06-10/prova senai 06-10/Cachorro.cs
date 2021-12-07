using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_senai_06_10
{
    class Cachorro:Animal
    {
        string Som;
        int QtdPassos = 6;

        public Cachorro(string nome, int idade, string Som)
        {
            setNome(nome);
            setIdade(idade);
            this.Som = Som;
        }


         public override void EmitirSom()
        {
            Console.WriteLine($"\n {GetNome()} - {GetSom()} ");
        }

        public override void Andar()
        {
            Console.WriteLine($"\n O {GetNome()} deu {QtdPassos} passos");
        }

        public string GetSom()
        {
            return Som;
        }
    }
}
