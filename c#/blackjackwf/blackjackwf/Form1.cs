using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjackwf
{
    public partial class Form1 : Form
    {
        public static int Pontuação(string Carta)
        {
            int x;
            if (Carta == "Ás")
            {
                x = 1;
                return x;
            }
            else if (Carta == "Q" || Carta == "10" || Carta == "J" || Carta == "K")
            {
                x = 10;
                return x;
            }
            else
            {
                x = int.Parse(Carta);
                return x;
            }
        }
        public Form1()
        {
            InitializeComponent();
            Saldo saldo = new Saldo();
            saldo.setValor(500);
            label2.Text = $"Saldo: R${saldo.GetValor()}";
            BtnHit.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        public void BtnApostar_Click(object sender, EventArgs e)
        {
            float ValorAposta = float.Parse(TextAposta.Text);
            
            // gerar baralho
            
            


                List<string> CardJogador = new List<string>();

                List<string> CardMesa = new List<string>();

                List<string> Naipes = new List<string>();

                int x;

                List<ClasseCarta> ListaCartas = new List<ClasseCarta>();

                List<string> SemNaipe = new List<string>();
                // adiciona itens nas listas
                {
                    SemNaipe.Add("Ás");
                    SemNaipe.Add("2");
                    SemNaipe.Add("3");
                    SemNaipe.Add("4");
                    SemNaipe.Add("5");
                    SemNaipe.Add("6");
                    SemNaipe.Add("7");
                    SemNaipe.Add("8");
                    SemNaipe.Add("9");
                    SemNaipe.Add("10");
                    SemNaipe.Add("Q");
                    SemNaipe.Add("J");
                    SemNaipe.Add("K");


                    Naipes.Add("Ouro");
                    Naipes.Add("Espada");
                    Naipes.Add("Copa");
                    Naipes.Add("Paus");
                }

                // gera o bralho
                {
                    for (int aux = 0; aux < SemNaipe.Count; aux++)
                    {
                        for (int aux2 = 0; aux2 < Naipes.Count; aux2++)
                        {
                            ClasseCarta carta = new ClasseCarta(SemNaipe[aux], Naipes[aux2]);
                            ListaCartas.Add(carta);
                        }
                    }
                }
                Random rnd = new Random();
                int PntJogador = 0;
                int PntMesa = 0;
                int CartaJogador;
                int CartaMesa;

                for (int aux = 0; aux < 2; aux++)
                {
                    CartaJogador = rnd.Next(0, ListaCartas.Count());
                    CardJogador.Add(ListaCartas[CartaJogador].GetCarta());
                    x = Pontuação(ListaCartas[CartaJogador].GetCarta());
                    PntJogador += x;
                    ListaCartas.RemoveAt(CartaJogador);

                    CartaMesa = rnd.Next(0, ListaCartas.Count());
                    CardMesa.Add(ListaCartas[CartaMesa].GetCarta());

                    x = Pontuação(ListaCartas[CartaMesa].GetCarta());
                    PntMesa += x;
                    ListaCartas.RemoveAt(CartaMesa);
                }
          

            CartasJogador.Text = $"Cartas Jogador:{CardJogador[0]} e {CardJogador[1]} ";

            CartasMesa.Text = $"Carta mesa: {CardMesa[0]}";

            BtnHit.Show();
        }

        private void CartasMesa_Click(object sender, EventArgs e)
        {

        }

        public void BtnHit_Click(object sender, EventArgs e)
        {
            CartaJogador = rnd.Next(0, ListaCartas.Count());
            CardJogador.Add(ListaCartas[CartaJogador].GetCarta());
            x = Pontuação(ListaCartas[CartaJogador].GetCarta());
            PntJogador += x;
            ListaCartas.RemoveAt(CartaJogador);
        }
    }
}
