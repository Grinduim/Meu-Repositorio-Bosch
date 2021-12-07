using System;
/*namespace tifaenf2123
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

// aula
/*namespace tifaenf2123
 
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lindo");
            //string nome = Console.ReadLine();
            //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            //Console.WriteLine("Bem vindo " + nome);
            //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");

            //int a = 15;
            //int b = 7;
            //Console.WriteLine("Aula " + (a + b));

            //string oi = null ;
            //Console.WriteLine(oi);


        }
    }
}*/

//Exercicio 01 - soma comuns

/*namespace tifaenf2123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Insira o numero a : ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Insira o numero b : ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(" A soma entre {0} e {1} é igual a {2}", a, b, (a + b));
            Console.WriteLine("A Subtração entre {0} e {1} é igual a {2}", a, b, (a-b));
            Console.WriteLine(" A multiplicação entre {0} e {1} é igual a {2}", a, b, (a * b));
            Console.WriteLine(" a Divisão é entre {0} e {1} é igual a  {2}", a, b, (a / b));
        }
    }
}*/

// exercicio o2 
/*namespace tifaenf2123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a quantidade de Km percorridos ");
            decimal km = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" Insira a quantidade de combustivel gasto ");
            decimal combus = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" Você teve um consumo médio de {0:0.00} km/litro", 
                decimal.Round((km / combus),2));
        }
    }
}*/

//Exercicio 2
namespace tifaenf2123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira a primeira nota ");
            decimal n1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" Segunda nota: ");
            decimal n2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Terceira nota: ");
            decimal n3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine(" O {0} teve a média de {1:0.00}", nome, (n1 + n2 + n3) / 3);

        }
    }
}
