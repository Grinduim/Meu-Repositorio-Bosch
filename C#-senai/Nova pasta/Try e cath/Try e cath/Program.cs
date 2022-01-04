using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_e_cath
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insira o primeiro numero");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o segundo numero");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);

            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero não existe!");
            }
            catch(FormatException)
            {
               Console.WriteLine("Não é possivel fazer operação aritimética com letras");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);    
            }
                           
        }
    }
}
