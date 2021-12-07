using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_08___tc_2_tk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira a temp em celcius");
            int tc = int.Parse(Console.ReadLine());
            Console.WriteLine(tctk(tc));
        }


        static int tctk(int tc)
        {
            int tk = tc + 273;
            return tk;
        }
    
    }
}
