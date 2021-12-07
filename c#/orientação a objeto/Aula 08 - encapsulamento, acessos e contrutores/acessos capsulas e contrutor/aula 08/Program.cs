using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_08
{
    class Program
    {
        static void Main(string[] args)
        {


            Bicicleta bikeDoVini = new Bicicleta(21,3,"amaralho",27,"Aluminio");

            Console.WriteLine($" Velocidade : {bikeDoVini.GetVelocidade()}, marcha {bikeDoVini.GetMarcha()}," +
                $" tamanho: {bikeDoVini.GetTamanho()}, cor {bikeDoVini.GetCor()} e material: {bikeDoVini.GetMaterial()} ");

            Bicicleta bikeTeste = new Bicicleta(10, 3);
            Console.WriteLine(bikeTeste.GetMarcha());
            Console.WriteLine(bikeTeste.GetVelocidade());
        }
    }
    }

