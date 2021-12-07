using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_senai_06_10
{
    abstract class Animal
    {
        string nome;
        int idade;

        public Animal()
        {

        }

        abstract public void EmitirSom();

        abstract public void Andar();

        public string GetNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }
}
