using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Prova
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Pedido> Clientes = new List<Pedido>();

            while (true)
            {
                Console.WriteLine("\n ------ MENU ------" +
                    "\n[1] - Incluir Cliente" +
                    "\n[2] - Listar Clientes" +
                    "\n[3] - Incluir Item na compra de Cliente" +
                    "\n[4] - Listar Pedidos de cliente.");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("\nNome:");
                        string nome = Console.ReadLine();
                        Pedido cliente = new Pedido(nome);
                        Clientes.Add(cliente);
                        Console.WriteLine("Cliente Adicionado com sucesso");
                        Task.Delay(2200).Wait();
                        Console.Clear();
                        break;

                    case 2:
                        if(Clientes.Count > 0)
                        {
                            Console.WriteLine($"\n---Temos os seguintes clientes cadastrados---");
                            for (int aux = 0; aux < Clientes.Count; aux++)
                            {
                                Console.WriteLine($"\n{aux + 1}º {Clientes[aux].GetNome()}");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A lista de clientes ainda está vazia");
                            break;
                        }

                    case 3:
                        Console.WriteLine($"\n---Temos os seguintes clientes cadastrados---");
                        for (int aux = 0; aux < Clientes.Count; aux++)
                        {
                            Console.WriteLine($"\n{aux + 1}º {Clientes[aux].GetNome()}");
                        }
                        Console.WriteLine("\nEm qual deles você quer inserir incluir um pedido ? Digite a posição");
                        int posição = int.Parse(Console.ReadLine());
                        posição = posição - 1;

                        Console.Write("\nNome do item:");
                        string NomeItem = Console.ReadLine();
                        Console.Write("\nPreço:");
                        decimal preço = decimal.Parse(Console.ReadLine());
                        Console.Write("\nQuantidade:");
                        int Qtd = int.Parse(Console.ReadLine());

                        ItemDePedido item = new ItemDePedido();
                        item.SetItem(NomeItem);
                        item.SetPreço(preço);
                        item.SetQuantidade(Qtd);
                        Clientes[posição].AcrescentarItem(item);

                        Console.WriteLine("\n Item adicionado com sucesso");
                        Console.WriteLine("Retornando ao menu");
                        Task.Delay(2200).Wait();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine($"\n---Temos os seguintes clientes cadastrados---");
                        for (int aux = 0; aux < Clientes.Count; aux++)
                        {
                            Console.WriteLine($"\n{aux + 1}º {Clientes[aux].GetNome()}");
                        }
                        Console.WriteLine("\nQual deles você quer visualizar a lista ? Digite a posição");
                        int listar = int.Parse(Console.ReadLine());
                        listar = listar - 1;

                        Clientes[listar].ImprimePedidos();
                        Console.WriteLine("Retornando ao menu");
                        break;
                }
            }
        }
    }
}
