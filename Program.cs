using System;
using System.Collections.Generic;
using ClasseCliente;
using ClasseFilme;
using ClasseLocacao;
namespace Prova_BlockBuster {
    class Program {
        static void Main (string[] args) {
            DateTime calendario = new DateTime (1995, 2, 25);

            List<Cliente> clientes = new List<Cliente> ();
            Cliente cliente1 = new Cliente ("0", "Ivan", calendario, "012.345.678-90", 3);
            clientes.Add (cliente1);
            Cliente cliente2 = new Cliente ("1", "Luiza", calendario, "123.456.789-01", 4);
            clientes.Add (cliente2);
            Cliente cliente3 = new Cliente ("2", "Jenny", calendario, "234.567.890-12", 4);
            clientes.Add (cliente3);
            Cliente cliente4 = new Cliente ("3", "Lady", calendario, "345.678.901-23", 1);
            clientes.Add (cliente4);
            Cliente cliente5 = new Cliente ("4", "Maria Cristina", calendario, "456.789.012-34", 3);
            clientes.Add (cliente5);

            List<Filme> filmes = new List<Filme> ();
            Filme filme1 = new Filme ("0", "Coringa", "2019", "Matar o Bátima", 19.5, 1);
            filmes.Add (filme1);
            Filme filme2 = new Filme ("1", "Rei Leão", "2019", "SIMBÁ", 21, 4);
            filmes.Add (filme2);
            Filme filme3 = new Filme ("2", "Alladin", "2019", "As arabias", 20.3, 5);
            filmes.Add (filme3);
            Filme filme4 = new Filme ("3", "A Bela e a Fera", "2018", "Gaston é machista e babacão", 7.1, 3);
            filmes.Add (filme4);
            Filme filme5 = new Filme ("4", "Anastacia", "1995", "Magia ronda a família real", 5.5, 3);
            filmes.Add (filme5);
            Filme filme6 = new Filme ("5", "Minions", "2017", "Banana?", 15.6, 5);
            filmes.Add (filme6);
            Filme filme7 = new Filme ("6", "O senhor dos aneis - as duas torres", "2006", "Por que não tem esse filme na netflix se tem todos os outros sr dos aneis?", 12.4, 9);
            filmes.Add (filme7);
            Filme filme8 = new Filme ("7", "Faltou criatividade aqui", "2020", "Ops... ainda tenho que fazer mais 2 filmes", 14.6, 4);
            filmes.Add (filme8);
            Filme filme9 = new Filme ("8", "Matrix 4", "2021", "Aqui prevemos o futuro", 30.6, 8);
            filmes.Add (filme9);
            Filme filme10 = new Filme ("9", "Esqueceram de mim", "1995", "Como eu poderia esquecer esse?", 8.6, 7);
            filmes.Add (filme10);
            Filme filme11 = new Filme ("6", "O ultimo samurai", "1997", "Por que esse tinha que ser o ultimo", 4.6, 2);
            filmes.Add (filme11);

            Locacao locacao1 = new Locacao ("0", cliente1);
            locacao1.adicionarFilme (filme1);
            locacao1.adicionarFilme (filme2);

            Locacao locacao2 = new Locacao ("1", cliente1);
            locacao2.adicionarFilme (filme8);
            locacao2.adicionarFilme (filme4);
            Locacao locacao3 = new Locacao ("0", cliente2);
            locacao3.adicionarFilme (filme6);
            locacao3.adicionarFilme (filme7);
            Locacao locacao7 = new Locacao ("1", cliente2);
            locacao7.adicionarFilme (filme9);
            locacao7.adicionarFilme (filme10);
            Locacao locacao4 = new Locacao ("0", cliente3);
            locacao4.adicionarFilme (filme7);
            locacao4.adicionarFilme (filme4);
            Locacao locacao5 = new Locacao ("0", cliente4);
            locacao5.adicionarFilme (filme5);
            locacao5.adicionarFilme (filme1);
            Locacao locacao6 = new Locacao ("0", cliente5);
            locacao6.adicionarFilme (filme11);
            locacao6.adicionarFilme (filme3);

            foreach (Cliente cliente in clientes) {
                Console.WriteLine ("---------------------------------------------------------------------------");
                Console.WriteLine ($"nome: {cliente.nome} \nQuantidade de filmes locados: {cliente.chamarLocados()}");
                foreach (Locacao locacao in cliente.locacoes) {
                    Console.WriteLine ($" \nID locação: {locacao.id}");
                    foreach (Filme filme in locacao.filmes) {
                        Console.WriteLine ($"Filme: {filme.nome}    \tPreço por filme: {filme.valor}");
                    }
                    Console.WriteLine ($"Valor da locação: {locacao.calcularLocacao()}\n ");
                }
            }

            foreach (Filme film in filmes) {
                Console.WriteLine ($" \nNome do filme: {film.nome} \tquantidade de locações: {film.retornaLocacoes()}\n{film.sinopse}");
            }
        }
    }
}