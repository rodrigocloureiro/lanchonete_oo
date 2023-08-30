using lanchonete_OO;

public class Program
{
    public static void Main(string[] args)
    {
        List<Prato> itensConsumidos = new List<Prato>();
        Pedido pedido = new Pedido("Rodrigo");

        itensConsumidos.Add(new Pizza(48.00, "30/09/2023", 480.00, "Calabresa", "Catupiry", "Tradicional"));
        itensConsumidos.Add(new Pizza(58.00, "30/09/2023", 480.00, "Francesa", "Cheddar", "Tradicional"));

        pedido.ItensConsumidos = itensConsumidos;
        pedido.GerarNotaFiscal(150.00);

        Console.ReadKey();
    }
}
