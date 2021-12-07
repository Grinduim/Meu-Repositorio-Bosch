using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_triangulo_e_retangulo_e_circulo
{
    class retangulo
    {
        double altura;
        double largura;

        public retangulo(double altura, double largura)
        {
            if( altura > 0 && largura > 0)
            {
                this.largura = largura;
                this.altura = altura;
            }
            else
            {
                this.largura = 1;
                this.altura = 1;
            }
        }

        public void DadosTriangulos()
        {
            Console.WriteLine($"O triangulo tem {altura}cm de altura e {altura}cm de altura");
        }

        public double AreaRetangulo()
        {
            double x = largura * altura;
            return x;
        }

        public double PerimetroRetangulo()
        {
            double aux = (altura*2)  + (largura*2);
            return aux;
        }
    }
}
