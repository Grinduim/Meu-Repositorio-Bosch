using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendarSalao;
using System.Globalization;

namespace AgendarSalao
{
    class Agendamento
    {
        String name;
        DateTime schedule;

        public Agendamento()
        {
             string TempName;
                DateTime Tempschedule;
                while (true)
                {

                    try
                    {

                        Console.Write("\nInsert the name: ");
                        TempName = Console.ReadLine();

                        Console.WriteLine("\nInsert a day of the visit\nPlease Format -> dd/MM/yyyy\n");
                        Tempschedule = DateTime.Parse(Console.ReadLine(), new CultureInfo("pt-BR"));

                        if (Tempschedule > DateTime.Now)
                        {
                            Name = TempName;
                            Schedule = Tempschedule;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\nDateTime Invalid, please, insert a  a date later than today  -> {DateTime.Now.ToString("dd/MM/yyyy")}");
                            continue;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine($"\nReservation Confirmed\nName:{Name} and Date: {Schedule}");
        }
        public string Name { get => name; set => name = value; }
        public DateTime Schedule { get => schedule; set => schedule = value; }
    }
}
