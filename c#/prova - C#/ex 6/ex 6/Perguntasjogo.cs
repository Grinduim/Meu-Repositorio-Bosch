using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6
{
    class Perguntasjogo
    {
        string pergunta;
        string resposta;


        public Perguntasjogo()
        {

        }
        public Perguntasjogo(string p1, string r1)
        {
            pergunta = p1;
            resposta = r1;
        }

        public string GetP()
        {
            return pergunta;
        }

        public string GetR()
        {
            return resposta;
        }


        public void SetP(string p1)
        {
            this.pergunta = p1;
        }

        public void SetR(string r1)
        {
            this.resposta = r1;
        }
    }
}
