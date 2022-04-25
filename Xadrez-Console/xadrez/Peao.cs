
using Xadrez_Console.tabuleiro;

namespace Xadrez_Console.xadrez
{
    class Peao : Peca
    {

        public Peao(Tabuleiro tab, Cor cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "P";
        }

        private bool existeInimigo(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p != null && p.Cor != Cor;
        }

        private bool livre(Posicao pos)
        {
            return Tab.peca(pos) == null;
        }

        public override bool[,] movimentoPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if ( Cor == Cor.Branca )
            {
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if ( Tab.posicaoValida(pos) && livre(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if ( Tab.posicaoValida(pos) && livre(pos) && Tab.posicaoValida(pos) && livre(pos) && QteMovimento == 0 )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

                if ( Tab.posicaoValida(pos) && existeInimigo(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

                if ( Tab.posicaoValida(pos) && existeInimigo(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }

            }

            else
            {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if ( Tab.posicaoValida(pos) && livre(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
             
                if ( Tab.posicaoValida(pos) && livre(pos) && Tab.posicaoValida(pos) && livre(pos) && QteMovimento == 0 )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if ( Tab.posicaoValida(pos) && existeInimigo(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if ( Tab.posicaoValida(pos) && existeInimigo(pos) )
                {
                    mat[pos.Linha, pos.Coluna] = true;
                }
            }

            return mat;
        }
    }
}