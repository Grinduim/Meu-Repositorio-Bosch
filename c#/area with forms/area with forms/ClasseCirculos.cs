using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_with_forms
{
    class ClasseCirculos
    {
        private double raio;

        public ClasseCirculos(double raio)
        {
            if (raio > 0)
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