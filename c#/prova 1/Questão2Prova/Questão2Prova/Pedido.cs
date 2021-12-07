using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Prova
{
    class Pedido
    {
        string NomeCliente;
        List<ItemDePedido> ListaItens = new List<ItemDePedido>();


        public Pedido()
        {

        }
        public Pedido(string nome, List<ItemDePedido> ListaItens)
        {
            this.NomeCliente = nome;
            this.ListaItens = ListaItens;
        }

        public Pedido(string nome)
        {
            this.NomeCliente = nome;
            
        }

        public string GetNome()
        {
            return NomeCliente;
        }

        public List<ItemDePedido> GetListaItens()
        {
            return ListaItens;
        }

        public void AcrescentarItem(ItemDePedido Itens)
        {
            ListaItens.Add(Itens);
        }

        public decimal GetTotal()
        {
            decimal Total = 0;
            for(int aux = 0; aux < ListaItens.Count(); aux++)
            {
                Total = Total + (ListaItens[aux].Getpreço() * ListaItens[aux].GetQuantidade());
            }
            return Total;
        }


        public void ImprimePedidos()
        {
            Console.WriteLine($"\n -----------------------------------" +
                $"\nNome do Cliente: {GetNome()}" +
                $"\nTotal do Pedido:R${GetTotal():0.00}" +
                $"\nItem | Preço");
            for(int aux = 0; aux < ListaItens.Count; aux++)
            {
                Console.WriteLine($"{ListaItens[aux].GetItem()} | R${ListaItens[aux].Getpreço()} ");
            }
            Console.WriteLine($"\n -----------------------------------");


        }
    }
}
