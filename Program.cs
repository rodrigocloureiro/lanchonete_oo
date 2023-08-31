using lanchonete_OO;

public class Program
{
    public static void Cardapio()
    {
        Console.WriteLine("Escolha o número do prato:");
        Console.WriteLine("1- Pizza calabresa com borda de catupiry e molho tradicional");
        Console.WriteLine("2- Pizza calabresa com borda de cheddar e molho tradicional");
        Console.WriteLine("3- Pizza frango com catupiry com borda de catupiry e molho tracidional");
        Console.WriteLine("4- X-Casa: Pão francês, molho cheddar e frango grelhado");
        Console.WriteLine("5- Sanduba da casa: Pão francês, maionese, ovos e bacon");
        Console.WriteLine("6- Sanduba natural: Pão de forma integral, molho natural e frango na grill");
        Console.WriteLine("7- Coxinha de frango (frita)");
        Console.WriteLine("8- Bolinha de queito (frita)");
        Console.WriteLine("9- Coxinha de costela (assada)");
        Console.WriteLine("0- Sair do pedido\n");
    }

    public static void Main(string[] args)
    {
        List<Prato> itensConsumidos = new List<Prato>();
        Pedido pedido;

        int opcao = -1;

        Console.Write("Qual seu nome: ");
        pedido = new Pedido(Console.ReadLine());

        while (opcao != 0)
        {
            Console.Clear();
            Cardapio();

            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    itensConsumidos.Add(new Pizza(48.00, "30/09/2023", 480.00, "Calabresa", "Catupiry", "Tradicional"));
                    break;

                default:
                    break;
            }
        }

        pedido.ItensConsumidos = itensConsumidos;
        Console.Write("Valor a ser pago: ");
        Console.WriteLine($"Cliente: {pedido.NomeCliente}");
        pedido.GerarNotaFiscal(150.00);

        Console.ReadKey();
    }
}
