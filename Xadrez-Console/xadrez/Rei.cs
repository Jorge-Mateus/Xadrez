using Xadrez_Console.tabuleiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base (cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
