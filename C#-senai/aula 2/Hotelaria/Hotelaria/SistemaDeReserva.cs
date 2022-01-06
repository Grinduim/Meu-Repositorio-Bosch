using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hotelaria
{
    public class SistemaDeReserva
    {
        private int Room;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private int TotalDays;

        public SistemaDeReserva() // "struct" para auxiliar no instnaciamento de objetos
        {
             while (true) // while para caso ter algum erro ele repetir a tela da entrada de dados
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

                    if (TempEntrada > DataAtual && TempSaida > TempEntrada) // verificando se a datas são validas
                    {
                        SetRoom(TempQuarto);
                        SetCheckIn(TempEntrada);
                        SetCheckOut(TempSaida);
                        SetTotalDay();
                        break;

                    }
                    else
                    {
                        // mensagem que os dados inseridos foram invalidos
                        Console.WriteLine("\n");
                        Console.WriteLine($"Não foi possivel atualizar a reserva, algum dados está errado.\n LEMBRETE: A data de saida deve ser superior da data de Entrada e a data de entrada deve ser superior a data Atual");
                        Console.WriteLine("\n\nPrecione qualquer tecla para continuar");
                        Console.ReadKey(); // aguardar o usuario precionar alguma tecla para dar continuidade
                        Console.Clear();
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e}");
                    Console.WriteLine("\n\nPrecione qualquer tecla para continuar");
                    Console.ReadKey(); // aguardar o usuario precionar alguma tecla para dar continuidade
                    Console.Clear();
                }
            }

            
        }



        public SistemaDeReserva ChangeReservation(SistemaDeReserva Reservation) // metoso para auxiliar  a mudança das datas
        {
             // var temporarias para auxiliar
            DateTime TempEntrada; 
            DateTime TempSaida;
            DateTime DataAtual = DateTime.Now;
            Console.WriteLine("Dados atuais da sua reserva:");
            Console.WriteLine($"\nCheckIn: {Reservation.GetCheckIn().ToString("dd/MM/yyyy")}\nCheckout: {Reservation.GetCheckOut().ToString("dd/MM/yyyy")}\nTotal de dias: {Reservation.GetTotalDays()}");
                            Console.WriteLine("---------------------");

            while (true) // while para caso ter algum erro ele repetir a tela da entrada de dados
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
                        Reservation.SetCheckIn(TempEntrada);
                        Reservation.SetCheckOut(TempSaida);
                        Reservation.SetTotalDay();
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
                    Console.WriteLine($"\n Erro:{e.Message}"); // capturando o erro
                }
               
            }
            return Reservation; // dando o retorno o objeto 

        }

        // metodos Sets para setar os atributos
        public void SetRoom(int NewRoom)
        {
            this.Room = NewRoom;
        }

        public void SetCheckIn(DateTime CheckIn)
        {
            this.CheckIn = CheckIn;
        }

        public void SetCheckOut(DateTime CheckOut)
        {
            this.CheckOut = CheckOut;
        }

        public void SetTotalDay()
        {
            this.TotalDays = int.Parse(CheckOut.Subtract(CheckIn).ToString("dd")); // conversão do periodo da estadia para string e dps para inteiro
        }

        //gets para poder visualizar os atributos somente por meio deles
        public int GetRoom()
        {
            return Room;
        }

        public DateTime GetCheckIn()
        {
            return CheckIn;
        }

        public DateTime GetCheckOut()
        {
            return CheckOut;
        }

        public int GetTotalDays()
        {
            return TotalDays;
        }
    }
}
