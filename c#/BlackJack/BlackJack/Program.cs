using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
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

        static void Main()
        {
            int w1 = 0;
            int saldo = 500;
            while (w1 ==0)
            {


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

                // jogador

                Console.WriteLine("---------------------------");
                Console.WriteLine("          Cassino          ");
                Console.WriteLine("---------------------------");

                Console.WriteLine("Selecione a opção que você deseja" +
                    "\n [1] - para apostar" +
                    "\n [2] - para sair");
                int opc = int.Parse(Console.ReadLine());



                switch (opc)
                {
                    case 1:
                        int PntJogador = 0;
                        int PntMesa = 0;
                        int CartaJogador;
                        int CartaMesa;

                        Console.WriteLine($"\nOlá ! O seu saldo é de R${saldo}" +
                            $"\n Quanto vocÊ quer apostar ? ");

                        int ValorAposta = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nOkay ! vamos começar o jogo");
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

                        Console.Write("\nSuas cartas : ");
                        for (int aux = 0; aux < CardJogador.Count; aux++)
                        {
                            Console.Write($"[{CardJogador[aux]}]");
                            Console.Write(" ");
                        }
                        Console.WriteLine($"\n Sua pontuação é :{PntJogador}");

                        Console.Write($"\nCarta da banca:");
                        for (int aux = 0; aux < CardMesa.Count; aux++)
                        {
                            Console.Write($"[{CardMesa[aux]}]");
                            Console.Write(" ");
                        }

                        int Wcard = 0;
                        while (Wcard == 0)
                        {
                            if (PntJogador <= 20 || PntMesa <= 20)
                            {
                                Console.WriteLine("\nVocê quer mais uma carta? [S/N]");
                                string cont = Console.ReadLine();
                                cont = cont.ToUpper();

                                if (cont == "S")
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

                                    Console.Write("\nSuas cartas : ");
                                    for (int aux = 0; aux < CardJogador.Count; aux++)
                                    {
                                        Console.Write($"[{CardJogador[aux]}]");
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine($"\n Sua pontuação é :{PntJogador}");

                                    Console.Write($"\nCarta da banca:");
                                    for (int aux = 0; aux < CardMesa.Count; aux++)
                                    {
                                        Console.Write($"[{CardMesa[aux]}]");
                                        Console.Write(" ");
                                    }
                                }
                                else 
                                {
                                   
                                    while (true)
                                    {
                                        if(PntMesa < 17)
                                        {
                                            CartaMesa = rnd.Next(0, ListaCartas.Count());
                                            CardMesa.Add(ListaCartas[CartaMesa].GetCarta());

                                            x = Pontuação(ListaCartas[CartaMesa].GetCarta());
                                            PntMesa += x;
                                            ListaCartas.RemoveAt(CartaMesa);
                                        }
                                        else if( PntJogador == 21)
                                        {
                                            Console.WriteLine("Você ganhou !");
                                            saldo = saldo + ValorAposta;
                                            Wcard = 1;
                                            break;
                                        }
                                        else if (PntMesa == 21)
                                        {
                                            Console.WriteLine("Você perdeu !");
                                            saldo = saldo - ValorAposta;
                                            Wcard = 1;
                                            break;
                                        }
                                        else if( PntJogador > 21 && PntMesa > 21)
                                        {
                                            Console.WriteLine("O dois impataram, ambos estouraram");
                                            Wcard = 1;
                                            break;
                                        }
                                        else
                                        {
                                            if(Math.Max(PntJogador, PntMesa) == PntJogador)
                                            {
                                                Console.WriteLine("Você ganhou !");
                                                saldo = saldo + ValorAposta;
                                                Wcard = 1;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Você perdeu !");
                                                saldo = saldo - ValorAposta;
                                                Wcard = 1;
                                                break;
                                            }
                                        }

                                    }
                                    
                                }
                            }
                        }



                        break;
                    case 2:
                        w1 = 1;
                        break;

                }
            }
        }
    }
}
