using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_21_09_21
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 01
            {

                /*Console.WriteLine("Insira o nome: ");
                string nome = Console.ReadLine();
                bool retorno = nome.ToUpper().StartsWith("A");
                switch (retorno)
                {
                    case true:
                        Console.WriteLine(nome);
                        break;
                    default:
                        Console.WriteLine("Seu nome não começa com A");
                        break;
                }*/
            }

            //Exercicio 02
            {
                /* Console.WriteLine("Insira o nome:");
                 string nome = Console.ReadLine();
                 // primeiro metodo
                 nome = nome.Substring(0, 4);
                 Console.WriteLine(nome);

                 //metodo 2 
                 for (int i = 0; i < 4; i++)
                 {
                     Console.Write(nome[i]);
                 }*/
            }
            //exercicio 3
            {
                /* Console.WriteLine("Insira o nome:");
                 string nome = Console.ReadLine();
                 //metodo 1 
                 Console.WriteLine(nome.Length);
                 // metodo 2
                 int a = 0;
                 for( int i = 0; i < nome.Length; i++)
                 {
                     a++;
                 }
                 Console.WriteLine(a);*/
            }

            // exercicio 04
            {
                /*Console.WriteLine(" insira o primeiro nome ");
                string n1 = Console.ReadLine();
                Console.WriteLine(" insira o segundo nome ");
                string n2 = Console.ReadLine();

                // metodo 1
                if (n1 == n2)
                {
                    Console.WriteLine("são iguais");

                }
                else
                {
                    Console.WriteLine("não são iguais");
                }
                // metodo 2
                if (n1.Contains(n2))
                {
                    Console.WriteLine("são iguais");

                }
                else
                {
                    Console.WriteLine("não são iguais");

                }*/



            }

            // Exercicio 05


            {
                /*Console.WriteLine("Insira a combinação de zeros e uns");
                string comb = Console.ReadLine();
                int n = 0;
                
                for(int i = 0; i < comb.Length; i++)
                {
                    if (comb[i] == '1')
                    {
                        n++;
                    }
                }

                Console.WriteLine(n);
                }*/

                // Exercicio 6
                {
                    /* Console.WriteLine("Insira a ocorrencia");
                     string oco = Console.ReadLine();

                     oco = oco.Replace("0", "1");
                     Console.WriteLine(oco);*/
                }

                // exercicio 7 
                {
                    /*Console.WriteLine("Insira as palavra ou frase");
                    string frase = Console.ReadLine();
                    frase = frase.ToLower();

                    for(int aux = 0; aux <frase.Length; aux++)
                    {
                        if (frase[aux] == 'a' || frase[aux] =='e' || frase[aux] =='i' || frase[aux] =='o' || frase[aux] == 'u')
                        {
                            frase =frase.Remove(aux,1);
                            aux -= 1;
                        }
                    }
                    Console.WriteLine(frase);*/

                }


                // Exercicio 8
                {
                    /*Console.WriteLine("Insira uma frase");
                    string frase = Console.ReadLine();
                    int cont = 0;

                    for (int aux = 0; aux < frase.Length; aux++)
                    {
                        if (frase[aux] == ' ')
                        {
                            cont++;
                        }
                    }
                    Console.WriteLine("Se tem {0} espaçoes  na frase", cont);
                }*/
                }

                //Exercicio 09
                {
                    /*Console.WriteLine("Insira a palavra");
                    string palavra = Console.ReadLine();
                    palavra = palavra.ToLower();
                    int x = 0;
                    for(int aux = 0; aux <palavra.Length; aux++)
                    {
                        if (palavra[aux] == 'a' || palavra[aux] == 'e' || palavra[aux] == 'i' || palavra[aux] == 'o' || palavra[aux] == 'u')
                        {
                            x++;
                        }
                    }
                    Console.WriteLine(x);*/
                }

                // Exercicio 10

                {
                    /*Console.WriteLine("Insira a palavra");
                    string palavra = Console.ReadLine();
                    palavra = palavra.ToLower();
                    Console.WriteLine("Por qual letra você deseja substituir?");
                    string letra = Console.ReadLine();
                    string p2 = "";
                    for(int aux = 0; aux <palavra.Length; aux++)
                    {
                        switch (palavra[aux] == 'a' || palavra[aux] == 'e' 
                            || palavra[aux] == 'i' || palavra[aux] == 'o' || palavra[aux] == 'u')
                        {
                            case true:
                                p2 += letra;
                                break;
                            case false:
                                p2 += palavra[aux];
                                break;
                        }
                    }
                    Console.WriteLine("\n" + p2);*/
                }

                // Exercicio 11

                {
                    /*Console.WriteLine("Insira a palavra");
                    string palavra = Console.ReadLine();

                    Console.WriteLine("Insira a letra q você quer substituir as ocorrencias");
                    char l1 = char.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a substituta: ");
                    char l2 = char.Parse(Console.ReadLine());

                    string final = "";

                    for (int aux = 0; aux < palavra.Length; aux++)
                    {
                        switch(palavra[aux] == l1)
                        {
                            case true:
                                final += l2;
                                break;

                            case false;
                                final += palavra[aux];
                                break;
                        }
                    }
                    Console.WriteLine(final);*/
                }

                // Exercicio 12

                {

                    /*Console.WriteLine("Primeira palavra");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("segunda palavra");
                    string p2 = Console.ReadLine();
                    string[] palavras = { p1, p2 };
                    if (p1[0] < p2[0])
                    {
                        Console.WriteLine($"{ palavras[0]},{ palavras[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"{palavras[1]},{palavras[0]}");
                    }*/

                }

                //exericico 13

                {
                   /* Console.WriteLine("Insira a palavra");
                    string p1 = Console.ReadLine();
                    p1 = p1.ToLower();
                    bool cond = true;
                    int aux2 = p1.Length - 1;
                    for (int aux1 = 0; aux1 < p1.Length; aux1++)
                    {
                        if (p1[aux1] == p1[aux2])
                        {

                        }
                        else
                        {
                            cond = false;
                            break;
                        }

                        aux2--;
                    }
                    if (cond == true)
                    {
                        Console.WriteLine($"{p1} é palindromo ");
                    }
                    else
                    {
                        Console.WriteLine($"{p1} não é palindromo");
                    }*/
                }

                //Exercicio 14

                {
                    /*Console.WriteLine("Insira p1");
                    string p1 = Console.ReadLine();
                    p1 = p1.ToLower();

                    Console.WriteLine("Insira p2");
                    string p2 = Console.ReadLine();
                    p2 = p2.ToLower();

                    int y = p2.Length;
                    int x = p1.Length - y;

                    string aux = p1.Substring(x, y);

                    if (aux == p2)
                    {
                        Console.WriteLine($"{p2} está contida em {p1}");
                    }
                    else
                    {
                        Console.WriteLine($"{p2} não está contida em {p1}");
                    }*/


                }


                }
            }
        }
    }

