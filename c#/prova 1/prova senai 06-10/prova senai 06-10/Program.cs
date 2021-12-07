using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_senai_06_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Macaco macaco = new Macaco("Barto", 4, "Uaaahaaaa");

            macaco.EmitirSom();
            macaco.Andar();

            Console.WriteLine("\n\n ------------------------------");

            Gato miau = new Gato("Miau", 2, " Miaaaauuu");
            miau.Andar();
            miau.EmitirSom();

            Console.WriteLine("\n\n ------------------------------");

            Cachorro preto = new Cachorro("Pretinho", 12, "AuAu");
            preto.Andar();
            preto.EmitirSom();
        }
    }
}
