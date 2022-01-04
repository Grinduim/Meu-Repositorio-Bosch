using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> quarto = new List<int>();
            List<string> entrada = new List<string>();
            List<string> saida = new List<string>();

            try
            {
                DateTime DataAtual = DateTime.Now; // data atual
                int TempQuarto; // Variaveis temporarias para auxiliarem na validação de itens
                DateTime TempEntrada;
                DateTime TempSaida;

                Console.WriteLine("\nInsira o numero do quarto: ");
                TempQuarto = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Qual da Data de entrada ? Formato yyyy/MM/ddd ");
                TempEntrada = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("\n Qual a data de saida ? Formato yyyy/MM/ddd ");
                TempSaida = DateTime.Parse(Console.ReadLine());


                if (TempEntrada > DataAtual && TempSaida > TempEntrada)
                {
                    Console.WriteLine("Validous");
                }

                // continuar a parte de validação das datas
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e}");
            }


            /*Console.WriteLine(DataAtual.ToString("dd/MM/yyyy"));
            DateTime teste = DateTime.Parse("2009-05-08"); //  string to data 
            Console.WriteLine(teste.ToString("dd/MM/yyyy"));

            if(DataAtual < teste) // validação de datas 
            {
                Console.WriteLine("teste1");
            }*/



        }
    }
}

