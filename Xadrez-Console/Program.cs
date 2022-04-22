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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimirTabuleiro(partida.tab);
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
