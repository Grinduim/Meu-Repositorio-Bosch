using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão2Prova
{
    class ItemDePedido
    {
        string item;
        decimal preço;
        int Quantidade;

        public ItemDePedido()
        {

        }

        public ItemDePedido(string item, decimal preço, int quantidade)
        {
            
               if (item != "" && preço > 0 && quantidade > 0)
                {
                    SetItem(item);
                    SetPreço(preço);
                    SetQuantidade(quantidade);
                }
                else
                {
                    Console.WriteLine("\nValores invalidos");

                }
            
            
        }

        public string GetItem()
        {
            return item;
        }

        public void SetItem(string Item)
        {
            if(item != " ")
            {
                this.item = Item;
            }
            else
            {
                Console.WriteLine("\nItem invalido");

            }
        }



        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetQuantidade(int Quantidade)
        {
            if (Quantidade > 0)
            {
                this.Quantidade = Quantidade;
            }
            else
            {
                Console.WriteLine("\nValor invalido");
            }
        }

        public decimal Getpreço()
        {
            return preço;
        }

        public void SetPreço(decimal preço)
        {

            if (preço > 0)
            {
                this.preço = preço;
            }
            else
            {
                Console.WriteLine("\nValor invalido");
            }
        }

    }
}
