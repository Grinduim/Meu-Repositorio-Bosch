using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05_raiz_com_func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Insira o valor da raiz cubida que deseja");
            double valor = double.Parse(Console.ReadLine());
            double func = raiz3(valor);
            Console.WriteLine($"{func:0.0000}");
        }

        static double raiz3(double val)
        {
            double raiz = Math.Pow(val, 1d / 3d);

            return raiz;
        }
    }
}
