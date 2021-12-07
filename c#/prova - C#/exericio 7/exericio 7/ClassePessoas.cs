using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exericio_7
{
    struct ClassePessoas
    {
        string nome;
        float altura;
        string Nasc;

        public ClassePessoas(string nome, float altura, string Nasc)
        {
            this.nome = nome;
            this.altura = altura;
            this.Nasc = Nasc;
        }


        public string GetNome()
        {
            return nome;
        }

        public string GetNac()
        {
            return Nasc;
        }


        public float GetAltura()
        {
            return altura;
        }
    }
}
