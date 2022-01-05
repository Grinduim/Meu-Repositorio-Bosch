using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Hotelaria;

namespace Hotel
{
    class Program
    {

        static public int Menu()
        {
            int opc;

            while (true)
            {
                try
                {
                    // print menu
                    Console.WriteLine("[1] - Fazer reserva \n[2] - Alterar datas da Reserva\n[3] - Mostrar Todas Reservas\n[4] - Sair\nR:");
                    opc = int.Parse(Console.ReadLine());

                    if (opc >= 1 && opc <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nNão consegui entender tente novamente por favor");
                        Console.WriteLine("\n\n");
                        continue;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"\n{e.Message}");
                }
            }
            return opc;
        }


        static public SistemaDeReserva CreatReservation()
        {
            while (true)
            {
                try
                {
                    DateTime DataAtual = DateTime.Now; // data atual
                    int TempQuarto; // Variaveis temporarias para auxiliarem na validação de itens
                    DateTime TempEntrada; // var temporaria para fazer as validações
                    DateTime TempSaida; // var temooraria para fazer as validações


                    Console.WriteLine("\nInsira o numero do quarto: ");
                    TempQuarto = int.Parse(Console.ReadLine());


                    Console.WriteLine("\nQual da Data de entrada ? Formato dd/MM/yyyy ");
                    TempEntrada = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                    // convertendo as string em DateTime e  informando a CultureInfo

                    Console.WriteLine("\nQual a data de saida ? Formato dd/MM/yyyy ");
                    TempSaida = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));


                    if (TempEntrada > DataAtual && TempSaida > TempEntrada)
                    {
                        SistemaDeReserva reserva = new SistemaDeReserva(TempEntrada, TempSaida, TempQuarto);
                        return reserva;

                    }
                    else
                    {
                        // mensagem que os dados inseridos foram invalidos
                        Console.WriteLine("\n");
                        Console.WriteLine($"Não foi possivel atualizar a reserva, algum dados está errado.\n LEMBRETE: A data de saida deve ser superior da data de Entrada e a data de entrada deve ser superior a data Atual");
                        Console.WriteLine("\n\nPrecione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e}");
                }
            }
        }


        static public SistemaDeReserva ChangeReservation(SistemaDeReserva Reservation )
        {
            DateTime TempEntrada;
            DateTime TempSaida;
            DateTime DataAtual = DateTime.Now;

            while (true)
            {
                try
                {
                    Console.WriteLine("\n Qual da Data de entrada ? Formato dd/MM/yyyy ");
                    TempEntrada = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                    // convertendo as string em DateTime e  informando a CultureInfo

                    Console.WriteLine("\n Qual a data de saida ? Formato dd/MM/yyyy ");
                    TempSaida = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                    if (TempEntrada > DataAtual && TempSaida > TempEntrada)
                    {
                        Reservation.ChangeReservation(TempEntrada, TempSaida);
                        //chamando a função na classe que muda a instancia 
                        break;
                    }
                    else
                    {
                        // mensagem de erro
                        Console.WriteLine("\n");
                        Console.WriteLine($"Não foi possivel atualizar a reserva, algum dados está errado.\nLEMBRETE: A data de saida deve ser superior da data de Entrada e a data de entrada deve ser superior a data Atual");
                        Console.WriteLine("\n\nPrecione qualquer tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"\n Erro:{e.Message}");
                }
               
            }
            return Reservation;
        }


        static void Main(string[] args)
        {
            List<SistemaDeReserva> Reservations = new List<SistemaDeReserva>(); // lista para armazenar os dados 

            int w1 = 1;
            while (w1 ==1)
            {
                int opc = Menu();
                Task.Delay(2500);
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        Reservations.Add(CreatReservation());
                        Task.Delay(1000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n Qual o numero do quarto que você quer alterar ?");
                        int NumberRoom = int.Parse(Console.ReadLine());

                        for (int NumberReservation = 0; NumberReservation < Reservations.Count; NumberReservation++) // for  run reservation in lists
                        {
                            if (Reservations[NumberReservation].Room == NumberRoom)
                            {
                                Reservations[NumberReservation] = ChangeReservation(Reservations[NumberReservation]); // if found room change a reservation

                                Console.WriteLine("\nReserva alterada!");
                                Task.Delay(1500);

                            }
                            else if(NumberReservation == Reservations.Count -1){
                                Console.WriteLine("Não foi possivel encontrar Esse quarto");
                                Console.WriteLine("\n\n");
                                break;
                            }
                        }

                        break;
                    case 3:

                        foreach(SistemaDeReserva Reservation in Reservations)
                        {
                            // print reservas
                            Console.WriteLine($"\n Room:{Reservation.Room}\nCheckIn: {Reservation.CheckIn.ToString("dd/MM/yyyy")}\nCheckout: {Reservation.CheckOut.ToString("dd/MM/yyyy")}\nTotal de dias: {Reservation.TotalDays}");
                            Console.WriteLine("---------------------");
                        }

                        Console.WriteLine("\n\n\n\n");
                        Task.Delay(5000);
                        break;

                    case 4:
                        w1 = 0;
                        Console.WriteLine("Encerrando programa");
                        break;
        
                }
            }
        }
    }
}

