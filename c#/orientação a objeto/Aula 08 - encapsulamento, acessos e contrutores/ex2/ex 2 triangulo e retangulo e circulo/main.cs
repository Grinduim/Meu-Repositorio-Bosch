using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_triangulo_e_retangulo_e_circulo
{
    class Program
    {


    }

    class usaformas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos valores você quer inseir ? ");
            int qtd = int.Parse(Console.ReadLine());

            double[] lista = new double[qtd];
            string[] lista2 = new string[qtd];

            int x = 0;

            for (x = 0; x < qtd; x++)
            {
                bool w1 = true;
                while (w1)
                {
                    Console.WriteLine("\nQual forma você deseja inserir ? " +
                    "\n 1 - para circulos" +
                    "\n 2 - para retangulos" +
                    "\n 3 - para triangulos");
                    int forma = int.Parse(Console.ReadLine());
                    if (forma > 0 && forma < 4)
                    {
                        w1 = false;
                    }
                    else
                    {
                        Console.WriteLine("\nvalor Errado digite novamente");
                    }

                    if( forma == 1)
                    {
                        Console.WriteLine("\nInsira o raio da circunferencia");
                        double raio = double.Parse(Console.ReadLine());
                        Circulos circ = new Circulos(raio);
                        lista[x] = circ.AreaCirculo();
                        lista2[x] = "Circulo";
                    }
                    else if( forma == 2)
                    {
                        Console.WriteLine("\nInsira a altura do retangulo");
                        double altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nInsira a largura do retangulo");
                        double largura = double.Parse(Console.ReadLine());

                        retangulo ret = new retangulo(altura, largura);

                        Console.WriteLine("\nVocê quer area ou perimetro ? \n 1 para area \n 2 para perimetro");
                        int aux2 = int.Parse(Console.ReadLine());
                        if (aux2 == 1)
                        {
                            lista[x]=ret.PerimetroRetangulo();
                            lista2[x] = "Retangulo Perimetro";
                        }
                        else
                        {
                            lista[x] = ret.AreaRetangulo();
                            lista2[x] = "Retangulo area";
                        }
                        
                    }

                    else
                    {
                        Console.WriteLine("Insira a altura do triangulo");
                        double altura = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insira a largura do triangulo");
                        double largura = double.Parse(Console.ReadLine());

                        Triangulo tri = new Triangulo(altura, largura);
                        lista[x] = tri.AreaTriangulo();
                        lista2[x] = "Triangulo";

                        
                    }
                }
            }

            for(int cont = 0; cont < qtd; cont++)
            {
                Console.WriteLine($"\n O {cont + 1}º valor  foi {lista2[cont]} e tem o valor de {lista[cont]:0.000}cm ");
            }
            Console.WriteLine("\n");
        }
    }
}
       