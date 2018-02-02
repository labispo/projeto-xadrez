﻿using System.Text;
using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("");
            sb.Append(coluna);
            sb.Append(linha);
            return sb.ToString();
        }

    }
}
