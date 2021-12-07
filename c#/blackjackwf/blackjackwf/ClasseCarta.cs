using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjackwf
{
    class ClasseCarta
    {
        string carta;
        string naipe;

        public ClasseCarta(string carta, string naipe)
        {
            this.carta = carta;
            this.naipe = naipe;
        }

        public void GetDados()
        {
            Console.WriteLine(carta);
            Console.WriteLine(naipe);
        }

        public string GetCarta()
        {
            return carta;
        }
    }
}


