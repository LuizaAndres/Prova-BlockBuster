using System;
using System.Collections.Generic;
using ClasseFilme;
using ClasseLocacao;

namespace ClasseCliente {
    public class Cliente {
        public String id;
        public String nome;
        public DateTime dataNascimento;
        public String cpf;
        public int diasDevolucao;
        public List<Locacao> locacoes = new List<Locacao> ();

        public Cliente (String id, String nome, DateTime dataNascimento, String cpf, int diasDevolucao) {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;
        }

        public int chamarLocados () {
            int filmes = 0;

            foreach (Locacao locacao in this.locacoes) {
                foreach (Filme filme in locacao.filmes) {
                    filmes++;
                }
            }

            return filmes;
        }
    }
}