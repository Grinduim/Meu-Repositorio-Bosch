using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    class NovaPergunta:Perguntasjogo
    {
        string dica;

        public NovaPergunta(string p1, string r1, string dica)
        {
            SetP(p1);
            SetR(r1);
            this.dica = dica;
        }

        public string GetDica()
        {
            return dica;
        }
    }
}
