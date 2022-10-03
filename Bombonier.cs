using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Bombonier
    {
        public int PipocaEscolhida { get; set; }
        public int BebidaEscolhida { get; set; }
        public int ComboEscolhido { get; set; }
        public double ValorTotal { get; set; }

        string[] pipocas = new string[4] { "Pipoca Pequena", "Pipoca Média", "Pipoca Grande", "Sem Pipoca" };
        double[] valorPipocas = new double[4] { 10.00, 15.00, 20.00, 0.00};

        public void Pipocas()
        {
            for (int i = 0; i < pipocas.Length; i++)

            Console.WriteLine(i + 1 + " - " + pipocas[i] + " R$: " + valorPipocas[i]);
            Console.WriteLine("\nEscolha a opção desejada:\n");
            PipocaEscolhida = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Você escolheu {pipocas[PipocaEscolhida]}, pelo valor R$ {valorPipocas[PipocaEscolhida]}");
            ValorTotal = ValorTotal + valorPipocas[PipocaEscolhida];

        }

        string[] bebidas = new string[6] { "Refrigerante pequeno", "Refrigerante médio", "Refrigerante grande", "Água", "Suco", "Sem bebida" };
        double[] valorBebidas = new double[6] { 8.00, 10.00, 12.00, 5.00, 12.00, 0.00 };

        public void Bebidas()
        {
            for (int i = 0; i < bebidas.Length; i++)

            Console.WriteLine(i + 1 + " - " + bebidas[i] + " R$: " + valorBebidas[i]);
            Console.WriteLine("\nEscolha a opção desejada:\n");
            BebidaEscolhida = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Você escolheu {bebidas[BebidaEscolhida]}, pelo valor R$ {valorBebidas[BebidaEscolhida]}");
            ValorTotal = ValorTotal + valorBebidas[BebidaEscolhida];
        }

        string[] combos = new string[4] { "Combo 1:\nContém: Pipoca pequena + Refrigerante Pequeno\n", "Combo 2:\nContém: Pipoca média + Refrigerante Grande\n", "Combo 3:\nContém: Pipoca grande + Refrigerante Grande + Água", "Sem combo\n"};
        double[] valorCombos = new double[4] { 15.50, 24.50, 32.50, 0.00 };

        public void Combos()
        {
            for (int i = 0; i < combos.Length; i++)

            Console.WriteLine(i + 1 + " - " + combos[i] + "R$: " + valorCombos[i]);
            Console.WriteLine("\nEscolha a opção desejada:\n");
            ComboEscolhido = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Você escolheu {combos[ComboEscolhido]}, pelo valor R$ {valorCombos[ComboEscolhido]}");
            ValorTotal = ValorTotal + valorCombos[ComboEscolhido];

        }

    }
}