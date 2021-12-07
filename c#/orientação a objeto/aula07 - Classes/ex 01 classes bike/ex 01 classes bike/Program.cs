using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01_classes_bike
{
    class Bicicleta
    {
        public int velocidade = 1;
        public int marcha = 1;

        public void MudarMarcha(int novaMarcha)
        {
            marcha = novaMarcha;
        }

        public void AumentarVelocidade(int incremento)
        {
            velocidade += incremento;
        }
        public void Reset()
        {
            velocidade = 1;
            marcha = 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bikeDoVinicius = new Bicicleta();
            Bicicleta bikeDoLuis = new Bicicleta();
            Bicicleta bikeDoAlgeu = new Bicicleta();

            bikeDoVinicius.AumentarVelocidade(6);
            bikeDoLuis.AumentarVelocidade(7);
            bikeDoAlgeu.AumentarVelocidade(26);

            Console.WriteLine(bikeDoAlgeu.velocidade);

            bikeDoAlgeu.MudarMarcha(5);
            bikeDoVinicius.MudarMarcha(2);
            bikeDoLuis.MudarMarcha(3);

            Console.WriteLine(bikeDoLuis.marcha);

            bikeDoVinicius.Reset();
            Console.WriteLine(bikeDoVinicius.marcha);
            Console.WriteLine(bikeDoVinicius.velocidade);

        }
    }

    
}
