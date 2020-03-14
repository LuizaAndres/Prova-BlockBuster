using System;
using System.Collections.Generic;
using ClasseFilme;
using ClasseCliente;

namespace ClasseLocacao{
    
    public class Locacao {
        public String id;
        public DateTime dataLocacao;
        public DateTime dataDevolucao;
        public Cliente cliente;
        public List<Filme> filmes = new List<Filme>();

        public Locacao(String id, Cliente cliente){
            this.id = id;
            this.cliente = cliente;
            this.dataLocacao = DateTime.Now;
            this.dataDevolucao = this.devolver(this.dataLocacao, this.cliente.diasDevolucao);
            cliente.locacoes.Add(this);
        }

        public DateTime devolver(DateTime dataLocacao, int diasDevolucao){
            return dataLocacao.AddDays(diasDevolucao);
        }

        public void adicionarFilme(Filme filme){
            this.filmes.Add(filme);
            filme.locacoes.Add(this);
        }

        public double calcularLocacao(){
            double valor = 0;
            foreach(Filme filme in this.filmes){
                valor += filme.valor;
            }

            return valor;
        }
        
    }
}