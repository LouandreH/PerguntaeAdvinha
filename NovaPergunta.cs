using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGODEADVINHA
{
    public class NovaPergunta : PerguntaJogo
    {
        public NovaPergunta():base()
        {
            this.Dica = "";
        }
        public NovaPergunta(string pergunta, string resposta, string dica) :base (pergunta, resposta)
        {

            this.Dica = dica;
        }

        private String dica; 
        public String Dica {
            get { return dica;  } 
            set { dica = value.ToUpper(); }
        }
    }
}
