using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_triangulo_e_retangulo_e_circulo
{
    class Triangulo
    {
        private double Altura;
        private double Largura;

        public Triangulo(double altura , double largura)
        {
            if( altura >0 && largura > 0)
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
            double aux = (Altura * Largura)/2;
            return aux;
        }
    }

}
