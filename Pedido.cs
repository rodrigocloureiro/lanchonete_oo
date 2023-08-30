namespace lanchonete_OO
{
    public class Pedido
    {
        private string _nomeCliente;
        private const double _taxaServico = 0.10;
        private List<Prato> _itensConsumidos;

        public Pedido(string nomeCliente)
        {
            _nomeCliente = nomeCliente;
            _itensConsumidos = new List<Prato>();
        }

        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        public double TaxaServico
        {
            get { return _taxaServico; }
        }

        public List<Prato> ItensConsumidos
        {
            get { return _itensConsumidos; }
            set { _itensConsumidos = value; }
        }

        public void GerarNotaFiscal(double valorPago)
        {
            Console.WriteLine("Nota Fiscal");
            Console.WriteLine("======================================");
            Console.WriteLine("RECHEIO\tBORDA\tMOLHO\tPREÇO\tTAXA SERVIÇO");
            foreach (Prato item in _itensConsumidos)
            {
                Console.WriteLine($"{item} - R$ {item.PrecoVenda * _taxaServico:F2}");
            }
            Console.WriteLine("======================================");
            Console.WriteLine($"Total do pedido: R$ {CalcularTotal():F2}");
            Console.WriteLine($"Valor pago: R$ 150.00");
            Console.WriteLine($"Troco: R$ {CalcularTroco(valorPago):F2}");
        }

        private double CalcularTotal()
        {
            double total = 0;
            foreach (Prato item in _itensConsumidos)
            {
                total += item.PrecoVenda;
            }
            return total * (1 + _taxaServico);
        }

        private double CalcularTroco(double valorPago)
        {
            return valorPago - CalcularTotal();
        }
    }
}
