using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Disciplinasmat
    {
        string NomeDisciplina;
        string horario;
        string QtdCredito;

        public Disciplinasmat(string NomeDisciplina, string horario, string QtdCredito)
        {
            this.NomeDisciplina = NomeDisciplina;
            this.horario = horario;
            this.QtdCredito = QtdCredito;
        }

        public string GetNomeDisciplina()
        {
            return NomeDisciplina;
        }

        public string GetHorario()
        {
            return horario;
        }

        public string GetCredito()
        {
            return NomeDisciplina;
        }
    }
}
