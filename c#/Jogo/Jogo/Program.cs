using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Jogo
{

    class Program
    {
        static void Main(string[] args)
        {
            string inicio = "Bem-Vindo ao jogo da forca 3000 G3N3R4T4R";
            string palavra = "Bosch";
            palavra = palavra.ToUpper();
            char[] VetPalavra = new char[palavra.Length];
            int erros = 0;
            int acertos = 0;


            for (int i = 0; i < inicio.Length; i++)
            {
                Console.Write(inicio[i]);
                Task.Delay(100).Wait();
            }
            Console.WriteLine("\n");

            {

                Console.Write(" ___________________________________" +
                            "\n|                                   |" +
                            "\n|                                   |" +
                            "\n|" +
                            "\n|" +
                            "\n|" +
                            "\n|" +
                            "\n|" +
                            "\n|" +
                            "\n|" +
                            "\n|   ");

                for (int aux = 0; aux < palavra.Length; aux++)
                {
                    Console.Write(" __ ");
                }

                Console.Write("\n|____________________________________");

                Console.WriteLine("\nDigite uma letra para tentar acertar a palavra");
                char letra = char.Parse(Console.ReadLine());
                letra = char.ToUpper(letra);

                for (int aux = 0; aux < palavra.Length; aux++)
                {

                    if (letra == palavra[aux])
                    {
                        VetPalavra[aux] = letra;
                        acertos++;
                        continue;

                    }
                    else if (aux == palavra.Length - 1)
                    {
                        if (acertos == 0)
                        {
                            VetPalavra[aux] = ' ';
                            erros++;
                            continue;
                        }
                        else
                        {
                            VetPalavra[aux] = ' ';
                            continue;
                        }

                    }
                    else
                    {
                        VetPalavra[aux] = ' ';
                        continue;
                    }
                }
                Task.Delay(300).Wait();
                Console.Clear();
                while (true)
                {
                    Console.Write(" ___________________________________" +
                                "\n|                                   |" +
                                "\n|                                   |" +
                               $"\n|                            Erros: {erros}" +
                                "\n|" +
                                "\n|" +
                                "\n|" +
                                "\n|" +
                                "\n|" +
                                "\n|" +
                                "\n|   ");

                    for (int aux = 0; aux < palavra.Length; aux++)
                    {
                        for (int aux2 = 0; aux < palavra.Length; aux2++)
                        {
                            if (VetPalavra[aux] == ' ')
                            {

                                Console.Write(" __ ");
                                break;

                            }
                            else if (VetPalavra[aux] == palavra[aux2])
                            {
                                Console.Write($"  {palavra[aux2]} ");
                                break;
                            }
                            continue;
                        }
                    }

                    Console.Write("\n|____________________________________");

                    Console.WriteLine("\nDigite uma letra para tentar acertar a palavra");
                    letra = char.Parse(Console.ReadLine());
                    letra = char.ToUpper(letra);

                    int count = 0;
                    for (int aux = 0; aux < palavra.Length; aux++)
                    {
                        if (VetPalavra[aux] != ' ')
                        {
                            continue;
                        }
                        else
                        {
                            if (letra == palavra[aux])
                            {
                                VetPalavra[aux] = letra;
                                acertos++;
                                count++;
                                continue;

                            }
                            else if (aux == palavra.Length - 1)
                            {
                                if (VetPalavra[aux] == ' ' & count == 0)
                                {
                                    erros++;
                                    continue;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                VetPalavra[aux] = ' ';
                                continue;
                            }
                        }
                        }
                    Task.Delay(300).Wait();
                    Console.Clear();
                    if (acertos == palavra.Length)
                        {
                            Console.WriteLine("\nParabens Você acertou!!");

                            Console.Write(" ___________________________________" +
                                     "\n|                                   |" +
                                     "\n|                                   |" +
                                    $"\n|                            Erros: {erros} " +
                                     "\n|" +
                                     "\n|" +
                                     "\n|" +
                                     "\n|" +
                                     "\n|" +
                                     "\n|" +
                                     "\n|   ");

                            for (int aux = 0; aux < palavra.Length; aux++)
                            {
                                for (int aux2 = 0; aux < palavra.Length; aux2++)
                                {
                                    if (VetPalavra[aux] == ' ')
                                    {

                                        Console.Write(" __ ");
                                        break;
                                    }
                                    else if (VetPalavra[aux] == palavra[aux2])
                                    {
                                        Console.Write($"  {palavra[aux2]} ");
                                        break;
                                    }
                                    continue;
                                }
                            }

                            Console.Write("\n|____________________________________");

                            Console.WriteLine("\n\n");
                            break;

                        }
                        else if (erros == (palavra.Length - 1) * 3)
                        {
                            Console.WriteLine($"\nAaaaa, Infelizmente você perdeu ://" +
                                $"\n a palavra era: '{palavra}'" +
                                $"\n Você teve {palavra.Length * 3} chances");
                            break;

                        }
                    }

                }
            }
        }
    }

