namespace lanchonete_OO
{
    public class Prato
    {
        private double _precoVenda;
        private string _dataValidade;
        private double _peso;

        public double PrecoVenda
        {
            get { return _precoVenda; }
            set { _precoVenda = value; }
        }

        public string DataValidade
        {
            get { return _dataValidade; }
            set { _dataValidade = value; }
        }

        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }
}
