using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Filme
    {
        public int FilmeEscolhido { get; set; }
        public double ValorTotal { get; set; }

        string[] listaFilmes = new string[4] { "Thor - Amor e Trovão", "Elvis", "Topgun", "O Debate" };
        double valorfilmes = 16.50;
        public void MostrarFilmes()
        {
            for (int i = 0; i < listaFilmes.Length; i++)

            Console.WriteLine(i + 1 + " - " + listaFilmes[i]);
            Console.WriteLine($"Valor de R$ {valorfilmes}\n");
            Console.WriteLine("Escolha a opção desejada:\n");
            FilmeEscolhido = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Você escolheu {listaFilmes[FilmeEscolhido]}, pelo valor R$ {valorfilmes}");
            ValorTotal = ValorTotal + valorfilmes;

        }

    }
}