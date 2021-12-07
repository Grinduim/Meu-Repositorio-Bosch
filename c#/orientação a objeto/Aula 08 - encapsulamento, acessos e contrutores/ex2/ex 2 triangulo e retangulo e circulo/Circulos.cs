using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_triangulo_e_retangulo_e_circulo
{
    class Circulos
    {
        private double raio;

        public Circulos(double raio)
        {
            if( raio > 0)
            {
                this.raio = raio;
            }
            else
            {
                this.raio = 1;
            }
        }

        public void DadosCirculo()
        {
            Console.WriteLine($" Essa Circunferencia tem {raio:0.000}cm de raio");
        }

        public double AreaCirculo()
        {
            double pi = Math.PI;
            double area = pi * Math.Pow(raio, 2);
            return area;
        }
    }
}
