using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOGODEADVINHA
{
    internal class Program
    {
        static void Main(string[] args)
        {   //lista de perguntas
            GerenciadorJogo jogo = new GerenciadorJogo();
            jogo.Jogar();
        }


        
    }
}
