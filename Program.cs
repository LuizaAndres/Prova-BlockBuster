using System;
using ClasseFilme;
using ClasseCliente;
using ClasseLocacao;

namespace Prova_BlockBuster
{
    class Program
    {
        static void Main(string[] args)
        {

            
            DateTime calendario = new DateTime(1995, 2, 25);
            
            Cliente cliente1 = new Cliente("0", "Adamastor", calendario, "0", 3);
            Locacao locacao1 = new Locacao("0", cliente1);

            Filme filme1 = new Filme("0", "Coringa", "2019", "Matar o Bátima", 19.5, 1);
            Filme filme2 = new Filme("1", "Rei Leão", "2019", "SIMBÁ", 21, 1);

            locacao1.adicionarFilme(filme1);
            locacao1.adicionarFilme(filme2);

            Locacao locacao2 = new Locacao("1", cliente1);
            locacao2.adicionarFilme(filme1);
            locacao2.adicionarFilme(filme2);

            Console.WriteLine("Filmes locados " + cliente1.filmesLocados());
            Console.WriteLine(locacao1.valorLocacao());
            Console.WriteLine(filme1.qtdLocacoes());
        }
    }
}
