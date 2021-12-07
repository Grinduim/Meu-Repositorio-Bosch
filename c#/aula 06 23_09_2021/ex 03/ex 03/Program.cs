using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o primeiro numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("insira o segundo numero");
            int n2 = int.Parse(Console.ReadLine());
            int x;
            x = condicaozao(n1, n2);
            Console.WriteLine(x);


         
        }

        static int condicaozao(int n1,int  n2)
        {
            if (n1 > n2)
            {
                return 1;
            }
            else if (n1 < n2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
            }
        }
    }

