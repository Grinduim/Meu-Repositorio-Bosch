using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_11_func_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a Data no formato DD/MM/AAAA");
            string data = Console.ReadLine();
            string[] valores = data.Split('/');

            Console.WriteLine(valores);
            validarData(valores[0], valores[1], valores[2]);
        }

        static void validarData(string DD,string  MM,string AAAA)
        {
            int m = int.Parse(MM);
            int dia = int.Parse(DD);
            int ano = int.Parse(AAAA);
            string[] matriz = { "janeiro", "fevereiro", "março", "abril", "maio",
                "junho", "julho", "agosto", "setembro", "outrubro", "novembro", "Dezembro" };
            string mes = matriz[m - 1];
            if(dia <32 && dia > 0)
            {
                Console.WriteLine($"{dia} de {mes} de {ano}");
            }
            else
            {
                Console.WriteLine("data Invalida");
            }
            
        }
    }
}
