using System;
using System.Collections.Generic;
using ClasseFilme;
using ClasseCliente;

namespace ClasseLocacao{
    //construtor generico
    public class Locacao {
        public String id;
        public DateTime dataLocacao;
        public DateTime dataDevolucao;
        public Cliente cliente;
        public List<Filme> filmes = new List<Filme>();
//construtor de locação usado em clientes
        public Locacao(String id, Cliente cliente){
            this.id = id;
            this.cliente = cliente;
            this.dataLocacao = DateTime.Now;
            this.dataDevolucao = this.devolver(this.dataLocacao, this.cliente.diasDevolucao);
            cliente.locacoes.Add(this);
        }
//metodo Program retorna data de devolução baseada na data de locacao + tempo de retorno
        public DateTime devolver(DateTime dataLocacao, int diasDevolucao){
            return dataLocacao.AddDays(diasDevolucao);
        }
//metodo que adiciona o filme na lista locacao da classe Clientes
        public void adicionarFilme(Filme filme){
            this.filmes.Add(filme);
            filme.locacoes.Add(this);
        }
//metodo que retorna o valor da locacao
        public double valorLocacao(){
            double valor = 0;
            foreach(Filme filme in this.filmes){
                valor += filme.valor;
            }

            return valor;
        }
    }
}