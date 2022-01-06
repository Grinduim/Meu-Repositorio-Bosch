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
            { // para caso ter algum erro ele dar retorno no menu, caso nao tenha ocorre o break dentro do if
                    
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

        static void Main(string[] args)
        {
            List<SistemaDeReserva> Reservations = new List<SistemaDeReserva>(); // lista para armazenar os dados 

            int w1 = 1;
            while (w1 ==1)
            { // while para o programa ficar em lup
                int opc = Menu(); // instanciando a função menu
                Task.Delay(2500);
                Console.Clear();

                switch (opc)
                {
                    case 1: // fazer reserva

                        SistemaDeReserva TempReserva = new SistemaDeReserva();
                        Reservations.Add(TempReserva); // criando a reserva adionando ela em uma lista
                        Task.Delay(3000);
                        Console.Clear();
                        break;
                    case 2: // alterara reserva
                        Console.WriteLine("\n Qual o numero do quarto que você quer alterar ?"); 
                        int NumberRoom = int.Parse(Console.ReadLine());

                        for (int NumberReservation = 0; NumberReservation < Reservations.Count; NumberReservation++) // for  run reservation in lists
                        {
                            if (Reservations[NumberReservation].GetRoom() == NumberRoom)
                            {
                                Reservations[NumberReservation] = Reservations[NumberReservation].ChangeReservation(Reservations[NumberReservation]); // if found room change reservation

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
                    case 3: // listar todas as reservas

                        foreach(SistemaDeReserva Reservation in Reservations)
                        {
                            // print reservas
                            Console.WriteLine($"\n Room:{Reservation.GetRoom()}\nCheckIn: {Reservation.GetCheckIn().ToString("dd/MM/yyyy")}\nCheckout: {Reservation.GetCheckOut().ToString("dd/MM/yyyy")}\nTotal de dias: {Reservation.GetTotalDays()}");
                            Console.WriteLine("---------------------");
                        }

                        Console.WriteLine("\n\n\n\n");
                        Task.Delay(5000);
                        break;

                    case 4: // encerrar programa
                        w1 = 0;
                        Console.WriteLine("Encerrando programa");
                        break;
        
                }
            }
        }
    }
}

