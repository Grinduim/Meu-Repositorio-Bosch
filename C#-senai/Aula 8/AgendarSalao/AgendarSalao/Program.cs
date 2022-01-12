using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using AgendarSalao;

namespace AgendarSalao
{
    class Program
    {

         
        static void Main(string[] args)
        {
            string Name;
            DateTime Schedule;
            while (true) // make inifnity input in case erro
            {
                try
                {

                    Console.Write("\nInsert the name: ");
                    Name = Console.ReadLine();

                    Console.WriteLine("\nInsert a day of the visit\nPlease Format -> dd/MM/yyyy\n");
                    Schedule = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                    if (Schedule > DateTime.Now)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\nDateTime Invalid, please, insert a  a date later than today  -> {DateTime.Now.ToString("dd/MM/yyyy")}");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: please inser a valid format");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }
            Console.WriteLine($"\nReservation Confirmed\nName:{Name} and Date: {Schedule}");
            Console.Clear();

            while (true)
            {
                DateTime NewSchedule;
                try
                {
                    Console.WriteLine("\nInsert the new day of the visit\nPlease Format -> dd/MM/yyyy\n");
                    NewSchedule = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));
                    if (NewSchedule > Schedule)
                    {
                        Schedule = NewSchedule;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\nDateTime Invalid, please, insert a  a date later than older schedule  -> {Schedule.ToString("dd/MM/yyyy")}");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: please inser a valid format");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    continue;
                }
            }




        }
    }
}
