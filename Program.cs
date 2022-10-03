using Cinema;

Filme[] filmes = new Filme[1];
Bombonier[] comidas = new Bombonier[1];
bool menu = true;
string sair = "S";
double valorPedido = 0;


while (menu)
{
    Console.Clear();

    filmes[0] = new Filme();
    comidas[0] = new Bombonier();

    Console.WriteLine("Bem vindo ao cinema!\n");
    Console.WriteLine("1 - Filmes em cartaz;");
    Console.WriteLine("2 - Pipocas;");
    Console.WriteLine("3 - Bebidas;");
    Console.WriteLine("4 - Combos;");
    Console.WriteLine("5 - Sair;");
   
    Console.WriteLine("Escolha a opção desejada:\n");

    for (int i = 0; i < filmes.Length; i++)
    {
        int opcao = Convert.ToInt32(Console.ReadLine());

        if (opcao == 1)
        {
            filmes[i].MostrarFilmes();
            Console.WriteLine();                       
            Console.WriteLine("Aperte qualquer tecla para continuar\n");
            Console.ReadKey();
            valorPedido = valorPedido + filmes[i].ValorTotal;
        }

        else if (opcao == 2)
        {
            comidas[i].Pipocas();
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar\n");
            Console.ReadKey();
            valorPedido = valorPedido + comidas[i].ValorTotal;
        }

        else if (opcao == 3)
        {
            comidas[i].Bebidas();
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar\n");
            Console.ReadKey();
            valorPedido = valorPedido + comidas[i].ValorTotal;
        }

        else if (opcao == 4)
        {
            comidas[i].Combos();
            Console.WriteLine("Aperte qualquer tecla para continuar\n");
            Console.ReadKey();
            valorPedido = valorPedido + comidas[i].ValorTotal;
        }

        else if (opcao == 5)
        {
            sair = Console.ReadLine();
            Console.WriteLine($"Valor total de seu pedido é de: R${valorPedido}.\nBom Filme!");
            menu = false;
        }


    }
}
