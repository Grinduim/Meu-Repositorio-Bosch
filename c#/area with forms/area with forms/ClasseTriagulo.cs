using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_with_forms
{
    class ClasseTriangulo
    {
        private double Altura;
        private double Largura;

        public ClasseTriangulo(double altura, double largura)
        {
            if (altura > 0 && largura > 0)
            {
                this.Altura = altura;
                this.Largura = largura;
            }
            else
            {
                this.Altura = 1;
                this.Largura = 1;
            }
        }

        public void GetDadosTriangulo()
        {
            Console.WriteLine($"O Triangulo tem {Altura}cm de altura e {Largura}cm de largura");
        }

        public double AreaTriangulo()
        {
            double aux = (Altura * Largura) / 2;
            return aux;
        }
    }

}