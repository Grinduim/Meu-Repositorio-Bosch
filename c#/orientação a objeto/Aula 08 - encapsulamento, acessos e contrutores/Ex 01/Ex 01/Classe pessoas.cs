using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_01
{
    class Pessoas
    {
       private int Idade;
       private string Nome;
       private string Endereço;

        
        public Pessoas(int idade, string nome, string endereço)
        {

            if( endereço != null && nome.Length>= 3 && idade > 0)
            {
                this.Endereço = endereço;
                this.Idade = idade;
                this.Nome = nome;
            }
            else
            {
                Console.WriteLine("não foi possivel inserir na lista");
            }
            
        }
        
        public int GetIdade()
        {
            return Idade;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetEndereço()
        {
            return Endereço;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade;
        }

        public void SetEndeço(string endereço)
        {
            this.Endereço = endereço;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public void ImprimaDados()
        {
            Console.WriteLine($"\nO {Nome} tem {Idade} anos e mora no endereço {Endereço}");
        }

        public void FazAniversario()
        {
            this.Idade++;
            Console.WriteLine($"Felicidade ao {Nome} agora ele tem {Idade} anos");
        }
      
    }
}
