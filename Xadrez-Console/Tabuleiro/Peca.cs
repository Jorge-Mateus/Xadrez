namespace Xadrez_Console.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimento { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.QteMovimento = 0;
        }

        public void incrimentarQteMovimento()
        {
            QteMovimento++;
        }

        public void descrimentarQteMovimento()
        {
            QteMovimento--;
        }


        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentoPossiveis();
            for ( int i = 0; i < Tab.Linhas; i++ )
            {
                for ( int j = 0; j < Tab.Colunas; j++ )
                {
                    if ( mat[i, j] )
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentoPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentoPossiveis();
    }
}
