using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGODEADVINHA
{
  
    public class GerenciadorJogo:PerguntaJogo

    {
        public GerenciadorJogo()
        {
            this.CriarPerguntas();
        }

        private List<NovaPergunta> perguntas;

        
        public List<NovaPergunta> Perguntas { 
            get { return this.perguntas; } 
        }

        public void Jogar()
        {
            
            Random r = new Random();
            int pos = r.Next(0, perguntas.Count);

            NovaPergunta pergunta = perguntas[pos];
            
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";

            while (tentativas < 3 && flag == false)
            {
                Console.WriteLine("Pergunta:" + pergunta.Pergunta);
                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                    Console.WriteLine("Parabens você ACERTOU!");
                }
                else
                {
                    Console.WriteLine("Errou! DICA: " + pergunta.Dica);
                }
                tentativas++;
            }
            if (flag == true)
            {
                Console.WriteLine("Você ganhou o jogo");
            }
            else
            {
                Console.WriteLine("Você Perdeu");
            }
            Console.ReadKey();
        }
        private void CriarPerguntas()
        {
            perguntas = new List<NovaPergunta>();
            perguntas.Add(new NovaPergunta("Qual e a Cor do Ceu? ", "AZUL", "Informe uma que comece com a letra A "));
            perguntas.Add(new NovaPergunta("Qual e cor do espaço?", "Preta", "cor que todos gostam! "));
            perguntas.Add(new NovaPergunta("Site de filme? ", "NETFLIX", "Melhor site da filmes! "));

        }
    }
   
}
