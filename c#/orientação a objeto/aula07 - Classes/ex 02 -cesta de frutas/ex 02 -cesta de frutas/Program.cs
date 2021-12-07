using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02__cesta_de_frutas
{

    class CestaDeFruta
    {
        public int uva = 0;
        public int chocolate = 0;
        public int maça = 0;

        public void QtdMaca(int quantidade)
        {
            maça = quantidade;
        }

        public void QtdUva(int quantidade)
        {
            uva = quantidade;
        }

        public void QtdChoco(int quantidade)
        {
            chocolate = quantidade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CestaDeFruta Cesta1 = new CestaDeFruta();
            CestaDeFruta Cesta2 = new CestaDeFruta();
            // criei duas instancias

            Cesta1.QtdChoco(6);
            Cesta1.QtdUva(200);
            Cesta1.QtdMaca(3);
            // formei a cesta 1 com os elesments que desejei

            Cesta2.QtdChoco(3);
            Cesta2.QtdMaca(6);
            Cesta2.QtdUva(76);
            // formatei a cesta 2

            Console.WriteLine($"A Cesta 1 tem {Cesta1.chocolate} chocolates, {Cesta1.uva} uvas" +
                $" e {Cesta1.maça} maças");

        }
    }
}
