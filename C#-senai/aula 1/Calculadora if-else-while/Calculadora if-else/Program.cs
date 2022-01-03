using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calculadora_if_else
{
    class Program
    {

        public static  void operacoes(int num1, int num2, string opc)
        {
            if (opc == "+")
            {
                Console.WriteLine($"\n{num1} + {num2} = {num1 + num2}");

            }
            else if(opc == "-")
            {
                Console.WriteLine($"\n{num1} - {num2} = {num1- num2}");

            }
            else if (opc == "/")
            {
                float res = (float)num1 / (float)num2;
                Console.WriteLine($"\n{num1} / {num2} = { res}");
            }
            else if (opc == "*")
            {
                Console.WriteLine($"\n{num1} * {num2} = {num1 * num2}");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel indentificar a operação");
            }
        }


        static void Main(string[] args)
        {

            //Escreva um programa que pergunte ao usuario dois numeros e a operação que ele deseja fazer.

            int num1;
            int num2;
            string operacao;
            int cond = 1;

            while (cond != 0) {
                Console.WriteLine("\nInsira o primeiro numero ");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInsira o segundo numero ");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nQual operação deseja fazer ? + - * /");
                operacao = Console.ReadLine();

                operacoes(num1, num2, operacao);

                Console.WriteLine("\nDeseja continuar ? se sim, insira qualquer numero, se não insira 0");
                cond = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
