using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q6_prova
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseTriangulo meuRetangulo = new ClasseTriangulo();
            meuRetangulo.altura = 40;
            meuRetangulo.largura = 20;
            Console.WriteLine("A area é: {0}", meuRetangulo.Area());
        }
    }
}
