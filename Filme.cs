using System;
using System.Collections.Generic;
using ClasseLocacao;

namespace ClasseFilme{
    public class Filme {
       
        public String id;
        public String nome;
        public String anoLancamento;
        public String sinopse;
        public double valor;
        public int estoque;
        public List<Locacao> locacoes = new List<Locacao>();

        public Filme(String paramId, String nome, String anoLancamento, String sinopse, double valor, int estoque){
            this.id = paramId;
            this.nome = nome;
            this.anoLancamento = anoLancamento;
            this.sinopse = sinopse;
            this.valor = valor;
            this.estoque = estoque;
        }

        public int retornaLocacoes(){
            return this.locacoes.Count;
        }
    }
}