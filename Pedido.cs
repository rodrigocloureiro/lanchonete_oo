namespace lanchonete_OO
{
    public class Pedido
    {
        private string _nomeCliente;
        private double _taxaServico;
        private Prato[] _itensConsumidos;

        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }

        public double TaxaServico
        {
            get { return _taxaServico; }
            set { _taxaServico = value; }
        }

        public Prato[] ItensConsumidos
        {
            get { return _itensConsumidos; }
            set { _itensConsumidos = value; }
        }

        public void GerarNotaFiscal() { }

        public double CalcularTotal()
        {
            return 0;
        }

        public double CalcularTroco(double valorPago)
        {
            return 0;
        }
    }
}
