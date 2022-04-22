using System;
using Xadrez_Console.tabuleiro;
using Xadrez_Console.xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(9, 2));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 2));

                Tela.imprimirTabuleiro(tab);
                Console.ReadLine();
            }
            catch ( TabuleiroException e )
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
